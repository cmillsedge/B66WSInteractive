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
    class BRTaskWrapper
    {
        private Session _session;
        private string _url;
        public BRTaskWrapper(Session session, string url)
        {
            _session = session;
            _url = url;
        }

        public BRTaskWrapper()
        {
        }

        public FolderArray SearchForTasks(string filterstring, string columnname, string operatorval)
        {
            TasksApi tasksApi = new TasksApi(_url);
            FolderArray tasks = tasksApi.TaskSearch(_session.SessionId, "", true, 100, FilterGenerator.SimpleFilter(columnname, operatorval, filterstring ));
            return tasks;

        }
    }
}
