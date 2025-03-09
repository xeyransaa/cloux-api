using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductManager
    {
        void Add(Product product);
        void Update(int id, Product product);
        void Remove(int id);
        Task<Product> GetById(int productId);
        List<Product> GetAllProducts();
    }
}
