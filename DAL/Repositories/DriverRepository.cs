using DAL.Entities;
using DAL.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class DriverRepository : BaseRepository<Driver>, IDriverRepository
    {
        public DriverRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Driver> GetDriversByName(string name)
        {
            return _set.Where(d => d.name.Contains(name)).ToList();
        }
    }
}
