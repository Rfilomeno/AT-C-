using ADS1T1M.TP3.Rodrigo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Xml;

namespace ADS1T1M.TP3.Rodrigo.Presentation.ConsoleApp
{
    public static class AlunoHelper
    {
        public static IEnumerable<Aluno> CriaAluno(XmlNodeList xnList)
        {
               List<Aluno> alunos = new List<Aluno>();
                foreach (XmlNode xn in xnList)
                {

                    Aluno aluno = new Aluno()
                    {
                        AlunoId = Guid.NewGuid(),
                        Matricula = xn["matricula"].InnerText,
                        Nome = xn["nome"].InnerText,
                        DataDeNascimento = Convert.ToDateTime(xn["datadenascimento"].InnerText),
                        Cpf = xn["cpf"].InnerText,
                        Ativo = ConvertHelper.ToBool(xn["ativo"].InnerText)

                    };

                    alunos.Add(aluno);

                }
                return alunos;
            
         }
    }
}
