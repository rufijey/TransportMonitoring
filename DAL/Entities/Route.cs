using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Route
    {
        public int Id { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int RouteNumber { get; set; }
        public ICollection<Stop> Stops { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }

}
