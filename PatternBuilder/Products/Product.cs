using PatternBuilder.Items;
using PatternBuilder.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Production
{
    class Product : IProduct
    {
        private List<IItem> _Items = new List<IItem>();
        public IPackaging Packaging { get; private set; }

        public string ProductName { get ; set ; }

        

        public void AddItem(IItem Item)
        {
            _Items.Add(Item);
        }

        public void AddPackaging(IPackaging PackagingType)
        {
            Packaging = PackagingType;
        }

        public List<IItem> GetAllItems()
        {
            return _Items;
        }

        public decimal GetTotalCost()
        {
            decimal itemCost = 0M;
            decimal packingCost = 0M;

            foreach (IItem I in _Items)
            {
                itemCost+=I.Cost;
            }

            packingCost = Packaging.Cost;

            return itemCost + packingCost;


        }
    }
}
