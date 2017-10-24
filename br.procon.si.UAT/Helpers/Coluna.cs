using System;

namespace br.procon.si.UAT.Helpers
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class Coluna : Attribute
    {
        private readonly string coluna;

        public Coluna(string nome)
        {
            this.coluna = nome;
        }

        public string Nome
        {
            get
            {
                return this.coluna;
            }
        }
    }
}