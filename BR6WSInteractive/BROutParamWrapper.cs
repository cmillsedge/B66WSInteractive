using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;


namespace BR6WSInteractive
{
    class BROutParamWrapper
    {
        private Session _session;
        private string _url;
        public BROutParamWrapper(Session session, string url)
        {
            _session = session;
            _url = url;
        }

        public BROutParamWrapper()
        {
        }

        public OutlineParameterArray GetAllOutlineParameters(string outlineName)
        {
            OutlineParametersApi outlineParametersApi = new OutlineParametersApi(_url);
            OutlineParameterArray outlineParameters = outlineParametersApi.OutlineParameterList(_session.SessionId, outlineName);
            return outlineParameters;
        }

        public string CreateOutlineParameter(string outlineName, OutlineParameter parameter)
        {
            string outcome = "";
            try
            {
                OutlineParametersApi outlineParametersApi = new OutlineParametersApi(_url);
                outlineParametersApi.OutlineParameterCreate(_session.SessionId, outlineName, parameter);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                outcome = ErrorParser.GetErrorMessageFromBioRailsError(ex.Message);
            }
             
            return outcome;
        }
    }


}
