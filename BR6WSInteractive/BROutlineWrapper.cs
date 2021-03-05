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
    class BROutlineWrapper
    {
        private Session _session;
        private string _url;
        public BROutlineWrapper(Session session, string url)
        {
            _session = session;
            _url = url;
        }

        public BROutlineWrapper()
        {
        }

        public FolderArray GetAllOutlines()
        {

            OutlinesApi outlinesApi = new OutlinesApi(_url);
            FolderArray outlines = outlinesApi.OutlineList(_session.SessionId, ""); //note path not really needed for this method so pass empty
            return outlines;

        }
    }
}
