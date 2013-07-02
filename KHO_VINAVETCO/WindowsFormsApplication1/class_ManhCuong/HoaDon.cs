using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1.Class_ManhCuong
{
   public class Cart 
   {
        private String MaMH;
        private String TenMH;
        private int SoLuong;
        private int DonGia;
        private int Thue;
        private String DVT;
      
     
   
     public Cart(String sMaMH,String sTenMH,int sSoLuong,int sDonGia, int sThue, String sDVT)
        {
            MaMH = sMaMH;
            TenMH = sTenMH;
            SoLuong = sSoLuong;
            DonGia = sDonGia;
            Thue = sThue;
            DVT = sDVT;
  
        }
     public String _MaMH
     { 
         get {return MaMH;}
         set {MaMH = value;}
     }
     public String _TenMH 
     {
         get { return TenMH; } 
         set { TenMH = value; } 
     }
     public int _SoLuong { get { return SoLuong; } set { SoLuong = value; } }
     public int _DonGia { get { return DonGia; } set { DonGia = value; } }
     public int _Thue { get { return Thue; } set { Thue = value; } }
     public String _DVT { get { return DVT; } set { DVT = value; } }
  
     public int _Total 
     {
         get { return (SoLuong >0 ? SoLuong :0)* DonGia;}
         
     }
   public  class HoaDon
     {
      private List<Cart> cart;
      public HoaDon()
      {
          if (cart == null)
              cart = new List<Cart>();
      }
      public List<Cart> _Cart
      {
          get { return cart; }
          set { cart = value; }
      }
      //tim mot san pham trong gio? hang`
      public int search_item_incart(String mamh)
      {
          int index = 0;
          foreach (Cart item in cart)
          {
              if (item._MaMH.Equals(mamh))
                  return index;
              index += 1;

          }
          return -1;
      }
      //insert 1 san pham vao
      public void insert_item_toCart(String mamh, String TenMH, int SoLuong, int DonGia, int Thue, String DVT)
      {
          if (search_item_incart(mamh) == -1)
          {
              Cart items = new Cart(mamh, TenMH, SoLuong, DonGia,Thue,DVT);
              cart.Add(items);
              
          }
          else
              cart[search_item_incart(mamh)]._SoLuong += SoLuong;
      }
      public void remove_item(String MaMH)
      {
          try
          {
              int index = search_item_incart(MaMH);
              cart.RemoveAt(index);
          }
          catch (IndexOutOfRangeException) { }
      }
      public int tong_HoaDon
      {
          get
          {
              int tempt = 0;
              if (cart == null)
                  return 0;
              else
                  foreach (Cart items in cart)
                  {
                      tempt += items._Total;
                  }
              return tempt;
          }
      }
     }
    }
}
