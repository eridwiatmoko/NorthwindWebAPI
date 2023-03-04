﻿using Northwind.Domain.Base;
using Northwind.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductPhotoServices> _lazyProductPhotoServices;
        private readonly Lazy<IUtilityService> _lazyUtilityService;
        private readonly Lazy<ISupplierServices> _lazySupplierServices;
        public ServiceManager(IRepositoryManager repositoryManager, IUtilityService _lazyUtilityService)
        {
            _lazyProductPhotoServices = new Lazy<IProductPhotoServices>(() => new ProductPhotoServices(repositoryManager, _lazyUtilityService));
            _lazySupplierServices = new Lazy<ISupplierServices>(() => new SupplierServices(repositoryManager));
        }
        public ISupplierServices SupplierServices => _lazySupplierServices.Value;

        public IProductPhotoServices ProductPhotoServices => _lazyProductPhotoServices.Value;
    }
}
