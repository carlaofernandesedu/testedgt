using br.procon.si.UI.Consumidor.Tests.Helpers;
using System;

namespace br.procon.si.UI.Consumidor.Tests.Pages
{
    public abstract class BasePage
    {
        protected ISeleniumHelper Driver { get; set; }

        public abstract Uri ObterPaginaUrl();

        public string Titulo
        {
            get
            {
                return Driver.ObterTitulo();
            }
        }
        protected string baseUrl { get; set; }

        public BasePage()
        {
            baseUrl = ConfigurationHelper.SiteUrl;
        }

        public BasePage(string baseurl, ISeleniumHelper driver) 
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

        public virtual BasePage  InicializarElementos()
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
