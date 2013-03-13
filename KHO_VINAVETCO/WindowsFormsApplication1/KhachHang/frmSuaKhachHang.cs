using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmSuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaKhachHang()
        {
            InitializeComponent();
            //Loaddulieu();

        }
        DTO DTO = new DTO();
        CTL CTRL = new CTL();
        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        public string MACHUYEN;
        DataTable dt = new DataTable();
        public string Nhan;
        public string TenKH,MaKV,DIACHI,SDT,SOTK,NGANHANG,MASOTHUE,FAX,YAHOO,WEBSITE,SKYPE,TINHTRANG;
        //public string machuyen;
        //DataTable dt = new DataTable();
        //DTO dto = new DTO();
        //CTL CTL = new CTL();

        //public void Loaddulieu()
        //{
            
        //}

        private void btLuu_Click(object sender, EventArgs e)
        {
            bool KT;
            if (cmbtinhtrang.Text == "Kích Hoạt")
            {
                KT = true; ;

            }
            else
            {
                KT = false;
            }


            //try
            //{
            if (cmbtenkhuvuc.Properties.ValueMember.ToString() == "")
            {
                MessageBox.Show("Vui Lòng Chọn Khu Vực ", "Thông Báo");

            }
            if (txttenkh.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tên Khách Hàng", "Thông Báo");

            }





            else if (txtsdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");

            }
            else if (txtsdt.Text.Length < 6 || txtsdt.Text.Length > 13)
            {
                MessageBox.Show("Số điện thoại phải nằm trong khoản từ 6 số tới 12 số");

            }
            else if (cmbtinhtrang.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Tình Trạng");

            }
            else if (cmbtenkhuvuc.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Tên Khu Vực");

            }


            else
            {
                DTO.MAKH = txtmakh.Text;
                txtmakh.Enabled = false;
                DTO.MAKV = cmbtenkhuvuc.Text;//cmbtenkhuvuc.Properties.ValueMember.ToString();

                DTO.TENKH = txttenkh.Text;
                DTO.SOTAIKHOAN = txtsotaikhan.Text;
                DTO.NGANHANG = txtnganhang.Text;
                DTO.MASOTHUE = txtmasothue.Text;
                DTO.DIACHI = txtdiachi.Text;
                // TXTSDT.Focus();
                //TXTSDT.SelectAll();
                DTO.SDT = txtsdt.Text;
                DTO.FAX = txtfax.Text;
                DTO.WEBSITE = txtwebsite.Text;
                DTO.YAHOO = txtyahoo.Text;
                DTO.SKYPE = txtnickskype.Text;
                DTO.TINHTRANG = KT;
               // CTRL.insertKhachHang(DTO);
                CTRL.updateKhachHang(DTO);
                MessageBox.Show("Bạn Đã Sửa Thành Công");
                this.Close();
                

            }

        }

        private void frmSuaKhachHang_Load(object sender, EventArgs e)
        {

            txtmakh.Text = MACHUYEN;
            
            txttenkh.Text = TenKH;
            cmbtenkhuvuc.Text = MaKV;
            txtdiachi.Text = DIACHI;
            txtmasothue.Text = MASOTHUE;
            txtnganhang.Text = NGANHANG;
            txtsdt.Text = SDT;
            txtwebsite.Text = WEBSITE;
            txtyahoo.Text = YAHOO;
            txtfax.Text = FAX;
            cmbtinhtrang.Text = TINHTRANG;
            txtsotaikhan.Text = SOTK;
            txtnickskype.Text = SKYPE;
           // this.kHUVUCTableAdapter.Fill(this.xUAT_NHAPTONDataSet.KHUVUC);
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}