using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using System.Threading;
using DevExpress.XtraGrid.Columns;

namespace WindowsFormsApplication1
{
    public partial class frmPhanQuyenbophan : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyenbophan()
        {
            InitializeComponent();
        }
        public string sMaBP;
        public Boolean isPhankho;
        CTL Ctl = new CTL();

        private void frmPhanQuyenbophan_Load(object sender, EventArgs e)
        {
            if (isPhankho)
            {
                /*DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("MAKHO"));
                dt.Columns.Add(new DataColumn("TENKHO"));
                dt.Columns.Add(new DataColumn("QUANLY"));
                dt.Columns.Add(new DataColumn("MABP"));
                */
                //gridControl2.DataSource = dt;

                string SQL = "SELECT PHANKHO.*,TENKHO FROM KHO,PHANKHO WHERE KHO.MAKHO=PHANKHO.MAKHO AND MABP='"+sMaBP+"'";

                DataTable TBS = Ctl.GETDATA(SQL);
                gridControl2.MainView = gridView1;
                gridControl2.DataSource = TBS;
                gridView1.RefreshData();
                gridControl2.RefreshDataSource();


            }
            else
            {
                string SQL = "SELECT PHANQUYEN.*,CHUCNANG FROM CHUCNANG,PHANQUYEN WHERE CHUCNANG.MACN=PHANQUYEN.MACN AND MABP='" + sMaBP + "'";

                DataTable TBS = Ctl.GETDATA(SQL);
                gridControl2.MainView = gridView2;
                gridControl2.DataSource = TBS;
                gridView2.RefreshData();
                gridControl2.RefreshDataSource();
            }

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (isPhankho)
            {

                int rowcount = gridView1.DataRowCount;
                for (int i = 0; i < rowcount; i++)
                {
                    DataRow dtr = dtr = gridView1.GetDataRow(i);

                    String quanly = dtr["QUANLY"].ToString();
                    string SQL = "";
                    if (quanly == "0")
                    {
                        SQL = "update  PHANKHO set quanly=0 where mabp='" + sMaBP + "' and makho='" + dtr["MAKHO"].ToString() + "' ";
                    }
                    else
                    {
                        SQL = "update  PHANKHO set quanly=1 where mabp='" + sMaBP + "' and makho='" + dtr["MAKHO"].ToString() + "' ";
                    }
                    Ctl.executeNonQuery(SQL);
                }
            }
            else
            {
                int rowcount = gridView2.DataRowCount;
                for (int i = 0; i < rowcount; i++)
                {
                    DataRow dtr = dtr = gridView2.GetDataRow(i);

                    String TATCA = dtr["TATCA"].ToString();
                    String TRUYCAP = dtr["TRUYCAP"].ToString();
                    String THEM = dtr["THEM"].ToString();
                    String XOA = dtr["XOA"].ToString();
                    String SUA = dtr["SUA"].ToString();
                    String IN = dtr["IN"].ToString();
                    if (TATCA == "0")
                    {
                        TATCA = "0";
                    }
                    else
                    {
                        TATCA = "1";
                    }
                    //
                    if (TRUYCAP == "0")
                    {
                        TRUYCAP = "0";
                    }
                    else
                    {
                        TRUYCAP = "1";
                    }

                    if (THEM == "0")
                    {
                        THEM = "0";
                    }
                    else
                    {
                        THEM = "1";
                    }

                    if (XOA == "0")
                    {
                        XOA = "0";
                    }
                    else
                    {
                        XOA = "1";
                    }

                    if (SUA == "0")
                    {
                        SUA = "0";
                    }
                    else
                    {
                        SUA = "1";
                    }
                    if (IN == "0")
                    {
                        IN = "0";
                    }
                    else
                    {
                        IN = "1";
                    }

                    string SQL = "UPDATE `phanquyen` SET `TATCA`=" + TATCA + ",`TRUYCAP`=" + TRUYCAP + ",`THEM`=" + THEM + ",`XOA`=" + XOA + ",`SUA`=" + SUA + ",`IN`=" + IN + " WHERE  `MABP`='" + sMaBP + "' and `MACN`=" + dtr["MACN"].ToString();
                    Ctl.executeNonQuery(SQL);
                }

            }

            this.Close();
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow dtr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                if(dtr!=null)
                    
                        if (e.Column.FieldName.ToString() == "TATCA")
                        {
                            string SSSS = dtr["TATCA"].ToString();
                            if (dtr["TATCA"].ToString() != "0")
                            {
                                
                                gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["TRUYCAP"], Convert.ToBoolean(1));
                                gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["THEM"], Convert.ToBoolean(1));
                                gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["XOA"], Convert.ToBoolean(1));
                                gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["SUA"], Convert.ToBoolean(1));
                                gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["IN"], Convert.ToBoolean(1));

                           
                            }
                            else
                            {
                               
                                gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["TRUYCAP"], Convert.ToBoolean(0));
                                gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["THEM"], Convert.ToBoolean(0));
                                gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["XOA"], Convert.ToBoolean(0));
                                gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["SUA"], Convert.ToBoolean(0));
                                gridView2.SetRowCellValue(e.RowHandle, gridView2.Columns["IN"], Convert.ToBoolean(0));
                            }
                        }
                    
              
        }

    }
}