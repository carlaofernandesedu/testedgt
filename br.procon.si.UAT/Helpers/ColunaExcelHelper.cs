using System;

namespace br.procon.si.UAT.Helpers
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class ColunaExcelHelper : Attribute
    {
        private readonly string coluna;

        public ColunaExcelHelper(string nome)
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