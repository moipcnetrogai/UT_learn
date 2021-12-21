using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace NomerWPF
{
    public class Proverka
    {
        public string proverkaCAR(string nom)
        {
            string regex1 = "^[АВЕКМНОРСТУХ]" + @"\" + "d{3}(?<!000)[АВЕКМНОРСТУХ]{2}" + @"\" + "d{2,3}$";
            string regex2 = "^[АВЕКМНОРСТУХ]{2}" + @"\" + "d{3}(?<!000)" + @"\" + "d{2,3}$";
            string regex3 = "^[АВЕКМНОРСТУХ]{2}" + @"\" + "d{4}(?<!0000)" + @"\" + "d{2,3}$";
            string regex4 = "^" + @"\" + "d{4}(?<!0000)[АВЕКМНОРСТУХ]{2}" + @"\" + "d{2,3}$";
            string regex5 = "^[АВЕКМНОРСТУХ]{2}" + @"\" + "d{3}(?<!000)[АВЕКМНОРСТУХ]" + @"\" + "d{2,3}$";
            string regex6 = "^Т[АВЕКМНОРСТУХ]{2}" + @"\" + "d{3}(?<!000)" + @"\" + "d{2,3}$";
            if (Regex.IsMatch(nom, regex1))       return "ОК";
            else if(Regex.IsMatch(nom, regex2)) return "ОК";
            else if (Regex.IsMatch(nom, regex3)) return "ОК";
            else if (Regex.IsMatch(nom, regex4)) return "ОК";
            else if (Regex.IsMatch(nom, regex5)) return "ОК";
            else if (Regex.IsMatch(nom, regex6)) return "ОК";
            else return "НЕ ОК";
        }

        public string proverkaEMAIL(string email)
        {
            string regexEMAIL = "^([a-z0-9_-]+" + @"\" + ".)*[a-z0-9_-]+@[a-z0-9_-]+(" + @"\" + ".[a-z0-9_-]+)*" + @"\" + ".[a-z]{2,6}$";
            if (Regex.IsMatch(email, regexEMAIL, RegexOptions.IgnoreCase) ) return "ОК";
            else return "НЕ ОК";
        }

    }
}
