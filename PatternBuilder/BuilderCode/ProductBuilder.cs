using PatternBuilder.Items;
using PatternBuilder.Packaging;
using PatternBuilder.Production;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.BuilderCode
{
    /// <summary>
    /// Provide a number of methods that build up a product and return it
    /// This could be replaced with a system to allow the user to build the products up
    /// </summary>
    class ProductBuilder
    {

        public Product GetProduct1()
        {
            Product p = new Product
            {
                ProductName = "Product Type 1"
            };
            p.AddItem(new Bolt8mm());
            p.AddItem(new Nut8mm());
            p.AddPackaging(new EnvelopeStandard());
            return p;
        }

        public Product GetProduct2()
        {
            Product p = new Product
            {
                ProductName = "Product Type 2"
            };
            p.AddItem(new Bolt10mm());
            p.AddItem(new Nut10mm());
            p.AddPackaging(new BoxStandard());
            return p;
        }
        public Product GetProduct3()
        {
            Product p = new Product
            {
                ProductName = "Product Type 3"
            };
            p.AddItem(new Bolt8mm());
            p.AddItem(new Nut10mm());
            p.AddPackaging(new BoxStandard());
            return p;
        }
        public Product GetProduct4()
        {
            Product p = new Product
            {
                ProductName = "Product Type 4"
            };
            p.AddItem(new Bolt8mm());
            p.AddItem(new Nut10mm());
            p.AddPackaging(new EnvelopeStandard());
            return p;
        }
        public Product GetProduct5()
        {
            Product p = new Product
            {
                ProductName = "Product Type 5"
            };
            p.AddItem(new Bolt8mm());
            p.AddPackaging(new EnvelopeSmall());
            return p;
        }
    }
}
