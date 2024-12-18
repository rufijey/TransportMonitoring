using System;
using DAL.Repositories.Intefaces;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDriverRepository Drivers { get; }
        IRouteRepository Routes { get; }
        IStopRepository Stops { get; }
        IVehicleRepository Vehicles { get; }

        void Save();
    }
}
