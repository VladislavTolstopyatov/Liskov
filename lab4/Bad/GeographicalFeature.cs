using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bad
{
    public class GeographicalFeature
    {
        protected string? Name { get; set; }

        public GeographicalFeature(string name) { this.Name = name; }


        public virtual string GetDescription()
        {
            return $"Это географический объект.{Name}";
        }

        public virtual void TourToTourist()
        {
            Console.WriteLine($"Турист посетил географический объект {Name}");
        }
    }
}
