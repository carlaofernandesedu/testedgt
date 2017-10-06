using Escola.DAL.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.DAL.Contexto
{
    public class EscolaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EscolaContext>
    {
        protected override void Seed(EscolaContext context)
        {

        }
    }
}
