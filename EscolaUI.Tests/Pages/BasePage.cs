﻿using EscolaUI.Tests.Helpers;
using System;

namespace EscolaUI.Tests.Pages
{
    public abstract class BasePage
    {
        protected ISeleniumHelper Driver { get; set; }

        public abstract Uri ConstructUrl();

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
            baseURL = ConfigurationHelper.SiteUrl;
        }

        public BasePage(string baseurl, ISeleniumHelper driver) 
        {
            baseURL = baseurl;
            Driver = driver; 
        }

        public virtual BasePage DefinirBaseURL(string baseurl)
        {
            baseURL = baseurl;
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
