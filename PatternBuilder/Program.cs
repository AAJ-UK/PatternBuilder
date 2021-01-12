using PatternBuilder.BuilderCode;
using PatternBuilder.Items;
using PatternBuilder.Production;
using System;
using System.Collections.Generic;

namespace PatternBuilder
{
    class Program
    {/// <summary>
     /// Builder Pattern
     /// This pattern allows you to construct a class that is a complex collection of smaller objects. 
     /// The collection of smaller objects can be developed 'on the fly' and could get quite complicated.
     /// for instance you may have a number of completely different physical items to add to a box, and you choose the box depending on the weight 
     /// of the items. Each item and the box/envelope itsself might have a cost associated with it. 
     /// 
     /// 
     /// This is a similar but simpler example where you manually select your packaging size, but it would be 
     /// easy to automate the packing selection using this pattern.
     /// What I love is how easy it is to add new products of existing types, new types, packaging that exists, brand new packaging types that 
     /// don't already exist and you get a product out where everything just works.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            // First off take a look at the item classes. They all impliment IItem, which means that every other module that understands IItem
            // knows how to deal with them. Same with the packaging, each package implements IPackaging.
            // In this example I used absract classes for further abstraction, a box never exists on it owm, myt there can be many version of
            // the box that can physically exist.
            // Again every module can handle any box or envelope as long as it implements IPackaging Interface.

            // First off create a concrete class of the product builder
            // this code can return many products, and each product consists of a varying number of items and some form of packaging to put the items in
            // The content of the products are hardcoded in this example, but it would be very easy to have that configurable from a database
            // or an order receiving system.
            ProductBuilder productBuilder = new ProductBuilder();

            // create a number of order. To keep it easy to see,
            // Order 1 is for Product Type 1, Order 2 for Product type 2 etc...
            Product order1 = productBuilder.GetProduct1();
            Product order2 = productBuilder.GetProduct2();
            Product order3 = productBuilder.GetProduct3();
            Product order4 = productBuilder.GetProduct4();
            Product order5 = productBuilder.GetProduct5();

            // we then add all the oders to our basket of orders. You can see that each order is made up
            // of completely different items, but it can still be added to the same basket
            List<Product> basket = new List<Product>
            {
                order1,
                order2,
                order3,
                order4,
                order5
            };

            // then we just display our basket of orders
            foreach (Product p in basket)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Product Name : {0}", p.ProductName);
                foreach (IItem i in p.GetAllItems())
                {
                    Console.WriteLine("Item : {0} Cost {1}", i.Description, i.Cost.ToString("C"));
                }
                Console.WriteLine("Packaging Cost : {0}", p.Packaging.Cost.ToString("C"));
                Console.WriteLine("Total order Cost :{0}", p.GetTotalCost().ToString("C"));
            }

        }
    }
}
