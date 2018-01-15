using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS1T1M.TP3.Rodrigo.Presentation.ConsoleApp
{
    public static class DateHelper
    {
        public static string[] PegarData()
        {
            var data = DateTime.Now;
            var dataSplit = data.ToString().Split('/', ' ', ':');
            string[] dataConfigurada = { dataSplit[2] + dataSplit[1] + dataSplit[0], dataSplit[3] + dataSplit[4] };
            return dataConfigurada;
        }
    }
}
