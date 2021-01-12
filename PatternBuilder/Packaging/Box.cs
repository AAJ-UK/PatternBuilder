using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Packaging
{
    /// <summary>
    /// Define an abstract box. Any other box that inherits this class will by default implement IPackaging
    /// </summary>
    public abstract class Box : IPackaging
    {
        public decimal Cost { get ; set ; }

        public string Size { get ; protected set; }

        public int SizeX { get; protected set; }
        public int SizeY { get; protected set; }
        public int SizeZ { get; protected set; }
    }
}
