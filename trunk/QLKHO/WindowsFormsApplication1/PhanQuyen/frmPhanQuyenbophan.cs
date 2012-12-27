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

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            if (isPhankho)
            {
                string SQL = "SELECT MAKHO,TENKHO FROM KHO";

                DataTable TBS = Ctl.GETDATA(SQL);
                gridControl2.MainView = gridView2;
                gridControl2.DataSource = TBS;
                gridView2.RefreshData();
                gridControl2.RefreshDataSource();
            }
            else
            {
                string SQL = "SELECT MATHANG.MAMH, TENMH, TENNHOMHANG, TENKHO, DONVITINH, sum(SOLUONGXUAT) as SOLUONGXUAT, GIATIEN, SOLUONGXUAT*GIATIEN AS TONGTIEN FROM MATHANG,NHOMHANG,KHO,DONVITINH,(select MAMH,SOLUONGXUAT, GIATIEN FROM CHITIETHDX, HOADONXUAT WHERE NGAYXUAT BETWEEN '" + dtoNCC.NGAYBD + "' AND '" + dtoNCC.NGAYKT + "') as CHITIETHDX WHERE MATHANG.MANH=NHOMHANG.MANH AND MATHANG.MAKHO=KHO.MAKHO AND MATHANG.MADVT = DONVITINH.MADVT AND MATHANG.MAMH=CHITIETHDX.MAMH group by MAMH";

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
            this.Close();
        }

    }
}