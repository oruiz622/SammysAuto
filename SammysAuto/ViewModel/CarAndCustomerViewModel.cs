﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SammysAuto.Models;

namespace SammysAuto.ViewModel
{
    public class CarAndCustomerViewModel
    {
        public ApplicationUser UserObj { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
