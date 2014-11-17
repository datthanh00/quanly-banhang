using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class frmsuahd : DevExpress.XtraEditors.XtraForm
    {
        public frmsuahd()
        {
            InitializeComponent();
        }
        clCtrl ctr = new clCtrl();
        public string MAHD;
        public DataTable LISTTRUOC, LISTSAU;
        private void frmxoahd_Load(object sender, EventArgs e)
        {
           
           
        }
       
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtlydo.Text.Length > 10)
            {
                string LYDO = txtlydo.Text;
                LYDO = LYDO.Replace("'", "");
                LYDO = LYDO.Replace("\"", "");
                PublicVariable.TMPtring = LYDO;
                if (LYDO.Length > 190)
                {
                    PublicVariable.TMPtring = "";
                    MessageBox.Show("lý do Sửa quá Dài");
                    return;
                }
                Inhdsua rep = new Inhdsua(MAHD,LYDO,LISTTRUOC,LISTSAU);
                rep.ShowPreviewDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("lý do Sửa quá ngắn");
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}