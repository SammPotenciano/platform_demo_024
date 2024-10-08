using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformDemoDB.Models
{
    [Table("ServicePlan")]
    public partial class ServicePlan
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateOfPurchase { get; set; }

        [InverseProperty("ServicePlan")]
        public virtual ICollection<Timesheet> Timesheets { get; set; } = new List<Timesheet>();
    }
}
