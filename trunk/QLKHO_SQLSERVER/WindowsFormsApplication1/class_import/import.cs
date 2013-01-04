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

            cbTable.Properties.Items.Add("NHà Cung Cấp");
            cbTable.Properties.Items.Add("Khách Hàng");
            cbTable.Properties.Items.Add("Mặt Hàng");
            button2.Enabled = false;

        }
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        importexcell excell;
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
                pv.executeNonQuery(lenh);
                tientrinh.PerformStep();
            }
            MessageBox.Show("Quá trình đưa dữ liệu đã hoàn tất.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tientrinh.Value = 0;
        }
        private String nhap_tien_tc(System.Data.DataRow cot)
        {
            String lenh = "";
            try
            {
                
                if (cbTable.SelectedIndex == 0)
                {
                    lenh = "INSERT INTO [NHACUNGCAP]([MANCC],[MAKV],[TENNCC],[DIACHI],[MASOTHUE],[SOTAIKHOAN],[NGANHANG],[SDT],[EMAIL],[FAX],[WEBSITE],[TINHTRANG]) "
                    + " VALUES ('" + cot["MANCC"] + "','" + cot["MAKV"] + "',N'" + cot["TENNCC"] + "',N'" + cot["DIACHI"] + "','" + cot["MASOTHUE"] + "','" + cot["SOTAIKHOAN"] + "',N'" + cot["NGANHANG"] + "','" + cot["SDT"] + "','" + cot["EMAIL"] + "','" + cot["FAX"] + "','" + cot["WEBSITE"] + "'," + cot["TINHTRANG"] + ") ";
                }
                else if (cbTable.SelectedIndex == 1)
                {
                    lenh = "INSERT INTO [KHACHHANG] ([MAKH],[MAKV],[TENKH],[SOTAIKHOAN],[NGANHANG],[MASOTHUE],[DIACHI],[SDT],[FAX],[WEBSITE],[YAHOO],[SKYPE],[TINHTRANG]) "
                + " VALUES ('" + cot["MAKH"] + "','" + cot["MAKV"] + "',N'" + cot["TENKH"] + "','" + cot["SOTAIKHOAN"] + "',N'" + cot["NGANHANG"] + "','" + cot["MASOTHUE"] + "',N'" + cot["DIACHI"] + "','" + cot["SDT"] + "','" + cot["FAX"] + "','" + cot["WEBSITE"] + "','" + cot["YAHOO"] + "','" + cot["SKYPE"] + "'," + cot["TINHTRANG"] + ") ";

                }
                else if (cbTable.SelectedIndex == 2)
                {
                    lenh = "INSERT INTO [MATHANG]([MAMH],[MATH],[MANH],[MAKHO],[TENMH],[MADVT],[SOLUONGMH],[HANSUDUNG],[GIAMUA],[GIABAN],[MOTA],[TINHTRANG]) "
                    + " VALUES ('" + cot["MAMH"] + "','" + cot["MATH"] + "','" + cot["MANH"] + "','" + cot["MAKHO"] + "',N'" + cot["TENMH"] + "','" + cot["MADVT"] + "'," + cot["SOLUONGMH"] + ",'" + cot["HANSUDUNG"] + "'," + cot["GIAMUA"] + "," + cot["GIABAN"] + ",N'" + cot["MOTA"] + "'," + cot["TINHTRANG"] + ")";
                }
            }
            catch
            {
                MessageBox.Show("CỘT TRONG FILE EXCELL KHÔNG HỢP LỆ");
            }
            return lenh;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

       
    }
}