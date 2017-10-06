using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entidades
{
    public enum Serie
    {
        Basico, Intermediario, Avancado
    }
    public class Matricula : Base 
    {
        public int CursoID { get; set; }
        public int AlunoID { get; set; }
        public Serie? Serie { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}
