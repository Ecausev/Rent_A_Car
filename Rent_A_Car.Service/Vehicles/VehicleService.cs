using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car.Service.Vehicles
{
    public class VehicleService : IVehicleService
    {
        private IVehicleRepository _VehicleRepository;

        public List<Model.Vehicles.Vehicles> GetAll()
        {
            return _VehicleRepository.FindAll().ToList();
        }
    }
}
