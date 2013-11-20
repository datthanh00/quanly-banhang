using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevComponents.DotNetBar;
using System.Globalization;
using System.Threading;
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Quanlykho;


namespace WindowsFormsApplication1
{
    public partial class frmKiemkho : DevExpress.XtraEditors.XtraForm
    {
        public frmKiemkho()
        {
            InitializeComponent();
        }
        
   
        string LoaiTG = "";
        string LoaiHT = "";
       
        DataTable dt = new DataTable();
        public int iNgonNgu;
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;


        
        Class_DTO_ThongKe dto = new Class_DTO_ThongKe();
        Class_ctrl_thongkekho ctr = new Class_ctrl_thongkekho();

        
   

        private void frmThongKeTongHop_Load(object sender, EventArgs e)
        {

            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

 
            vload();
            load_cbhanghoa();
 
            if (!PublicVariable.isKHOILUONG)
            {
                gridView1.Columns["KHOILUONG"].Visible = false;
            }

            if (!PublicVariable.isHSD)
            {
                gridView1.Columns["LOHANG"].Visible = false;
                gridView1.Columns["HSD"].Visible = false;
            }

            Load_mathang();
        }




  
        public void load()
        {
            //dto.NGAY_BD = DateTime.Parse(dateNgayBD);
            //dto.NGAY_KT = DateTime.Parse(dateNgayKT);
            dto.Loai_TG = LoaiTG;
            dto.Loai_HT = LoaiHT;

        }



        private void vload()
        {

        }

        private void load_cbhanghoa()
        {
            cbncc.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cbncc.Properties.DisplayMember = "NGAY";
            cbncc.Properties.ValueMember = "NGAY";
            cbncc.Properties.View.BestFitColumns();
            //cbmathang.Properties.PopupFormWidth = 200;
            Class_ctrl_thongkekho ctr1 = new Class_ctrl_thongkekho();
            DataTable dt = ctr1.dtGetKIKIEM();
            cbncc.Properties.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                cbncc.Text = dt.Rows[0][0].ToString();
            }
            gridView2.BestFitColumns();
            //cbmathang.best
        }


        private void simpleButton11_Click(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
           string SQL="",HSD;
           CTL ctlNCC = new CTL();

           SQL = "";

          
               for (int i = 0; i < gridView1.DataRowCount; i++)
               {
                   SQL = "";
                   for (int j = 0; j < 20&&i < gridView1.DataRowCount; j++)
                   {
                       DataRow dtr = gridView1.GetDataRow(i);
                        HSD=cbncc.Text;
                       if(PublicVariable.isTONTHUCTE)
                       {
                            HSD = HSD.Substring(6, 4) + "/" + HSD.Substring(3, 2) + "/" + HSD.Substring(0, 2);
                       }
                       SQL = SQL + " \r\nGO\r\n UPDATE TONKIEMKHO SET [TONTT]=" + dtr["TONTT"].ToString() + ",[TONKHO]=" + dtr["TONKHO"].ToString() + " WHERE MAMH='" + dtr["MAMH"].ToString() + "' AND LOHANG='" + dtr["LOHANG"].ToString() + "' AND NGAY='" + HSD + "'";
                       i++;
                   }
				   i--;
                   ctlNCC.executeNonQuery2(SQL);
               }
          
            MessageBox.Show("ĐÃ LƯU KIỂM THỰC TẾ KHO HÀNG");
            Load_mathang();
         }



        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }
        private void Load_mathang()
        {
            string NGAYKIEMKHO = "";
            if (cbncc.Text != "")
            {
                NGAYKIEMKHO = cbncc.Text;
            }
            gridControl1.DataSource = ctr.getonkiemkho(NGAYKIEMKHO);
            gridView1.BestFitColumns();
        }
        

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            DataTable printtable = (DataTable)gridControl1.DataSource;
            Inhdoanhthu rep = new Inhdoanhthu(printtable, 15);
            rep.ShowPreviewDialog();
        }


        private void cbHienThiBatDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void BtXuatdulieu_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            } 
            try
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
            catch (Exception)
            {

                DevComponents.DotNetBar.MessageBoxEx.Show("Đã Tồn Tại Tên");
            }

        }



        private void printableComponentLink1_CreateReportFooterArea(object sender, CreateAreaEventArgs e)
        {
            string reportHeader = "Chủ Cửa Hàng                  Thủ Kho                  Kế Toán";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 10, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void printableComponentLink1_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            CTL ctlbc = new CTL();
            String SQL = "select TENKHO, convert(varchar,getDate(),103) AS NGAY FROM KHO WHERE MAKHO='" + PublicVariable.MAKHO + "'";
            DataTable dt = ctlbc.GETDATA(SQL);
            string reportHeader = "Báo Cáo Tồn Phân Lô Kho " + dt.Rows[0]["TENKHO"].ToString() + " -- Ngày: " + dt.Rows[0]["NGAY"].ToString() + "";

            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }


        private void xoalohangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN XÓA ");
                return;
            }

            if (XtraMessageBox.Show("Bạn Có Muốn Xóa Lô Hàng Này Không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int focusrow = gridView1.FocusedRowHandle;
                DataRow dtr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dtr != null)
                {
                    String sMAMH = dtr["MAMH"].ToString();
                    String sLOHANG = dtr["LOHANG"].ToString();
                    if (sMAMH != "")
                    {
                       ctr.DELETE_LOHANGTONDAU(sMAMH, sLOHANG);
                    }
                }
            }
            Load_mathang();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn Tạo Kì Kiểm Kho Mới Không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                ctr.createtonkiemkho();
            }
            else
            {
                return;
            }
            load_cbhanghoa();
            Load_mathang();
        }

        private void cbncc_Validated(object sender, EventArgs e)
        {
            Load_mathang();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            
           // ctr.createtonkiemkho();
           
            Load_mathang();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow dtr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dtr != null)
            {

                if (e.Column.FieldName.ToString() == "TONTT")
                {
                    try
                    {
                        double tontt = Convert.ToDouble(dtr["TONTT"].ToString());
                        if (tontt < 0)
                        {
                            MessageBox.Show("Tồn Thực tế không thể nhỏ hơn 0");
                            dtr["TONTT"] = "0";
                        }
                        else
                        {
                            dtr["CHENHLECH"] = (Convert.ToDouble(dtr["TONTT"].ToString()) - Convert.ToDouble(dtr["TONKHO"].ToString())).ToString();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Tồn thực tế phải là số");
                        dtr["TONTT"] = "0";
                        return;
                    }
                }

            }
        }

        private void frmKiemkho_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn Xóa kì kiểm kho hôm nay Không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ctr.deletetonkiemkho();
            }
            else
            {
                return;
            }
            load_cbhanghoa();
            Load_mathang();
        }


    }
}
        
       
    
