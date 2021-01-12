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
    /// 
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ProductBuilder productBuilder = new ProductBuilder();

            Product order1 = productBuilder.GetProduct1();
            Product order2 = productBuilder.GetProduct2();
            Product order3 = productBuilder.GetProduct3();
            Product order4 = productBuilder.GetProduct4();
            Product order5 = productBuilder.GetProduct5();

            List<Product> orders = new List<Product>();
            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);
            orders.Add(order4);
            orders.Add(order5);


            foreach (Product o in orders)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Product Name : {0}",o.ProductName);
                foreach (IItem i in o.GetAllItems())
                {
                    Console.WriteLine("Item : {0} Cost {1}", i.Description, i.Cost.ToString());
                }
                Console.WriteLine("Packaging Cost : {0}", o.Packaging.Cost);
                Console.WriteLine("Total order Cost :{0}", o.GetTotalCost());
            }

        }
    }
}
