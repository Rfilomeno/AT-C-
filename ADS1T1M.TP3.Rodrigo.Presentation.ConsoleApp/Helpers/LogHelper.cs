using ADS1T1M.TP3.Rodrigo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS1T1M.TP3.Rodrigo.Presentation.ConsoleApp
{
    public static class LogHelper
    {
        
        public static void escreveLog(string situacao, string[] data, Aluno aluno)
        {
            var sb = new StringBuilder();
            string pathDoLog = @"C:\Assessment Rodrigo_Filomeno\ADS1T1M.TP3.Rodrigo.Solution\Data\exporte-alunos-log-de-carga-" + data[0] + data[1] + ".txt";
                        
            sb.AppendLine($"matricula>{aluno.Matricula}; nome>{aluno.Nome}; ativo>{ConvertHelper.ToString(aluno.Ativo)}; {situacao};");
            
            string log = sb.ToString();
            File.AppendAllText(pathDoLog, log);

        }
        public static void escreveLog(string situacao, string[] data, Aluno aluno, string propriedade,string propriedadeAlterada)
        {
            var sb = new StringBuilder();
            string pathDoLog = @"C:\Assessment Rodrigo_Filomeno\ADS1T1M.TP3.Rodrigo.Solution\Data\exporte-alunos-log-de-carga-" + data[0] + data[1] + ".txt";
                       
            sb.AppendLine($"matricula>{aluno.Matricula}; nome>{aluno.Nome}; ativo>{ConvertHelper.ToString(aluno.Ativo)}; {situacao} {propriedade}>{propriedadeAlterada};");
           
            string log = sb.ToString();
            File.AppendAllText(pathDoLog, log);

        }
    }
}
