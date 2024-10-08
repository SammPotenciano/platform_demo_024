using Microsoft.EntityFrameworkCore;
using PlatformDemoDB.Domain;
using PlatformDemoDB.Interfaces;
using PlatformDemoDB.Models;
using System.Runtime.CompilerServices;

namespace PlatformDemoDB.Data.Repository
{
    public class ServicePlanTimesheetsRepo : Repo, IServicePlanTimesheetsRepo
    {
        public ServicePlanTimesheetsRepo(AppDbContext context) : base(context) 
        { 
        }

        public async Task<List<DBServicePlanTimesheets>> GetAsync()
        {
            return await this.Context.Timesheets
                .Include(t => t.ServicePlan) // Include the related ServicePlan entity
                .Select(t => new DBServicePlanTimesheets(
                    t.Id,
                    t.ServicePlanDesc,
                    t.ServicePlan.DateOfPurchase, // Accessing DateOfPurchase from ServicePlan
                    t.ServicePlan.Timesheets.Count)) // Counting related Timesheets
                .ToListAsync(); // Use ToListAsync for proper async behavior
        }

    }
}
