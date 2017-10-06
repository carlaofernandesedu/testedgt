using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entidades
{
    public class Aluno : Base 
    {
        public string Nome { get; set; }
        public DateTime DataInscricao { get; set; }
        public virtual ICollection<Matricula> Matriculas { get; set; }
    } 
}
