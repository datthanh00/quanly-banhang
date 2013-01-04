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
        public Boolean isDELETEKHACHHANG(DTO DTO)
        {
            return DAO.isDELELEKHACHHANG(DTO);
        }
        public void DELETEBOPHAN(DTO DTO)
        {
            DAO.DELELEBOPHAN(DTO);
        }
        public Boolean isDELETEBOPHAN(DTO DTO)
        {
            return DAO.isDELELEBOPHAN(DTO);
        }
        public void DELETEMATHANG(DTO DTO)
        {
            DAO.DELELEMATHANG(DTO);
        }
        public Boolean isDELETEMATHANG(DTO DTO)
        {
            return DAO.isDELELEMATHANG(DTO);
        }
        public void DELETENHOMHANG(DTO DTO)
        {
            DAO.DELELENHOMHANG(DTO);
        }

        public Boolean isDELETENHOMHANG(DTO DTO)
        {
            return DAO.isDELELENHOMHANG(DTO);
        }
        public void DELETEQUANLY(DTO DTO)
        {
            DAO.DELELEQUANLY(DTO);
        }
        public void DELETETHUE(DTO DTO)
        {
            DAO.DELELETHUE(DTO);
        }
        public Boolean isDELETETHUE(DTO DTO)
        {
            return DAO.isDELELETHUE(DTO);
        }
        public void DELETEKHO(DTO DTO)
        {
            DAO.DELELEKHO(DTO);
        }
        public Boolean isDELETEKHO(DTO DTO)
        {
            return DAO.isDELELEKHO(DTO);
        }
        public void DELETEKV(DTO DTO)
        {
            DAO.DELELEKV(DTO);
        }
        public Boolean isDELETEKV(DTO DTO)
        {
            return DAO.isDELELEKV(DTO);
        }
        public void DELETENCC(DTO DTO)
        {
            DAO.DELELENCC(DTO);
        }
        public Boolean  isDELETENCC(DTO DTO)
        {
            return DAO.isDELELENCC(DTO);
        }
        public void DELETENHANVIEN(DTO DTO)
        {
            DAO.DELELENHANVIEN(DTO);
        }
        public Boolean isDELETENHANVIEN(DTO DTO)
        {
            return DAO.isDELELENHANVIEN(DTO);
        }
        public void DELETEDVT(DTO DTO)
        {
            DAO.DELELEDVT(DTO);
        }
        public Boolean isDELETEDVT(DTO DTO)
        {
            return DAO.isDELELEDVT(DTO);
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
        public string GETMANCCfromtraMHDN(String MAHDN)
        {
            return DAO.GETMANCCfromtraMHDN(MAHDN);
        }
        public string GETMAKHfromMHDX(String MAHDX)
        {
            return DAO.GETMAKHfromMHDX(MAHDX);
        }
        public string GETMAKHfromtraMHDX(String MAHDX)
        {
            return DAO.GETMAKHfromtraMHDX(MAHDX);
        }

        public DataTable GETKHO()
        {
            return DAO.GETKHO();
        }
 
        public DataTable GETMMH()
        {
            return DAO.GETMMH();
        }
        public DataTable GETMMHN(string MAHDN)
        {
            return DAO.GETMMHN(MAHDN);
        }
        public DataTable GETMMHX(string MAHDX)
        {
            return DAO.GETMMHX(MAHDX);
        }
        public DataTable GETDATA(string SQL)
        {
            return DAO.GET_DATA(SQL);
        }
        internal object getDatabase()
        {
            throw new NotImplementedException();
        }
        //tra hoa don nhap
        public void INSERTtraHOADONNHAP(DTO DTO)
        {
            DAO.INSERTtraHOADONNHAP(DTO);
        }
        public bool isINSERTtraHOADONNHAP(string MHDN)
        {
            return DAO.isINSERTtraHOADONNHAP(MHDN);
        }
        public void UPDATEtraHOADONNHAP(DTO DTO)
        {
            DAO.UPDATEtraHOADONNHAP(DTO);
        }


        public int maxrowtraCTHOADONNHAP(string MHDN)
        {
            return DAO.maxrowtraCTHOADONNHAP(MHDN);
        }
        //hoa don nhap
        public void INSERTHOADONNHAP(DTO DTO)
        {
            DAO.INSERTHOADONNHAP(DTO);
        }
        
        public void UPDATEHOADONNHAP(DTO DTO)
        {
            DAO.UPDATEHOADONNHAP(DTO);
        }
        public bool isINSERTHOADONNHAP(string MHDN)
        {
            return  DAO.isINSERTHOADONNHAP(MHDN);
        }
        //ct hoa don nhap
        public void INSERTtraCTHOADONNHAP(DTO DTO)
        {
            DAO.INSERTtraCTHOADONNHAP(DTO);
        }
        public void INSERTCTHOADONNHAP(DTO DTO)
        {
            DAO.INSERTCTHOADONNHAP(DTO);
        }
        public bool ISINSERTCTHOADONNHAP(string MAHDN, int ID)
        {
            return DAO.ISINSERTCTHOADONNHAP(MAHDN, ID);
        }
        public void UPDATEtraCTHOADONNHAP(DTO DTO)
        {
            DAO.UPDATEtraCTHOADONNHAP(DTO);
        }
        public void UPDATECTHOADONNHAP(DTO DTO)
        {
            DAO.UPDATECTHOADONNHAP(DTO);
        }
        public void DELETECTHOADONNHAP(string MAHDN, int ID)
        {
            DAO.DELETECTHOADONNHAP(MAHDN, ID);
        }
        public void DELETEtraCTHOADONNHAP(string MAHDN, int ID)
        {
            DAO.DELETEtraCTHOADONNHAP(MAHDN, ID);
        }
        public int maxrowCTHOADONNHAP(string MHDN)
        {
            return DAO.maxrowCTHOADONNHAP(MHDN);
        }
        


        //ct hoa don xuat
        public int maxrowCTHOADONXUAT(string MHDX)
        {
            return DAO.maxrowCTHOADONXUAT(MHDX);
        }
        public int maxrowtraCTHOADONXUAT(string MHDX)
        {
            return DAO.maxrowtraCTHOADONXUAT(MHDX);
        }


        public DataTable GETtraCTHOADONNHAP(string MAHDN)
        {
            return DAO.GETtraCTHOADONNHAP(MAHDN);
        }
        public DataTable GETCTHOADONNHAP(string MAHDN)
        {
            return DAO.GETCTHOADONNHAP(MAHDN);
        }
        public DataTable GETtraHOADONNHAP(DTO dto)
        {
            return DAO.GETtraHOADONNHAP(dto);
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
        public void INSERTtraHOADONXUAT(DTO DTO)
        {
            DAO.INSERTtraHOADONXUAT(DTO);
        }
        public bool isINSERTHOADONXUAT(string MHDX)
        {
            return DAO.isINSERTHOADONXUAT(MHDX);
        }
        public bool isINSERTtraHOADONXUAT(string MHDX)
        {
            return DAO.isINSERTtraHOADONXUAT(MHDX);
        }
        public void UPDATEHOADONXUAT(DTO DTO)
        {
            DAO.UPDATEHOADONXUAT(DTO);
        }
        public void UPDATEtraHOADONXUAT(DTO DTO)
        {
            DAO.UPDATEtraHOADONXUAT(DTO);
        }
        public void INSERTtraCTHOADONXUAT(DTO DTO)
        {
            DAO.INSERTtraCTHOADONXUAT(DTO);
        }
        public void INSERTCTHOADONXUAT(DTO DTO)
        {
            DAO.INSERTCTHOADONXUAT(DTO);
        }
        public bool ISINSERTCTHOADONXUAT(string MAHDX, int ID)
        {
            return DAO.ISINSERTCTHOADONXUAT(MAHDX, ID);
        }
        public void UPDATEtraCTHOADONXUAT(DTO DTO)
        {
            DAO.UPDATEtraCTHOADONXUAT(DTO);
        }
        public void UPDATECTHOADONXUAT(DTO DTO)
        {
            DAO.UPDATECTHOADONXUAT(DTO);
        }
        public void DELETECTHOADONXUAT(string MAHDN, int ID)
        {
            DAO.DELETECTHOADONXUAT(MAHDN, ID);
        }
        public void DELETEtraCTHOADONXUAT(string MAHDN, int ID)
        {
            DAO.DELETEtraCTHOADONXUAT(MAHDN, ID);
        }
        public DataTable GETtraHOADONXUAT(DTO dto)
        {
            return DAO.GETtraHOADONXUAT(dto);
        }
        public DataTable GETHOADONXUAT(DTO dto)
        {
            return DAO.GETHOADONXUAT(dto);
        }
        public DataTable GETCTHOADONXUAT(string MAHDX)
        {
            return DAO.GETCTHOADONXUAT(MAHDX);
        }
        public DataTable GETtraCTHOADONXUAT(string MAHDX)
        {
            return DAO.GETtraCTHOADONXUAT(MAHDX);
        }

        public void executeNonQuery(string SQL)
        {
             DAO.executeNonQuery(SQL);
        }






       
    }
}
