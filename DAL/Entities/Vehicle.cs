using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int RouteNumber { get; set; }
        public int? DriverId { get; set; }
        public Driver Driver { get; set; }
        public int? RouteId { get; set; }
        public Route Route { get; set; }

    }
}
