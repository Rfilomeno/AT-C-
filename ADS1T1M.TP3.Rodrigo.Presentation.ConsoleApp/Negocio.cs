using System.Collections.Generic;
using ADS1T1M.TP3.Rodrigo.Domain.Entities;

namespace ADS1T1M.TP3.Rodrigo.Presentation.ConsoleApp
{
    public class Negocio
    {
        public static void VerificaBd(string[] data, IEnumerable<Aluno> alunos)
        {
            var AlunoDao = new AlunoDao();
                
            foreach (var aluno in alunos)
            {

                var pesquisaAluno = AlunoDao.BuscaAluno(aluno.Matricula);
                //matricula nao pode ser alterada pois é utilizada pra busca.
                if (pesquisaAluno == null)
                {
                    AlunoDao.SalvaAluno(aluno);
                    //log inclusão
                    LogHelper.escreveLog("Adicionado", data, aluno);
                }
                else if (pesquisaAluno.Nome != aluno.Nome)
                {
                    var propriedade = "nome";
                    var old = pesquisaAluno.Nome;
                    AlunoDao.MudaDadoDeAluno(aluno, propriedade);

                    //log alteração
                    LogHelper.escreveLog("Alterado:", data, aluno, propriedade, old);
                }
                else if (pesquisaAluno.Cpf != aluno.Cpf)
                {
                    var propriedade = "cpf";
                    var old = pesquisaAluno.Cpf;
                    AlunoDao.MudaDadoDeAluno(aluno, propriedade);

                    //log alteração
                    LogHelper.escreveLog("Alterado:", data, aluno, propriedade, old);
                }
                else if (pesquisaAluno.DataDeNascimento != aluno.DataDeNascimento)
                {
                    var propriedade = "dtn";
                    var old = pesquisaAluno.DataDeNascimento;
                    AlunoDao.MudaDadoDeAluno(aluno, propriedade);

                    //log alteração
                    LogHelper.escreveLog("Alterado:", data, aluno, propriedade, old.ToString());
                }
                else if (pesquisaAluno.Ativo != aluno.Ativo)
                {
                    var propriedade = "ativo";
                    var old = pesquisaAluno.Ativo;
                    AlunoDao.MudaDadoDeAluno(aluno, propriedade);

                    //log alteração
                    LogHelper.escreveLog("Alterado:", data, aluno, propriedade, ConvertHelper.ToString(old));
                }
                else // outros elses de outras alterações
                {
                    //log de nao alteracao
                    LogHelper.escreveLog("OK", data, aluno);
                }
            }
        }
    }
}
