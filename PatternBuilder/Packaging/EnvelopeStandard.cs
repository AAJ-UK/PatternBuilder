using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Packaging
{
    class EnvelopeStandard : Envelope
    {
        public EnvelopeStandard()
        {
            Cost = 1.23M;
            Size = "standard";
            SizeX = 5;
            SizeY = 5;
            SizeZ = 5;
        }

     
    }
}
