using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Inhdoanhthu : DevExpress.XtraReports.UI.XtraReport
    {
        public Inhdoanhthu(DataTable PrintTable,int BanIn )
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
                        lbtenbaocao.Text = "Báo Cáo Mua Hàng Ngày Kho " + dt2.Rows[0]["TENKHO"].ToString()+" Theo Hóa Đơn";
                        gridControl1.MainView = gridmuahangngay;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            gridmuahangngay.Columns["KHOILUONG"].Visible = false;
                        }
			
                        break;
                    }
                case 1:
                    {
                        lbtenbaocao.Text = "Báo Cáo Mua Hàng Nhà Cung Cấp Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Sản Phẩm";
                        gridControl1.MainView = gridmuahangNCC;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            gridmuahangNCC.Columns["KHOILUONG"].Visible = false;
                        }
			
                        break;
                    }
                case 2:
                    {
                        lbtenbaocao.Text = "Báo Cáo Mua Hàng Sản Phẩm Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridmuahangsanpham;
						if (!PublicVariable.isKHOILUONG)
						{
                            gridmuahangsanpham.Columns["KHOILUONG"].Visible = false;
						}
                        break;
                    }
                case 3:
                    {
                        lbtenbaocao.Text = "Báo Cáo Xuất Hàng Ngày Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = gridbanhangngay;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            gridbanhangngay.Columns["KHOILUONG"].Visible = false;
                        }
                        break;
                    }
                case 4:
                    {
                        lbtenbaocao.Text = "Báo Cáo Xuất Hàng Theo Khách Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Sản Phẩm";
                        gridControl1.MainView = gridbanhangkhachhang;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            gridbanhangkhachhang.Columns["KHOILUONG"].Visible = false;
                        }
                        break;
                    }
                case 5:
                    {
                        lbtenbaocao.Text = "Báo Cáo Xuất Hàng Theo Sản Phẩm Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Nhóm Theo Mặt Hàng";
                        gridControl1.MainView = gridbanhangsanpham;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            gridbanhangsanpham.Columns["KHOILUONG"].Visible = false;
                        }
                        break;
                    }
                case 6:
                    {
                        lbtenbaocao.Text = "Báo Cáo Doanh Thu Nhân Viên Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = griddoanhsonhanvien;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            griddoanhsonhanvien.Columns["KHOILUONG"].Visible = false;
                        }
                        break;
                    }
                case 7:
                    {
                        lbtenbaocao.Text = "Báo Cáo Hóa Đơn Theo Nhà Cung Cấp Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = gridhoadontheoNCC;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            gridhoadontheoNCC.Columns["KHOILUONG"].Visible = false;
                        }
                        if (!PublicVariable.isHSD)
                        {
                            gridhoadontheoNCC.Columns["HSD"].Visible = false;
                        }
                        break;
                    }
                case 8:
                    {
                        lbtenbaocao.Text = "Báo Cáo Hóa Đơn Theo Khách Hàng Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = gridhoadontheokhachhang;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            gridhoadontheokhachhang.Columns["KHOILUONG"].Visible = false;
                        }
                        if (!PublicVariable.isHSD)
                        {
                            gridhoadontheokhachhang.Columns["HSD"].Visible = false;
                        }
                        break;
                    }
                case 9:
                    {
                        lbtenbaocao.Text = "Báo Cáo Tồn Kho Cuối Kỳ Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = gridtonkhocuoiky;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            gridtonkhocuoiky.Columns["KHOILUONG"].Visible = false;
                        }
                        if (!PublicVariable.isHSD)
                        {
                            gridtonkhocuoiky.Columns["HSD"].Visible = false;
                        }
                        break;
                    }
                case 10:
                    {
                        lbtenbaocao.Text = "Báo Cáo Thẻ Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = advthekho;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            advthekho.Columns["KLTONDAU"].Visible = false;
                            advthekho.Columns["KLNHAP"].Visible = false;
                            advthekho.Columns["KLTRANHAP"].Visible = false;
                            advthekho.Columns["KLXUAT"].Visible = false;
                            advthekho.Columns["KLTRAXUAT"].Visible = false;
                            advthekho.Columns["KLTONCUOI"].Visible = false;
                        }

                       
                        break;
                    }
                case 11:
                    {
                        lbtenbaocao.Text = "Báo Cáo Sổ Chi Tiết Hàng Hóa Kho " + dt2.Rows[0]["TENKHO"].ToString() + " Theo Hóa Đơn";
                        gridControl1.MainView = advsochitiethanghoa;
                        if (!PublicVariable.isKHOILUONG)
                        {
                            advsochitiethanghoa.Columns["KLTONDAU"].Visible = false;
                            advsochitiethanghoa.Columns["KLNHAP"].Visible = false;
                            advsochitiethanghoa.Columns["KLTRANHAP"].Visible = false;
                            advsochitiethanghoa.Columns["KLXUAT"].Visible = false;
                            advsochitiethanghoa.Columns["KLTRAXUAT"].Visible = false;
                            advsochitiethanghoa.Columns["KLTONCUOI"].Visible = false;
                        }
                        break;
                    }
            }
            gridControl1.DataSource = PrintTable;
            
        }



    }
}
