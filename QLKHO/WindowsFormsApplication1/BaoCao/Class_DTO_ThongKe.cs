using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class_DTO_ThongKe
    {
        private string _TENKHO;

        public string TENKHO
        {
            get { return _TENKHO; }
            set { _TENKHO = value; }
        }
        private string _MAKHO;

        public string MAKHO
        {
            get { return _MAKHO; }
            set { _MAKHO = value; }
        }
        private string _NGAYBDKHO;
        public string NGAYBDKHO
        {
            get { return _NGAYBDKHO; }
            set { _NGAYBDKHO = value; }
        }
        private string _NGAYKTKHO;

        public string NGAYKTKHO
        {
            get { return _NGAYKTKHO; }
            set { _NGAYKTKHO = value; }
        }
        //----------------------------
        private DateTime _NGAY_BD;

        public DateTime NGAY_BD
        {
            get { return _NGAY_BD; }
            set { _NGAY_BD = value; }
        }
        private DateTime _NGAY_KT;

        public DateTime NGAY_KT
        {
            get { return _NGAY_KT; }
            set { _NGAY_KT = value; }
        }
        private string _LOAI_TG;

        public string Loai_TG
        {
            get { return _LOAI_TG; }
            set { _LOAI_TG = value; }
        }
        private string _LOAI_HT;

        public string Loai_HT
        {
            get { return _LOAI_HT; }
            set { _LOAI_HT = value; }
        }
        private string _MANH;

        public string MANH
        {
            get { return _MANH; }
            set { _MANH = value; }
        }

        //------------------------------------
        private string _MANHOMHANG;
        private string _TENNHOMHANG;
        public string MANHOMHANG
        {
            get { return _MANHOMHANG; }
            set { _MANHOMHANG = value; }
        }

        public string TENNHOMHANG
        {
            get { return _TENNHOMHANG; }
            set { _TENNHOMHANG = value; }
        }
       // --------------------------------------------------------
        private DateTime _NGAYBD;

        public DateTime NGAYBD
        {
            get { return _NGAYBD; }
            set { _NGAYBD = value; }
        }
        private DateTime _NGAYKT;

        public DateTime NGAYKT
        {
            get { return _NGAYKT; }
            set { _NGAYKT = value; }
        }
        //-----------------------------
       
    }
}
