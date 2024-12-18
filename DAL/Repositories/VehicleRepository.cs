using DAL.Entities;
using DAL.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Vehicle> GetVehiclesByStatus(string status)
        {
            return _set.Where(v => v.status == status).ToList();
        }
    }
}
