using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SmartTransportView
{
    public partial class MainForm : Form
    {
        Transport t = new Transport();
        SmartTransportBL st = new SmartTransportBL();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowTimeTable_Click(object sender, EventArgs e)
        {
            Connections c= t.GetConnections("Sursee", "Luzern");
            //dgvShowTimeTable.DataSource = t.GetConnections("", "").ConnectionList;
            dgvShowTimeTable.DataSource = st.GetTimeTableData();
            dgvShowTimeTable.Columns["StartEndTime"].HeaderText = "Startzeit - Endzeit";
            dgvShowTimeTable.Columns["StartEndStation"].HeaderText = "Start-Station --> Endstation";
            dgvShowTimeTable.Columns["Duration"].HeaderText = "Dauer";
            dgvShowTimeTable.Columns["Rail"].HeaderText = "Gleis";
            dgvShowTimeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
        }
    }
}
