using Shopping.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Client.Data
{
    public class ProductContext
    {
        public static readonly List<Product> Products = new List<Product> {

        new Product(){
        Name="Iphone X",
        Description="Nice Phone with many cameras",
        ImageFile="product-1.png",
        Price=950.00M,
        Category="Smart Phone"

        },
        new Product(){
         Name="Iphone 14",
        Description="New Phone release in 2022",
        ImageFile="product-2.png",
        Price=1250.00M,
        Category="Smart Phone"

        },
        new Product(){
         Name="Google Home",
        Description="Helps in creating a smart home",
        ImageFile="product-5.png",
        Price=850.00M,
        Category="Smart Home"

        },
        new Product(){
         Name="Samsung Dishwasher",
        Description="New machine released in 2022",
        ImageFile="product-6.png",
        Price=850.00M,
        Category="Kitchen"

        },
        new Product(){
         Name="Samsung S6",
        Description="New Phone release in 2022",
        ImageFile="product-3.png",
        Price=850.00M,
        Category="Smart Phone"

        },
        new Product(){
         Name="Pixel 6XL",
        Description="New Phone release in 2022",
        ImageFile="product-4.png",
        Price=850.00M,
        Category="Smart Phone"

        }
        };
    }
}
