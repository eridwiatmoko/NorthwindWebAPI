﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Services.Abstraction
{
    public interface IServiceManager
    {
        IProductPhotoServices ProductPhotoServices { get; }
        ISupplierServices SupplierServices { get; }
    }
}
