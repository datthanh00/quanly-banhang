using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class frmLienHe : DevExpress.XtraEditors.XtraForm
    {
        public frmLienHe()
        {
            InitializeComponent();
        }
    /*
        private void btLienHe_Click(object sender, EventArgs e)
        {
              try  
        {  
           
             MailMessage mM = new MailMessage();  
             mM.From = new MailAddress("ngocanhsoft@yahoo.com");  
             mM.To.Add("ngocanhsoft@yahoo.com");  
             mM.Subject = "dada";               mM.Body = "asas";  
             mM.IsBodyHtml = true;  
             mM.Priority = MailPriority.High;              SmtpClient sC = new SmtpClient("smtp.mail.yahoo.com");  
             sC.Port = 587;  
             sC.Credentials = new NetworkCredential("ngoc_anh-94@yahoo.com", "saovayem");  
             //sC.EnableSsl = true;  
             sC.Send(mM);  
             this.Text = "Mail Send Successfully";  
             //lbReport.ForeColor = Color.Green;  
 
        }  
        catch(Exception ex)  
        {  
           this.Text = ex+"Mail Sending Fail's";  
            //lbReport.ForeColor = Color.Red;  
       }  
   
           // Mail("ngocanhsoft@yahoo.com", "ngocanhsoft@yahoo.com", "ngocanhsoft@yahoo.com", "ngocanhsoft@yahoo.com", "dasdsadas", "dsadasdasd", true);
            
        }
        */
        private System.Net.Mail.MailMessage _mail = new System.Net.Mail.MailMessage();
        public void Mail(string fromName, string fromMail, string toName, string toMail, string subject, string body, bool isHtml)
        {
            this._mail.Subject = subject;
            this._mail.Body = body;
            this._mail.From = new System.Net.Mail.MailAddress(fromMail, fromName);
            this._mail.To.Add(new System.Net.Mail.MailAddress(toMail, toName));
            this._mail.IsBodyHtml = isHtml;
            this._mail.BodyEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");
            this._mail.SubjectEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");Send();
        }
        public bool Send()
        {
          
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.mail.yahoo.com", 465); // Mettre le serveur smtp ici
                smtp.Send(this._mail);
                return true;
     
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbThanhVien_Click(object sender, EventArgs e)
        {

        }
    }
}