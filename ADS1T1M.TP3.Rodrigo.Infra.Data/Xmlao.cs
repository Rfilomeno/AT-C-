using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ADS1T1M.TP3.Rodrigo.Infra.Data
{
    public static class Xmlao
    {
        static string pathDoXml = @"C:\Assessment Rodrigo_Filomeno\ADS1T1M.TP3.Rodrigo.Solution\Data\exporte-alunos.xml";
        public static XmlNodeList LerXml()
        {
            try
            {
                
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathDoXml);
                XmlNodeList xnList = xmlDoc.GetElementsByTagName("aluno");
                return xnList;

            }catch (FileNotFoundException ex)
            {
                Console.WriteLine("Arquivo XML não encontrado");
                Console.ReadKey();
                Environment.Exit(00);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro no sistema.");
                Console.ReadKey();
                Environment.Exit(00);
            }
            return null;
        }
        public static void RenomeiaXmlOriginal(string[] data)
        {
            try {
                string pathDoXmlrenomeado = @"C:\Assessment Rodrigo_Filomeno\ADS1T1M.TP3.Rodrigo.Solution\Data\exporte-alunos-" + data[0] + "-" + data[1] + ".xml";
                bool overWrite = true;
                File.Copy(pathDoXml, pathDoXmlrenomeado, overWrite);
                File.Delete(pathDoXml);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Arquivo XML não encontrado");
                Console.ReadKey();
                Environment.Exit(00);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro no sistema.");
                Console.ReadKey();
                Environment.Exit(00);
            }

        }

    }
}
