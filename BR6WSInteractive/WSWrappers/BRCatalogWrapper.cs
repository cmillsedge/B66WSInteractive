﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioRails.Core.Api;
using BioRails.Core.Client;
using BioRails.Core.Model;

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

        public ParameterRoleArray GetRoles()
        {

            CatalogueApi catalogueApi = new CatalogueApi(_url);
            ParameterRoleArray roles = catalogueApi.CatalogueParameterRoles(_session.SessionId);
            return roles;

        }

        public NamedArray GetDictVals(string path, string match, int limit, int offset)
        {

            CatalogueApi catalogueApi = new CatalogueApi(_url);
            NamedArray vals = catalogueApi.DataValues(_session.SessionKey,path, match, limit, offset);
            return vals;

        }
    }
}
