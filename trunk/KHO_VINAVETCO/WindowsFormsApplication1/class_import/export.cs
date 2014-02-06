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
           dateTu.Text= DateTime.Now.ToString("dd/MM/yyy");
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
            DataTable dt1 = ctl.GETDATA("SELECT convert(varchar,getDate(),103) AS NGAY FROM KHO");
            string now=dt1.Rows[0][0].ToString();

            String SQL = "";
            int i=1;
            int ngay=Convert.ToInt32(dateTu.Text.Substring(0,2));
            int thang=Convert.ToInt32(dateTu.Text.Substring(3,2));
            int nam=Convert.ToInt32(dateTu.Text.Substring(6,4));
            string subthang = "";
            string subngay = "";
            while (i != 0)
            {

                if (ngay < 10){ subngay = "0";} else { subngay = ""; }
                if (thang < 10) { subthang = "0"; } else { subthang = ""; }
                string datekt = nam + "/" +subthang+ thang + "/" + subngay+ngay;
                
                SQL = SQL+ " SELECT * FROM ("
                + " SELECT convert(varchar,TONKHOTT.NGAY,103) AS NGAY ,TENMH,TONKHOTT.MAMH,TENNCC,TONKHONGAY as TONTT, TONKHONGAY-SUM(TONCUOI) AS CHENHLECH"
                + " FROM( SELECT TENMH+' - ' + QUYCACH AS TENMH,MATHANG.MAMH, MATHANG.MANCC, TENNCC,convert(varchar,GETDATE(),103) AS NGAY,TONCUOI"
                + " FROM (SELECT KHOHANG.MAMH,(SELECT CASE WHEN SUM(TONKHO) IS NULL THEN 0 ELSE SUM(TONKHO) END FROM TONDAUKHOHANG WHERE TONDAUKHOHANG.MAMH=KHOHANG.MAMH AND TONDAUKHOHANG.LOHANG=KHOHANG.LOHANG )+(SELECT CASE WHEN SUM(NHAPXUAT) IS NULL THEN 0 ELSE SUM(NHAPXUAT) END FROM TONKHO WHERE TONKHO.MAMH=KHOHANG.MAMH AND TONKHO.LOHANG=KHOHANG.LOHANG AND TONKHO.NGAY <= '" + datekt + "') AS TONCUOI "
                + " FROM (SELECT KHOHANG.MAMH,TONKHO,LOHANG FROM KHOHANG ) AS KHOHANG) AS T1, MATHANG,NHACUNGCAP, DONVITINH WHERE MATHANG.TINHTRANG='True' AND MATHANG.MAMH=T1.MAMH AND NHACUNGCAP.MANCC=MATHANG.MANCC AND MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MAKHO='KHO1' ) AS T22, TONKHOTT WHERE TONKHOTT.MAMH=T22.MAMH AND TONKHOTT.NGAY='" + datekt + "' GROUP BY TENMH,TONKHOTT.MAMH,MANCC,TENNCC,TONKHOTT.NGAY,TONKHOTT.TONKHONGAY ) AS T111 WHERE T111.CHENHLECH <>0";

                string NGAYSOSANH = subngay+ ngay + "/" +subthang+ thang + "/" + nam;
                if (NGAYSOSANH == now)
                {
                    i = 0;
                }else{

                    switch (thang)
                    {
                    	case 1:
                            if (ngay == 31)
                            {
                                ngay = 1;
                                thang = 2;
                            }else
                            {
                                ngay =ngay+ 1;
                            }
                    		break;
                        case 2:
                            if(ngay==29)
                            {
                                ngay=1;
                                thang=3;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                        case 3:
                            if(ngay==31)
                            {
                                ngay=1;
                                thang=4;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                        case 4:
                            if(ngay==30)
                            {
                                ngay=1;
                                thang=5;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                        case 5:
                            if(ngay==31)
                            {
                                ngay=1;
                                thang=6;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                        case 6:
                            if(ngay==30)
                            {
                                ngay=1;
                                thang=7;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                        case 7:
                            if(ngay==31)
                            {
                                ngay=1;
                                thang=8;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                        case 8:
                            if(ngay==31)
                            {
                                ngay=1;
                                thang=9;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                        case 9:
                            if(ngay==30)
                            {
                                ngay=1;
                                thang=10;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                        case 10:
                            if(ngay==31)
                            {
                                ngay=1;
                                thang=11;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                        case 11:
                            if(ngay==30)
                            {
                                ngay=1;
                                thang=12;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                        case 12:
                            if(ngay==31)
                            {
                                ngay=1;
                                thang=1;
                            }
                            else
                            {
                                ngay = ngay + 1;
                            }
                    		break;
                    }


                    SQL = SQL + " UNION ALL ";
                }


                

            }
            
            DataTable dt = ctl.GETDATA(SQL);
            gridControl1.DataSource = dt;
        }
    }
}