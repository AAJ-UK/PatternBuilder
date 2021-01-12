using PatternBuilder.BuilderCode;
using PatternBuilder.Items;
using PatternBuilder.Packaging;
using PatternBuilder.Production;
using System;
using System.Collections.Generic;

namespace PatternBuilder
{
    class Program
    {/// <summary>
    /// Builder Pattern
    /// This pattern allows you to construct collections of objects. The collections can get quite complicated
    /// for instance you may have a number of completely different items to add to a box, and you choose the box depending on the weight 
    /// of the items. Each itam and the box might have a cost assoctiated. 
    /// This is an example but you manually select your packaging size, but it would be easy to automate using this pattern.
    /// What I love is how each it is to add new products of existing types, new type, packaging that exists, brand new packaging types that 
    /// don't already exist and everything else just works.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            // First off look at the items. They all impliment IItem, which means that ebery other module
            // knows how to deal with them. Same with the packaging, each implements IPackaging.
            // Again every module can handle any box or envelope as long as it implements IPackaging.

            // first off create a concrete class of the product builder
            // this code can return many products, and each product consists off a number of items and some form of packaging
            // The Makeup of the products is hardcoded in tis example, but it would be very easy to have that configurable
            // from a database
            ProductBuilder productBuilder = new ProductBuilder();

            // create a nu,ber of order. To keep it easy to see,
            // Order 1 is for Product Type 1, Order 2 for Product type 2 etc...
            Product order1 = productBuilder.GetProduct1();
            Product order2 = productBuilder.GetProduct2();
            Product order3 = productBuilder.GetProduct3();
            Product order4 = productBuilder.GetProduct4();
            Product order5 = productBuilder.GetProduct5();

            // we then add all the oders to our basket of orders. You can see that each order is made up
            // of completely different items, but it can still be added to the same basket
            List<Product> basket = new List<Product>();
            basket.Add(order1);
            basket.Add(order2);
            basket.Add(order3);
            basket.Add(order4);
            basket.Add(order5);

            // then we just display our basket of orders
            foreach (Product p in basket)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Product Name : {0}",p.ProductName);
                foreach (IItem i in p.GetAllItems())
                {
                    Console.WriteLine("Item : {0} Cost {1}", i.Description, i.Cost.ToString());
                }
                Console.WriteLine("Packaging Cost : {0}", p.Packaging.Cost);
                Console.WriteLine("Total order Cost :{0}", p.GetTotalCost());
            }

        }
    }
}
