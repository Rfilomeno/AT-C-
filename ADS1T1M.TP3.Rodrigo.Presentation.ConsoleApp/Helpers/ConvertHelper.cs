using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS1T1M.TP3.Rodrigo.Presentation.ConsoleApp
{
    public static class ConvertHelper
    {
        public static string ToString(bool valor)
        {
            if (valor)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        public static bool ToBool(string valor)
        {
            if (valor == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
