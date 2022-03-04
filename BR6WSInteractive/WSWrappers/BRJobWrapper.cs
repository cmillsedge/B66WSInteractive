using BioRails.Core.Api;
using BioRails.Core.Model;


namespace BR6WSInteractive
{
    class BRJobWrapper
    {
        private Session _session;
        private string _url;
        public BRJobWrapper(Session session, string url)
        {
            _session = session;
            _url = url;
        }

        public BRJobWrapper()
        {
        }

        public JobReport RefreshJob(string jobId)
        {

            JobsApi jobsAPI = new JobsApi(_url);
            JobReport jobNew = jobsAPI.JobGet(_session.SessionKey, jobId);

            return jobNew;

        }
    }
}
