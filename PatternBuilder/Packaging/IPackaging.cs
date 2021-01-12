using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Packaging
{
    interface IPackaging
    {
        public decimal Cost { get; set; }
        public string Size { get; }
    }
}
