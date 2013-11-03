using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using Quanlykho;

namespace WindowsFormsApplication1
{
    public partial class frmThongTinNhom : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinNhom()
        {
            InitializeComponent();
        }
        clCtrl ctr = new clCtrl();
        clDTO dto = new clDTO();
        private void frmThongTinNhom_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
                dto.MACT = "1";
                tb = ctr.getTTCTy(dto);
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                   lbTenCt1.Text = tb.Rows[i]["TENCT"].ToString();
                   labelControl1.Text = tb.Rows[i]["diachi"].ToString();
                }
            string hostname = "";
            System.Net.IPHostEntry ip = new IPHostEntry();
            hostname = System.Net.Dns.GetHostName();
            ip = System.Net.Dns.GetHostEntry(hostname);
            lblHostName.Text = ":" + ip.HostName;

            foreach (System.Net.IPAddress listip in ip.AddressList)
            {
                lblIP.Text = ":" + listip.ToString();
            }
            lbGhiChu.Text = "Sản phẩm được Lập trình riêng cho cửa hàng";
            lbDiaChi.Text=LamVN.DIACHI.ToString()+" :";
            lbip.Text = "IP :";
            lbTenCongTy.Text = "Tên công ty :";
            lbPhienBan.Text = "Phiên bản : Nội Bộ";
            lbPhanMem.Text = "Phần mềm "+ resVietNam.frmMain.ToString()+ " cửa hàng Tuấn Hạnh";

            this.MouseDown += new MouseEventHandler(frmThongTinNhom_MouseDown);
            this.MouseUp += new MouseEventHandler(frmThongTinNhom_MouseUp);
            this.MouseMove += new MouseEventHandler(frmThongTinNhom_MouseMove);
        }

        private void frmThongTinNhom_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Close();
        }
        private bool dragging;
        private Point pointClicked;

        private void frmThongTinNhom_MouseMove(object sender, MouseEventArgs e)
        {
     
       
            if (dragging)
            {
                this.Opacity = 0.5;
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));
                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);
                this.Location = pointMoveTo;
            }
            else
            {
                this.Opacity = 1;
            }
        
        }

        private void frmThongTinNhom_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmThongTinNhom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                dragging = false;
            }
            if (e.Button == MouseButtons.Right)
            {

                this.Close();

            }  
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}