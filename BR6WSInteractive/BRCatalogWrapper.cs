﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace BR6WSInteractive
{
    class BRCatalogWrapper
    {
        private Session _session;
        private string _url;
        public BRCatalogWrapper(Session session, string url)
        {
            _session = session;
            _url = url;
        }

        public BRCatalogWrapper()
        {
        }

        public NamedArray GetAllConcepts()
        {
            NamedArray dataConcepts = new NamedArray();
            CatalogueApi catalogueApi = new CatalogueApi(_url);
            dataConcepts = catalogueApi.DataConcepts(_session.SessionId); ;
            return dataConcepts;
        }

        public ParameterTypeAliasArray GetParamAliases()
        {

            ParameterTypeAliasArray parameterTypeAliases = new ParameterTypeAliasArray();
            CatalogueApi catalogueApi = new CatalogueApi(_url);
            parameterTypeAliases = catalogueApi.CatalogueParameters(_session.SessionId);
            return parameterTypeAliases;

        }

        public NamedArray GetLookups()
        {

            NamedArray dataElements = new NamedArray();
            CatalogueApi catalogueApi = new CatalogueApi(_url);
            dataElements = catalogueApi.DataElements(_session.SessionId);
            return dataElements;

        }
    }
}
