using System;
using System.Data;

namespace WindowsFormsApplication1
{
    class CTL
    {
        DAO DAO = new DAO();
        public void insertKhachHang(DTO DTO)
        {
            DAO.insertKhachHang(DTO);
        }
        public void updateKhachHang(DTO DTO)
        {
            DAO.updateKhachHang(DTO);
        }
        public void INSERTNHACC(DTO DTO)
        {
            DAO.INSERTNHACC(DTO);
        }
        public void UPDATENHACC(DTO DTO)
        {
            DAO.UPDATENHACC(DTO);
        }
        public void INSERTKHUVUC(DTO DTO)
        {
            DAO.INSERTKHUVUC(DTO);
        }
        public void INSERTBOPHAN(DTO DTO)
        {
            DAO.INSERTBOPHAN(DTO);
        }
        public void UPDATEBOPHAN(DTO DTO)
        {
            DAO.UPDATEBOPHAN(DTO);
        }
        public void INSERTNHOMHANG(DTO DTO)
        {
            DAO.INSERTNHOMHANG(DTO);
        }
        public void UPDATENHOMHANG(DTO DTO)
        {
            DAO.UPDATENHOMHANG(DTO);
        }
        public void UPDATEKHUVUC(DTO DTO)
        {
            DAO.UPDATEKHUVUC(DTO);
        }
        public void INSERTDVT(DTO DTO)
        {
            DAO.INSERTDVT(DTO);
        }
        public void INSERTTHUE(DTO DTO)
        {
            DAO.INSERTTHUE(DTO);
        }
        public void UPDATETHUE(DTO DTO)
        {
            DAO.UPDATETHUE(DTO);
        }

        public void UPDATEDVT(DTO DTO)
        {
            DAO.UPDATEDVT(DTO);
        }
        public void UPDATENHANVIEN(DTO DTO)
        {
            DAO.UPDATENHANVIEN(DTO);
        }
        public void UPDATEQUANLY(DTO DTO)
        {
            DAO.UPDATEQUANLY(DTO);
        }
        public void INSERTQUANLY(DTO DTO)
        {
            DAO.INSERTQUANLY(DTO);
        }
        public void addMatHangCtrl(DTO dto)
        {
            DAO.addMatHang(dto);
        }
        public void UPDATEMATHANG(DTO dto)
        {
            DAO.UPDATEMATHANG(dto);
        }
        public void INSERTNHANVIEN(DTO DTO)
        {
            DAO.INSERTNHANVIEN(DTO);
        }

        public void INSERTKHO(DTO DTO)
        {
            DAO.INSERTKHO(DTO);
        }
        public void UPDATEKHO(DTO DTO)
        {
            DAO.UPDATEKHO(DTO);
        }
        public void DELETEKHACHHANG(DTO DTO)
        {
            DAO.DELELEKHACHHANG(DTO);
        }
        public void DELETEBOPHAN(DTO DTO)
        {
            DAO.DELELEBOPHAN(DTO);
        }
        public void DELETEMATHANG(DTO DTO)
        {
            DAO.DELELEMATHANG(DTO);
        }
        public void DELETENHOMHANG(DTO DTO)
        {
            DAO.DELELENHOMHANG(DTO);
        }
        public void DELETEQUANLY(DTO DTO)
        {
            DAO.DELELEQUANLY(DTO);
        }
        public void DELETETHUE(DTO DTO)
        {
            DAO.DELELETHUE(DTO);
        }
        public void DELETEKHO(DTO DTO)
        {
            DAO.DELELEKHO(DTO);
        }
        public void DELETEKV(DTO DTO)
        {
            DAO.DELELEKV(DTO);
        }
        public void DELETENCC(DTO DTO)
        {
            DAO.DELELENCC(DTO);
        }
        public void DELETENHANVIEN(DTO DTO)
        {
            DAO.DELELENHANVIEN(DTO);
        }
        public void DELETEDVT(DTO DTO)
        {
            DAO.DELELEDVT(DTO);
        }
        public DataTable GETKHACHHANG()
        {
            return DAO.GETDANHSACHKH();
        }
        public DataTable GETKHACHHANG(string MAKH)
        {
            return DAO.GETDANHSACHKH(MAKH);
        }
        public DataTable GETKHACHHANG1()
        {
            return DAO.GETDANHSACHKH1();
        }
        public DataTable GETKHUVUC()
        {
            return DAO.GETKV();
        }
        public string GETTENKHUVUC(string MAKV)
        {
            return DAO.GETTENKHUVUC(MAKV);
        }
        public DataTable GETDVT()
        {
            return DAO.GETDVT();
        }
        public DataTable GETMATHANG()
        {
            return DAO.GETMATHANG();
        }
        public DataTable GETMATHANG(string MAMH)
        {
            return DAO.GETMATHANG(MAMH);
        }
        public DataTable GETTHUE()
        {
            return DAO.GETTHUE();
        }
        public DataTable GETNV()
        {
            return DAO.GETNHANVIEN();
        }
        public DataTable GETQL()
        {
            return DAO.GETQUANLY();
        }
       
