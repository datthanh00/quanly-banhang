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
//using WindowsFormsApplication1.class_TungLam;

namespace WindowsFormsApplication1
{
    public partial class frmThemNoptientruoc : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNoptientruoc()
        {
            InitializeComponent();
        }
        ketnoi connect = new ketnoi();

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string MANCC,MAKH,SOTIEN,ID;
        public Boolean isthem,iskhachhang;
        CTL ctlDOITUONG = new CTL();
        
        private void frmThemKhuVuc_Load(object sender, EventArgs e)
        {
            cboTenNCC.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            cboTenNCC.Properties.DisplayMember = "TENDOITUONG";
            cboTenNCC.Properties.ValueMember = "MADOITUONG";
            cboTenNCC.Properties.View.BestFitColumns();
            cboTenNCC.Properties.PopupFormWidth = 300;
            if (cbotientra.Text == "")
            {
                cbotientra.Value = 0;
            }
            if (cbotientra.Value <0)
            {
                MessageBox.Show("không thể điền số tiền nhỏ hơn không");
                return;
            }
            if (isthem)
            {

                cboTenNCC.Properties.DataSource = ctlDOITUONG.GETDANHSACHDOITUONGKH();
                cbotientra.Value = 0;
            }
            else
            {
                if (iskhachhang)
                {
                    cboTenNCC.Properties.DataSource = ctlDOITUONG.GETDANHSACHDOITUONGKH();
                    Checkkh.Checked = true;
                    cboTenNCC.Text = MAKH;
                    cbotientra.Value = Convert.ToDecimal(SOTIEN);
                }
                else
                {
                    cboTenNCC.Properties.DataSource = ctlDOITUONG.GETDANHSACHDOITUONGNCC();
                    Checkncc.Checked = true;
                    cboTenNCC.Text = MANCC;
                    cbotientra.Value = Convert.ToDecimal(SOTIEN);
                }
                cboTenNCC.Properties.ReadOnly = true;
                Checkkh.Properties.ReadOnly = true;
                Checkncc.Properties.ReadOnly = true;
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                string SQL = "";
                string MADOITUONG= gridView3.GetFocusedRowCellValue("MADOITUONG").ToString();
                Int64 tientra = Convert.ToInt64(cbotientra.Value);
                if (tientra < 0)
                {
                    MessageBox.Show("Số tiền trả không được nhỏ hơn 0");
                    return;
                }
                else if (cboTenNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp hoặc khách hàng");
                    return;
                }
                if (isthem)
                {
                    SQL = "\r\nGO\r\n INSERT INTO [TIENTRATRUOC]([MADOITUONG],[SOTIEN],[NGAY],[MAKHO])  VALUES  ('" + MADOITUONG + "'," + Convert.ToInt64(cbotientra.Value).ToString() + ",convert(varchar,GETDATE(),101),'"+PublicVariable.MAKHO+"')";
                    if (Checkkh.Checked == true)
                    {
                        SQL = SQL + "\r\nGO\r\n UPDATE KHACHHANG SET TIENTRATRUOC=TIENTRATRUOC + " + Convert.ToInt64(cbotientra.Value).ToString() + " WHERE MAKH='" + MADOITUONG + "'";
                    }
                    else
                    {
                        SQL = SQL + "\r\nGO\r\n UPDATE NHACUNGCAP SET TIENTRATRUOC=TIENTRATRUOC + " + Convert.ToInt64(cbotientra.Value).ToString() + " WHERE MANCC='" + MADOITUONG + "'";
                    }
                    ctlDOITUONG.EXCUTE_SQL2(SQL);
                    MessageBox.Show("bạn đã Thêm thành công");
                }
                else
                {
                    SQL = "\r\nGO\r\n UPDATE  [TIENTRATRUOC] SET [SOTIEN]=" + Convert.ToInt64(cbotientra.Value).ToString() + " WHERE ID=" + ID;
                    if (Checkkh.Checked == true)
                    {
                        SQL = SQL + "\r\nGO\r\n UPDATE KHACHHANG SET TIENTRATRUOC=TIENTRATRUOC -" + SOTIEN + " + " + Convert.ToInt64(cbotientra.Value).ToString() + " WHERE MAKH='" + MADOITUONG + "'";
                    }
                    else
                    {
                        SQL = SQL + "\r\nGO\r\n UPDATE NHACUNGCAP SET TIENTRATRUOC=TIENTRATRUOC  -" + SOTIEN + " + " + Convert.ToInt64(cbotientra.Value).ToString() + " WHERE MANCC='" + MADOITUONG + "'";
                    }
                    ctlDOITUONG.EXCUTE_SQL2(SQL);
                    MessageBox.Show("bạn đã Sửa thành công");
                }
                
                this.Close();
           
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
            
            
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void txtma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                
                btluu_Click(null, null);
            }
        }

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }

        private void txtghichu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }

        private void checkTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {

                btluu_Click(null, null);
            }
        }

        private void Checkkh_CheckedChanged(object sender, EventArgs e)
        {
            cboTenNCC.Properties.DataSource = ctlDOITUONG.GETDANHSACHDOITUONGKH();
        }

        private void Checkncc_CheckedChanged(object sender, EventArgs e)
        {
            cboTenNCC.Properties.DataSource = ctlDOITUONG.GETDANHSACHDOITUONGNCC();
        }
    }
}