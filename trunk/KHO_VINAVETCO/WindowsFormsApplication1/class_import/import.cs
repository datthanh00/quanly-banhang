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
            cbTable.Properties.Items.Add("THÊM TỒN KHO THUC TẾ");
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
                else if (cbTable.SelectedIndex == 10)
                {
                    lenh = "INSERT INTO [TONKHOTT]([NGAY],[MAMH],[MAKHO],[TONTT],[TONKHONGAY]) "
              + " VALUES ('" + cot["NGAY"].ToString() + "','" + cot["MAMH"].ToString() + "','" + cot["MAKHO"].ToString() + "'," + cot["TONTT"].ToString() + "," + cot["TONKHONGAY"].ToString() + ")";
               
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

        private void button7_Click(object sender, EventArgs e)
        {
            CTL ctlNCC = new CTL();
            String SQL = "SELECT mamh,toncuoi,convert(varchar,ngay,101) as ngay,TONCUOINGAY FROM TONKHO";
            DataTable dt= ctlNCC.GETDATA(SQL);

            for (int i = dt.Rows.Count-1; i >=0; i--)
            {
                if (dt.Rows[i][3].ToString() == "")
                {
                    SQL = "update tonkho set TONCUOINGAY=" + dt.Rows[i][1].ToString() + " where mamh='" + dt.Rows[i][0].ToString() + "' and ngay='" + dt.Rows[i][2].ToString() + "'";
                    ctlNCC.executeNonQuery(SQL);

                    SQL = "SELECT mamh,toncuoi,convert(varchar,ngay,101) as ngay,TONCUOINGAY FROM TONKHO";
                    dt = ctlNCC.GETDATA(SQL);
                }
            }
        }

        private void btnEDITMAHD_Click(object sender, EventArgs e)
        {
            string SQLEDIT = "";
            DataTable DTEDIT;
            CTL CTLEDIT = new CTL();
            string NEWMA = "";
            string CODE = "",OLDCODE="";
            int LENTCODE = 0;
            //EDIT MA BANG GIA
            CODE="BG";
            OLDCODE = "BG";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MABG,CODEKHO FROM BANGGIA,KHO WHERE BANGGIA.MAKHO=KHO.MAKHO";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {
                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA=DTEDIT.Rows[I][0].ToString();
                    SQLEDIT =SQLEDIT+ "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE BANGGIA SET MABG='" + NEWMA + "' WHERE MABG='" + MA + "'";
                    SQLEDIT = SQLEDIT +" \r\nGO\r\n UPDATE BANGGIAMATHANG SET MABG='"+NEWMA+"' WHERE MABG='"+MA+"'";
                    
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE KHACHHANG SET MABG='" + NEWMA + "' WHERE MABG='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA BO PHAN
            CODE = "BP";
            OLDCODE = "MABP";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MABP,'' AS CODEKHO FROM BOPHAN";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }

                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE BOPHAN SET MABP='" + NEWMA + "' WHERE MABP='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHANKHO SET MABP='" + NEWMA + "' WHERE MABP='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHANQUYEN SET MABP='" + NEWMA + "' WHERE MABP='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE NHANVIEN SET MABP='" + NEWMA + "' WHERE MABP='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA PHIEU THU
            CODE = "PT";
            OLDCODE = "PT";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAPT,CODEKHO AS MAHD FROM PHIEUTHU,HOADONXUAT,KHO WHERE PHIEUTHU.MAHDX=HOADONXUAT.MAHDX AND HOADONXUAT.MAKHO=KHO.MAKHO UNION ALL SELECT MAPT,CODEKHO AS MAHD FROM PHIEUTHU,TRAHOADONNHAP,KHO WHERE PHIEUTHU.MAHDX=TRAHOADONNHAP.MAHDN AND TRAHOADONNHAP.MAKHO=KHO.MAKHO";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }

                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHIEUTHU SET MAPT='" + NEWMA + "' WHERE MAPT='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }


            //EDIT MA PHIEU CHI

            CODE = "PC";
            OLDCODE = "PC";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAPC,CODEKHO FROM PHIEUCHI,HOADONNHAP,KHO WHERE PHIEUCHI.MAHDN=HOADONNHAP.MAHDN AND HOADONNHAP.MAKHO=KHO.MAKHO UNION ALL SELECT MAPC,CODEKHO  FROM PHIEUCHI,TRAHOADONXUAT,KHO WHERE PHIEUCHI.MAHDN=TRAHOADONXUAT.MAHDX AND TRAHOADONXUAT.MAKHO=KHO.MAKHO";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }

                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHIEUCHI SET MAPC='" + NEWMA + "' WHERE MAPC='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }
            //EDIT MA DON VI TINH
            CODE = "DVT";
            OLDCODE = "DVT";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MADVT,'' AS CODEKHO FROM DONVITINH";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }

                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE DONVITINH SET MADVT='" + NEWMA + "' WHERE MADVT='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE MATHANG SET MADVT='" + NEWMA + "' WHERE MADVT='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA KHACH HANG
            CODE = "KH";
            OLDCODE = "KH";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAKH, CODEKHO FROM KHACHHANG,KHO WHERE KHACHHANG.MAKHO=KHO.MAKHO";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE KHACHHANG SET MAKH='" + NEWMA + "' WHERE MAKH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRAHOADONXUAT SET MAKH='" + NEWMA + "' WHERE MAKH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE HOADONXUAT SET MAKH='" + NEWMA + "' WHERE MAKH='" + MA + "'";
                    

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA KHO
            CODE = "KHO";
            OLDCODE = "MAKHO";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAKHO, '' AS CODEKHO1 FROM KHO";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE KHO SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKIEMKHO SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE MATHANG SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHOTT SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHANKHO SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE NHACUNGCAP SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRAHOADONNHAP SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRAHOADONXUAT SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE HOADONXUAT SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE HOADONNHAP SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHO SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE BANGGIA SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE KHACHHANG SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE MAHDARRAY SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
                    
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE CHITIETHDXTAM SET MAKHO='" + NEWMA + "' WHERE MAKHO='" + MA + "'";
         

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA KHU VUC
            CODE = "KV";
            OLDCODE = "MAKV";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAKV, '' AS CODEKHO FROM KHUVUC";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }

                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE KHUVUC SET MAKV='" + NEWMA + "' WHERE MAKV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE NHACUNGCAP SET MAKV='" + NEWMA + "' WHERE MAKV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE KHACHHANG SET MAKV='" + NEWMA + "' WHERE MAKV='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA MAT HANG
            CODE = "MH";
            OLDCODE = "MH";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAMH, CODEKHO FROM MATHANG,KHO WHERE MATHANG.MAKHO=KHO.MAKHO";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE MATHANG SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKIEMKHO SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHOTT SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE BANGGIAMATHANG SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE KHOHANG SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRACHITIETHDX SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE CHITIETHDX SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE CHITIETHDN SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRACHITIETHDN SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONDAUMATHANG SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHO SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE CHITIETHDXTAM SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONDAUKHOHANG SET MAMH='" + NEWMA + "' WHERE MAMH='" + MA + "'";
                    

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }


            //EDIT MA NHA CUNG CAP
            CODE = "NCC";
            OLDCODE = "MANCC";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MANCC, CODEKHO FROM NHACUNGCAP,KHO WHERE NHACUNGCAP.MAKHO=KHO.MAKHO";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE NHACUNGCAP SET MANCC='" + NEWMA + "' WHERE MANCC='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE MATHANG SET MANCC='" + NEWMA + "' WHERE MANCC='" + MA + "'";
                    
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRAHOADONNHAP SET MANCC='" + NEWMA + "' WHERE MANCC='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE HOADONNHAP SET MANCC='" + NEWMA + "' WHERE MANCC='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA NHAN VIEN
            CODE = "NV";
            OLDCODE = "MANV";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MANV, '' AS CODEKHO FROM NHANVIEN";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE NHANVIEN SET MANV='" + NEWMA + "' WHERE MANV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHIEUCHI SET MANV='" + NEWMA + "' WHERE MANV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHIEUTHU SET MANV='" + NEWMA + "' WHERE MANV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRAHOADONNHAP SET MANV='" + NEWMA + "' WHERE MANV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRAHOADONXUAT SET MANV='" + NEWMA + "' WHERE MANV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE HOADONXUAT SET MANV='" + NEWMA + "' WHERE MANV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE HOADONNHAP SET MANV='" + NEWMA + "' WHERE MANV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHO SET MANV='" + NEWMA + "' WHERE MANV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE KHACHHANG SET MANV='" + NEWMA + "' WHERE MANV='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE KHO SET MANV='" + NEWMA + "' WHERE MANV='" + MA + "'";
                    
                    

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA NHAP KHAC
            CODE = "HDNK";
            OLDCODE = "MAHDN";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAHDN, CODEKHO FROM HOADONNHAP,KHO WHERE HOADONNHAP.MAKHO=KHO.MAKHO AND TYPE<>1";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE HOADONNHAP SET MAHDN='" + NEWMA + "' WHERE MAHDN='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHIEUCHI SET MAHDN='" + NEWMA + "' WHERE MAHDN='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE CHITIETHDN SET MAHDN='" + NEWMA + "' WHERE MAHDN='" + MA + "'";
                    
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHO SET MAHD='" + NEWMA + "' WHERE MAHD='" + MA + "'";
                   
                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA XUAT KHAC
            CODE = "HDXK";
            OLDCODE = "MAHDX";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAHDX, CODEKHO FROM HOADONXUAT,KHO WHERE HOADONXUAT.MAKHO=KHO.MAKHO AND TYPE<>1";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE HOADONXUAT SET MAHDX='" + NEWMA + "' WHERE MAHDX='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHIEUTHU SET MAHDX='" + NEWMA + "' WHERE MAHDX='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE CHITIETHDX SET MAHDX='" + NEWMA + "' WHERE MAHDX='" + MA + "'";
                    
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE CHITIETHDXTAM SET MAHDX='" + NEWMA + "' WHERE MAHDX='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHO SET MAHD='" + NEWMA + "' WHERE MAHD='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA NHOM HANG
            CODE = "NH";
            OLDCODE = "NH";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MANH, '' AS CODEKHO FROM NHOMHANG";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }

                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE NHOMHANG SET MANH='" + NEWMA + "' WHERE MANH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE MATHANG SET MANH='" + NEWMA + "' WHERE MANH='" + MA + "'";


                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA THUE
            CODE = "TH";
            OLDCODE = "TH";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MATH, '' AS CODEKHO FROM THUE";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }

                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE THUE SET MATH='" + NEWMA + "' WHERE MATH='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE MATHANG SET MATH='" + NEWMA + "' WHERE MATH='" + MA + "'";


                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA TRA XUAT
            CODE = "THDX";
            OLDCODE = "MATHDX";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAHDX, CODEKHO FROM TRAHOADONXUAT,KHO WHERE TRAHOADONXUAT.MAKHO=KHO.MAKHO AND TYPE=1";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length >(LENTCODE+4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRAHOADONXUAT SET MAHDX='" + NEWMA + "' WHERE MAHDX='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHIEUCHI SET MAHDN='" + NEWMA + "' WHERE MAHDN='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRACHITIETHDX SET MAHDX='" + NEWMA + "' WHERE MAHDX='" + MA + "'";
                    
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHO SET MAHD='" + NEWMA + "' WHERE MAHD='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA TRA NHAP
            CODE = "THDN";
            OLDCODE = "MATHDN";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAHDN, CODEKHO FROM TRAHOADONNHAP,KHO WHERE TRAHOADONNHAP.MAKHO=KHO.MAKHO AND TYPE=1";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length > (LENTCODE + 4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRAHOADONNHAP SET MAHDN='" + NEWMA + "' WHERE MAHDN='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHIEUTHU SET MAHDX='" + NEWMA + "' WHERE MAHDX='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TRACHITIETHDN SET MAHDN='" + NEWMA + "' WHERE MAHDN='" + MA + "'";
                   
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHO SET MAHD='" + NEWMA + "' WHERE MAHD='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA XUAT
            CODE = "HDX";
            OLDCODE = "MAHDX";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAHDX, CODEKHO FROM HOADONXUAT,KHO WHERE HOADONXUAT.MAKHO=KHO.MAKHO AND TYPE=1";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length > (LENTCODE + 4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE HOADONXUAT SET MAHDX='" + NEWMA + "' WHERE MAHDX='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHIEUTHU SET MAHDX='" + NEWMA + "' WHERE MAHDX='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE CHITIETHDX SET MAHDX='" + NEWMA + "' WHERE MAHDX='" + MA + "'";
                    
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHO SET MAHD='" + NEWMA + "' WHERE MAHD='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            //EDIT MA NHAP
            CODE = "HDN";
            OLDCODE = "MAHDN";
            LENTCODE = OLDCODE.Length + 4;
            SQLEDIT = "SELECT MAHDN, CODEKHO FROM HOADONNHAP,KHO WHERE HOADONNHAP.MAKHO=KHO.MAKHO AND TYPE=1";
            DTEDIT = CTLEDIT.GETDATA(SQLEDIT);
            if (DTEDIT.Rows.Count > 0)
            {

                for (int I = 0; I < DTEDIT.Rows.Count; I++)
                {
                    SQLEDIT = "";
                    string MA = DTEDIT.Rows[I][0].ToString();
                    SQLEDIT = SQLEDIT + "";
                    if (MA.Length > (LENTCODE + 4))
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString()+"0" + Convert.ToInt32(MA.Substring(LENTCODE, MA.Length - LENTCODE)).ToString();
                    }
                    else
                    {
                        NEWMA = CODE + DTEDIT.Rows[I][1].ToString() + Convert.ToInt32(MA.Substring(OLDCODE.Length, MA.Length - OLDCODE.Length)).ToString();
                    }
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE HOADONNHAP SET MAHDN='" + NEWMA + "' WHERE MAHDN='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE PHIEUCHI SET MAHDN='" + NEWMA + "' WHERE MAHDN='" + MA + "'";
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE CHITIETHDN SET MAHDN='" + NEWMA + "' WHERE MAHDN='" + MA + "'";
                    
                    SQLEDIT = SQLEDIT + " \r\nGO\r\n UPDATE TONKHO SET MAHD='" + NEWMA + "' WHERE MAHD='" + MA + "'";

                    CTLEDIT.EXCUTE_SQL2(SQLEDIT);
                }
            }

            MessageBox.Show("ĐÃ HOÀN THÀNH");
        }

       
    }
}