using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task11
{
    static class Exception
    {
        public static bool GroupNoController(this string value)
        {
            bool contoller = false;
            for (int i = 1; i < value.Length; i++)
            {
                if (char.IsNumber(value[i]))
                    contoller = true;
                else 
                {
                    contoller = false;
                    break;
                }

            }
            return value.Length < 5 && value[0] == char.ToUpper(value[0]) && contoller;
        }

        public static bool FullnameController(this string fullName)
        {
            string[] nameList = fullName.Split(' ');
            if (nameList.Length == 2 && !string.IsNullOrWhiteSpace(nameList[0]) && !string.IsNullOrWhiteSpace(nameList[1]))
                return true;

            return false;
        }
    }
}
