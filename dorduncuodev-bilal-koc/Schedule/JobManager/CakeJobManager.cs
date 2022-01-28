using Hangfire;
using Schedule.JobActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.JobManager
{
    public static class CakeJobManager
    {
        public static void MakeCake()
        {
            RecurringJob.AddOrUpdate<CakeJobs>(x => x.MakingCake(), "*/1 * * * *");
        }

        public static void ChangeStat()
        {
            RecurringJob.AddOrUpdate<CakeJobs>(x => x.ChangeStatus(), "46 19 * * *" ,TimeZoneInfo.Local);
        }
    }
}
