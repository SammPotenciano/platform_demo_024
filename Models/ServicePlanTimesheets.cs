using System.ComponentModel.DataAnnotations;


namespace PlatformDemoWeb.Models
{
    public class ServicePlanTimesheets
    {
        public int Id { get; set; }
        [Display(Name = "Service Plan: ")]
        public string ServicePlanDesc { get; set; }
        [Display(Name = "Purchase Date: ")]
        public DateTime DateOfPurchase { get; set; }

        [Display(Name = "Number of Timesheets: ")]
        public int TotalTimesheets { get; set; }

    }
}
