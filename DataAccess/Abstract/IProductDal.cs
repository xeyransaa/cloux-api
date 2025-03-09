using Core;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepositary<Product>
    {
        List<Product> GetProducts();


        Task<Product> GetById(int id);

        public void AddProduct(Product product);
        public void UpdateProduct(int id, Product product );
        public void DeleteProduct(int id);
        
    }
}
