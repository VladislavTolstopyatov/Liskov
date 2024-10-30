using Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good
{
    public class OceanAbyss : GeographicalFeature
    {
        public OceanAbyss(string name) : base(name)
        {
        }

        public override void TourToTourist()
        {
            throw new Exception("Невозможно побывать на дне океанской бездны!");
        }

    }
}
