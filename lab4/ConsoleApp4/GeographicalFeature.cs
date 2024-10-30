using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good
{
    public class GeographicalFeature : ITourToTourist
    {
        protected string? Name { get; set; }

        public GeographicalFeature(string name) { this.Name = name; }

        public string GetDescription()
        {
            return $"Это географический объект.{Name}";
        }

        public virtual void TourToTourist()
        {
        }
    }
}
