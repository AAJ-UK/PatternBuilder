using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Packaging
{
    class BoxStandard : Box
    {
        public BoxStandard()
        {
            Cost = 1.23M;
            Size = "standard";
            SizeX = 10;
            SizeY = 10;
            SizeZ = 10;


        }
    }
}
