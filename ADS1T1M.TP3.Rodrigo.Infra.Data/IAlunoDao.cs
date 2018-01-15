using ADS1T1M.TP3.Rodrigo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS1T1M.TP3.Rodrigo.Infra.Data
{
    interface IAlunoDao
    {
        Aluno BuscaAluno(string matricula);

        void SalvaAluno(Aluno aluno);

        void MudaDadoDeAluno(Aluno aluno, string propriedade);
    }
}
