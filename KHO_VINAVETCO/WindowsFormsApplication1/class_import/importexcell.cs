using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using System.Drawing;

using Excel;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.class_import
{
    class importexcell
    {
        private System.Data.OleDb.OleDbConnection con;
        private String sConnectionString;
        public void mo_excel(String file_readed)
        {
            sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                   "Data Source=" + file_readed + ";" +
                   "Extended Properties=Excel 8.0";

               //sConnectionString = "server=" + AppC.AppSettings.Settings["server"].Value.ToString() + ";" + "database=" + AppC.AppSettings.Settings["database"].Value.ToString() + ";" + "integrated security = true;uid=" + AppC.AppSettings.Settings["uid"].Value.ToString() + ",pwd=" + AppC.AppSettings.Settings["pwd"].Value.ToString() + "";
                // sConnectionString = " Data Source=103.3.245.243\\sql2008;Network Library=DBMSSOCN;Initial Catalog=nguyendat_qlkho;User ID=nguyendat_thanh;Password=Xziojs1U98;";
             
        }

        public System.Data.DataTable get_data_from_excell()
        {
            System.Data.DataTable bang = new System.Data.DataTable();

            try
            {

                con = new System.Data.OleDb.OleDbConnection(sConnectionString);
                con.Open();
                System.Data.OleDb.OleDbCommand lenh = new System.Data.OleDb.OleDbCommand("SELECT * FROM [Sheet1$]", con);
                System.Data.OleDb.OleDbDataAdapter thich_ung = new System.Data.OleDb.OleDbDataAdapter();
                thich_ung.SelectCommand = lenh;
                thich_ung.Fill(bang);
                con.Close();
            }
            catch
            {
            }
            return bang;
        }

         public void style_dgview(DataGridView luoi)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.ForeColor = Color.Blue;
            style1.BackColor = Color.Linen;
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.ForeColor = Color.Red;
            style2.BackColor = Color.White;
            for (int i = luoi.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    luoi.Rows[i].DefaultCellStyle = style1;
                }
                else if (i % 2 != 0)
                {
                    luoi.Rows[i].DefaultCellStyle = style2;

                }
            }
        }
    }

}
