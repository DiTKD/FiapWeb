using FiapWeb.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiapWeb.Data
{
    public class PerguntaContext: DbContext
    {
        public PerguntaContext(DbContextOptions<PerguntaContext> options):base(options)
        {

        }

        public DbSet<Pergunta> Perguntas { get; set; }
        
    }
}
