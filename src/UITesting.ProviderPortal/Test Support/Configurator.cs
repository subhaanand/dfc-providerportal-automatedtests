﻿using System;
using System.Configuration;

namespace UITesting.ProviderPortal.TestSupport
{
    public class Configurator
    {
        private static Configurator configuratorInstance = null;

        private readonly String browser;
        private readonly String baseUrlVenues;
        private readonly String baseUrl;
        private readonly String useBS;

        private Configurator()
        {
            browser = ConfigurationManager.AppSettings["config_setting"];
            useBS = ConfigurationManager.AppSettings["useBS"];
            baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            baseUrlVenues = ConfigurationManager.AppSettings["BaseUrlVenues"];
        }

        public static Configurator GetConfiguratorInstance()
        {
            if (configuratorInstance == null)
            {
                configuratorInstance = new Configurator();
            }
            return configuratorInstance;
        }

        public String GetBrowser()
        {
            return browser;
        }

        public String GetBaseUrl()
        {
            return baseUrl;
        }

        public String GetBaseUrlVenues()
        {
            return baseUrlVenues;
        }

        public String GetUseBS()
        {
            return useBS;
        }
    }
}