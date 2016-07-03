using Microsoft.AspNet.SignalR;
using SignalRDatabaseValueChanges.Models;
using System.Collections.Generic;
using System.Linq;

namespace SignalRDatabaseValueChanges.Repository
{
    public class JobRepository
    {
        public IEnumerable<JobInfos> GetData()
        {
            var context = new SignalREntities();
            var data = context.JobInfoes.Select(x => new JobInfos()
                             {
                                 JobID = x.JobId,
                                 Name = x.Name,
                                 LastExecutionDate = x.LastExecutionDate.Value,
                                 Status = x.Status
                             }).ToList();
            IHubContext hub = GlobalHost.ConnectionManager.GetHubContext<JobHub>();
            hub.Clients.All.displayStatus();

            return data;

        }
        //private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        //{
        //    JobHub.Show();
        //}
    }
}