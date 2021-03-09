using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using api.Models;
using System;
using System.Linq;

namespace api.Models
{
    public static class Fixtures
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApiContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApiContext>>()))
            {
                if (!context.WineFamilies.Any())
                {
                  
                    context.WineFamilies.AddRange(
                    new WineFamily
                    {
                        Name = "Rouge"
                    }, new WineFamily
                    {
                        Name = "Rosé"
                    }, new WineFamily
                    {
                        Name = "Blanc"
                    }, new WineFamily
                    {
                        Name = "Pétillant"
                    }, new WineFamily
                    {
                        Name = "Digestif"
                    }
                );
                }

                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product
                        {
                            Name = "Dragon de Quintus, 2nd vin du Château Quintus, 2016",
                            Price = 120.00,
                            SellPrice = 179.99,
                            WineFamily_Id = 1,
                        }, new Product
                        {
                            Name = "UBY N°4 Gros & Petit Manseng Doux, 2020",
                            Price = 4.50,
                            SellPrice = 7.90,
                            WineFamily_Id = 3,
                        }, new Product
                        {
                            Name = "Château La Sauvageonne La Villa, 2019",
                            Price = 30.00,
                            SellPrice = 45.00,
                            WineFamily_Id = 2,
                            
                        }, new Product
                        {
                            Name = "Hennessy, Paradis",
                            Price = 1200.00,
                            SellPrice = 1500.99,
                            WineFamily_Id = 5,
                        }
                    );
                }

                if (!context.Customers.Any())
                {
                    context.Customers.AddRange(
                        new Customer
                        {
                            Name = "Didier Rossigni",
                            Address = "3 rue des Potiers, Dijon",
                            Email = "didier.rossigni@laposte.net"
                        }, new Customer
                        {
                            Name = "Olivier Jambon",
                            Address = "125 rue de la République, Paris",
                            Email = "olivier.jambon@gmail.com"
                        }, new Customer
                        {
                            Name = "Kevin Doublet",
                            Address = "7 avenue des Laitues, Arcachon",
                            Email = "xx_killer_bg_xx@gmail.com"
                        }
                    );
                }

                if (!context.Suppliers.Any())
                {
                    context.Suppliers.AddRange(
                        new Supplier
                        {
                            Name = "Lavinia",
                            Address = "3-5 Boulevard de la Madeleine, 75001 Paris"
                        }, new Supplier
                        {
                            Name = "Nicolas Rouen Carrel",
                            Address = "40 rue Armand Carrel, Rouen 76000"
                        }
                    );
                }

                if (!context.Stocks.Any())
                {
                    context.Stocks.AddRange(
                        new Stock
                        {
                            ProductId = 1,
                            Quantity = 200
                        }, new Stock
                        {
                            ProductId = 2,
                            Quantity = 100
                        }, new Stock
                        {
                            ProductId = 3,
                            Quantity = 1400
                        }, new Stock
                        {
                            ProductId = 4,
                            Quantity = 10
                        }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}