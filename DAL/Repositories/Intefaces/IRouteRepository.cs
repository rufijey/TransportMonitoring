using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Intefaces
{
    public interface IRouteRepository : IRepository<Route>
    {
        IEnumerable<Route> GetRoutesByNumber(int routeNumber);

    }
}
