using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppFontend
{
    public class Helper
    {
        public static bool isValidURL(string path)
        {
            string pattern = @"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return reg.IsMatch(path);
        }
    }
}
