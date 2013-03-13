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
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }
        clCtrl ctr = new clCtrl();
        clDTO dto = new clDTO();
        public frmMain frm;
        public delegate void _deDongTab();
        public _deDongTab deDongTab;
        string sMaBP;
  
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
         

            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frm = new frmMain();
            frm.LoadVI += new frmMain.Translate(loadVN);
            frm.LoadEN += new frmMain.Translate(loadEN);
            if (iNgonNgu == 0)
            {
                loadVN();
            }
            else { loadEN(); }
            LoadBoPhan();
            loadNguoiDung();

        }

       

        private void LoadBoPhan()
        {
            gridControl1.DataSource = ctr.getBoPhan();
            if (gridView1.RowCount > 0)
            {
                DataRow dtr = gridView1.GetDataRow(0);
                sMaBP = dtr[0].ToString();
            }
        }
        
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
       
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                
            DataRow dtr = gridView1.GetDataRow(e.RowHandle);
            sMaBP = dtr[0].ToString();
            sTenBP = dtr[1].ToString();
            loadNguoiDung();
            }
            catch 
            {

                
            }
        } 
        private void loadNguoiDung()
        {
            dto.MABOPHAN = sMaBP;
            gridControl2.DataSource = ctr.getOneNhanVienBP(dto);
            if (gridView2.RowCount > 0)
            {
                DataRow dtr = gridView2.GetDataRow(0);
                sMaNV = dtr[0].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frmThemNguoiDung frm = new frmThemNguoiDung();
            frm.iNgonNgu = iNgonNgu;
            frm.ShowDialog();
            loadNguoiDung();

        }
        string sMaNV, ssMaBOPhan, sTenDangNhap,sTenNhanVien,sTenBP;
        string bTinhTrang;
        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
   
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            if (gridView2.RowCount>0)
            {
                if (sMaNV != "")
                {
                    frmSuaNguoiDung frm = new frmSuaNguoiDung();
                    frm.tennv = sTenNhanVien;
                    frm.mabp = sMaBP;
                    frm.tenbp = sTenBP;
                    frm.tendangnh = sTenDangNhap;
                    frm.manv = sMaNV;
                    frm.iNgonNgu = iNgonNgu;
                    frm.ShowDialog();
                    loadNguoiDung();
                    sMaNV = "";
                }
                else
                {
                    if (iNgonNgu == 0)
                    {
                        XtraMessageBox.Show("Vui chọn nhân viên cần sửa");

                    }
                    else
                    {
                        XtraMessageBox.Show("Please choose Employee to edit");

                    }
                }
                
            }
            else
            {
                sMaNV = "";
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bộ phận này không có nhân viên nào");

                }
                else
                {
                    XtraMessageBox.Show("This department no employee");

                }
            }
           
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
              
                    DataRow dtr = gridView2.GetDataRow(e.RowHandle);
                        sMaNV = dtr[0].ToString();
                        sTenNhanVien = dtr[5].ToString();
                        sTenDangNhap = dtr[2].ToString();
                        bTinhTrang = dtr[3].ToString(); 
                
             
            }
            catch 
            {
               
             
            }
            
        
           
        }
    
        public void loadVN()
        {
            iNgonNgu = 0;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMABP.Caption = LamVN.MABP.ToString();
            colMANV.Caption = LamVN.MANV.ToString();
            colMABP1.Caption = LamVN.MABP.ToString();
            dockPanelBoPhan.Text = resVietNam.btBoPhan.ToString();
            colUSERNAME.Caption = LamVN.USERNAME.ToString();
            colTINHTRANG1.Caption = LamVN.TINHTRANG.ToString();
            colTINHTRANG.Caption = LamVN.TINHTRANG.ToString();
            btDong.Text = LamVN.DONG.ToString();
            btXoa.Text = LamVN.XOA.ToString();
            btThem.Text = LamVN.THEM.ToString();
            btSua.Text = LamVN.SUA.ToString();
            layoutControlGroup3.Text = "Người dùng";
            colTENBOPHAN.Caption = LamVN.TENBP.ToString();
            colTENNV.Caption = LamVN.TENNV.ToString();
        }
        public void loadEN()
        {
            iNgonNgu = 1;
            CultureInfo objCultureInfo = Thread.CurrentThread.CurrentCulture;
            colMABP.Caption = LamEL.MABP.ToString();
            colMANV.Caption = LamEL.MANV.ToString();
            colMABP1.Caption = LamEL.MABP.ToString();
            dockPanelBoPhan.Text = resEngLand.btBoPhan.ToString();
            colUSERNAME.Caption = LamEL.USERNAME.ToString();
            colTINHTRANG1.Caption = LamEL.TINHTRANG.ToString();
            colTINHTRANG.Caption = LamEL.TINHTRANG.ToString();
            btDong.Text = LamEL.DONG.ToString();
            btXoa.Text = LamEL.XOA.ToString();
            btThem.Text = LamEL.THEM.ToString();
            btSua.Text = LamEL.SUA.ToString();
            layoutControlGroup3.Text = "User";
            colTENBOPHAN.Caption = LamEL.TENBP.ToString();
            colTENNV.Caption = LamEL.TENNV.ToString();
        }
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (PublicVariable.THEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            try
            {
                if (gridView2.RowCount > 0)
                {
                    if (sMaNV != "")
                    {
                        frmSuaNguoiDung frm = new frmSuaNguoiDung();
                        frm.tennv = sTenNhanVien;
                        frm.mabp = sMaBP;
                        frm.tenbp = sTenBP;
                        frm.tendangnh = sTenDangNhap;
                        frm.manv = sMaNV;
                        frm.iNgonNgu = iNgonNgu;
                        frm.ShowDialog();
                        loadNguoiDung();
                    }
                    else
                    {
                        if (iNgonNgu == 0)
                        {
                            XtraMessageBox.Show("Vui chọn nhân viên cần sửa");

                        }
                        else
                        {
                            XtraMessageBox.Show("Please choose Employee to edit");

                        }
                    }
                }
                else
                {

                    if (iNgonNgu == 0)
                    {
                        XtraMessageBox.Show("Bộ phận này không có nhân viên nào");

                    }
                    else
                    {
                        XtraMessageBox.Show("This department no employee");

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        public int iNgonNgu;
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (PublicVariable.XOA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            if (gridView2.RowCount > 0)
            {
                if (sMaNV != "")
                {
                    if (sTenDangNhap == "admin")
                    {
                        if (iNgonNgu == 0)
                        {
                            XtraMessageBox.Show(" Không được xoá quản lý cao cấp");

                        }
                        else
                        {
                            XtraMessageBox.Show("No permision delete Admin");

                        }

                    }
                    else
                    {
                        if (iNgonNgu == 0)
                        {
                            if (XtraMessageBox.Show("Bạn có muốn xoá nhân viên " + sTenNhanVien + "  hay không ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                            {
                                dto.MANV = sMaNV;
                                ctr.XoaNguoiDung(dto);
                                loadNguoiDung();
                                sMaNV = "";
                            }
                        }
                        else
                        {
                            if (XtraMessageBox.Show("Do you want to delete " + sTenNhanVien + " ? ", "Infomation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                            {
                                dto.MANV = sMaNV;
                                ctr.XoaNguoiDung(dto);
                                loadNguoiDung();
                                sMaNV = "";
                            }
                        }
                    }


                }
                else
                {
                    if (iNgonNgu == 0)
                    {
                        XtraMessageBox.Show("Vui chọn nhân viên cần xoá");

                    }
                    else
                    {
                        XtraMessageBox.Show("Please choose Employee to delete");

                    }
                }
            }
            else
            {
               
                if (iNgonNgu == 0)
                {
                    XtraMessageBox.Show("Bộ phận này không có nhân viên nào");

                }
                else
                {
                    XtraMessageBox.Show("This department no employee");

                }
            }
            
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            deDongTab();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void linkTaoMoi_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void linkTheoHoaDon_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void linkTheoSanPham_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void btnphanquyen_Click(object sender, EventArgs e)
        {
            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            frmPhanQuyenbophan frmbp = new frmPhanQuyenbophan();
            frmbp.sMaBP = sMaBP;
            frmbp.isPhankho = false;
            frmbp.ShowDialog();
        }

        private void btnphankho_Click(object sender, EventArgs e)
        {
            

            if (PublicVariable.SUA == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }
            if (sMaBP != "")
            {
                frmPhanQuyenbophan frmbp = new frmPhanQuyenbophan();
                frmbp.sMaBP = sMaBP;
                frmbp.isPhankho = true;
                frmbp.ShowDialog();
            }
            else
            {
                MessageBox.Show("chọn 1 bộ phận để phân quyền");
            }
        }
    }
}