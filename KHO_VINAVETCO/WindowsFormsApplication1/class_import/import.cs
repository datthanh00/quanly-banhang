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

            cbTable.Properties.Items.Add("KHO");
            cbTable.Properties.Items.Add("THUẾ");
            cbTable.Properties.Items.Add("ĐƠN VỊ TÍNH");
            cbTable.Properties.Items.Add("NHÓM HÀNG");
            cbTable.Properties.Items.Add("KHU VỰC");
            cbTable.Properties.Items.Add("BẢNG GIÁ");
            cbTable.Properties.Items.Add("NHÀ CUNG CẤP");
            cbTable.Properties.Items.Add("KHÁCH HÀNG");
            cbTable.Properties.Items.Add("MẶT HÀNG");
            button2.Enabled = false;
           
        }
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        importexcell excell;
        Boolean isupdate = false;

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
          
            if (checkTT.Checked)
            {
                isupdate = true;
                if (XtraMessageBox.Show("Bạn có muốn Cập Nhật không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                isupdate = false;
                if (XtraMessageBox.Show("Bạn có muốn Thêm không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
           
            DataTable dulieu = new DataTable();
            Provider pv = new Provider();
            pv.connect();
            String lenh = ""; ;
            dulieu = (DataTable)(luoi.DataSource);
            tientrinh.Maximum = dulieu.Rows.Count;
            tientrinh.Minimum = 0;
            tientrinh.Step = 1;

            //INSERT KHO 0
            if (cbTable.SelectedIndex == 0 && !isupdate)
            {
                string MA = "(";
                foreach (System.Data.DataRow DONG in dulieu.Rows)
                {
                    MA = MA + "'" + DONG["MAKHO"] + "',";
                }
                MA = MA.Substring(0, MA.Length - 1) + ")";

                string SQL2 = "Select MAKHO FROM KHO WHERE MAKHO IN "+ MA;
                DataTable TBMA=pv.getdata(SQL2);
                if (TBMA.Rows.Count > 0)
                {
                    MessageBox.Show("MÃ KHO NÀY: "+TBMA.Rows[0][0].ToString()+" ĐÃ TỒN TẠI");
                    return;
                }
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n INSERT INTO [KHO]([MAKHO],[CODEKHO],[TENKHO],[DIACHI],[SDTB],[DTDD],[NGUOILH],[FAX],[GHICHU],[TINHTRANG]) VALUES ('" + COT["MAKHO"] + "','" + COT["CODEKHO"] + "',N'" + COT["TENKHO"] + "',N'" + COT["DIACHI"] + "','" + COT["SDTB"] + "','" + COT["DTDD"] + "',N'" + COT["NGUOILH"] + "','" + COT["FAX"] + "',N'" + COT["GHICHU"] + "',1)";
                }
          
            }
            //UPDATE KHO 0
            else if (cbTable.SelectedIndex == 0&&isupdate)
            {
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n UPDATE [KHO] SET [CODEKHO] ='" + COT["CODEKHO"] + "',[TENKHO] =N'" + COT["TENKHO"] + "',[DIACHI] =N'" + COT["DIACHI"] + "',[SDTB] ='" + COT["SDTB"] + "',[DTDD] ='" + COT["DTDD"] + "',[NGUOILH] =N'" + COT["NGUOILH"] + "',[FAX] ='" + COT["FAX"] + "',[GHICHU] =N'" + COT["GHICHU"] + "' WHERE [MAKHO] ='" + COT["MAKHO"] + "'";
                }
            }
            //INSERT THUẾ
            else if (cbTable.SelectedIndex == 1 && !isupdate)
            {
                string MA = "(";
                foreach (System.Data.DataRow DONG in dulieu.Rows)
                {
                    MA = MA + "'" + DONG["MATH"] + "',";
                }
                MA = MA.Substring(0, MA.Length - 1) + ")";

                string SQL2 = "Select MATH FROM THUE WHERE MATH IN " + MA;
                DataTable TBMA = pv.getdata(SQL2);
                if (TBMA.Rows.Count > 0)
                {
                    MessageBox.Show("MÃ THUẾ NÀY: " + TBMA.Rows[0][0].ToString() + " ĐÃ TỒN TẠI");
                    return;
                }
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n INSERT INTO [THUE]([MATH],[SOTHUE]) VALUES('" + COT["MATH"] + "','" + COT["SOTHUE"] + "')";
                }
            }
            //UPDATE THUẾ
            else if (cbTable.SelectedIndex == 1&&isupdate)
            {
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n UPDATE [THUE] SET SOTHUE='" + COT["SOTHUE"] + "' WHERE MATH='" + COT["MATH"] + "'";
                }
            }
            //INSERT ĐƠN VỊ TÍNH
            else if (cbTable.SelectedIndex == 2 && !isupdate)
            {
                string MA = "(";
                foreach (System.Data.DataRow DONG in dulieu.Rows)
                {
                    MA = MA + "'" + DONG["MADVT"] + "',";
                }
                MA = MA.Substring(0, MA.Length - 1) + ")";

                string SQL2 = "Select MADVT FROM DONVITINH WHERE MADVT IN " + MA;
                DataTable TBMA = pv.getdata(SQL2);
                if (TBMA.Rows.Count > 0)
                {
                    MessageBox.Show("MÃ ĐƠN VỊ TÍNH NÀY: " + TBMA.Rows[0][0].ToString() + " ĐÃ TỒN TẠI");
                    return;
                }
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n INSERT INTO [DONVITINH]([MADVT],[DONVITINH]) VALUES('" + COT["MADVT"] + "',N'" + COT["DONVITINH"] + "')";
                }
            }
            //UPDATE ĐƠN VỊ TÍNH
            else if (cbTable.SelectedIndex == 2&&isupdate)
            {
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n UPDATE [DONVITINH] SET DONVITINH=N'" + COT["DONVITINH"] + "' WHERE MADVT='" + COT["MADVT"] + "'";
                }
            }
            //INSERT NHÓM HÀNG
            else if (cbTable.SelectedIndex == 3 && !isupdate)
            {
                string MA = "(";
                foreach (System.Data.DataRow DONG in dulieu.Rows)
                {
                    MA = MA + "'" + DONG["MANH"] + "',";
                }
                MA = MA.Substring(0, MA.Length - 1) + ")";

                string SQL2 = "Select MANH FROM NHOMHANG WHERE MANH IN " + MA;
                DataTable TBMA = pv.getdata(SQL2);
                if (TBMA.Rows.Count > 0)
                {
                    MessageBox.Show("MÃ NHÓM HÀNG NÀY: " + TBMA.Rows[0][0].ToString() + " ĐÃ TỒN TẠI");
                    return;
                }
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n INSERT INTO [NHOMHANG]([MANH],[TENNHOMHANG],GHICHU) VALUES('" + COT["MANH"] + "',N'" + COT["TENNHOMHANG"] + "',N'" + COT["GHICHU"] + "')";
                }
            }
            // UPDATE NHÓM HÀNG
            else if (cbTable.SelectedIndex == 3 && isupdate)
            {
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n UPDATE [NHOMHANG] SET TENNHOMHANG=N'" + COT["TENNHOMHANG"] + "',GHICHU=N'" + COT["GHICHU"] + "' WHERE MANH='" + COT["MANH"] + "'";
                }
            }
            //INSERT KHU VỰC
            else if (cbTable.SelectedIndex == 4 && !isupdate)
            {
                string MA = "(";
                foreach (System.Data.DataRow DONG in dulieu.Rows)
                {
                    MA = MA + "'" + DONG["MAKV"] + "',";
                }
                MA = MA.Substring(0, MA.Length - 1) + ")";

                string SQL2 = "Select MAKV FROM KHUVUC WHERE MAKV IN " + MA;
                DataTable TBMA = pv.getdata(SQL2);
                if (TBMA.Rows.Count > 0)
                {
                    MessageBox.Show("MÃ KHU VUC NÀY: " + TBMA.Rows[0][0].ToString() + " ĐÃ TỒN TẠI");
                    return;
                }
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n INSERT INTO [KHUVUC]([MAKV],[TENKV],GHICHU,TINHTRANG) VALUES('" + COT["MAKV"] + "',N'" + COT["TENKV"] + "',N'" + COT["GHICHU"] + "',1)";
                }
            }
            // UPDATE KHU VỰC
            else if (cbTable.SelectedIndex == 4 && isupdate)
            {
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n UPDATE [KHUVUC] SET TENKV=N'" + COT["TENKV"] + "',GHICHU=N'" + COT["GHICHU"] + "' WHERE MAKV='" + COT["MAKV"] + "'";
                }
            }
            // INSERT BẢNG GIÁ
            else if (cbTable.SelectedIndex == 5 && !isupdate)
            {
                
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n INSERT INTO [BANGGIA]([MABG],[MAKHO],TENBG) VALUES('" + COT["MABG"] + "','" + COT["MAKHO"] + "',N'" + COT["TENBG"] + "')";
                    lenh = lenh + "\r\nGO\r\n  INSERT INTO BANGGIAMATHANG ([MABG],[MAMH],[GIABAN])  SELECT '" + COT["MABG"] + "' AS MABG,MAMH,0 AS GIABAN FROM MATHANG WHERE MAKHO='" + COT["MAKHO"] + "'";
                }
      
            }
            // UPDATE BẢNG GIÁ
            else if (cbTable.SelectedIndex == 5 && isupdate)
            {
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n UPDATE [BANGGIA] SET MAKHO='" + COT["MAKHO"] + "',TENBG=N'" + COT["TENBG"] + "' WHERE MABG='" + COT["MABG"] + "' ";
                }
            }
            //INSERT NHÀ CUNG CẤP
            else if (cbTable.SelectedIndex == 6 && !isupdate)
            {
                string MA = "(";
                foreach (System.Data.DataRow DONG in dulieu.Rows)
                {
                    MA = MA + "'" + DONG["MANCC"] + "',";
                }
                MA = MA.Substring(0, MA.Length - 1) + ")";

                string SQL2 = "Select MANCC FROM NHACUNGCAP WHERE MANCC IN " + MA;
                DataTable TBMA = pv.getdata(SQL2);
                if (TBMA.Rows.Count > 0)
                {
                    MessageBox.Show("MÃ NHÀ CUNG CẤP NÀY: " + TBMA.Rows[0][0].ToString() + " ĐÃ TỒN TẠI");
                    return;
                }
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n INSERT INTO [NHACUNGCAP]([MANCC],[MAKV],[TENNCC],[DIACHI],[MASOTHUE],[SOTAIKHOAN],[NGANHANG],[SDT],[EMAIL],[FAX],[WEBSITE],[TINHTRANG],[MAKHO],[CONGNO],[TIENTRATRUOC]) VALUES('" + COT["MANCC"] + "','" + COT["MAKV"] + "',N'" + COT["TENNCC"] + "',N'" + COT["DIACHI"] + "','" + COT["MASOTHUE"] + "','" + COT["SOTAIKHOAN"] + "',N'" + COT["NGANHANG"] + "','" + COT["SDT"] + "','" + COT["EMAIL"] + "','" + COT["FAX"] + "','" + COT["WEBSITE"] + "',1,'" + COT["MAKHO"] + "'," + COT["CONGNO"] + "," + COT["TIENTRATRUOC"] + ")";
                    lenh = lenh + " \r\nGO\r\n INSERT INTO TONDAUCONGNONCC([MANCC],[CONGNO])VALUES ('" + COT["MANCC"] + "'," + COT["CONGNO"] + ")";
                    
                }
            }
            //UPDATE NHÀ CUNG CẤP
            else if (cbTable.SelectedIndex == 6 && isupdate)
            {
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n UPDATE [NHACUNGCAP] SET MAKV='" + COT["MAKV"] + "',TENNCC=N'" + COT["TENNCC"] + "',DIACHI=N'" + COT["DIACHI"] + "',MASOTHUE='" + COT["MASOTHUE"] + "',SOTAIKHOAN='" + COT["SOTAIKHOAN"] + "',NGANHANG=N'" + COT["NGANHANG"] + "',SDT='" + COT["SDT"] + "',EMAIL='" + COT["EMAIL"] + "',FAX='" + COT["FAX"] + "',WEBSITE='" + COT["WEBSITE"] + "',MAKHO='" + COT["MAKHO"] + "',CONGNO=" + COT["CONGNO"] + ",TIENTRATRUOC=" + COT["TIENTRATRUOC"] + " WHERE MANCC='" + COT["MANCC"] + "'";
                    lenh = lenh + " \r\nGO\r\n UPDATE TONDAUCONGNONCC set CONGNO=" + COT["CONGNO"] + " WHERE MANCC='" + COT["MANCC"] + "'";
                }
            }
            //INSERT KHÁCH HÀNG
            else if (cbTable.SelectedIndex == 7 && !isupdate)
            {
                string MA = "(";
                foreach (System.Data.DataRow DONG in dulieu.Rows)
                {
                    MA = MA + "'" + DONG["MAKH"] + "',";
                }
                MA = MA.Substring(0, MA.Length - 1) + ")";

                string SQL2 = "Select MAKH FROM KHACHHANG WHERE MAKH IN " + MA;
                DataTable TBMA = pv.getdata(SQL2);
                if (TBMA.Rows.Count > 0)
                {
                    MessageBox.Show("MÃ KHÁCH HÀNG NÀY: " + TBMA.Rows[0][0].ToString() + " ĐÃ TỒN TẠI");
                    return;
                }
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n INSERT INTO [KHACHHANG]([MAKH],[MAKV],[MANV],[MABG],[TENKH],[SOTAIKHOAN],[NGANHANG],[MASOTHUE],[DIACHI],[SDT],[FAX],[WEBSITE],[YAHOO],[SKYPE],[TINHTRANG],[MAKHO],[CONGNO],TIENTRATRUOC) VALUES('" + COT["MAKH"] + "','" + COT["MAKV"] + "','" + COT["MANV"] + "','" + COT["MABG"] + "',N'" + COT["TENKH"] + "','" + COT["SOTAIKHOAN"] + "',N'" + COT["NGANHANG"] + "','" + COT["MASOTHUE"] + "',N'" + COT["DIACHI"] + "','" + COT["SDT"] + "','" + COT["FAX"] + "','" + COT["WEBSITE"] + "','" + COT["YAHOO"] + "','" + COT["SKYPE"] + "',1,'" + COT["MAKHO"] + "'," + COT["CONGNO"] + "," + COT["TIENTRATRUOC"] + ")";
                    lenh = lenh + " \r\nGO\r\n INSERT INTO TONDAUCONGNOKH([MAKH],[CONGNO])VALUES ('" + COT["MAKH"] + "','" + COT["CONGNO"] + "')";
                }
            }
            //UPDATE KHÁCH HÀNG
            else if (cbTable.SelectedIndex == 7 && isupdate)
            {
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n UPDATE [KHACHHANG] SET MAKV='" + COT["MAKV"] + "', MANV='" + COT["MANV"] + "', MABG='" + COT["MABG"] + "',TENKH=N'" + COT["TENKH"] + "',DIACHI=N'" + COT["DIACHI"] + "',MASOTHUE='" + COT["MASOTHUE"] + "',SOTAIKHOAN='" + COT["SOTAIKHOAN"] + "',NGANHANG=N'" + COT["NGANHANG"] + "',SDT='" + COT["SDT"] + "',EMAIL='" + COT["EMAIL"] + "',FAX='" + COT["FAX"] + "',WEBSITE='" + COT["WEBSITE"] + "', YAHOO='" + COT["YAHOO"] + "', SKYPE='" + COT["SKYPE"] + "',MAKHO='" + COT["MAKHO"] + "',CONGNO=" + COT["CONGNO"] + ",TIENTRATRUOC=" + COT["TIENTRATRUOC"] + " WHERE MAKH='" + COT["MAKH"] + "'";
                    lenh = lenh + " \r\nGO\r\n UPDATE TONDAUCONGNOKH set CONGNO=" + COT["CONGNO"] + " WHERE MAKH='" + COT["MAKH"] + "'";
                }
            } // INSERT MẶT HÀNG
            else if (cbTable.SelectedIndex == 8 && !isupdate)
            {
                string MA = "(";
                foreach (System.Data.DataRow DONG in dulieu.Rows)
                {
                    MA = MA + "'" + DONG["MAMH"] + "',";
                }
                MA = MA.Substring(0, MA.Length - 1) + ")";

                string SQL2 = "Select MAMH FROM MATHANG WHERE MAMH IN " + MA;
                DataTable TBMA = pv.getdata(SQL2);
                if (TBMA.Rows.Count > 0)
                {
                    MessageBox.Show("MÃ MẶT HÀNG NÀY: " + TBMA.Rows[0][0].ToString() + " ĐÃ TỒN TẠI");
                    return;
                }
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n INSERT INTO [MATHANG]([MAMH],[MATH],[MANH],[MAKHO],[TENMH],[MADVT],[SOLUONGMH],[GIAMUA],[MOTA],[TINHTRANG],[MANCC],[KLDVT],QUYCACH) VALUES('" + COT["MAMH"] + "','" + COT["MATH"] + "','" + COT["MANH"] + "','" + COT["MAKHO"] + "',N'" + COT["TENMH"] + "','" + COT["MADVT"] + "','" + COT["SOLUONGMH"] + "','" + COT["GIAMUA"] + "','" + COT["MOTA"] + "','" + COT["TINHTRANG"] + "','" + COT["MANCC"] + "','" + COT["KLDVT"] + "',N'" + COT["QUYCACH"] + "')";
                    lenh = lenh + "\r\nGO\r\n  INSERT INTO BANGGIAMATHANG ([MABG],[MAMH],[GIABAN])  SELECT MABG,'" + COT["MAMH"] + "' AS MAMH,0 AS GIABAN FROM BANGGIA WHERE MAKHO='" + COT["MAKHO"] + "'";
                    lenh = lenh + "\r\nGO\r\n  INSERT INTO TONDAUMATHANG([MAMH],[TONDAU]) VALUES ('" + COT["MAMH"] + "','" + COT["SOLUONGMH"] + "')";
            
                
                    for (int i = 0; i < 10; i++)
                    {
                        if (COT["LO" + i.ToString()] != "" && COT["SLLO" + i.ToString()] != "")
                        {
                            if (COT["SLLO" + i.ToString()].ToString() != null && COT["SLLO" + i.ToString()].ToString() != "")
                            {
                                Double SL = Convert.ToDouble(COT["SLLO" + i.ToString()]);
                                if (SL >= 0)
                                {
                                    string HSD = COT["HSD" + i.ToString()].ToString();
                                    HSD = HSD.Substring(6, 4) + "/" + HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2);
                                    lenh = lenh + " \r\nGO\r\n INSERT INTO [KHOHANG] ([MAMH],[LOHANG],[GIAMUA],[TONKHO],[NGAYNHAP],[HSD],[TINHTRANG]) VALUES('" + COT["MAMH"] + "','" + COT["LO" + i.ToString()] + "','" + COT["GIAMUA"] + "','" + COT["SLLO" + i.ToString()] + "',convert(varchar,getDate(),101),'" + HSD + "',1)";
                                    lenh = lenh + "\r\nGO\r\n  INSERT INTO [TONDAUKHOHANG] ([MAMH],[LOHANG],[GIAMUA],[TONKHO]) VALUES ('" + COT["MAMH"] + "','" + COT["LO" + i.ToString()] + "'," + COT["GIAMUA"] + "," + COT["SLLO" + i.ToString()] + ")";

                                    String SQL3 = "select COUNT(*) from TONKHOTT WHERE NGAY=convert(varchar,GETDATE(),101) AND MAKHO='" + COT["MAKHO"] + "'";
                                    DataTable dt = pv.getdata(SQL3);
                                    if (dt.Rows[0][0].ToString() != "0")
                                    {
                                        lenh = lenh + "\r\nGO\r\n  INSERT INTO TONKHOTT([NGAY],[MAMH],[LOHANG],[TONKHONGAY],[MAKHO]) VALUES (convert(varchar,GETDATE(),101),'" + COT["MAMH"] + "','" + COT["LO" + i.ToString()] + "',0,'" + COT["MAKHO"] + "')";
                                    }

                                }
                            }
                        }
                    }

                   }
            }
            // UPDATE MẶT HÀNG\
            else if (cbTable.SelectedIndex == 8 && isupdate)
            {
                lenh = "";
                foreach (System.Data.DataRow COT in dulieu.Rows)
                {
                    lenh = lenh + " \r\nGO\r\n UPDATE [MATHANG] SET MATH='" + COT["MATH"] + "',MANH='" + COT["MANH"] + "',QUYCACH='" + COT["QUYCACH"] + "',MAKHO='" + COT["MAKHO"] + "',TENMH=N'" + COT["TENMH"] + "',MADVT='" + COT["MADVT"] + "',SOLUONGMH='" + COT["SOLUONGMH"] + "',GIAMUA='" + COT["GIAMUA"] + "',MOTA='" + COT["MOTA"] + "' WHERE MAMH='" + COT["MAMH"] + "'";
                    lenh = lenh + "\r\nGO\r\n  UPDATE TONDAUMATHANG SET TONDAU='" + COT["SOLUONGMH"] + "' WHERE MAMH='" + COT["MAMH"] + "'";


                    for (int i = 0; i < 10; i++)
                    {
                        if (COT["LO" + i.ToString()] != "" && COT["SLLO" + i.ToString()] != "")
                        {
                            if (COT["SLLO" + i.ToString()].ToString() != null && COT["SLLO" + i.ToString()].ToString() != "")
                            {
                                Double SL = Convert.ToDouble(COT["SLLO" + i.ToString()]);
                                if (SL > 0)
                                {
                                    string HSD = COT["HSD" + i.ToString()].ToString();
                                    HSD = HSD.Substring(6, 4) + "/" + HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2);
                                    lenh = lenh + " \r\nGO\r\n UPDATE  [KHOHANG] SET  GIAMUA='" + COT["GIAMUA"] + "',TONKHO='" + COT["SLLO" + i.ToString()] + "',HSD='" + HSD + "' WHERE MAMH='" + COT["MAMH"] + "' AND LOHANG='" + COT["LO" + i.ToString()] + "'";
                                    lenh = lenh + "\r\nGO\r\n  UPDATE  [TONDAUKHOHANG] SET GIAMUA='" + COT["GIAMUA"] + "',TONKHO='" + COT["SLLO" + i.ToString()] + "' WHERE  MAMH='" + COT["MAMH"] + "' AND LOHANG='" + COT["LO" + i.ToString()] + "'";

                                }
                            }
                        }
                    }
                }
              
            }

            try
            {
                pv.executeNonQuery2(lenh);
            }
            catch(Exception EX)
            {
                MessageBox.Show("LỖI: "+EX.Message.ToString());
            }
            tientrinh.PerformStep();

            MessageBox.Show("Quá trình đưa dữ liệu đã hoàn tất.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tientrinh.Value = 0;
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

        private void import_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }

       
    }
}