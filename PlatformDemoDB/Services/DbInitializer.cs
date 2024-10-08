using PlatformDemoDB.Data;
using PlatformDemoDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PlatformDemoDB.Services
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AppDbContext>>()))
            {
                if (context == null || context.ServicePlans == null)
                {
                    throw new ArgumentNullException("Null AppDbContext");
                }

                if (context.ServicePlans.Any())
                {
                    return;   // DB has been seeded
                }

                context.ServicePlans.AddRange(

                    new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now.AddMonths(-10),
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "Business Basic",
                                StartDateTime = DateTime.Now.AddMonths(-10),
                                EndDateTime = DateTime.Now.AddMonths(-9),
                                Description = "Task 1"
                            }
                        }
                    },
                    new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now.AddMonths(-9),
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "Business Standard",
                                StartDateTime = DateTime.Now.AddMonths(-9),
                                EndDateTime = DateTime.Now.AddMonths(-8),
                                Description = "Task 1"
                            },
                            new Timesheet
                            {
                                ServicePlanDesc = "Business Premium",
                                StartDateTime = DateTime.Now.AddMonths(-1),
                                EndDateTime = DateTime.Now,
                                Description = "Task 1"
                            }
                        }
                    },
                    new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now,
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "Apps for Business",
                                StartDateTime = DateTime.Now,
                                EndDateTime = DateTime.Now,
                                Description = "Task 1"
                            }
                        }
                    },
                    new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now.AddMonths(-30),
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "E3/Office 365 E3",
                                StartDateTime = DateTime.Now.AddMonths(-30),
                                EndDateTime = DateTime.Now,
                                Description = "Task 1"
                            }
                        }
                    },
                    new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now.AddMonths(-15),
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "E5/Office 365 E51,2",
                                StartDateTime = DateTime.Now.AddMonths(-15),
                                EndDateTime = DateTime.Now.AddMonths(-1),
                                Description = "Task 1"
                            }
                        }
                    },
                    new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now.AddMonths(-50),
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "Office 365 E1",
                                StartDateTime = DateTime.Now.AddMonths(-50),
                                EndDateTime = DateTime.Now.AddMonths(-48),
                                Description = "Task 1"
                            }
                        }
                    },
                    new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now.AddMonths(-15),
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "Microsoft 365 F1",
                                StartDateTime = DateTime.Now.AddMonths(-15),
                                EndDateTime = DateTime.Now.AddMonths(-14),
                                Description = "Task 1"
                            },
                            new Timesheet
                            {
                                ServicePlanDesc = "Microsoft 365 F1",
                                StartDateTime = DateTime.Now.AddMonths(-13),
                                EndDateTime = DateTime.Now.AddMonths(-1),
                                Description = "Task 1"
                            }
                        }
                    },
                    new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now.AddMonths(-9),
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "Exchange Online Plan 1",
                                StartDateTime = DateTime.Now.AddMonths(-9),
                                EndDateTime = DateTime.Now.AddMonths(-8),
                                Description = "Task 1"
                            },
                            new Timesheet
                            {
                                ServicePlanDesc = "Exchange Online Plan 1",
                                StartDateTime = DateTime.Now.AddMonths(-1),
                                EndDateTime = DateTime.Now,
                                Description = "Task 1"
                            }
                        }
                    },
                    new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now.AddMonths(-12),
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "Exchange Online Plan 2",
                                StartDateTime = DateTime.Now.AddMonths(-12),
                                EndDateTime = DateTime.Now.AddMonths(-12),
                                Description = "Task 1"
                            }
                        }
                    }, new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now.AddMonths(-12),
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "Microsoft Defender for Office 365",
                                StartDateTime = DateTime.Now.AddMonths(-100),
                                EndDateTime = DateTime.Now,
                                Description = "Task 1"
                            }
                        }
                    },
                    new ServicePlan
                    {
                        DateOfPurchase = DateTime.Now.AddMonths(-9),
                        Timesheets = new List<Timesheet>(){
                            new Timesheet
                            {
                                ServicePlanDesc = "Microsoft 365 Apps for Enterprise",
                                StartDateTime = DateTime.Now.AddMonths(-9),
                                EndDateTime = DateTime.Now.AddMonths(-8),
                                Description = "Task 1"
                            },
                            new Timesheet
                            {
                                ServicePlanDesc = "Microsoft 365 Apps for Enterprise",
                                StartDateTime = DateTime.Now.AddMonths(-1),
                                EndDateTime = DateTime.Now,
                                Description = "Task 1"
                            }
                        }
                    }

                );

                        context.SaveChanges();
                    

            }
        }
    }
}
