using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AdemITHome.Data;
using System;
using System.Linq;

namespace AdemITHome.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider servicerProvider)
        {
            using (var context = new AdemITHomeContext(servicerProvider.GetRequiredService<DbContextOptions<AdemITHomeContext>>()))
            {
                if (context.Article.Any())
                {
                    return;
                }
                context.Article.AddRange(
                    new Article
                    {
                        Title = "Day01 Azure",
                        ReleaseDate = DateTime.Parse("2022-01-18"),
                        Link = "https://01",
                        Count = 0
                    },
                    new Article
                    {
                        Title = "Day02 Sign Up Azure",
                        ReleaseDate = DateTime.Parse("2022-01-18"),
                        Link = "https://02",
                        Count = 0
                    }
                );
                context.SaveChanges();
            }

        }
    }
}