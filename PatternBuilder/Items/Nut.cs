using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Items
{
    /// <summary>
    /// Define an abstract nut. Any other nut that inherits this class will by default implement IItem
    /// </summary>
    public abstract class Nut : IItem
    {
        public string Description { get; protected set; }
        public decimal Cost { get; set; }
    }
}
