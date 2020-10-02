using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    public interface IVerkstad
    { 
        bool AddVehicle(Vehicle vehicle);
        void RemoveVehicle(Vehicle vehicle);

        List<Vehicle> GetListOfVehicles();

    }
}
