using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Data
{
    public class ProductContext
    {
        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);
            Products = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);
            SeedData(Products);
        }

        private void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(x => true).Any();
            if (!existProduct) {
                productCollection.InsertManyAsync(getPreConfiguredProducts());
            }
        }

        private IEnumerable<Product> getPreConfiguredProducts()
        {
            return new List<Product> {
            new Product()
            {
                Name = "Iphone X",
                Description = "Nice Phone with many cameras",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = "Smart Phone"

            }
            ,
            new Product()
            {
                Name = "Iphone 14",
                Description = "New Phone release in 2022",
                ImageFile = "product-2.png",
                Price = 1250.00M,
                Category = "Smart Phone"

            },
            new Product()
            {
                Name = "Updated again Google Home Display",
                Description = "Helps in creating a smart home",
                ImageFile = "product-5.png",
                Price = 850.00M,
                Category = "Smart Home"

            },
            new Product()
            {
                Name = "Samsung Dishwasher",
                Description = "New machine released in 2022",
                ImageFile = "product-6.png",
                Price = 850.00M,
                Category = "Kitchen"

            },
            new Product()
            {
                Name = "Samsung S6",
                Description = "New Phone release in 2022",
                ImageFile = "product-3.png",
                Price = 850.00M,
                Category = "Smart Phone"

            },
            new Product()
            {
                Name = "Pixel 6XL hna",
                Description = "New Phone release in 2022",
                ImageFile = "product-4.png",
                Price = 850.00M,
                Category = "Smart Phone"

            }
            };
        }

        public IMongoCollection<Product> Products { get;}
        //public List<Product> Products = new List<Product> {

        //new Product(){
        //Name="Iphone X",
        //Description="Nice Phone with many cameras",
        //ImageFile="product-1.png",
        //Price=950.00M,
        //Category="Smart Phone"

        //},
        //new Product(){
        // Name="Iphone 14",
        //Description="New Phone release in 2022",
        //ImageFile="product-2.png",
        //Price=1250.00M,
        //Category="Smart Phone"

        //},
        //new Product(){
        // Name="Updated again Google Home Display",
        //Description="Helps in creating a smart home",
        //ImageFile="product-5.png",
        //Price=850.00M,
        //Category="Smart Home"

        //},
        //new Product(){
        // Name="Samsung Dishwasher",
        //Description="New machine released in 2022",
        //ImageFile="product-6.png",
        //Price=850.00M,
        //Category="Kitchen"

        //},
        //new Product(){
        // Name="Samsung S6",
        //Description="New Phone release in 2022",
        //ImageFile="product-3.png",
        //Price=850.00M,
        //Category="Smart Phone"

        //},
        //new Product(){
        // Name="Pixel 6XL",
        //Description="New Phone release in 2022",
        //ImageFile="product-4.png",
        //Price=850.00M,
        //Category="Smart Phone"

        //}
        //};
    }
}
