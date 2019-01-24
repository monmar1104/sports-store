using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new ProductE
                {
                    Name = "Kajak",
                    Description = "ódka przeznaczona dla jednej osoby",
                    Category = "Sporty wodne",
                    Price = 275
                },
                new ProductE
                {
                    Name = "Kamizelka ratunkowa",
                    Description = "Chroni i dodaje uroku",
                    Category = "Sporty wodne",
                    Price = 48.95m
                },
                new ProductE
                {
                    Name = "Piïka",
                    Description = "Zatwierdzone przez FIFA rozmiar i waga",
                    Category = "Piłka nożna",
                    Price = 19.50m
                },
                new ProductE
                {
                    Name = "Flagi naroĝne",
                    Description = "Nadadzą twojemu boisku profesjonalny wygląd",

                    Category = "Piłka nożna",
                    Price = 34.95m
                },
                new ProductE
                {
                    Name = "Stadiom",
                    Description = "Składany stadion na 35 000 osób",
                    Category = "Piïka noĝna",
                    Price = 79500
                },
                new ProductE
                 {
                     Name = "Czapka",
                     Description = "Zwiększa efektywność mózgu o 75%",
                     Category = "Szachy",
                     Price = 16
                 },
                 new ProductE
                 {
                     Name = "Niestabilne krzesło",
                     Description = "Zmniejsza szanse przeciwnika",
                     Category = "Szachy",
                     Price = 29.95m
                 },
                 new ProductE
                 {
                     Name = "Ludzka szachownica",
                     Description = "Przyjemna gra dla całej rodziny!",
                     Category = "Szachy",
                     Price = 75
                 },
                 new ProductE
                 {
                     Name = "BłyszczÈcy król",
                     Description = "Figura pokryta zïotem i wysadzana diamentami",
                     Category = "Szachy",
                     Price = 1200
                 }
                 );
                                context.SaveChanges();
                            }
                        }
                    }
                }