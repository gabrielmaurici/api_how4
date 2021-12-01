using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class JogoContext : DbContext
    {
        public DbSet<Jogo> Jogos { get; set; }

        public JogoContext() : base(@"Data Source=GABRIEL\SQLEXPRESS;Initial Catalog=api_how;Integrated Security=True")
        {

        }
    }
}
