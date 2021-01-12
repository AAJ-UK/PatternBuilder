using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilder.Packaging
{
    class EnvelopeSmall : Envelope
    {
        public EnvelopeSmall()
        {
            Cost = 0.86M;
            Size = "small";
            SizeX = 2;
            SizeY = 2;
            SizeZ = 2;


        }
    }
}
