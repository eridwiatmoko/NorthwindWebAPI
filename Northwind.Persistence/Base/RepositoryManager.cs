using Northwind.Domain.Base;
using Northwind.Domain.Repositories;
using Northwind.Persistence.Repositories;
using Northwind.Persistence.RepositoryContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Persistence.Base
{
    public class RepositoryManager : IRepositoryManager
    {
        private AdoDbContext _adoContext;
        private IRegionRepository _regionRepository;
        private IProductRepository _pruductRepository;
        private Lazy<IProductPhotoRepository> _productPhotoRepositoryLazy;
        private Lazy<ISupplierRepository> _supplierRepositoryLazy;
        private Lazy<IUserRepository> _userRepositoryLazy;
        //private Lazy<IRegionRepository> _regionRepositoryLazy;

        public RepositoryManager(AdoDbContext adoContext)
        {
            _adoContext = adoContext;
            _productPhotoRepositoryLazy = new Lazy<IProductPhotoRepository>(() => new ProductPhotoRepository(adoContext));
            _supplierRepositoryLazy = new Lazy<ISupplierRepository>(() => new SupplierRepository(adoContext));
            _userRepositoryLazy = new Lazy<IUserRepository>(() => new UsersRepository(adoContext));
            //_regionRepositoryLazy = new Lazy<IRegionRepository>(()=> new RegionRepository(adoContext));
        }

        //public IRegionRepository RegionRepository => _regionRepositoryLazy.Value;

        public IRegionRepository RegionRepository
        {
            get
            {
                if (_regionRepository == null)
                {
                    _regionRepository = new RegionRepository(_adoContext);
                }
                return _regionRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (_pruductRepository == null) 
                {
                    _pruductRepository = new ProductRepository(_adoContext);
                }
                return _pruductRepository;
            }
        }

        public ISupplierRepository SupplierRepository => _supplierRepositoryLazy.Value;


        public IProductPhotoRepository ProductPhotoRepository => _productPhotoRepositoryLazy.Value;
        public IUserRepository UserRepository => _userRepositoryLazy.Value;
    }
}
