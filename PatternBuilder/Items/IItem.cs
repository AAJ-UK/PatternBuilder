using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Items
{
    interface IItem
    {
        public string Description { get;  }
        public decimal Cost { get; set; }
    }
}
