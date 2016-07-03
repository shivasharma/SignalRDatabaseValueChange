using SignalRDatabaseValueChanges.Models;
using SignalRDatabaseValueChanges.Repository;
using System.Collections.Generic;
using System.Web.Http;

namespace SignalRDatabaseValueChanges.Controllers
{
    public class ValuesController : ApiController
    {
        JobRepository objRepo = new JobRepository();

        public IEnumerable<JobInfos> Get()
        {
            return objRepo.GetData();
        }
    }
}
