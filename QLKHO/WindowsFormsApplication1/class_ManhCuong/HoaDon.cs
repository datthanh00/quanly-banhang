using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
      
     
   
     public Cart(String MaMH,String TenMH,int SoLuong,int DonGia, int Thue, String DVT)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.Thue = Thue;
            this.DVT = DVT;
  
        }
     public String _MaMH
     { 
         get {return this.MaMH;}
         set {this.MaMH = value;}
     }
     public String _TenMH 
     {
         get { return this.TenMH; } 
         set { this.TenMH = value; } 
     }
     public int _SoLuong { get { return this.SoLuong; } set { this.SoLuong = value; } }
     public int _DonGia { get { return this.DonGia; } set { this.DonGia = value; } }
     public int _Thue { get { return this.Thue; } set { this.Thue = value; } }
     public String _DVT { get { return this.DVT; } set { this.DVT = value; } }
  
     public int _Total 
     {
         get { return (SoLuong >0 ? SoLuong :0)* DonGia;}
         
     }
   public  class HoaDon
     {
      private List<Cart> cart;
      public HoaDon()
      {
          if (this.cart == null)
              this.cart = new List<Cart>();
      }
      public List<Cart> _Cart
      {
          get { return this.cart; }
          set { this.cart = value; }
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
              this.cart.Add(items);
              
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
