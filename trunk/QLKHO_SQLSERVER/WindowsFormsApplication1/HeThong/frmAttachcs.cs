using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmAttachcs : DevExpress.XtraEditors.XtraForm
    {
       
        public frmAttachcs()
        {
            InitializeComponent();
        }
        Thread regularThread1;
        private void VLoad2()
        {
            Mysqlchange MSQL = new Mysqlchange();
            FileStream fs = new FileStream("log.txt", FileMode.Open, FileAccess.Write);
            StreamWriter wr = new StreamWriter(fs);
            wr.WriteLine("Database duoc tao luc : " + DateTime.Now.ToString());
            wr.Close();
            fs.Close();
        tt:
            try
            {
                using (MSQL.SQLConnection1 = Provider.get_Connect()) 
                {
                    MSQL.SQLConnection1.Close();
                }
            }
            catch
            {
                XtraMessageBox.Show("Không tìm thấy server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCauHinhHeThong frm = new frmCauHinhHeThong();
                frm.ShowDialog();
                goto tt;
            }
            XtraMessageBox.Show("Database được tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        int idem = -1;
        string s = "Đang tạo cơ sở dữ liệu.........";

        private void tmDem_Tick(object sender, EventArgs e)
        {
            idem++;
            if (idem < s.Length)
            {
                labelX1.Text += s[idem].ToString();
            }
            else
            {
                idem = -1;
                labelX1.Text = "";
            }
        }
        private void VXoa(object stateinfo)
        {
            File.Delete("XUAT_NHAPTON.SQL");
            File.Delete("TAO_DATABASE.BAT");
            XtraMessageBox.Show("Database được tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void vLoad()
        {
            regularThread1.Join();
            try
            {
                Process.Start("TAO_DATABASE_XNT.BAT");
            }
            catch
            {
                XtraMessageBox.Show("Không tìm thấy file database, liên hệ nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void vLoad1()
        {
            foreach (Process item in Process.GetProcesses())
            {
                if (item.ProcessName.ToString().ToLower() == "cmd")
                {
                    item.Kill();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool btest = false;
            foreach (Process item in Process.GetProcesses())
            {
                if (item.ProcessName.ToString().ToLower() == "cmd")
                {
                    btest = true;
                }
            }
            if (btest == false)
            {
                tmDem.Stop();
                labelX1.Text = "";
                timer1.Stop();
                VLoad2();
            }
        }

        private void frmAttachcs_Load(object sender, EventArgs e)
        {
            labelX1.Text = "";
            tmDem.Interval = 50;
            if (!File.Exists("TAO_DATABASE_XNT.BAT"))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Không tìm thấy file database, liên hệ nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                try
                {
                    Thread regularThread;
                    regularThread1 = new Thread(new ThreadStart(vLoad1));
                    regularThread = new Thread(new ThreadStart(vLoad));
                    // regularThread2 = new Thread(new ThreadStart(VLoad2));
                    regularThread1.Start();
                    //regularThread2.Start();
                    regularThread.Start();

                    //regularThread.Join();
                }
                catch
                {
                    XtraMessageBox.Show("Không tìm thấy file database, liên hệ nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }
    }
}