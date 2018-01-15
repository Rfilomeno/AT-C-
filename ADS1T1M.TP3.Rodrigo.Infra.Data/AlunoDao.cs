using ADS1T1M.TP3.Rodrigo.Domain.Entities;
using ADS1T1M.TP3.Rodrigo.Infra.Data;
using ADS1T1M.TP3.Rodrigo.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS1T1M.TP3.Rodrigo.Presentation.ConsoleApp
{
    public class AlunoDao : IAlunoDao
    {
        private static EntityContextDb contexto = new EntityContextDb();

        public Aluno BuscaAluno(string matricula)
        {
            try
            {
                return contexto.Alunos.Where(a => a.Matricula == matricula).FirstOrDefault();
            }catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro na consulta ao Banco de Dados");
                Console.ReadKey();
                Environment.Exit(00);
            }
            return null;
        }

        public void SalvaAluno(Aluno aluno)
        {
            try
            {

                contexto.Alunos.Add(aluno);
                contexto.SaveChanges();
            }catch(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao inserir dado no Banco de Dados");
                Console.ReadKey();
                Environment.Exit(00);
            }
        }

        public void MudaDadoDeAluno(Aluno aluno, string propriedade)
        {
            try
            {
                var pesquisa = BuscaAluno(aluno.Matricula);
                switch (propriedade)
                {
                    case "matricula":
                        pesquisa.Matricula = aluno.Matricula;
                        break;
                    case "nome":
                        pesquisa.Nome = aluno.Nome;
                        break;

                    case "cpf":
                        pesquisa.Cpf = aluno.Cpf;
                        break;
                    case "dtn":
                        pesquisa.DataDeNascimento = aluno.DataDeNascimento;
                        break;
                    case "ativo":
                        pesquisa.Ativo = aluno.Ativo;
                        break;
                }
                contexto.SaveChanges();

            }catch(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro no Banco de Dados");
                Console.ReadKey();
                Environment.Exit(00);
            }
        }
    }
}
