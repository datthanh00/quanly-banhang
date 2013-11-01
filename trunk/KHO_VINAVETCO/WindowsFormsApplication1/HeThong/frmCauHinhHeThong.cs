using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Configuration;
using WindowsFormsApplication1.Class_ManhCuong;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Threading;
using Microsoft.Win32;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class frmCauHinhHeThong : DevExpress.XtraEditors.XtraForm
    {
        public frmCauHinhHeThong()
        {
            InitializeComponent();
        }
       // private SQLDMO.Application sqlApp = new SQLDMO.ApplicationClass();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listBoxnetwork.Items.Clear();
            Loadingggg ld = new Loadingggg();
            ld.CreateWaitDialog();
            ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");
            #region cach 1
            //try
            //{
            //    //get all available SQL Servers		
            //    cbTenMayChu.Properties.Items.Clear();
            //    sqlServers = sqlApp.ListAvailableSQLServers();
            //    for (int i = 0; i < sqlServers.Count; i++)
            //    {
            //        string srv = sqlServers.Item(i + 1);
            //        if (srv != null)
            //        {
            //            this.cbTenMayChu.Properties.Items.Add(srv);
            //            TreeNode node = new TreeNode(srv);
            //            //treeListChonMayChu.Nodes.Add(node);
            //        }




            //    }
            //    if (this.cbTenMayChu.Properties.Items.Count > 0)
            //        this.cbTenMayChu.SelectedIndex = 0;
            //    else
            //        this.cbTenMayChu.Text = "<No available SQL Servers>";

            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message, "Error");
            //} 
            #endregion
            //---------------------------------cach 2------------------------------------

            
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
            String[] instances = (String[])rk.GetValue("InstalledInstances");
            if (instances.Length > 0)
            {
                listBoxnetwork.Items.Clear();
                listBoxLocal.Items.Clear();
                cbTenMayChu.Properties.Items.Clear();
                foreach (String element in instances)
                {
                    if (element == "MSSQLSERVER")
                    {
                        listBoxLocal.Items.Add(System.Environment.MachineName);
                        cbTenMayChu.Properties.Items.Add(System.Environment.MachineName);
                        cbTenMayChu.SelectedIndex = 0;
                    }
                    else

                        listBoxLocal.Items.Add(System.Environment.MachineName + @"\" + element);
                    cbTenMayChu.Properties.Items.Add(System.Environment.MachineName + @"\" + element);
                    cbTenMayChu.SelectedIndex = 0;
                    
                }
            }
           
            Thread threadGetNetworkInstances = new Thread(GetNetworkInstances);
            threadGetNetworkInstances.Start();
           
           



            ld.simpleCloseWait();
        }
        Server srv;
        ServerConnection conn;
        private void GetNetworkInstances()
        {
            
            DataTable dt = SmoApplication.EnumAvailableSqlServers(false);

            if (dt.Rows.Count > 0)
            {
                
                foreach (DataRow dr in dt.Rows)
                {
                    AddNetworkInstance(dr["Name"].ToString());
                }
            }
        }
        delegate void SetMessageCallback(string text);
        private void AddNetworkInstance(string text)
        {
           
            if (this.listBoxnetwork.InvokeRequired)
            {
                SetMessageCallback d = new SetMessageCallback(AddNetworkInstance);
                this.BeginInvoke(d, new object[] { text });
            }
            else
            {
                this.listBoxnetwork.Items.Add(text);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
           Loadingggg ld = new Loadingggg();
                ld.CreateWaitDialog();
                ld.SetWaitDialogCaption("Đang tải dữ liệu - Vui Lòng Chờ");
                #region Cach 1
                //==================== Cach 1===================================
            //try
            //{
               
            //    this.Cursor = Cursors.WaitCursor;
            //    // this.lstObjects.Items.Clear();
            //    this.cbDatabase.Properties.Items.Clear();

            //    SQLDMO.SQLServer srv = new SQLDMO.SQLServerClass();
            //    srv.Connect(this.cbTenMayChu.SelectedItem.ToString(), txtTaiKhoan.Text, this.txtMatKhau.Text);

            //    foreach (SQLDMO.Database db in srv.Databases)
            //    {
            //        if (db.Name != null)
            //            this.cbDatabase.Properties.Items.Add(db.Name);
            //    }
            //    this.cbDatabase.Properties.Sorted = true;
            //    if (this.cbDatabase.Properties.Items.Count > 0)
            //    {
            //        this.cbDatabase.SelectedIndex = 0;
            //        this.cbDatabase.Enabled = true;
            //        // this.groupBox1.Enabled = true;
            //    }
            //    else
            //    {
            //        //this.groupBox1.Enabled = false;
            //        this.cbDatabase.Enabled = false;
            //        this.cbDatabase.Text = "<No databases found>";
            //    }
            //    this.Cursor = Cursors.Default;
                
            //}
            //catch (Exception err)
            //{
            //    this.Cursor = Cursors.Default;
            //    MessageBox.Show(err.Message, "Error");
                //}
               

                #endregion

                try
                {
                    cbDatabase.Properties.Items.Clear();
                  
                    string sqlSErverInstance;

                    if (listBoxnetwork.SelectedIndex == 0)
                    {
                        sqlSErverInstance = cbTenMayChu.SelectedItem.ToString();
                    }
                    else
                    {
                        sqlSErverInstance = listBoxnetwork.SelectedItem.ToString();
                    }

                    if (radioButton1.Checked == true)
                    {
                        conn = new ServerConnection();
                        conn.ServerInstance = sqlSErverInstance;
                    }
                    else
                    {
                        conn = new ServerConnection(sqlSErverInstance, txtTaiKhoan.Text, this.txtMatKhau.Text);
                    }
                    srv = new Server(conn);

                    foreach (Database db in srv.Databases)
                    {
                        cbDatabase.Properties.Items.Add(db.Name);
                        cbDatabase.Text = "XUAT_NHAPTON";
                    }
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            
            
            ld.simpleCloseWait();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = false;
            txtTaiKhoan.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = true;
            txtTaiKhoan.Enabled = true;
        }
        System.Configuration.Configuration AppC = ConfigurationManager.OpenExeConfiguration("App");

        private void frmCauHinhHeThong_Load(object sender, EventArgs e)
        {
            cbTenMayChu.Text = AppC.AppSettings.Settings["Server"].Value;
            txtMatKhau.Enabled = false;
            txtTaiKhoan.Enabled = false;
            radioButton1.Checked = true;
         
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //tt:
            //MSDN microsoft
            //DMO
            try
            {
                if (cbTenMayChu.Text == "")
                {
                    MessageBox.Show("Tên máy chủ database rỗng!");
                    cbTenMayChu.Focus();
                    return;
                }
                if (cbDatabase.Text=="")
                {
                    MessageBox.Show("Sai Tên database");
                    cbDatabase.Focus();
                    return;
                }
               
                if (!File.Exists("App"))
                {
                    File.Create("App");
                    FileInfo fi = new FileInfo("App");
                    fi.Attributes = FileAttributes.Hidden | FileAttributes.System;
                }
                if (!File.Exists("App.config"))
                {
                    AppC.AppSettings.Settings.Add("Server", cbTenMayChu.Text);
                    AppC.AppSettings.Settings.Add("Database", cbDatabase.Text);
                    //AppC.AppSettings.Settings.Add("Integrated security", "true");
                    AppC.AppSettings.Settings.Add("uid", txtTaiKhoan.Text);
                    AppC.AppSettings.Settings.Add("pwd", txtMatKhau.Text);
                    AppC.Save();
                }
                else
                {
                    AppC.AppSettings.Settings["Server"].Value = cbTenMayChu.Text;
                    AppC.AppSettings.Settings["Database"].Value = cbDatabase.Text;
                   // AppC.AppSettings.Settings["Integrated security"].Value = "true";
                    AppC.AppSettings.Settings["uid"].Value = txtTaiKhoan.Text;
                    AppC.AppSettings.Settings["pwd"].Value = txtMatKhau.Text;
                    AppC.Save();
                }
                try
                {
                 
                }
                catch
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Không tìm thấy server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DevComponents.DotNetBar.MessageBoxEx.Show("Đã lưu thành công");
                PublicVariable.isUSELAN = true;
            }
            catch (Exception)
            {

               //MessageBox.Show(e.ToString())  ;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLocal.Items.Count>0)
            {
                cbTenMayChu.Text= listBoxLocal.SelectedValue.ToString();
            }
        }

        private void listBoxnetwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxnetwork.Items.Count>0)
            {
                 cbTenMayChu.Text = listBoxnetwork.SelectedValue.ToString();
            }
           
        }

        private void tab_Click(object sender, EventArgs e)
        {
          
        }
    }
}