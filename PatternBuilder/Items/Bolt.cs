using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Items
{
    public abstract class Bolt : IItem
    {
        public string Description { get;  protected set; }
        public decimal Cost { get; set; }
    }
}
