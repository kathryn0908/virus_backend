using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using virus_mvc.Data;
using System;
using System.Linq;

namespace virus_mvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new virus_mvcContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<virus_mvcContext>>()))
            {
                // Look for any movies.
                if (context.VirusData.Any())
                {
                    return;   // DB has been seeded
                }

                context.VirusData.AddRange(
                    new VirusData
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new VirusData
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new VirusData
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new VirusData
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}