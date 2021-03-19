using Lessons.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lessons.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;}

        IEnumerable<Car> getFavCars { get; set; }

        Car getObjectCar(int carId);
    }
}
