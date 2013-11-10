using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class frmLog : DevExpress.XtraEditors.XtraForm
    {
        public frmLog()
        {
            InitializeComponent();
        }
        public delegate void _deDongTab();
        public _deDongTab deDongTab;


        private void frmLog_Load(object sender, EventArgs e)
        {
            if (PublicVariable.XEM == "False")
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN ");
                return;
            }

            CTL ctl = new CTL();
            string SQL = "select * from log";
            DataTable dt= ctl.GETDATA(SQL);

            gridControl1.DataSource = dt;

        }

        private void frmLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            deDongTab();
        }
       
    }
}