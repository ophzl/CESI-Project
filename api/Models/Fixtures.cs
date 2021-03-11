using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using api.Models;
using System;
using System.Linq;
using System.Collections.Generic;

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
                var Families = new List<WineFamily>(){
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
                    };




                if (!context.WineFamilies.Any())
                {
                    context.WineFamilies.AddRange(Families);
                }
                var Suppliers = new List<Supplier>() {new Supplier
                        {
                            Name = "Lavinia",
                            Address = "3-5 Boulevard de la Madeleine, 75001 Paris"
                        }, new Supplier
                        {
                            Name = "Nicolas Rouen Carrel",
                            Address = "40 rue Armand Carrel, Rouen 76000"
                        }};


                if (!context.Suppliers.Any())
                {
                    context.Suppliers.AddRange(Suppliers);
                }


                context.SaveChanges();

                context.SaveChanges();
                var Products = new List<Product>() { new Product
                        {
                            Name = "Dragon de Quintus",
                            House = "Chateau Quintus",
                            Year = "2016",
                            Quantity = 100,
                            Price = 120.00,
                            SellPrice = 179.99,
                            WineFamily_Id = Families.Find(f => f.Name == "Rouge").Id,
                            DefaultSupplier_Id = Suppliers.Find(s => s.Id == 1).Id,
                        }, new Product
                        {
                            Name = "UBY N°4 Gros & Petit Manseng Doux",
                            House = "Uby",
                            Year = "2020",
                            Quantity = 600,
                            Price = 4.50,
                            SellPrice = 7.90,
                            WineFamily_Id = Families.Find(f => f.Name == "Blanc").Id,
                            DefaultSupplier_Id = Suppliers.Find(s => s.Id == 2).Id,
                        }, new Product
                        {
                            Name = "La Villa",
                            House = "Château La Sauvageonne",
                            Year = "2019",
                            Quantity = 300,
                            Price = 30.00,
                            SellPrice = 45.00,
                            WineFamily_Id = Families.Find(f => f.Name == "Blanc").Id,
                            DefaultSupplier_Id = Suppliers.Find(s => s.Id == 1).Id,
                        }, new Product
                        {
                            Name = "Paradis",
                            House = "Hennessy",
                            Year = "1908",
                            Quantity = 2,
                            Price = 1200.00,
                            SellPrice = 1500.99,
                            WineFamily_Id = Families.Find(f => f.Name == "Digestif").Id,
                            DefaultSupplier_Id = Suppliers.Find(s => s.Id == 2).Id,
                        }};


                if (!context.Products.Any())
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();

                var Customers = new List<Customer>() {new Customer
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
                        }, new Customer
                        {
                            Name = "Thomas Bangalter",
                            Address = "909 Rue de la revolution",
                            Email = "silverhead@dp.com"
                        }, new Customer
                        {
                            Name = "Guy-Manuel del Homem-Christo",
                            Address = "909 Rue de la revolution",
                            Email = "goldenhead@dp.com"
                        }};


                if (!context.Customers.Any())
                {
                    context.Customers.AddRange(Customers);
                }

                context.SaveChanges();


            }
        }
    }
}