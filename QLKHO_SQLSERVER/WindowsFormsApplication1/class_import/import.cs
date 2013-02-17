using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication1.class_import
{
    public partial class import : DevExpress.XtraEditors.XtraForm
    {
        public import()
        {
            InitializeComponent();
        }
         private void import_Load(object sender, EventArgs e)
        {
            excell  = new importexcell();

            cbTable.Properties.Items.Add("Thêm NHà Cung Cấp");
            cbTable.Properties.Items.Add("Thêm Khách Hàng");
            cbTable.Properties.Items.Add("Thêm Mặt Hàng");
            cbTable.Properties.Items.Add("Thêm Đơn Vị Tính");
            cbTable.Properties.Items.Add("Update Nhà Cung Cấp");
            cbTable.Properties.Items.Add("Update Khách Hàng");
            cbTable.Properties.Items.Add("Update Mặt Hàng");
            cbTable.Properties.Items.Add("Update Đơn Vị Tính");
            cbTable.Properties.Items.Add("Thêm Kho Hàng");
            cbTable.Properties.Items.Add("update Kho Hàng");
            button2.Enabled = false;
            loadgridMatHang();

        }
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        importexcell excell;
        public void loadgridMatHang()
        {
            CTL ctlNCC = new CTL();
            cboTenNCC.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenNCC.Properties.DisplayMember = "TENMH";
            cboTenNCC.Properties.ValueMember = "MAMH";
            cboTenNCC.Properties.View.BestFitColumns();
            cboTenNCC.Properties.PopupFormWidth = 400;
            cboTenNCC.Properties.DataSource = ctlNCC.GETMATHANG1();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mo.Filter = "(*.xls)|*.xls";
            DataTable bang = new DataTable();
            if (mo.ShowDialog() == DialogResult.OK)
            {
                if (mo.FileName != "")
                {

                    excell.mo_excel(mo.FileName);
                    bang = excell.get_data_from_excell();
                    luoi.DataSource = bang;
                    button2.Enabled = true;
                    excell.style_dgview(luoi);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DataTable dulieu = new DataTable();
           Provider pv = new Provider();
           pv.connect();
            String lenh;
            dulieu = (DataTable)(luoi.DataSource);
            tientrinh.Maximum = dulieu.Rows.Count;
            tientrinh.Minimum = 0;
            tientrinh.Step = 1;
            foreach (System.Data.DataRow duyet_dong in dulieu.Rows)
            {
                lenh = nhap_tien_tc(duyet_dong);
                try
                {
                    pv.executeNonQuery(lenh);
                }
                catch
                {
                    MessageBox.Show("CỘT TRONG FILE EXCELL KHÔNG HỢP LỆ"+lenh+"");
                }
                tientrinh.PerformStep();
            }
            MessageBox.Show("Quá trình đưa dữ liệu đã hoàn tất.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tientrinh.Value = 0;
        }
        private String nhap_tien_tc(System.Data.DataRow cot)
        {
            String lenh = "";
            
                
                if (cbTable.SelectedIndex == 0)
                {
                    lenh = "INSERT INTO [NHACUNGCAP]([MANCC],[MAKV],[MAKHO],[TENNCC],[DIACHI],[MASOTHUE],[SOTAIKHOAN],[NGANHANG],[SDT],[EMAIL],[FAX],[WEBSITE],[TINHTRANG]) "
                    + " VALUES ('" + cot["MANCC"] + "','" + cot["MAKV"] + "','" + cot["MAKHO"] + "',N'" + cot["TENNCC"] + "',N'" + cot["DIACHI"] + "','" + cot["MASOTHUE"] + "','" + cot["SOTAIKHOAN"] + "',N'" + cot["NGANHANG"] + "','" + cot["SDT"] + "','" + cot["EMAIL"] + "','" + cot["FAX"] + "','" + cot["WEBSITE"] + "'," + cot["TINHTRANG"] + ") ";
                }
                else if (cbTable.SelectedIndex == 1)
                {
                    lenh = "INSERT INTO [KHACHHANG] ([MAKH],[MAKV],[MAKHO],[TENKH],[SOTAIKHOAN],[NGANHANG],[MASOTHUE],[DIACHI],[SDT],[FAX],[WEBSITE],[YAHOO],[SKYPE],[TINHTRANG]) "
                + " VALUES ('" + cot["MAKH"] + "','" + cot["MAKV"] + "','" + cot["MAKHO"] + "',N'" + cot["TENKH"] + "','" + cot["SOTAIKHOAN"] + "',N'" + cot["NGANHANG"] + "','" + cot["MASOTHUE"] + "',N'" + cot["DIACHI"] + "','" + cot["SDT"] + "','" + cot["FAX"] + "','" + cot["WEBSITE"] + "','" + cot["YAHOO"] + "','" + cot["SKYPE"] + "'," + cot["TINHTRANG"] + ") ";

                }
                else if (cbTable.SelectedIndex == 2)
                {
                    string HSD = cot["HANSUDUNG"].ToString().Substring(0, 10);
                    lenh = "INSERT INTO [MATHANG]([MAMH],[MATH],[MANH],[MANCC],[MAKHO],[TENMH],[KLDVT],[MADVT],[SOLUONGMH],[HANSUDUNG],[GIAMUA],[GIABAN],[MOTA],[TINHTRANG]) "
                    + " VALUES ('" + cot["MAMH"] + "','" + cot["MATH"] + "','" + cot["MANH"] + "','" + cot["MANCC"] + "','" + cot["MAKHO"] + "',N'" + cot["TENMH"] + "','" + cot["KLDVT"] + "','" + cot["MADVT"] + "'," + cot["SOLUONGMH"] + ",'" + HSD + "'," + cot["GIAMUA"] + "," + cot["GIABAN"] + ",N'" + cot["MOTA"] + "'," + cot["TINHTRANG"] + ")";
                }
                else if (cbTable.SelectedIndex == 3)
                {
                    lenh = "INSERT INTO [DONVITINH]([MADVT],[DONVITINH]) "
                    + " VALUES ('" + cot["MADVT"] + "',N'" + cot["DONVITINH"] + "')";
                }
                else if (cbTable.SelectedIndex == 4)
                {
                    lenh = "UPDATE  [NHACUNGCAP] "
                    + " SET  [TENNCC]= N'" + cot["TENNCC"] + "',[DIACHI]=N'" + cot["DIACHI"] + "',[MASOTHUE]='" + cot["MASOTHUE"] + "',[SOTAIKHOAN]='" + cot["SOTAIKHOAN"] + "',[NGANHANG]=N'" + cot["NGANHANG"] + "',[SDT]='" + cot["SDT"] + "',[EMAIL]='" + cot["EMAIL"] + "',[FAX]='" + cot["FAX"] + "',[WEBSITE]='" + cot["WEBSITE"] + "',[TINHTRANG]=" + cot["TINHTRANG"] + " WHERE [MANCC]='" + cot["MANCC"] + "'";
                }
                else if (cbTable.SelectedIndex == 5)
                {
                    lenh = "UPDATE   [KHACHHANG] "
                + " SET  [TENKH]=N'" + cot["TENKH"] + "',[SOTAIKHOAN]='" + cot["SOTAIKHOAN"] + "',[NGANHANG]=N'" + cot["NGANHANG"] + "',[MASOTHUE]='" + cot["MASOTHUE"] + "',[DIACHI]=N'" + cot["DIACHI"] + "',[SDT]='" + cot["SDT"] + "',[FAX]='" + cot["FAX"] + "',[WEBSITE]='" + cot["WEBSITE"] + "',[YAHOO]='" + cot["YAHOO"] + "',[SKYPE]='" + cot["SKYPE"] + "',[TINHTRANG]=" + cot["TINHTRANG"] + " WHERE [MAKH]='" + cot["MAKH"] + "'";

                }
                else if (cbTable.SelectedIndex == 6)
                {
                    //string HSD = cot["HANSUDUNG"].ToString().Substring(0, 10);
                    //HSD = HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2) + "/" + HSD.Substring(6, 4);
                    //lenh = "UPDATE   [MATHANG] "
                   // + " SET  [TENMH]=N'" + cot["TENMH"] + "',[MANCC]=N'" + cot["MANCC"] + "',[KLDVT]='" + cot["KLDVT"] + "',[MADVT]='" + cot["MADVT"] + "',[SOLUONGMH]=" + cot["SOLUONGMH"] + ",[HANSUDUNG]='" + HSD + "',[GIAMUA]=" + cot["GIAMUA"] + ",[GIABAN]=" + cot["GIABAN"] + ",[MOTA]=N'" + cot["MOTA"] + "',[TINHTRANG]=" + cot["TINHTRANG"] + " WHERE [MAMH]='" + cot["MAMH"] + "'";
                    lenh = "UPDATE   [MATHANG] "
                    + " SET  [GIAMUA]=" + cot["GIAMUA"] + ",[GIABAN]=" + cot["GIABAN"] + " WHERE [MAMH]='" + cot["MAMH"] + "'";                
                }
                else if (cbTable.SelectedIndex == 7)
                {
                    lenh = "UPDATE   [DONVITINH] "
                    + " SET  [DONVITINH]= N'" + cot["DONVITINH"] + "' WHERE [MADVT]='" + cot["MADVT"] + "'";
                }
                else if (cbTable.SelectedIndex == 8)
                {
                    String HSD = cot["HSD"].ToString().Substring(0, 10);
                    HSD = HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2) + "/" + HSD.Substring(6, 4);
                
                    String NGAYNHAP = cot["NGAYNHAP"].ToString().Substring(0, 10);
                    NGAYNHAP = NGAYNHAP.Substring(3, 2) + "/" + NGAYNHAP.Substring(0, 2) + "/" + NGAYNHAP.Substring(6, 4);
                    lenh = "INSERT INTO [KHOHANG]([MAMH],[LOHANG],[HSD],[GIAMUA],[TONKHO],[NHAPKHO],[XUATKHO],[TRANHAPKHO],[TRAXUATKHO],[NGAYNHAP]) "
                    + " VALUES ('" + cot["MAMH"].ToString() + "',N'" + cot["LOHANG"].ToString() + "',N'" + HSD + "'," + cot["GIAMUA"].ToString() + "," + cot["TONKHO"].ToString() + "," + cot["NHAPKHO"].ToString() + "," + cot["XUATKHO"] + "," + cot["TRANHAPKHO"].ToString() + "," + cot["TRAXUATKHO"].ToString() + ",N'" + NGAYNHAP + "')";
                }
                else if (cbTable.SelectedIndex == 9)
                {
                    lenh = "UPDATE   [KHOHANG] "
                    + " SET  [GIAMUA]=" + cot["GIAMUA"] + " WHERE [MAMH]='" + cot["MAMH"] + "'";
                }
            return lenh;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deDongTab();
            DataTable dt = new DataTable();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            export exp = new export();
            exp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn Thực HIện Câu Lệnh không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Provider pv = new Provider();
                    pv.connect();
                    String SQL = txtsql.Text;
                    pv.executeNonQuery(SQL);

                }
                catch
                {
                    MessageBox.Show("Có Lỗi Xảy Ra Với Câu Lệnh");
                }

                MessageBox.Show("Đã Hoàn Thành Câu Lệnh");
            }
        }

        private void btncomputerdate_Click(object sender, EventArgs e)
        {
            PublicVariable.isUSE_COMPUTERDATE = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CTL ctlNCC = new CTL();
            string mamhsql = gridView3.GetFocusedRowCellValue("MAMH").ToString(); ;
            string soluongsql = txtsoluong.Text;
            string lohangsql = "1";
            if (txtlohang.Text != "")
            {
                lohangsql = txtlohang.Text;
            }

            String SQL = "update mathang set soluongmh=soluongmh+" + soluongsql + " where mamh='" + mamhsql + "' ";
            ctlNCC.executeNonQuery(SQL);

            SQL = "update KHOHANG set tonkho=tonkho + " + soluongsql + ", nhapkho=nhapkho+" + soluongsql + " where mamh='" + mamhsql + "' and LOHANG='" + lohangsql + "' ";
            ctlNCC.executeNonQuery(SQL);

            loadgridMatHang();
            MessageBox.Show("Đã Hoàn Thành Câu Lệnh");
        }

       
    }
}