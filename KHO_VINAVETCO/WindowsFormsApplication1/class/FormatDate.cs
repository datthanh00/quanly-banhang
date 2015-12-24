using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
	class FormatDate
	{
        public static void Main()
        {
            
        System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-GB");
        cultureInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
        cultureInfo.DateTimeFormat.LongTimePattern = "dd/MM/yyyy hh:mm:ss";
        System.Windows.Forms.Application.CurrentCulture = cultureInfo;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-GB");

        }
	}
}
