using System;

namespace WindowsFormsApplication1
{
    class clDTO
    {
        //------------------------Thong tin cong ty
        private String _MACT;
        private String _GHICHU;
        private String _TENCT;
        private String _DIACHI;
        private String _SDT;
        private String _MOBILE;
        private String _EMAIL;
        private String _FAX;
        private String _LOGO;
        private String _MASOTHUE;
        private String _WEBSITE;
      
        public String MACT
        {
            get { return _MACT; }
            set { _MACT = value; }
        }
        public String GHICHU
        {
            get { return _GHICHU; }
            set { _GHICHU = value; }
        }
        public String TENCT
        {
            get { return _TENCT; }
            set { _TENCT = value; }
        }

        public String DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }

        public String SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        public String MOBILE
        {
            get { return _MOBILE; }
            set { _MOBILE = value; }
        }

        public String EMAIL
        {
            get { return _EMAIL; }
            set { _EMAIL = value; }
        }

        public String FAX
        {
            get { return _FAX; }
            set { _FAX = value; }
        }

        public string LOGO
        {
            get { return _LOGO; }
            set { _LOGO = value; }
        }

        public String MASOTHUE
        {
            get { return _MASOTHUE; }
            set { _MASOTHUE = value; }
        }

        public String WEBSITE
        {
            get { return _WEBSITE; }
            set { _WEBSITE = value; }
        }

       

        //----------------------MAT HANG-------------------------------
        private string _MAMH;
	private string _MATH;
	private string _MANH;
	//private string _MAKHO;
	private string _TENMH;
	private int _MADVT;
	private int _SOLUONGMH;
	private DateTime _HANSUDUNG;
	private int _GIAMUA;
	private int _GIABAN;
	private Byte[] _PICTURE;
	private String _MOTA;
    private bool _TINHTRANG;
    public string MAMH
    {
        get { return _MAMH; }
        set { _MAMH = value; }
    }

    public string MATH
    {
        get { return _MATH; }
        set { _MATH = value; }
    }

    public string MANH
    {
        get { return _MANH; }
        set { _MANH = value; }
    }

    public string TENMH
    {
        get { return _TENMH; }
        set { _TENMH = value; }
    }

    public int MADVT
    {
        get { return _MADVT; }
        set { _MADVT = value; }
    }

    public int SOLUONGMH
    {
        get { return _SOLUONGMH; }
        set { _SOLUONGMH = value; }
    }

    public DateTime HANSUDUNG
    {
        get { return _HANSUDUNG; }
        set { _HANSUDUNG = value; }
    }

    public int GIAMUA
    {
        get { return _GIAMUA; }
        set { _GIAMUA = value; }
    }

    public int GIABAN
    {
        get { return _GIABAN; }
        set { _GIABAN = value; }
    }

    public Byte[] PICTURE
    {
        get { return _PICTURE; }
        set { _PICTURE = value; }
    }

    public string MOTA
    {
        get { return _MOTA; }
        set { _MOTA = value; }
    }

    public bool TINHTRANG
    {
        get { return _TINHTRANG; }
        set { _TINHTRANG = value; }
    }

        //---------------------Nhom Hang---------------------------------------------------------
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
        //database------------------------------------------------------------------------------
        private string _DUONGDAN;

        public string DUONGDAN
        {
            get { return _DUONGDAN; }
            set { _DUONGDAN = value; }
        }
        private string _TENFILE;

        public string TENFILE
        {
            get { return _TENFILE; }
            set { _TENFILE = value; }
        }
        //--------------------------------------------------------------------------------------------
        //--------THONG KE DOANH THU-----------------
        private string _NGAYBD;

        public string  NGAYBD
        {
            get { return _NGAYBD; }
            set { _NGAYBD = value; }
        }
        private string _NGAYKT;

        public string NGAYKT
        {
            get { return _NGAYKT; }
            set { _NGAYKT = value; }
        }
        private string _THEHIEN;

        //public string THEHIEN
        //{
        //    get { return _THEHIEN; }
        //    set { _THEHIEN = value; }
        //}
        private string _LOAITG;

        public string LOAITG
        {
            get { return _LOAITG; }
            set { _LOAITG = value; }
        }
        //---------------- DOANH THU END----------------------
        //-----------------Kho------------------------------
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
        //______________________________________DANG NHAP_________________________________________
        private string _MANV;
        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }
        private string _TENNV;
        public string TENNV
        {
            get { return _TENNV; }
            set { _TENNV = value; }
        }
        private string _TENDANGNHAP;

        public string TENDANGNHAP
        {
            get { return _TENDANGNHAP; }
            set { _TENDANGNHAP = value; }
        }
        private string _MATKHAU;

        public string MATKHAU
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }
        private string _MABOPHAN;

        public string MABOPHAN
        {
            get { return _MABOPHAN; }
            set { _MABOPHAN = value; }
        }
        //_________________________________________________________________________________________________
    }
}
