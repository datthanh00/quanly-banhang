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
    public partial class frmKhoaso : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoaso()
        {
            InitializeComponent();
        }
        
  
       


        public delegate void _deDongTab();
        public _deDongTab deDongTab;

        public frmMain frm;
        
   
        Class_ctrl_thongkekho ctr = new Class_ctrl_thongkekho();

        


        private void frmThongKeTongHop_Load(object sender, EventArgs e)
        {

            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            frm = new frmMain();
            load_khoaso();
   
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void load_khoaso()
        {
            gridControl1.DataSource = ctr.getKHOASO();
        }

        private void btxem_Click(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            string SQL = "";
            CTL ctlNCC = new CTL();

            SQL = "";
            if (XtraMessageBox.Show("Bạn có muốn Lưu khóa sổ không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    SQL = "";
                    for (int j = 0; j < 20 && i < gridView1.DataRowCount; j++)
                    {
                        DataRow dtr = gridView1.GetDataRow(i);
                        string TINHTRANG = "",NGAY="";
                        NGAY = dtr["NGAY"].ToString();
                        if (NGAY.Length>6)
                        {
                            NGAY = NGAY.Substring(6, 4) + "/" + NGAY.Substring(3, 2) + "/" + NGAY.Substring(0, 2);
                        }
                        if (dtr["TINHTRANG"].ToString() == "False")
                        {
                            TINHTRANG = "0";
                        }
                        else
                        {
                            TINHTRANG = "1";
                        }

                        SQL = SQL + " \r\nGO\r\n UPDATE KHOASOTHEOKHO SET [TINHTRANG]=" + TINHTRANG + ", NGAY='" + NGAY + "' WHERE ID='" + dtr["ID"].ToString() + "' AND MAKHO='"+PublicVariable.MAKHO+"'";                            
                        i++;
                    }
                    ctlNCC.executeNonQuery2(SQL);
                }
            }
            MessageBox.Show("ĐÃ LƯU KHÓA SỔ");
           // load_khoaso();


        }

        private void frmKhoaso_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow dtr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dtr != null)
            {

                if (e.Column.FieldName.ToString() == "NGAY")
                {
                    try
                    {
                        String NGAY =dtr["NGAY"].ToString();
                        if (NGAY == "")
                        {
                            MessageBox.Show("NGÀY KHÔNG ĐƯỢC ĐỂ TRỐNG");
                            dtr["NGAY"] = DateTime.Now.ToString("dd/MM/yyyy");
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("NGÀY LỖI");
                        dtr["NGAY"] = DateTime.Now.ToString("dd/MM/yyyy");
                        return;
                    }
                }

            }
        }

    }
}
        
       
    
