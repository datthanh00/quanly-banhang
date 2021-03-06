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
						if (!PublicVariable.isKHOILUONG)
						{
							gridmathangnhap.Columns["KHOILUONG"].Visible = false;
						}
						if (!PublicVariable.isHSD)
						{
							gridmathangnhap.Columns["HSD"].Visible = false;
						}
                        break;
                    }
                case 2:
                    {
                        lbtenbaocao.Text = "Báo Cáo Nhập Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridtongnhap;
						if (!PublicVariable.isKHOILUONG)
						{
							gridtongnhap.Columns["KHOILUONG"].Visible = false;
						}
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
						if (!PublicVariable.isKHOILUONG)
						{
							gridmathangxuat.Columns["KHOILUONG"].Visible = false;
						}
						if (!PublicVariable.isHSD)
						{
							gridmathangxuat.Columns["HSD"].Visible = false;
						}
                        break;
                    }
                case 5:
                    {
                        lbtenbaocao.Text = "Báo Cáo Xuất Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridTongxuat;
						if (!PublicVariable.isKHOILUONG)
						{
							gridTongxuat.Columns["KHOILUONG"].Visible = false;
						}
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
						if (!PublicVariable.isKHOILUONG)
						{
							gridmathangkhtra.Columns["KHOILUONG"].Visible = false;
						}
						if (!PublicVariable.isHSD)
						{
							gridmathangkhtra.Columns["HSD"].Visible = false;
							gridmathangkhtra.Columns["LOHANG"].Visible = false;
						}
                        break;
                    }
                case 8:
                    {
                        lbtenbaocao.Text = "Báo Cáo Khách Trả Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridTongkhtra;
						if (!PublicVariable.isKHOILUONG)
						{
							gridTongkhtra.Columns["KHOILUONG"].Visible = false;
						}
						if (!PublicVariable.isHSD)
						{
							gridTongkhtra.Columns["LOHANG"].Visible = false;
						}
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
						if (!PublicVariable.isKHOILUONG)
						{
							gridmathangtracty.Columns["KHOILUONG"].Visible = false;
						}
						if (!PublicVariable.isHSD)
						{
							gridmathangtracty.Columns["HSD"].Visible = false;
							
						}
                        break;
                    }
                case 11:
                    {
                        lbtenbaocao.Text = "Báo Cáo Trả Hàng CTY Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridTongtracty;
						if (!PublicVariable.isKHOILUONG)
						{
							gridTongtracty.Columns["KHOILUONG"].Visible = false;
						}
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
                        advtonkhongay.ActiveFilterString = "[SOLUONGMH]>0";
						if (!PublicVariable.isKHOILUONG)
						{
							advtonphanlo.Columns["KHOILUONG"].Visible = false;
						}
						if (!PublicVariable.isHSD)
						{
							advtonphanlo.Columns["HANSUDUNG"].Visible = false;
							advtonphanlo.Columns["LOHANG"].Visible = false;
						}
                        break;
                    }
                case 17:
                    {
                        lbtenbaocao.Text = "Báo Cáo Tồn Kho Ngày Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = advtonkhongay;
                        advtonkhongay.ActiveFilterString = "[TONCUOI]>0 OR [TONTT]<>0";
						if (!PublicVariable.isKHOILUONG)
						{
							advtonkhongay.Columns["KLTONDAU"].Visible = false;
							advtonkhongay.Columns["KLNHAP"].Visible = false;
							advtonkhongay.Columns["KLTRANHAP"].Visible = false;
							advtonkhongay.Columns["KLXUAT"].Visible = false;
							advtonkhongay.Columns["KLTRAXUAT"].Visible = false;
							advtonkhongay.Columns["KLTONCUOI"].Visible = false;
							
						}
                        break;
                    }
                case 18:
                    {
                        lbtenbaocao.Text = "Báo Cáo Tồn Kho Theo Nhà Cung Cấp Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = advtonghoptonncc;
						if (!PublicVariable.isKHOILUONG)
						{
							advtonghoptonncc.Columns["KLTONDAU"].Visible = false;
							advtonghoptonncc.Columns["KLNHAP"].Visible = false;
							advtonghoptonncc.Columns["KLTRANHAP"].Visible = false;
							advtonghoptonncc.Columns["KLXUAT"].Visible = false;
							advtonghoptonncc.Columns["KLTRAXUAT"].Visible = false;
							advtonghoptonncc.Columns["KLTONCUOI"].Visible = false;
							
						}
				
                        break;
                    }
                case 19:
                    {
                        lbtenbaocao.Text = "Báo Cáo Tồn Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = advtonghopton;
						if (!PublicVariable.isKHOILUONG)
						{
                            advtonghopton.Columns["KLTONDAU"].Visible = false;
                            advtonghopton.Columns["KLNHAP"].Visible = false;
                            advtonghopton.Columns["KLTRANHAP"].Visible = false;
                            advtonghopton.Columns["KLXUAT"].Visible = false;
                            advtonghopton.Columns["KLTRAXUAT"].Visible = false;
                            advtonghopton.Columns["KLTONCUOI"].Visible = false;
							
						}
                        break;
                    }
                case 20:
                    {
                        lbtenbaocao.Text = "Báo Cáo Mặt Hàng Tồn Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = gridmathangtonkho;
						if (!PublicVariable.isKHOILUONG)
						{
							gridmathangtonkho.Columns["KHOILUONG"].Visible = false;
						}
						if (!PublicVariable.isHSD)
						{
							gridmathangtonkho.Columns["HANSUDUNG"].Visible = false;
						}
                        break;
                    }
            }
            gridControl1.DataSource = PrintTable;
            
        }



    }
}
