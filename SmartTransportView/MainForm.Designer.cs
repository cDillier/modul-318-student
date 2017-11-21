namespace SmartTransportView
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cbStartStation = new System.Windows.Forms.ComboBox();
            this.cbEndStation = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnShowTimeTable = new System.Windows.Forms.Button();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblEndStation = new System.Windows.Forms.Label();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.spSmartTransport = new System.Windows.Forms.SplitContainer();
            this.dgvShowTimeTable = new System.Windows.Forms.DataGridView();
            this.gmcMap = new GMap.NET.WindowsForms.GMapControl();
            this.dgvStationBoard = new System.Windows.Forms.DataGridView();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnStationBoard = new System.Windows.Forms.ToolStripButton();
            this.btnGMap = new System.Windows.Forms.ToolStripButton();
            this.btnSateliteMap = new System.Windows.Forms.ToolStripButton();
            this.btnGoogleMap = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSmartTransport)).BeginInit();
            this.spSmartTransport.Panel1.SuspendLayout();
            this.spSmartTransport.Panel2.SuspendLayout();
            this.spSmartTransport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTimeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStartStation
            // 
            this.cbStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStartStation.FormattingEnabled = true;
            this.cbStartStation.Location = new System.Drawing.Point(239, 33);
            this.cbStartStation.Name = "cbStartStation";
            this.cbStartStation.Size = new System.Drawing.Size(347, 37);
            this.cbStartStation.TabIndex = 0;
            this.cbStartStation.TextChanged += new System.EventHandler(this.cbStartStation_TextChanged);
            this.cbStartStation.Leave += new System.EventHandler(this.cbStartStation_Leave);
            // 
            // cbEndStation
            // 
            this.cbEndStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEndStation.FormattingEnabled = true;
            this.cbEndStation.Location = new System.Drawing.Point(770, 33);
            this.cbEndStation.Name = "cbEndStation";
            this.cbEndStation.Size = new System.Drawing.Size(347, 37);
            this.cbEndStation.TabIndex = 1;
            this.cbEndStation.TextChanged += new System.EventHandler(this.cbEndStation_TextChanged);
            this.cbEndStation.Leave += new System.EventHandler(this.cbEndStation_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpStartTime);
            this.panel1.Controls.Add(this.btnShowTimeTable);
            this.panel1.Controls.Add(this.lblDepartureTime);
            this.panel1.Controls.Add(this.lblEndStation);
            this.panel1.Controls.Add(this.lblStartStation);
            this.panel1.Controls.Add(this.cbStartStation);
            this.panel1.Controls.Add(this.cbEndStation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 217);
            this.panel1.TabIndex = 3;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "dd.MM.yyyy  |  HH:mm";
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(239, 105);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(347, 36);
            this.dtpStartTime.TabIndex = 2;
            // 
            // btnShowTimeTable
            // 
            this.btnShowTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTimeTable.Location = new System.Drawing.Point(622, 105);
            this.btnShowTimeTable.Name = "btnShowTimeTable";
            this.btnShowTimeTable.Size = new System.Drawing.Size(495, 36);
            this.btnShowTimeTable.TabIndex = 3;
            this.btnShowTimeTable.Text = "Verbindung suchen";
            this.btnShowTimeTable.UseVisualStyleBackColor = true;
            this.btnShowTimeTable.Click += new System.EventHandler(this.btnShowTimeTable_Click);
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(65, 112);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(147, 29);
            this.lblDepartureTime.TabIndex = 4;
            this.lblDepartureTime.Text = "Abfahrtszeit";
            // 
            // lblEndStation
            // 
            this.lblEndStation.AutoSize = true;
            this.lblEndStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndStation.Location = new System.Drawing.Point(617, 36);
            this.lblEndStation.Name = "lblEndStation";
            this.lblEndStation.Size = new System.Drawing.Size(133, 29);
            this.lblEndStation.TabIndex = 4;
            this.lblEndStation.Text = "Endstation";
            // 
            // lblStartStation
            // 
            this.lblStartStation.AutoSize = true;
            this.lblStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartStation.Location = new System.Drawing.Point(65, 41);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(141, 29);
            this.lblStartStation.TabIndex = 3;
            this.lblStartStation.Text = "Startstation";
            // 
            // spSmartTransport
            // 
            this.spSmartTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spSmartTransport.Location = new System.Drawing.Point(0, 0);
            this.spSmartTransport.Name = "spSmartTransport";
            // 
            // spSmartTransport.Panel1
            // 
            this.spSmartTransport.Panel1.Controls.Add(this.dgvShowTimeTable);
            this.spSmartTransport.Panel1.Controls.Add(this.panel1);
            // 
            // spSmartTransport.Panel2
            // 
            this.spSmartTransport.Panel2.Controls.Add(this.gmcMap);
            this.spSmartTransport.Panel2.Controls.Add(this.dgvStationBoard);
            this.spSmartTransport.Size = new System.Drawing.Size(1576, 690);
            this.spSmartTransport.SplitterDistance = 1277;
            this.spSmartTransport.TabIndex = 7;
            // 
            // dgvShowTimeTable
            // 
            this.dgvShowTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowTimeTable.Location = new System.Drawing.Point(0, 217);
            this.dgvShowTimeTable.Name = "dgvShowTimeTable";
            this.dgvShowTimeTable.RowTemplate.Height = 24;
            this.dgvShowTimeTable.Size = new System.Drawing.Size(1277, 473);
            this.dgvShowTimeTable.TabIndex = 6;
            this.dgvShowTimeTable.TabStop = false;
            this.dgvShowTimeTable.DataSourceChanged += new System.EventHandler(this.dgvShowTimeTable_DataSourceChanged);
            this.dgvShowTimeTable.SelectionChanged += new System.EventHandler(this.dgvShowTimeTable_SelectionChanged);
            // 
            // gmcMap
            // 
            this.gmcMap.Bearing = 0F;
            this.gmcMap.CanDragMap = true;
            this.gmcMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmcMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmcMap.GrayScaleMode = false;
            this.gmcMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmcMap.LevelsKeepInMemmory = 5;
            this.gmcMap.Location = new System.Drawing.Point(0, 0);
            this.gmcMap.MarkersEnabled = true;
            this.gmcMap.MaxZoom = 2;
            this.gmcMap.MinZoom = 2;
            this.gmcMap.MouseWheelZoomEnabled = true;
            this.gmcMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmcMap.Name = "gmcMap";
            this.gmcMap.NegativeMode = false;
            this.gmcMap.PolygonsEnabled = true;
            this.gmcMap.RetryLoadTile = 0;
            this.gmcMap.RoutesEnabled = true;
            this.gmcMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmcMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmcMap.ShowTileGridLines = false;
            this.gmcMap.Size = new System.Drawing.Size(295, 690);
            this.gmcMap.TabIndex = 7;
            this.gmcMap.Zoom = 0D;
            // 
            // dgvStationBoard
            // 
            this.dgvStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStationBoard.Location = new System.Drawing.Point(0, 0);
            this.dgvStationBoard.Name = "dgvStationBoard";
            this.dgvStationBoard.RowTemplate.Height = 24;
            this.dgvStationBoard.Size = new System.Drawing.Size(295, 690);
            this.dgvStationBoard.TabIndex = 6;
            this.dgvStationBoard.TabStop = false;
            this.dgvStationBoard.DataSourceChanged += new System.EventHandler(this.dgvStationBoard_DataSourceChanged);
            // 
            // tsMenu
            // 
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStationBoard,
            this.btnGMap,
            this.btnSateliteMap,
            this.btnGoogleMap});
            this.tsMenu.Location = new System.Drawing.Point(1536, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(40, 690);
            this.tsMenu.TabIndex = 9;
            this.tsMenu.Text = "toolStrip1";
            this.tsMenu.Click += new System.EventHandler(this.tsMenu_Click);
            // 
            // btnStationBoard
            // 
            this.btnStationBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStationBoard.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnStationBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnStationBoard.Image")));
            this.btnStationBoard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStationBoard.Name = "btnStationBoard";
            this.btnStationBoard.Size = new System.Drawing.Size(37, 161);
            this.btnStationBoard.Text = "Abfahrtstafel";
            this.btnStationBoard.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.btnStationBoard.ToolTipText = "Geben sie eine Startstation ein \r\nund drücken Sie anschliessend\r\ndie Tabulatortas" +
    "te";
            this.btnStationBoard.Click += new System.EventHandler(this.btnStationBoard_Click);
            // 
            // btnGMap
            // 
            this.btnGMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGMap.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnGMap.Image = ((System.Drawing.Image)(resources.GetObject("btnGMap.Image")));
            this.btnGMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGMap.Name = "btnGMap";
            this.btnGMap.Size = new System.Drawing.Size(37, 77);
            this.btnGMap.Text = "Karte";
            this.btnGMap.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.btnGMap.ToolTipText = "Geben Sie eine Startstation und eine \r\nEndstation ein und drücken\r\nSie anschliess" +
    "end Enter";
            this.btnGMap.Click += new System.EventHandler(this.btnGMap_Click);
            // 
            // btnSateliteMap
            // 
            this.btnSateliteMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSateliteMap.Image = global::SmartTransportView.Properties.Resources.map;
            this.btnSateliteMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSateliteMap.Name = "btnSateliteMap";
            this.btnSateliteMap.Size = new System.Drawing.Size(37, 24);
            this.btnSateliteMap.Text = "Satellit";
            this.btnSateliteMap.Click += new System.EventHandler(this.btnSateliteMap_Click);
            // 
            // btnGoogleMap
            // 
            this.btnGoogleMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoogleMap.Image = global::SmartTransportView.Properties.Resources.map__1_;
            this.btnGoogleMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoogleMap.Name = "btnGoogleMap";
            this.btnGoogleMap.Size = new System.Drawing.Size(37, 24);
            this.btnGoogleMap.Text = "Standart";
            this.btnGoogleMap.Click += new System.EventHandler(this.btnGoogleMap_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnShowTimeTable;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 690);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.spSmartTransport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Smart Transport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.spSmartTransport.Panel1.ResumeLayout(false);
            this.spSmartTransport.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spSmartTransport)).EndInit();
            this.spSmartTransport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTimeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStartStation;
        private System.Windows.Forms.ComboBox cbEndStation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblEndStation;
        private System.Windows.Forms.Label lblStartStation;
        private System.Windows.Forms.Button btnShowTimeTable;
        private System.Windows.Forms.SplitContainer spSmartTransport;
        private System.Windows.Forms.DataGridView dgvStationBoard;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnStationBoard;
        private System.Windows.Forms.DataGridView dgvShowTimeTable;
        private GMap.NET.WindowsForms.GMapControl gmcMap;
        private System.Windows.Forms.ToolStripButton btnGMap;
        private System.Windows.Forms.ToolStripButton btnSateliteMap;
        private System.Windows.Forms.ToolStripButton btnGoogleMap;
    }
}

