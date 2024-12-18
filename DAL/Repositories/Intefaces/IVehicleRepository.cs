﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Intefaces
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        IEnumerable<Vehicle> GetVehiclesByStatus(string status);
    }
}
