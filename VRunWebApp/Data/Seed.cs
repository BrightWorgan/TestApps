

using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using VRunWebApp.Data.Enum;
using VRunWebApp.Models;

namespace VRunWebApp.Data
{
    public class Seed
    {

        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.RunningClubs.Any())
                {
                    context.RunningClubs.AddRange(new List<RunningClub>()
                    {
                        new RunningClub()
                        {
                            Title = "Russborough house ParkRun",
                            Image = "",
                            Description = "This is offical running club for the Blessington Area / West Wicklow Parkrun, located in the mature gardens of the histric Russbourough House.",
                            ClubCategory = ClubCategory.ParkRun,
                            AddressId = 10,

                            Address = new Address()
                            {
                                EirCode = "W90VA01",
                                Town = "Blessington",
                                County = "Co. Wicklow",
                                Country = "ROI"
                            }
                        },


                        new RunningClub()
                        {
                            Title = "The Lakeshore Striders",
                            Image = "",
                            Description = "Blessington Lakes running club",
                            ClubCategory = ClubCategory.RoadRunner,
                            AddressId = 9,
                            Address = new Address()
                            {
                                EirCode = "W90VA01",
                                Town = "Blessington",
                                County = "Co. Wicklow",
                                Country = "ROI"
                            }
                        }
                        
                    });

                    context.SaveChanges();
                }


                //Races
                if (!context.Races.Any())
                {
                    context.Races.AddRange(new List<RaceCourse>()
                    {
                        new RaceCourse()
                        {
                            Title = "Blessington ParkRun",
                            Image = "",
                            Description = "This is the Blessington Area / West Wicklow Parkrun, located in the mature gardens of the histric Russbourough House.",
                            RaceCategory = RaceCourseCate.ParkRun,
                             AddressId = 10,
                            Address = new Address()
                            {
                               EirCode = "W90VA01",
                                Town = "Blessington",
                                County = "Co. Wicklow",
                                Country = "ROI"
                            }
                        },
                        new RaceCourse()
                        {
                            Title = "Dublin Marathon",
                            Image = "",
                            Description = "The Dublin Marathon is an annual 26.2 mile road marathon in Dublin, Ireland, held on the last Sunday in October. Prior to 2016, the race took place on the last Monday in October, which is a public holiday in Ireland.",
                            RaceCategory = RaceCourseCate.Marathon,
                            AddressId = 1,
                            Address = new Address()
                            {
                                EirCode = "D",
                                Town = "Dublin City Centre",
                                County = "Co. Dublin",
                                Country = "ROI"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

    }
}
