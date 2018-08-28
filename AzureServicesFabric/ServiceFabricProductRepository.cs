using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce1.ProductCatalog.Model;
using Microsoft.ServiceFabric.Data.Collections;
using Microsoft.ServiceFabric.Data;

namespace ECommerce1.ProductCatalog
{
    class ServiceFabricProductRepository : IProductRepository
    {
        private readonly IReliableStateManager _stateManger;

       public ServiceFabricProductRepository(IReliableStateManager stateManger)
        {
            _stateManger = stateManger;

        }

            
        public async Task AddProduct(Product product)
        {
            var products = await _stateManger.GetOrAddAsync<IReliableDictionary<Guid, Product>>("products");//IReliable Dictionary leaves in Data.Collections
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
