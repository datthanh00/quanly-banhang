﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class frmLoad : DevExpress.XtraEditors.XtraForm
    {
        public frmLoad()
        {
            InitializeComponent();
        }
        int z;
        public int iNgonNgu;
        private void timer1_Tick(object sender, EventArgs e)
        {
            z += 2;
            if (z > 100)
            {
                this.Hide();


                this.timer1.Enabled = false;

                RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
                rkey.SetValue("sCountry", "United States");
                rkey.SetValue("sShortDate", "dd/MM/yyyy");
                rkey.SetValue("sLongDate", "dd/MM/yyyy");

                rkey.SetValue("sDecimal", ".");
                rkey.SetValue("sGrouping", ",");
                rkey.SetValue("sNativeDigits", "123,456,789");
                
                rkey.SetValue("sList", ",");
                rkey.SetValue("sThousand", ",");
                rkey.Close();

                Registry.SetValue(@"HKEY_USERS\.Default\Control Panel\International", "sCountry", "United States");
                Registry.SetValue(@"HKEY_USERS\.Default\Control Panel\International", "sShortDate", "dd/MM/yyyy");
                Registry.SetValue(@"HKEY_USERS\.Default\Control Panel\International", "sLongDate", "dd/MM/yyyy");

                Registry.SetValue(@"HKEY_USERS\.Default\Control Panel\International", "sDecimal", ".");
                Registry.SetValue(@"HKEY_USERS\.Default\Control Panel\International", "sGrouping", ",");
                Registry.SetValue(@"HKEY_USERS\.Default\Control Panel\International", "sNativeDigits", "123,456,789");

                Registry.SetValue(@"HKEY_USERS\.Default\Control Panel\International", "sList", ",");
                Registry.SetValue(@"HKEY_USERS\.Default\Control Panel\International", "sThousand", ",");
                


                DataTable PhanKho = new DataTable();
                DataTable PhanQuyen = new DataTable();
                String SQL = "";
                CTL ctl = new CTL();
                SQL = "select * from phankho where MABP='" + sBoPhan + "' and quanly=1";
                PhanKho= ctl.GETDATA(SQL);
                SQL = "select * from phanquyen where MABP='" + sBoPhan + "'";
                PhanQuyen = ctl.GETDATA(SQL);

                frmMain frm = new frmMain();
                frm.sBoPhan = sBoPhan;
                frm.sTennv = sTennv;
                frm.sManv = sManv;
                frm.PhanKho = PhanKho;
                frm.PhanQuyen = PhanQuyen;
                frm.Show();
                this.Hide();

                return;

            }
            this.progressBar1.EditValue = z;

        }
        public string sManv, sTennv, sBoPhan;
        private void frmLoad_Load(object sender, EventArgs e)
        {
            
            this.timer1.Enabled = false;
            this.timer1.Interval = 10;
            timer1.Start(); 
        }

    }
}