using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformDemoDB.Domain
{
    public class DBServicePlanTimesheets
    {
        public int Id { get; set; }
        public string ServicePlanDesc { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int TotalTimesheets { get; set; }

        public DBServicePlanTimesheets(int id, string servicePlanDesc, DateTime dateOfPurchase, int totalTimesheets)
        {
            Id = id;
            ServicePlanDesc = servicePlanDesc;
            DateOfPurchase = dateOfPurchase;
            TotalTimesheets = totalTimesheets;
        }
    }



}
