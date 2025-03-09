using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager: IProductManager
    {
        private readonly IProductDal _dal;

        public ProductManager(IProductDal dal)
        {
            _dal = dal;
        }

        public void Add(Product product)
        {
            _dal.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _dal.GetProducts();
        }

        public void Remove(int id)
        {
            var product = _dal.Get(c => c.Id == id);
            product.IsDeleted = true;
            _dal.Update(product);
        }

        public void Update(int id, Product product)
        {
            _dal.UpdateProduct(id, product);
        }

        Task<Product> IProductManager.GetById(int productId)
        {
            return _dal.GetById(productId);
        }
    }
}
