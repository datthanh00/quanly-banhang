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


namespace WindowsFormsApplication1
{
    public partial class frmnodauky : DevExpress.XtraEditors.XtraForm
    {
        public frmnodauky()
        {
            InitializeComponent();
        }
        
  
       
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


            Load_CONGNONCC();
        }

        private void loadReSVN1()
        {
            
            btin.Text = resVietNam.btIn.ToString();
            BtXuatdulieu.Text = resVietNam.btXuat.ToString();
            btdong.Text = resVietNam.btDong.ToString();
  
            //labelControl2.Text = resVietNam.lbden.ToString();
            //labelControl13.Text = resVietNam.lbtu.ToString();
            //labelControl14.Text = resVietNam.lbden.ToString();
            //lbTu.Text = resVietNam.lbtu.ToString();
            //lbDen.Text = resVietNam.lbden.ToString();
            //lbNam.Text = resVietNam.lbNam.ToString();
        }

        private void loadReSEG1()
        {
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;

       
           btin.Text = resEngLand.btIn.ToString();
           BtXuatdulieu.Text = resEngLand.btXuat.ToString();
           btdong.Text = resEngLand.btDong.ToString();

           
        }
     


       
      


        private void simpleButton11_Click(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
           string SQL="";
           CTL ctlNCC = new CTL();

           SQL = "";

           SQL = " SELECT COUNT(TONDAUCONGNONCC.MANCC) FROM TONDAUCONGNONCC, NHACUNGCAP WHERE NHACUNGCAP.MANCC=TONDAUCONGNONCC.MANCC AND MAKHO='" + PublicVariable.MAKHO + "'";
                
           DataTable dt=ctlNCC.GETDATA(SQL);
           SQL = "";
           if (dt.Rows[0][0].ToString() == "0")
           {
               for (int i = 0; i < gridView1.DataRowCount; i++)
               {
                   SQL = "";
                   for (int j = 0; j < 20&&i < gridView1.DataRowCount; j++)
                   {
                       DataRow dtr = gridView1.GetDataRow(i);
                       SQL = SQL + " \r\nGO\r\n INSERT INTO TONDAUCONGNONCC([MANCC],[TONGTIENTRA])VALUES('" + dtr["MANCC"].ToString() + "'," + dtr["TONGTIENTRA"].ToString() + ")  "
                           + " \r\nGO\r\n INSERT INTO CONGNONCC ([MANCC],[TONGTIENTRA],[TONGTIENDATRA]) VALUES ('" + dtr["MANCC"].ToString() + "'," + dtr["TONGTIENTRA"].ToString() + ",0) ";
                       i++;
                   }
                   ctlNCC.executeNonQuery2(SQL);
               }
               
           }  else
           {
               for (int i = 0; i < gridView1.DataRowCount; i++)
               {
                   SQL = "";
                   for (int j = 0; j < 20&&i < gridView1.DataRowCount; j++)
                   {
                       DataRow dtr = gridView1.GetDataRow(i);

                       SQL = SQL + " \r\nGO\r\n UPDATE TONDAUCONGNONCC SET [TONGTIENTRA]=" + dtr["TONGTIENTRA"].ToString() + " WHERE MANCC='" + dtr["MANCC"].ToString() + "'"
                           + "  \r\nGO\r\n UPDATE CONGNONCC SET [TONGTIENTRA]=" + dtr["TONGTIENTRA"].ToString() + " WHERE MANCC='" + dtr["MANCC"].ToString() + "'";
                       i++;
                   }
                   ctlNCC.executeNonQuery2(SQL);
               }
           }
            MessageBox.Show("ĐÃ LƯU NỢ NHÀ CUNG CẤP DẦU KỲ");
            Load_CONGNONCC();
         }



        private void Load_CONGNONCC()
        {
            gridControl1.DataSource = ctr.getCONGNONCC_DAUKY();
        }
        

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (PublicVariable.IN == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            DataTable printtable = (DataTable)gridControl1.DataSource;
            Inhd rep = new Inhd(printtable, 16);
            rep.ShowPreviewDialog();
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

        



    }
}
        
       
    
