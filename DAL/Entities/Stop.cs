using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Stop
    {
        public int Id { get; set; }
        public string Coordinates { get; set; }
        public string StopName { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
    }

}
