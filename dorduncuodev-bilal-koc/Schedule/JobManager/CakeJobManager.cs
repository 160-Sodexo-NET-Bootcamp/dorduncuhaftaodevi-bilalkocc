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
        public static void MakeCake()//her 15dakikada 1 nesne üretimi yapan method
        {
            RecurringJob.AddOrUpdate<CakeJobs>(x => x.MakingCake(), "*/15 * * * *");
        }

        public static void ChangeStat()//18:00'da hazırlanıyor durumundan satılabilir durumuna geçiren method
        {
            RecurringJob.AddOrUpdate<CakeJobs>(x => x.ChangeStatus(), "00 18 * * *" ,TimeZoneInfo.Local);
        }
    }
}
