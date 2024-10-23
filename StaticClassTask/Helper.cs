using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassTask
{
    internal static class Helper
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;

        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool HasDigit(this string item)
        {

            for (int i = 0; i < item.Length; i++)
            {
                if (Char.IsDigit(item[i]))
                {
                    return true;
                }
            }
            return false;

        }
        public static bool CheckPassword(this string password)
        {
            if (password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {

                    if (Char.IsUpper(password[i]))/*&& Char.IsLower(password[i]) && Char.IsDigit(password[i]) && password.Length >= 8*/
                    {
                        for (int j = 0; j < password.Length; j++)
                        {
                            if (Char.IsLower(password[j]))
                            {
                                for (int k = 0; k < password.Length; k++)
                                {
                                    if (Char.IsDigit(password[k]))
                                    {
                                        return true;

                                    }
                                }
                            }
                        }

                    }
                }
               
            } return false;
        }

            public static string Capitalize(this string value)
            {
                return value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        
    }
}
