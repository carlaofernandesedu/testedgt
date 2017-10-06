using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entidades
{
    public class Curso : Base  
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Nome { get; set; }

    }
}
