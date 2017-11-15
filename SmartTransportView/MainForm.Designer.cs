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
            this.cbStartStation = new System.Windows.Forms.ComboBox();
            this.cbEndStation = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.lblEndStation = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.dgvShowTimeTable = new System.Windows.Forms.DataGridView();
            this.btnShowTimeTable = new System.Windows.Forms.Button();
            this.tbDateTime = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStartStation
            // 
            this.cbStartStation.FormattingEnabled = true;
            this.cbStartStation.Items.AddRange(new object[] {
            "Sursee",
            "Luzern"});
            this.cbStartStation.Location = new System.Drawing.Point(147, 3);
            this.cbStartStation.Name = "cbStartStation";
            this.cbStartStation.Size = new System.Drawing.Size(121, 24);
            this.cbStartStation.TabIndex = 0;
            // 
            // cbEndStation
            // 
            this.cbEndStation.FormattingEnabled = true;
            this.cbEndStation.Location = new System.Drawing.Point(147, 33);
            this.cbEndStation.Name = "cbEndStation";
            this.cbEndStation.Size = new System.Drawing.Size(121, 24);
            this.cbEndStation.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbDateTime);
            this.panel1.Controls.Add(this.btnShowTimeTable);
            this.panel1.Controls.Add(this.lblDepartureTime);
            this.panel1.Controls.Add(this.lblEndStation);
            this.panel1.Controls.Add(this.lblStartStation);
            this.panel1.Controls.Add(this.cbStartStation);
            this.panel1.Controls.Add(this.cbEndStation);
            this.panel1.Location = new System.Drawing.Point(40, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 177);
            this.panel1.TabIndex = 3;
            // 
            // lblStartStation
            // 
            this.lblStartStation.AutoSize = true;
            this.lblStartStation.Location = new System.Drawing.Point(45, 10);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(87, 17);
            this.lblStartStation.TabIndex = 3;
            this.lblStartStation.Text = "Start-Station";
            // 
            // lblEndStation
            // 
            this.lblEndStation.AutoSize = true;
            this.lblEndStation.Location = new System.Drawing.Point(50, 40);
            this.lblEndStation.Name = "lblEndStation";
            this.lblEndStation.Size = new System.Drawing.Size(82, 17);
            this.lblEndStation.TabIndex = 4;
            this.lblEndStation.Text = "End-Station";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(45, 105);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(83, 17);
            this.lblDepartureTime.TabIndex = 4;
            this.lblDepartureTime.Text = "Abfahrtszeit";
            // 
            // dgvShowTimeTable
            // 
            this.dgvShowTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTimeTable.Location = new System.Drawing.Point(334, 35);
            this.dgvShowTimeTable.Name = "dgvShowTimeTable";
            this.dgvShowTimeTable.RowTemplate.Height = 24;
            this.dgvShowTimeTable.Size = new System.Drawing.Size(598, 177);
            this.dgvShowTimeTable.TabIndex = 4;
            // 
            // btnShowTimeTable
            // 
            this.btnShowTimeTable.Location = new System.Drawing.Point(96, 139);
            this.btnShowTimeTable.Name = "btnShowTimeTable";
            this.btnShowTimeTable.Size = new System.Drawing.Size(172, 23);
            this.btnShowTimeTable.TabIndex = 5;
            this.btnShowTimeTable.Text = "Verbindung suchen";
            this.btnShowTimeTable.UseVisualStyleBackColor = true;
            this.btnShowTimeTable.Click += new System.EventHandler(this.btnShowTimeTable_Click);
            // 
            // tbDateTime
            // 
            this.tbDateTime.Location = new System.Drawing.Point(203, 100);
            this.tbDateTime.MaxLength = 4;
            this.tbDateTime.Name = "tbDateTime";
            this.tbDateTime.Size = new System.Drawing.Size(65, 22);
            this.tbDateTime.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 485);
            this.Controls.Add(this.dgvShowTimeTable);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Smart Transport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTimeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStartStation;
        private System.Windows.Forms.ComboBox cbEndStation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblEndStation;
        private System.Windows.Forms.Label lblStartStation;
        private System.Windows.Forms.DataGridView dgvShowTimeTable;
        private System.Windows.Forms.Button btnShowTimeTable;
        private System.Windows.Forms.TextBox tbDateTime;
    }
}

