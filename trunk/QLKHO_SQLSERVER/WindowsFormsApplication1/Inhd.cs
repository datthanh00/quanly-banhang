using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Inhd : DevExpress.XtraReports.UI.XtraReport
    {
        public Inhd(DataTable PrintTable,int BanIn )
        {
            
            CTL ctl = new CTL();
            InitializeComponent();
            String SQL = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime,TENKHO from  KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt2 = ctl.GETDATA(SQL);

            string ss1 = dt2.Rows[0]["CurrentDateTime"].ToString();
            lbngaylap.Text = ss1;
             SQL = "select * from thongtinct where mact=1";
            
            DataTable dt = ctl.GETDATA(SQL);

            lbtencty.Text = dt.Rows[0]["TENCT"].ToString();
            lbdienthoai.Text = dt.Rows[0]["SDT"].ToString();
            lbfax.Text = dt.Rows[0]["FAX"].ToString();
            lbDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();

            

            switch (BanIn)
            {
                case 0:
                    {
                        lbtenbaocao.Text = "Báo Cáo Nhập Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString()+" Theo Hóa Đơn";
                        gridControl1.MainView = gridphieunhap;
                        break;
                    }
                case 1:
                    {
                        lbtenbaocao.Text = "Báo Cáo Nhập Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Sản Phẩm";
                        gridControl1.MainView = gridmathangnhap;
                        break;
                    }
                case 2:
                    {
                        lbtenbaocao.Text = "Báo Cáo Nhập Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridtongnhap;
                        break;
                    }
                case 3:
                    {
                        lbtenbaocao.Text = "Báo Cáo Xuất Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = gridPhieuxuat;
                        break;
                    }
                case 4:
                    {
                        lbtenbaocao.Text = "Báo Cáo Xuất Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Sản Phẩm";
                        gridControl1.MainView = gridmathangxuat;
                        break;
                    }
                case 5:
                    {
                        lbtenbaocao.Text = "Báo Cáo Xuất Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridTongxuat;
                        break;
                    }
                case 6:
                    {
                        lbtenbaocao.Text = "Báo Cáo Khách Trả Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = gridphieukhtra;
                        break;
                    }
                case 7:
                    {
                        lbtenbaocao.Text = "Báo Cáo Khách Trả Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Sản Phẩm";
                        gridControl1.MainView = gridmathangkhtra;
                        break;
                    }
                case 8:
                    {
                        lbtenbaocao.Text = "Báo Cáo Khách Trả Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridTongkhtra;
                        break;
                    }
                case 9:
                    {
                        lbtenbaocao.Text = "Báo Cáo Trả Hàng CTY Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = gridphieutracty;
                        break;
                    }
                case 10:
                    {
                        lbtenbaocao.Text = "Báo Cáo Trả Hàng CTY Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Sản Phẩm";
                        gridControl1.MainView = gridmathangtracty;
                        break;
                    }
                case 11:
                    {
                        lbtenbaocao.Text = "Báo Cáo Trả Hàng CTY Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridTongtracty;
                        break;
                    }
                case 12:
                    {
                        lbtenbaocao.Text = "Báo Cáo  Công Nợ Khách Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = gridCongnokh;
                        break;
                    }
                case 13:
                    {
                        lbtenbaocao.Text = "Báo Cáo Phiếu Thu Nợ Khách Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = gridphieuthukh;
                        break;
                    }
                case 14:
                    {
                        lbtenbaocao.Text = "Báo Cáo  Công Nợ Nhà Cung Cấp Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = gridCongnoncc;
                        break;
                    }
                case 15:
                    {
                        lbtenbaocao.Text = "Báo Cáo Phiếu Trả Nợ Nhà Cung Cấp Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = gridphieuchincc;
                        break;
                    }
                case 16:
                    {
                        lbtenbaocao.Text = "Báo Cáo Tồn Phân Lô Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = advtonphanlo;
                        break;
                    }
            }
            gridControl1.DataSource = PrintTable;
            
        }



    }
}
