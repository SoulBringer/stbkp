using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageApp.DataBase
{
    public class Validator
    {
        public static bool IsValidName(string name)
        {
            foreach (var n in name)
                if ((
                    ((n >= 'A') && (n <= 'Z')) ||
                    ((n >= 'a') && (n <= 'z')) ||
                    ((n >= 'А') && (n <= 'Я')) ||
                    ((n >= 'а') && (n <= 'я')) ||
                    (n == ' ')) == false)
                    return false;
            return true;
        }
    }
}
