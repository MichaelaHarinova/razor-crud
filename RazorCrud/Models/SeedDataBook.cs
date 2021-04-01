using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorCrud.Models
{
    public class SeedDataBook
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorCrudBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorCrudBookContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "R.U.R",
                        ReleaseDate = DateTime.Parse("1920-25-01"),
                        Genre = "Science fiction",
                        Price = 7.99M
                    },

                    new Book
                    {
                        Title = "Nineteen Eighty-Four ",
                        ReleaseDate = DateTime.Parse("1949-6-8"),
                        Genre = "Dystopian, political fiction, social science fiction",
                        Price = 8.99M
                    },

                    new Book
                    {
                        Title = "Rendezvous with Rama",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Science fiction",
                        Price = 9.99M
                    },

                    new Book
                    {
                        Title = "Maria Treben's Cures",
                        ReleaseDate = DateTime.Parse("1980-4-15"),
                        Genre = "Healthcare",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }

    }
}