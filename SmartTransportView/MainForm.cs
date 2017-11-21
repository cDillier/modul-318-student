using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using SwissTransport;
using GMap.NET.WindowsForms.Markers;
using System.Device.Location;

namespace SmartTransportView
{
    public partial class MainForm : Form
    {
        //Google Map Quelle: https://youtu.be/_V7CRn47pZk
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        bool mapOptionActiv = false;
        bool stationBoardActiv = false;

        Transport t = new Transport();
        SmartTransportBL st = new SmartTransportBL();
        List<string> stationList = new List<string>();
        bool showStationBoard = true;
        List<ISmartTransportBL> stList = new List<ISmartTransportBL>();
        double latitude = 0;
        double longitude = 0;
        int lastStartStationLen = 0;
        int lastEndStationLen = 0;
        public MainForm()
        {
            InitializeComponent();
            SetStationBoardVisibility();
            SetPanel2Visibility(false);
            AccessControl();
            SetGoogleMapDefault();
            SetDefaultDataGridView(dgvStationBoard);
            SetDefaultDataGridView(dgvShowTimeTable);
            dgvStationBoard.Columns["StartEndTime"].HeaderText = "Abfahrtszeit";
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += watcher_PositionChanged;
            watcher.Start();
            spSmartTransport.SplitterDistance = 850;
        }

        private void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            latitude = e.Position.Location.Latitude;
            longitude = e.Position.Location.Longitude;
        }

        private void SetGoogleMapDefault()
        {
            gmcMap.DragButton = MouseButtons.Left;
            gmcMap.CanDragMap = true;
            gmcMap.MapProvider = GMapProviders.GoogleMap;
            gmcMap.Position = new PointLatLng(47.170785, 8.09788);
            gmcMap.MinZoom = 0;
            gmcMap.MaxZoom = 24;
            gmcMap.Zoom = 9;
            gmcMap.AutoScroll = true;
        }
        private void btnShowTimeTable_Click(object sender, EventArgs e)
        {
            SetFirstNameFromList(cbStartStation);
            SetFirstNameFromList(cbEndStation);
            dgvShowTimeTable.DataSource = st.GetTimeTableData(cbStartStation.Text, cbEndStation.Text, dtpStartTime.Value);

            if (dgvShowTimeTable.Rows.Count != 0)
            {
                DataGridViewRow selectedRow = dgvShowTimeTable.Rows[0];
                object x = selectedRow.Cells["XCoordination"].Value;
                object y = selectedRow.Cells["YCoordination"].Value;
                gmcMap.Position = new PointLatLng(Convert.ToDouble(x), Convert.ToDouble(y));
            }
        }

        private void SetDefaultDataGridView(DataGridView dgv)
        {
            dgv.DataSource = new List<ISmartTransportBL>();
            dgv.Columns["StartEndTime"].HeaderText = "Abfahrtszeit - Ankunftszeit";
            dgv.Columns["StartEndStation"].HeaderText = "Abfahrtstation --> Endstation";
            dgv.Columns["Duration"].HeaderText = "Dauer";
            dgv.Columns["Rail"].HeaderText = "Gleis";
            dgv.Columns["XCoordination"].Visible = false;
            dgv.Columns["YCoordination"].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetFirstNameFromList(ComboBox cb)
        {
            if (cb.Items.Count != 0 && cb.SelectedIndex == -1) cb.Text = cb.Items[0].ToString();
        }
        private void cbStartStation_TextChanged(object sender, EventArgs e)
        {
            int len = cbStartStation.Text.Length;
            if (len - lastStartStationLen <= 1 && len - lastStartStationLen >= -1)
            {
                AutoFillHelper(cbStartStation);
                AccessControl();
            }
            lastStartStationLen = len;
        }
        private void cbEndStation_TextChanged(object sender, EventArgs e)
        {
            int len = cbEndStation.Text.Length;
            if (len - lastEndStationLen <= 1 && len - lastEndStationLen >= -1)
            {
                AutoFillHelper(cbEndStation);
                AccessControl();
            }
            lastEndStationLen = len;
        }

        private void AccessControl()
        {
            if (cbStartStation.Text != "" && cbEndStation.Text != "") btnShowTimeTable.Enabled = true;
            else btnShowTimeTable.Enabled = false;
        }

        private void AutoFillHelper(ComboBox cb)
        {
            stationList = new List<string>(t.GetStationsString(cb.Text));
            //stationList.Sort();
            cb.Items.Clear();
            cb.Items.AddRange(stationList.ToArray());
            int textLenght = cb.Text.Length;
            if (textLenght != 0) cb.SelectionStart = textLenght;
        }

        private void cbStartStation_Leave(object sender, EventArgs e)
        {
            SetFirstNameFromList(cbStartStation);
            if (showStationBoard) dgvStationBoard.DataSource = st.GetStationBoard(cbStartStation.Text);
        }

        private void cbEndStation_Leave(object sender, EventArgs e)
        {
            SetFirstNameFromList(cbEndStation);
        }

        private void SetMenuOptionVisibility(bool showMapOptions)
        {

            bool showPanel = showMapOptions != mapOptionActiv || showMapOptions == stationBoardActiv;
            mapOptionActiv = showMapOptions;
            stationBoardActiv = !showMapOptions;
            SetPanel2Visibility(showPanel);
            btnSateliteMap.Visible = showMapOptions;
            btnGoogleMap.Visible = showMapOptions;
            dgvStationBoard.Visible = !showMapOptions;
            gmcMap.Visible = showMapOptions;
        }


        private void SetPanel2Visibility(bool visible)
        {

            if (visible)
            {
                spSmartTransport.Panel2.Show();
                spSmartTransport.Panel2Collapsed = false;

            }
            else
            {
                spSmartTransport.Panel2.Hide();
                spSmartTransport.Panel2Collapsed = true;
                mapOptionActiv = false;
                stationBoardActiv = false;
            }
        }

        private void btnStationBoard_Click(object sender, EventArgs e)
        {

            SetStationBoardVisibility();
            SetMenuOptionVisibility(false);
            //stationBoardActiv = true;
            mapOptionActiv = false;
        }

        private void SetStationBoardVisibility()
        {
            showStationBoard = !showStationBoard;
            if (showStationBoard)
            {
                dgvStationBoard.DataSource = st.GetStationBoard(cbStartStation.Text);
            }
        }

        private void dgvShowTimeTable_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridViewVisibility(dgvShowTimeTable);
        }

        private void dgvStationBoard_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridViewVisibility(dgvStationBoard);
        }

        private void DataGridViewVisibility(DataGridView dgv)
        {
            if (dgv.RowCount == 0) dgv.Visible = false;
            else dgv.Visible = true;
        }

        private void btnGMap_Click(object sender, EventArgs e)
        {
            SetStationBoardVisibility();

            SetMenuOptionVisibility(true);
            stationBoardActiv = false;
        }

        private void dgvShowTimeTable_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnSateliteMap_Click(object sender, EventArgs e)
        {
            gmcMap.MapProvider = GMapProviders.GoogleSatelliteMap;
        }

        private void btnGoogleMap_Click(object sender, EventArgs e)
        {
            gmcMap.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            SmartTransportEmailView mailForm = new SmartTransportEmailView(dgvShowTimeTable);
            mailForm.ShowDialog();
        }
    }
}
