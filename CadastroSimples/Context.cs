using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace CadastroSimples
{
    public class Context : DbContext
    {
        public Context() : base("Connection") { }

        public DbSet<Agenda> ObjetoAgenda { get; set; }
    }
}
