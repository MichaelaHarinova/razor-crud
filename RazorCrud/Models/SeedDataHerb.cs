using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorCrud.Models
{
    public class SeedDataHerb
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorCrudHerbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorCrudHerbContext>>()))
            {
                // Look for any movies.
                if (context.Herb.Any())
                {
                    return;   // DB has been seeded
                }

                context.Herb.AddRange(
                    new Herb
                    {
                        Name = "Taraxacum officinale",
                        Usage = "chronic hepatitis, diabetes, atopic eczema, rheumatism...",
                        Part = "root",
                        Grams = 100 ,
                        Price = 3.99M
                    },

                    new Herb
                    {
                        Name = "Silybum marianum",
                        Usage = "regenerates and strengthens the liver, eczema, periodontitis...",
                        Part = "Whole plant",
                        Grams = 100 ,
                        Price = 2.99M
                    },

                    new Herb
                    {
                        Name = "Hypericum perforatum",
                        Usage = "contributes to greater emotional balance, suppresses sleep disorders...",
                        Part = "Whole plant",
                        Grams = 100 ,
                        Price = 4.99M
                    },

                    new Herb
                    {
                        Name = "Plectranthus amboinicus",
                        Usage = "asthma, runny nose, airway inflammation, cold, headaches...",
                        Part = "Leaves",
                        Grams = 100 ,
                        Price = 1.99M
                    }
                    
                );
                context.SaveChanges();
            }
        }

    }
}