using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlatformDemoDB.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PlatformDemoWeb.Models;


public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IServicePlanTimesheetsRepo _repo;
    public IndexModel(ILogger<IndexModel> logger,
                      IServicePlanTimesheetsRepo repo)
    {
        _logger = logger;
        _repo = repo;
    }

    List<ServicePlanTimesheets> _servicePlanTimesheets;
    public List<ServicePlanTimesheets> servicePlanTimesheets
    {
        get
        {
            return _servicePlanTimesheets;
        }
    }

    public async Task<IActionResult> OnGet()
    {
        try
        {
            var result = await _repo.GetAsync();
            _servicePlanTimesheets = result.Select(s => new ServicePlanTimesheets()
            {
                Id = s.Id,
                ServicePlanDesc = s.ServicePlanDesc,
                DateOfPurchase = s.DateOfPurchase,
                TotalTimesheets = s.TotalTimesheets
            }).ToList();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
        }

        return Page();
    }
}
