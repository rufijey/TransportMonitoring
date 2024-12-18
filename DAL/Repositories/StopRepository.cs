using DAL.Entities;
using DAL.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class StopRepository : BaseRepository<Stop>, IStopRepository
    {
        public StopRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Stop> GetStopsByName(string stopName)
        {
            return _set.Where(s => s.StopName.Contains(stopName)).ToList();
        }

        public Stop GetStopByCoordinates(string coordinates)
        {
            return _set.FirstOrDefault(s => s.Coordinates == coordinates);
        }
    }
}
