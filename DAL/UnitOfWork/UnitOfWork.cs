using DAL.EF;
using DAL.Entities;
using DAL.Repositories;
using DAL.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        private DriverRepository _driverRepository;
        private RouteRepository _routeRepository;
        private StopRepository _stopRepository;
        private VehicleRepository _vehicleRepository;

        public UnitOfWork(DbContextOptions options)
        {
            _dbContext = new DbContext(options);
        }

        public IDriverRepository Drivers
        {
            get
            {
                if (_driverRepository == null)
                    _driverRepository = new DriverRepository(_dbContext);
                return _driverRepository;
            }
        }

        public IRouteRepository Routes
        {
            get
            {
                if (_routeRepository == null)
                    _routeRepository = new RouteRepository(_dbContext);
                return _routeRepository;
            }
        }

        public IStopRepository Stops
        {
            get
            {
                if (_stopRepository == null)
                    _stopRepository = new StopRepository(_dbContext);
                return _stopRepository;
            }
        }

        public IVehicleRepository Vehicles
        {
            get
            {
                if (_vehicleRepository == null)
                    _vehicleRepository = new VehicleRepository(_dbContext);
                return _vehicleRepository;
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
