﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02.Entities.Interfaces
{
    public interface ICarWash
    {
        void WashCar(Car car);
        void WashTrailer(Truck truck);
    }
}
