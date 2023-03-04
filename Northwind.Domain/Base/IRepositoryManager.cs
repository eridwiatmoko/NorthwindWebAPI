﻿using Northwind.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Domain.Base
{
    public interface IRepositoryManager
    {
        IRegionRepository RegionRepository { get; }
        IProductRepository ProductRepository { get; }
        ISupplierRepository SupplierRepository { get; }
        IProductPhotoRepository ProductPhotoRepository { get; }
        IUserRepository UserRepository { get; }
    }
}
