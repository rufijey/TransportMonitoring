using DAL.Entities;
using DAL.Repositories.Intefaces;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class RouteRepository : BaseRepository<Route>, IRouteRepository
    {
        public RouteRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Route> GetRoutesByNumber(int routeNumber)
        {
            return _set.Where(r => r.RouteNumber == routeNumber).ToList();
        }
    }
}
