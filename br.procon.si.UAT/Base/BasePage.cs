﻿using br.procon.si.UAT.Helpers;

namespace br.procon.si.UAT.Base
{
    public abstract class BasePage
    {
        protected ISeleniumHelper Driver { get; set; }

        public abstract string ObterPaginaUrl();

        public string Titulo
        {
            get
            {
                return Driver.ObterTitulo();
            }
        }

        protected string baseUrl { get; set; }

        protected BasePage()
        {
            baseUrl = ConfigurationHelper.SiteUrl;
        }

        protected BasePage(string baseurl, ISeleniumHelper driver)
        {
            baseUrl = baseurl;
            Driver = driver;
        }

        public virtual BasePage DefinirBaseUrl(string baseurl)
        {
            baseUrl = baseurl;
            return this;
        }

        public virtual BasePage DefinirDriver(ISeleniumHelper driver)
        {
            Driver = driver;
            return this;
        }

        public virtual BasePage CapturarTela()
        {
            Driver.CapturarTela(this.GetType().Name);
            return this;
        }

        public virtual BasePage InicializarElementos()
        {
            Driver.InicializarElementos(this);
            return this;
        }

        public virtual BasePage ExecutarScript(string jsScript)
        {
            Driver.ExecutarScripts(jsScript);
            return this;
        }
    }
}