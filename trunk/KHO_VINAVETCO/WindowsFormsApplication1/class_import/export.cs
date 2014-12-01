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
    public partial class export : DevExpress.XtraEditors.XtraForm
    {
        public export()
        {
            InitializeComponent();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CTL ctl = new CTL();
                String SQL = txtsql.Text;
                DataTable dt = ctl.GETDATA(SQL);
                gridControl1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Cau lenh truy van Sai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel|*.xls";
            saveFileDialog1.Title = "Save an File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                gridControl1.ExportToXls(saveFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CTL ctl = new CTL();
            DateTime dti = new DateTime();
            DataTable dt1 = ctl.GETDATA("select convert(varchar,GETDATE(),102)");

            string NAM = dt1.Rows[0][0].ToString().Substring(0, 4);

            String SQL = "SELECT T1.*,SOLUONGMH-TONCUOI AS CHENHLECH  FROM ( SELECT MAMH,SOLUONGMH,(SELECT COALESCE(SUM(TONDAU),0) FROM TONDAUMATHANG WHERE TONDAUMATHANG.MAMH=MATHANG.MAMH  AND CHOTKHO='01/01/2014')+(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END FROM TONKHO WHERE TONKHO.MAMH=MATHANG.MAMH  AND TONKHO.NGAY BETWEEN '01/01/"+NAM+"' AND GETDATE() ) AS TONCUOI FROM   MATHANG )AS T1 WHERE SOLUONGMH-TONCUOI <>0";

            DataTable dt = null;
            dt = ctl.GETDATA(SQL);
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            gridControl1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CTL ctl = new CTL();
            DateTime dti = new DateTime();
            DataTable dt1 = ctl.GETDATA("SELECT GETDATE()");

            string NAM = dt1.Rows[0][0].ToString().Substring(0, 4);

            String SQL = "SELECT MAMH,SOLUONGMH AS 'TONKHO MATHANG' ,TONKHO AS 'TONKHO KHOHANG',SOLUONGMH-TONKHO AS CHENHLECH FROM( SELECT MATHANG.MAMH,SOLUONGMH,SUM(TONKHO)AS TONKHO FROM KHOHANG,MATHANG WHERE MATHANG.MAMH=KHOHANG.MAMH GROUP BY MATHANG.MAMH,SOLUONGMH )AS T1 WHERE SOLUONGMH-TONKHO <>0";

            DataTable dt = null;
            dt = ctl.GETDATA(SQL);
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            gridControl1.DataSource = dt;
        }
    }
}