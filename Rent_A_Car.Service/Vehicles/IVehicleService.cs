using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car.Service.Vehicles
{
    public interface IVehicleService
    {
        List<Model.Vehicles.Vehicles> GetAll();
        void Add(Model.Vehicles.Vehicles vehicles);
    }
}
