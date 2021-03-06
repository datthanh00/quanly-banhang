using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Inhd : DevExpress.XtraReports.UI.XtraReport
    {
        
        public Inhd(DataTable PrintTable, int BanIn)
        {
            
            CTL ctl = new CTL();
            InitializeComponent();
            String SQL = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime,TENKHO from  KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt2 = ctl.GETDATA(SQL);

            string ss1 = dt2.Rows[0]["CurrentDateTime"].ToString();
            lbngaylap.Text = "Ngày: "+ss1;
             SQL = "select * from thongtinct where mact=1";
            
            DataTable dt = ctl.GETDATA(SQL);

            lbtencty.Text = dt.Rows[0]["TENCT"].ToString();
            lbdienthoai.Text = "Điện Thoại:  "+dt.Rows[0]["SDT"].ToString()+"        Fax:  "+dt.Rows[0]["FAX"].ToString();
            lbDiaChi.Text = "Địa Chỉ:  " + dt.Rows[0]["DIACHI"].ToString();
            lbintrai.Text = dt.Rows[0]["TTINTRAI"].ToString();
            lbttinphai.Text = dt.Rows[0]["TTINPHAI"].ToString();
            lbingiua.Text = dt.Rows[0]["TTINGIUA"].ToString();
            gridControl1.DataSource = PrintTable;
            Form f = new Form();
            f.Controls.Add(this.gridControl1);
            f.Location = new Point(2000, 2000);
            
            switch (BanIn)
            {
                case 0:
                    {
                        lbtenbaocao.Text = "Báo Cáo Nhập Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString()+" Theo Hóa Đơn";
                        gridControl1.MainView = gridphieunhap;
                        gridphieunhap.BestFitColumns();

                        break;
                    }
                case 1:
                    {
                        lbtenbaocao.Text = "Báo Cáo Nhập Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Sản Phẩm";
                        gridControl1.MainView = gridmathangnhap;
                        gridControl1.DataSource = PrintTable;
                       
						if (!PublicVariable.isKHOILUONG)
						{
							gridmathangnhap.Columns["KHOILUONG"].Visible = false;
						}
						if (!PublicVariable.isHSD)
						{
							gridmathangnhap.Columns["HSD"].Visible = false;
                            gridmathangnhap.Columns["LOHANG"].Visible = false;
						}
                        gridControl1.RefreshDataSource();
                        gridmathangnhap.ExpandAllGroups();
                        
                        gridmathangnhap.BestFitColumns();
                        break;
                    }
                case 2:
                    {
                        lbtenbaocao.Text = "Báo Cáo Nhập Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridtongnhap;
                        gridControl1.RefreshDataSource();
                        gridtongnhap.OptionsView.ColumnAutoWidth = true;
                        gridtongnhap.BestFitColumns();
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
                        gridPhieuxuat.BestFitColumns();
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
                            gridmathangxuat.Columns["LOHANG"].Visible = false;
						}
                        gridmathangxuat.BestFitColumns();
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
                        gridTongxuat.BestFitColumns();
                        break;
                    }
                case 6:
                    {
                        lbtenbaocao.Text = "Báo Cáo Khách Trả Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = gridphieukhtra;
                        gridphieukhtra.BestFitColumns();
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
                        gridmathangkhtra.BestFitColumns();
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
                        gridTongkhtra.BestFitColumns();
                        break;
                    }
                case 9:
                    {
                        lbtenbaocao.Text = "Báo Cáo Trả Hàng CTY Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = gridphieutracty;
                        gridphieutracty.BestFitColumns();
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
                            gridmathangtracty.Columns["LOHANG"].Visible = false;
							
						}
                        gridmathangtracty.BestFitColumns();
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
                        gridTongtracty.BestFitColumns();
                        break;
                    }
                case 12:
                    {
                        lbtenbaocao.Text = "Báo Cáo Công Nợ Khách Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = gridCongnokh;
                        gridCongnokh.BestFitColumns();
                        break;
                    }
                case 13:
                    {
                        if (PublicVariable.IS_VINAVETCO)
                        {
                            lbtenbaocao.Text = "BẢNG KÊ NỘP TIỀN CÁC ĐẠI LÝ";
                            gridControl1.MainView = gridphieuthukh2;
                            gridphieuthukh2.BestFitColumns();
                        }
                        else
                        {
                            lbtenbaocao.Text = "Báo Cáo Phiếu Thu Kho " + dt2.Rows[0]["TENKHO"].ToString();
                            gridControl1.MainView = gridphieuthukh;
                            gridphieuthukh.BestFitColumns();
                        }

                       
                        break;
                    }
                case 14:
                    {
                        lbtenbaocao.Text = "Báo Cáo Công Nợ Nhà Cung Cấp " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = gridCongnoncc;
                        gridCongnoncc.BestFitColumns();
                        break;
                    }
                case 15:
                    {
                        lbtenbaocao.Text = "Báo Cáo Phiếu Chi Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = gridphieuchincc;
                        gridphieuchincc.BestFitColumns();
                        break;
                    }
                case 16:
                    {
                        
                        gridControl1.MainView = advtonphanlo;
						if (!PublicVariable.isKHOILUONG)
						{
							advtonphanlo.Columns["KHOILUONG"].Visible = false;
						}
                        if (!PublicVariable.isHSD)
                        {
                            advtonphanlo.Columns["HANSUDUNG"].Visible = false;
                            advtonphanlo.Columns["NGAYSUDUNG"].Visible = false;
                            advtonphanlo.Columns["LOHANG"].Visible = false;
                            lbtenbaocao.Text = "Báo Cáo Tồn Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        }
                        else
                        {
                            lbtenbaocao.Text = "Báo Cáo Tồn Phân Lô Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        }
                        advtonphanlo.BestFitColumns();
                        break;
                    }
                case 17:
                    {
                        lbtenbaocao.Text = "Báo Cáo Tồn Kho Ngày Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = advtonkhongay;
						if (!PublicVariable.isKHOILUONG)
						{
							advtonkhongay.Columns["KLTONDAU"].Visible = false;
							advtonkhongay.Columns["KLNHAP"].Visible = false;
							advtonkhongay.Columns["KLTRANHAP"].Visible = false;
							advtonkhongay.Columns["KLXUAT"].Visible = false;
							advtonkhongay.Columns["KLTRAXUAT"].Visible = false;
							advtonkhongay.Columns["KLTONCUOI"].Visible = false;
						}
              
                        advtonkhongay.BestFitColumns();
                        break;
                    }
                case 18:
                    {
                        lbtenbaocao.Text = "Báo Cáo Tổng Hợp Xuất Nhập Tồn Kho Theo Nhà Cung Cấp Kho " + dt2.Rows[0]["TENKHO"].ToString();
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
                        advtonghoptonncc.BestFitColumns();
                        break;
                    }
                case 19:
                    {
                        lbtenbaocao.Text = "Báo Cáo Tổng Hợp Xuất Nhập Tồn Kho " + dt2.Rows[0]["TENKHO"].ToString();
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
                        if (!PublicVariable.isHSD)
                        {
                            advtonghopton.Columns["LOHANG"].Visible = false;
                            advtonghopton.Columns["HSD"].Visible = false;
                        }
                        advtonghopton.BestFitColumns();
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
                        gridmathangtonkho.BestFitColumns();
                        break;
                    }
                case 21:
                    {
                        lbtenbaocao.Text = "Báo Cáo Hóa Đơn Công Nợ Khách Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = gridhoadoncongnokh;
                        gridhoadoncongnokh.BestFitColumns();
                        break;
                    }
                case 22:
                    {
                        lbtenbaocao.Text = "Báo Cáo Hóa Đơn Công Nợ Nhà Cung Cấp Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = gridhoadoncongnoncc;
                        gridhoadoncongnoncc.BestFitColumns();
                        break;
                    }
                case 23:
                    {

                        gridControl1.MainView = bandMHTONDAU;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            bandMHTONDAU.Columns["KHOILUONG"].Visible = false;
                        }
                        if (!PublicVariable.isHSD)
                        {
                            bandMHTONDAU.Columns["HANSUDUNG"].Visible = false;
                            bandMHTONDAU.Columns["NGAYSUDUNG"].Visible = false;
                            bandMHTONDAU.Columns["LOHANG"].Visible = false;
                        }
                     
                        lbtenbaocao.Text = "Báo Cáo Tồn Đầu Kì Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        bandMHTONDAU.BestFitColumns();
                        break;
                    }
                case 24:
                    {
                        lbtenbaocao.Text = "Báo Cáo Tồn Kho Ngày Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = advtonkhongay;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            advtonkhongay.Columns["KLTONDAU"].Visible = false;
                            advtonkhongay.Columns["KLNHAP"].Visible = false;
                            advtonkhongay.Columns["KLTRANHAP"].Visible = false;
                            advtonkhongay.Columns["KLXUAT"].Visible = false;
                            advtonkhongay.Columns["KLTRAXUAT"].Visible = false;
                            advtonkhongay.Columns["KLTONCUOI"].Visible = false;
                        }
            
                        advtonkhongay.BestFitColumns();
                        break;
                    }
                case 25:
                    {
                        lbtenbaocao.Text = "Báo Cáo đặt hàng nhập Kho " + dt2.Rows[0]["TENKHO"].ToString();
                        gridControl1.MainView = griddathangnhap;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            griddathangnhap.Columns["KHOILUONG"].Visible = false;
                        }
                        griddathangnhap.BestFitColumns();
                        break;
                    }
                case 26:
                    {
                        lbtenbaocao.Text = "Báo Cáo đặt hàng khách hàng Kho " + dt2.Rows[0]["TENKHO"].ToString();

                        gridControl1.MainView = griddathangxuat;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            griddathangxuat.Columns["KHOILUONG"].Visible = false;
                        }
                        if (!PublicVariable.isHSD)
                        {
                            griddathangxuat.Columns["LOHANG"].Visible = false;
                            griddathangxuat.Columns["HSD"].Visible = false;
                        }
                        griddathangxuat.BestFitColumns();
                        break;
                    }
            }

            
            f.Controls.Clear();
            f.Dispose();
           
            
        }



    }
}
