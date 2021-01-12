using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Packaging
{
    public abstract class Envelope : IPackaging
    {
        public decimal Cost { get; set; }

        public string Size { get; protected set; }

        public int SizeX { get; protected set; }
        public int SizeY { get; protected set; }
        public int SizeZ { get; protected set; }
    }
}
