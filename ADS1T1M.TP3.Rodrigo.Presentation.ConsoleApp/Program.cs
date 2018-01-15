using ADS1T1M.TP3.Rodrigo.Domain.Entities;
using ADS1T1M.TP3.Rodrigo.Infra.Data;
using ADS1T1M.TP3.Rodrigo.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ADS1T1M.TP3.Rodrigo.Presentation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // configura a data para o formato requerido
            string[] data = DateHelper.PegarData();

            // Ler o arquivo xml
            XmlNodeList xnList = Xmlao.LerXml();
            
            //renomeia arquivo
            Xmlao.RenomeiaXmlOriginal(data);

            //cria aluno com arquivo lido
            IEnumerable<Aluno> alunos = AlunoHelper.CriaAluno(xnList);

            // Logica para adicionar/modificar alunos no Banco de Dados
            Negocio.VerificaBd(data, alunos);

            Console.WriteLine("Programa executado com sucesso! Pressione uma tecla para sair.");
            Console.ReadKey();
        }
       
    }  
}
