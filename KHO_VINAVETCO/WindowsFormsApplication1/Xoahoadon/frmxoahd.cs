﻿using System;
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
    public partial class frmxoahd : DevExpress.XtraEditors.XtraForm
    {
        public frmxoahd()
        {
            InitializeComponent();
        }
        clCtrl ctr = new clCtrl();
        public string MAHD, TENMH,MAMH,SOLUONG;
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
                if (LYDO.Length > 190)
                {
                    PublicVariable.TMPtring = "";
                    MessageBox.Show("lý do xóa quá Dài");
                    return;
                }
                PublicVariable.TMPtring = LYDO;
                
                Inhdx rep = new Inhdx(MAHD, MAMH, TENMH,SOLUONG, LYDO);
                rep.ShowPreviewDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("lý do xóa quá ngắn");
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}