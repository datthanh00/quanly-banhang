using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Class_ManhCuong
{
    class NhapHangDTO
    {
        private string _MANCC;
        private string _TENNCC;
        public string MANCC
        {
            get { return _MANCC; }
            set { _MANCC = value; }
        }

        public string TENNCC
        {
            get { return _TENNCC; }
            set { _TENNCC = value; }
        }
    }
}
