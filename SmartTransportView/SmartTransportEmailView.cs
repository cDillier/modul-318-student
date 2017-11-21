using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SmartTransportView
{
    public partial class SmartTransportEmailView : Form
    {
        public SmartTransportEmailView(DataGridView smartTransportData)
        {
            InitializeComponent();
            tbMailBody.Text += "SmartTransport:\r\n\r\n";
            SetDateInBodyMail(smartTransportData);
        }

        private void SetDateInBodyMail(DataGridView smartTransportData)
        {
            if (smartTransportData.Rows.Count != 0)
            {
                tbMailBody.Text += "Abfahrtszeit - Ankunftszeit | Abfahrtstation --> Endstation | Dauer | Gleis";
                foreach (DataGridViewRow dataRow in smartTransportData.Rows)
                {
                    tbMailBody.Text += "\r\n" + dataRow.Cells["StartEndTime"].Value + " | " + dataRow.Cells["StartEndStation"].Value + " | " + dataRow.Cells["Duration"].Value + " | " + dataRow.Cells["Rail"].Value;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage email = new MailMessage(tbFrom.Text,tbTo.Text,tbSubject.Text ,tbMailBody.Text);
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 589);//("smtp.office365.com", 587);
           //System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("")
            mailClient.Send(email);
        }
    }
}
