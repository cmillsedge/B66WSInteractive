using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioRails.Core.Api;
using BioRails.Core.Client;
using BioRails.Core.Model;

namespace BR6WSInteractive
{
    class BRProcessWrapper
    {
        private Session _session;
        private string _url;
        public BRProcessWrapper(Session session, string url)
        {
            _session = session;
            _url = url;
        }

        public BRProcessWrapper()
        {
        }

        public FolderArray GetProcessesForOutline(string outline)
        {

            OutlineProcessesApi processApi = new OutlineProcessesApi(_url);
            FolderArray processes = processApi.ProcessList(_session.SessionId, outline); 
            return processes;

        }

        public Process GetProcessByPath(string path)
        {

            OutlineProcessesApi processApi = new OutlineProcessesApi(_url);
            Process process = processApi.ProcessFind(_session.SessionId, path);
            return process;

        }
    }
}
