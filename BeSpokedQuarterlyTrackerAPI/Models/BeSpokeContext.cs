using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BeSpokedQuarterlyTrackerAPI.Models
{
    /// <summary>
    /// BeSpokeContext - used to mimic a Database in the absense of one. Creates a list of Datalayer object outlined in
    /// the requirements. This object is used as a singleton, Dependancy Injected into the service in Startup.cs. 
    /// </summary>
    public class BeSpokeContext
    {
        public List<Customer> Customers { get; set; }
        public List<Products> Products { get; set; }
        public List<SalesPerson> SalesPersons { get; set; }
        public List<Sales> Sales { get; set; }
        public List<Discount> Discounts { get; set; }

        public BeSpokeContext()
        {
            Customers = new List<Customer>
            {
                new Customer
                {
                    CustomerId = 1,
                    Address = "123 main st",
                    Phone = "954 993 2637",
                    FirstName = "Bob",
                    LastName = "Johnson",
                    StartDate = new DateTime(2020, 1, 1)
                },
                new Customer
                {
                    CustomerId = 2,
                    Address = "465 wally way",
                    Phone = "852 654 2135",
                    FirstName = "John",
                    LastName = "Jacobs",
                    StartDate = new DateTime(2019, 3, 10)
                },
                new Customer
                {
                    CustomerId = 3,
                    Address = "3050 Semora blvd. ",
                    Phone = "123-123-2342",
                    FirstName = "laura",
                    LastName = "Englewood",
                    StartDate = new DateTime(2021, 8, 5)
                },
                new Customer
                {
                    CustomerId = 4,
                    Address = "23 spruce ln",
                    Phone = "4655453224",
                    FirstName = "Wilfredys",
                    LastName = "Dominiquez",
                    StartDate = new DateTime(2020, 6, 1)
                },
                new Customer
                {
                    CustomerId = 5,
                    Address = "457 Calle Ocho",
                    Phone = "305-305-3055",
                    FirstName = "Armando",
                    LastName = "Perez",
                    StartDate = new DateTime(2017, 11, 12)
                }
            };

            Products = new List<Products>
            {
                new Products
                {
                    Manufacturer = "Specialized",
                    Name = "Sohoku-1",
                    Style = "Racing",
                    ProductId = 1,
                    PurchasePrice = 529.99m,
                    CommissionPct = 6,
                    SalePrice = 1029.99m,
                    QtyOnHand = 8
                },
                new Products
                {
                    Manufacturer = "Pinarello",
                    Name = "Prince",
                    Style = "Racing",
                    ProductId = 2,
                    PurchasePrice = 349m,
                    CommissionPct = 2,
                    SalePrice = 629m,
                    QtyOnHand = 50
                },
                new Products
                {
                    Manufacturer = "De Rosa",
                    Name = "Fushimi-2",
                    Style = "Mountain",
                    ProductId = 3,
                    PurchasePrice = 520m,
                    CommissionPct = 10,
                    SalePrice = 760m,
                    QtyOnHand = 10
                },
                new Products
                {
                    Manufacturer = "Anchor",
                    Name = "RFX8",
                    Style = "Street",
                    ProductId = 4,
                    PurchasePrice = 299m,
                    CommissionPct = 1,
                    SalePrice = 399m,
                    QtyOnHand = 100
                },
                new Products
                {
                    Manufacturer = "SCOTT Sports SA",
                    Name = "Addict 2011",
                    Style = "Racing",
                    ProductId = 5,
                    PurchasePrice = 299m,
                    CommissionPct = 1,
                    SalePrice = 399m,
                    QtyOnHand = 100
                },
            };

            SalesPersons = new List<SalesPerson>
            {
                new SalesPerson
                {
                    FirstName = "John",
                    LastName = "Dorian",
                    Address = "8135 N West Broad St",
                    Manager = "Davey Jones",
                    Phone = "954 954 9945",
                    SalespersonId = 1,
                    StartDate = new DateTime(2019, 11, 2),
                },
                new SalesPerson
                {
                    FirstName = "Christopher",
                    LastName = "Turk",
                    Address = "8135 N West Broad St",
                    Manager = "Davey Jones",
                    Phone = "954 954 9946",
                    SalespersonId = 2,
                    StartDate = new DateTime(2020, 2, 12),
                },
                new SalesPerson
                {
                    FirstName = "Perry",
                    LastName = "Cox",
                    Address = "8135 N Westin Rd",
                    Manager = "Jimmy Shula",
                    Phone = "954 452 8422",
                    SalespersonId = 3,
                    StartDate = new DateTime(2015, 4, 10),
                },
            };

            Sales = new List<Sales>
            {
                new Sales
                {
                    SalesDate = new DateTime(2021, 11, 15, 11, 11, 0),
                    Customer = Customers.FirstOrDefault(x => x.CustomerId == 1),
                    Product = Products.FirstOrDefault(x => x.ProductId == 1),
                    SalesPerson = SalesPersons.FirstOrDefault(x => x.SalespersonId == 2),
                    SalesId = 1,
                    SalePrice = 1029.99m,
                    CommissionAwarded = 129.99m
                },
                new Sales
                {
                    SalesDate = new DateTime(2021, 11, 15, 13, 11, 0),
                    Customer = Customers.FirstOrDefault(x => x.CustomerId == 2),
                    Product = Products.FirstOrDefault(x => x.ProductId == 2),
                    SalesPerson = SalesPersons.FirstOrDefault(x => x.SalespersonId == 2),
                    SalesId = 2,
                    SalePrice = 500.00m,
                    CommissionAwarded = 10m
                },
                new Sales
                {
                    SalesDate = new DateTime(2021, 11, 15, 14, 11, 0),
                    Customer = Customers.FirstOrDefault(x => x.CustomerId == 3),
                    Product = Products.FirstOrDefault(x => x.ProductId == 3),
                    SalesPerson = SalesPersons.FirstOrDefault(x => x.SalespersonId == 1),
                    SalesId = 3,
                    SalePrice = 700m,
                    CommissionAwarded = 70m
                },
                new Sales
                {
                    SalesDate = new DateTime(2021, 11, 16, 8, 11, 0),
                    Customer = Customers.FirstOrDefault(x => x.CustomerId == 3),
                    Product = Products.FirstOrDefault(x => x.ProductId == 1),
                    SalesPerson = SalesPersons.FirstOrDefault(x => x.SalespersonId == 3),
                    SalesId = 4,
                    SalePrice = 1029.99m,
                    CommissionAwarded = 61.74m
                },
            };

            Discounts = new List<Discount>
            {
                new Discount
                {
                    Product = Products.FirstOrDefault(x => x.ProductId % 2 == 0),
                    BeginDate = new DateTime(2021, 12, 01),
                    EndDate = new DateTime(2021, 12, 31),
                    DiscountId = 1,
                    DiscountPct = 20
                },
                new Discount
                {
                    Product = Products.FirstOrDefault(x => x.ProductId == 5),
                    BeginDate = new DateTime(2021, 11, 01),
                    EndDate = new DateTime(2021, 11, 30),
                    DiscountId = 2,
                    DiscountPct = 50
                },
                new Discount
                {
                    Product = Products.FirstOrDefault(x => x.ProductId == 5),
                    BeginDate = new DateTime(2021, 12, 01),
                    EndDate = new DateTime(2021, 12, 15),
                    DiscountId = 3,
                    DiscountPct = 7
                },

            };
        }
    }
}