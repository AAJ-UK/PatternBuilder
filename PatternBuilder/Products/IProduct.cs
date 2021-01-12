using PatternBuilder.Items;
using PatternBuilder.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Production
{
    interface IProduct
    {
        public string ProductName { get; set; }
        List<IItem> GetAllItems();
        public IPackaging Packaging { get;}
        decimal GetTotalCost();

        void AddItem(IItem Item);
        void AddPackaging(IPackaging PackagingType);

    }
}
