using EscolaUI.Tests.Helpers;

namespace EscolaUI.Tests.Pages
{
    public abstract class BasePage
    {
        protected SeleniumHelper Driver
        {
            get
            {
                return BaseUITest.Driver;
            }
        }

        public ISeleniumHelper Browser
        {
            get
            {
                return BaseUITest.Driver;
            }
        }

        public string Titulo
        {
            get
            {
                return Driver.ObterTitulo();
            }
        }
        /// <summary>
        /// Base URL used for the UI tests.
        /// </summary>
        protected string baseURL { get; set; }

        /// <summary>
        /// Default constructor.
        /// Initializes page objectos within DOM.
        /// </summary>
        public BasePage()
        {

        }

        public BasePage(string url) 
        {
            baseURL = url;
            

        }

        protected internal void InicializarElementos(object page)
        {
            Driver.InicializarElementos(page);
        }

        //public BasePage(string url) : this(url,30,30,false,false)
        //{

        //}

        //public BasePage(string url, int scriptSegundos = 30, int paginaSegundos = 30, bool Maximizado = false, bool LimparCookies = false)
        //{
        //    baseURL = url;
        //    Browser.InicializarElementos(this);

        //}
        protected internal void ExecutarScript(string jsScript)
        {
            Driver.ExecutarScripts(jsScript);
        }

        protected internal void ObterScreenShot(string nomeArquivo)
        {
            Driver.ObterScreenShot(nomeArquivo);
        }
    }
}
