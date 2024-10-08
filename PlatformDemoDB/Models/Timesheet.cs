using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace PlatformDemoDB.Models
{
    [Table("Timesheet")]
    public partial class Timesheet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Ensures that Id is auto-incremented
        public int Id { get; set; }
        public string? ServicePlanDesc { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string? Description { get; set; }
        public int TotalTimesheets { get; set; }

        [ForeignKey("ServicePlanId")]
        [InverseProperty("Timesheets")]
        public int ServicePlanId { get; set; }
        public virtual ServicePlan ServicePlan { get; set; } = null!;

        
        
    }
}
