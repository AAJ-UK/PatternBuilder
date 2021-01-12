using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Items
{
    /// <summary>
    /// Define an abstract bolt. Any other bolt that inherits this class will by default implement IItem
    /// </summary>
    public abstract class Bolt : IItem
    {

        public string Description { get; protected set; } = "";
        public decimal Cost { get; set; } = 0;
    }
}
