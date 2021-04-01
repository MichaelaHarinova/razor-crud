using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorCrud.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorCrudMusicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorCrudMusicContext>>()))
            {
                // Look for any movies.
                if (context.Music.Any())
                {
                    return;   // DB has been seeded
                }

                context.Music.AddRange(
                    new Music
                    {
                        Band = "Amaranthe",
                        Album = "Amaranthe",
                        ReleaseDate = DateTime.Parse("2011-01-11"),
                        Price = 19.99M,
                        Genre = "Power metal, Metalcore, Dance-rock, Melodic death metal"
                    },

                    new Music
                    {
                        Band = "Amon Amarth",
                        Album = "Berserker",
                        ReleaseDate = DateTime.Parse("2019-01-03"),
                        Price = 24.99M,
                        Genre = "Melodic death metal"
                    },

                    new Music
                    {
                        Band = "Eluveitie",
                        Album = "Helvetios ",
                        ReleaseDate = DateTime.Parse("2012-01-08"),
                        Price = 22.99M,
                        Genre = "Folk metal, Melodic death metal, Celtic metal"
                    },

                    new Music
                    {
                        Band = "M:40",
                        Album = "Historiens svarta vingslag",
                        ReleaseDate = DateTime.Parse("2007-01-05"),
                        Price = 14.99M,
                        Genre = "Crust, Hardcore"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}