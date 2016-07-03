using System;

namespace SignalRDatabaseValueChanges.Models
{
    public class JobInfos
    {
        public int JobID { get; set; }
        public string Name { get; set; }
        public DateTime LastExecutionDate { get; set; }
        public string Status { get; set; }
    }
}