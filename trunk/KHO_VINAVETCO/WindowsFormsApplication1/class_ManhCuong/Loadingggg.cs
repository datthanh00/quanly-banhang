using System;

namespace WindowsFormsApplication1
{
    class Loadingggg 
    {

        private DevExpress.Utils.WaitDialogForm dlg = null;
       public void CreateWaitDialog()
       {
           dlg = new DevExpress.Utils.WaitDialogForm("Xin vui lòng chờ đợi");
       }
       public void SetWaitDialogCaption(string fCaption)
       {
           if (dlg != null)
           {
               dlg.Caption = fCaption;
           }
       }
      
       public void simpleCloseWait()
       {
           dlg.Close();
       }

    }
}
