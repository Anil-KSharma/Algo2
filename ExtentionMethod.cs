using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public static class ExtentionMethod
    {
        public static string ToProper(this String e)
        {
            string Proper = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(e);
            string[] arr = e.Split(' ');
            string gv = "";
            foreach (var item in arr)
            {
                string s = item.ToLower();
                string b= s[0].ToString().ToUpper();
                gv +=" "+ b + s.Substring(1,s.Length-1);
            }
            

            return Proper+ "-" + gv.Trim();

        }
    }
}