        public DataTable GETBP()
        {
            return DAO.GETBP();
        }
        public DataTable GETNHOMHANG()
        {
            return DAO.GETNHOMHANG();
        }
        public DataTable GETDANHSACHKH()
        {
            return DAO.GETDANHSACHKH();
        }
        public DataTable GETDANHSACHNCC()
        {
            return DAO.GETDANHSACHNCC();
        }
        public DataTable GETDANHSACHNCC(String MANCC)
        {
            return DAO.GETDANHSACHNCC(MANCC);
        }
        public string GETMANCCfromMHDN(String MAHDN)
        {
            return DAO.GETMANCCfromMHDN(MAHDN);
        }
        public string GETMAKHfromMHDX(String MAHDX)
        {
            return DAO.GETMAKHfromMHDX(MAHDX);
        }
        

        public DataTable GETKHO()
        {
            return DAO.GETKHO();
        }
        public DataTable GETMH()
        {
            return DAO.GETMH();
        }
        public DataTable GETMMH()
        {
            return DAO.GETMMH();
        }
        public DataTable GETDATA(string SQL)
        {
            return DAO.GET_DATA(SQL);
        }
        internal object getDatabase()
        {
            throw new NotImplementedException();
        }
        public void INSERTHOADONNHAP(DTO DTO)
        {
            DAO.INSERTHOADONNHAP(DTO);
        }
        public bool isINSERTHOADONNHAP(string MHDN)
        {
            return  DAO.isINSERTHOADONNHAP(MHDN);
        }
        public int maxrowCTHOADONNHAP(string MHDN)
        {
            return DAO.maxrowCTHOADONNHAP(MHDN);
        }
        public int maxrowCTHOADONXUAT(string MHDX)
        {
            return DAO.maxrowCTHOADONXUAT(MHDX);
        }
        public void UPDATEHOADONNHAP(DTO DTO)
        {
            DAO.UPDATEHOADONNHAP(DTO);
        }
        public void INSERTCTHOADONNHAP(DTO DTO)
        {
            DAO.INSERTCTHOADONNHAP(DTO);
        }
        
        public void UPDATECTHOADONNHAP(DTO DTO)
        {
            DAO.UPDATECTHOADONNHAP(DTO);
        }
        public void DELETECTHOADONNHAP(string MAHDN, int ID)
        {
            DAO.DELETECTHOADONNHAP(MAHDN, ID);
        }
        public bool ISINSERTCTHOADONNHAP(string MAHDN, int ID)
        {
            return DAO.ISINSERTCTHOADONNHAP(MAHDN, ID);
        }
        

        public DataTable GETALLCTHOADONNHAP()
        {
            return DAO.GETCTHOADONNHAP();
        }
        public DataTable GETCTHOADONNHAP(string MAHDN)
        {
            return DAO.GETCTHOADONNHAP(MAHDN);
        }
        
        public DataTable GETHOADONNHAP(DTO dto)
        {
            return DAO.GETHOADONNHAP(dto);
        }
        public DataTable LAYTIENNO(DTO dto)
        {
            return DAO.LAYTIENNO(dto);
        }
        public DataTable LAYTIENNOKH(DTO dto)
        {
            return DAO.LAYTIENNOKH(dto);
        }
        public void INSERTHOADONXUAT(DTO DTO)
        {
            DAO.INSERTHOADONXUAT(DTO);
        }
        public bool isINSERTHOADONXUAT(string MHDX)
        {
            return DAO.isINSERTHOADONXUAT(MHDX);
        }
        public void UPDATEHOADONXUAT(DTO DTO)
        {
            DAO.UPDATEHOADONXUAT(DTO);
        }

        public void INSERTCTHOADONXUAT(DTO DTO)
        {
            DAO.INSERTCTHOADONXUAT(DTO);
        }
        public bool ISINSERTCTHOADONXUAT(string MAHDX, int ID)
        {
            return DAO.ISINSERTCTHOADONXUAT(MAHDX, ID);
        }
        public void UPDATECTHOADONXUAT(DTO DTO)
        {
            DAO.UPDATECTHOADONXUAT(DTO);
        }
        public void DELETECTHOADONXUAT(string MAHDN, int ID)
        {
            DAO.DELETECTHOADONXUAT(MAHDN, ID);
        }


        public DataTable GETHOADONXUAT(DTO dto)
        {
            return DAO.GETHOADONXUAT(dto);
        }
        public DataTable GETCTHOADONXUAT(string MAHDX)
        {
            return DAO.GETCTHOADONXUAT(MAHDX);
        }









       
    }
}
