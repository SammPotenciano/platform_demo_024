using PlatformDemoDB.Domain;

namespace PlatformDemoDB.Interfaces
{
    public interface IServicePlanTimesheetsRepo
    {
        Task<List<DBServicePlanTimesheets>> GetAsync();
    }
}
