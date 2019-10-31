using System;
using System.Text.RegularExpressions;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {            
            return (Regex.IsMatch(str1,str2, RegexOptions.IgnoreCase));
        }
    }
}
