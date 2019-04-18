﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SammysAuto.Models;

namespace SammysAuto.ViewModel
{
    public class CarAndServicesViewModel
    {
  
        public int carId { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Style { get; set; }
        public int Year { get; set; }
      



        public Car CarObj { get; set; }
        public Service NewServiceObj { get; set; }
        public IEnumerable<Service> PastServicesObj { get; set; }
        public List<ServiceType> ServiceTypesObj { get; set; }

    }
}
