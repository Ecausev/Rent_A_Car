using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rent_A_Car.Models
{
    public class VehiclesViewModel : VehicleViewModel
    {
        public List<Model.Vehicles.Vehicles> Vehicles { get; set; }
    }
}