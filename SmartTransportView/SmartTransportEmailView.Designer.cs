namespace SmartTransportView
{
    partial class SmartTransportEmailView
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
            this.components = new System.ComponentModel.Container();
            this.tbMailBody = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tpMail = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMailBody
            // 
            this.tbMailBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMailBody.Location = new System.Drawing.Point(0, 0);
            this.tbMailBody.Multiline = true;
            this.tbMailBody.Name = "tbMailBody";
            this.tbMailBody.Size = new System.Drawing.Size(1076, 338);
            this.tbMailBody.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.tbUser);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.tbSubject);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.tbTo);
            this.panel1.Controls.Add(this.tbFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 100);
            this.panel1.TabIndex = 5;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 75);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(50, 17);
            this.lblSubject.TabIndex = 11;
            this.lblSubject.Text = "Betreff";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(114, 72);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(423, 22);
            this.tbSubject.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(896, 10);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(168, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Email versenden";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(13, 38);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(77, 17);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "Empfänger";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(13, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(69, 17);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "Absender";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(114, 38);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(423, 22);
            this.tbTo.TabIndex = 6;
            this.tpMail.SetToolTip(this.tbTo, "xxxxxx@outlook.com");
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(114, 10);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(423, 22);
            this.tbFrom.TabIndex = 5;
            this.tpMail.SetToolTip(this.tbFrom, "xxxxxx@outlook.com");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbMailBody);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 338);
            this.panel2.TabIndex = 6;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(725, 10);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(165, 22);
            this.tbUser.TabIndex = 12;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(619, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 17);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "Benutzername";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(619, 38);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 17);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Passwort";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(725, 38);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(165, 22);
            this.tbPassword.TabIndex = 15;
            // 
            // SmartTransportEmailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SmartTransportEmailView";
            this.Text = "SmartTransportEmailView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMailBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.ToolTip tpMail;
    }
}