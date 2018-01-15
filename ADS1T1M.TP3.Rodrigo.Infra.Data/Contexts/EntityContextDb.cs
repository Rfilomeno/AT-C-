using ADS1T1M.TP3.Rodrigo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS1T1M.TP3.Rodrigo.Infra.Data.Contexts
{
    public class EntityContextDb: DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
    }
}
