using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFProductDal : EFEntityRepositary<ClouxDbContext, Product>, IProductDal
    {

        public async Task<Product> GetById(int id)
        {
            using ClouxDbContext context = new();
            var product = context.Products
              .Where(c => !c.IsDeleted && c.Id == id)
              .FirstOrDefaultAsync();
            return await product;
        }

        public List<Product> GetProducts()
        {
            using ClouxDbContext context = new();
            var products = context.Products
              .Where(c => !c.IsDeleted)
              .ToList();
            return products;
        }


        public void UpdateProduct(int id, Product product )
        {
            using ClouxDbContext context = new();
            product.Id = id;


            context.Products.Update(product);
            context.SaveChanges();
        }

        public void AddProduct(Product product) { 
        
            using ClouxDbContext context = new();
            context.Products.Add(product);
            context.SaveChanges();
                  
            
           
        }

        public void DeleteProduct(int id)
        {
            using ClouxDbContext context = new();
            var deletedProduct = context.Products.Where(g => g.Id == id).FirstOrDefault();
            deletedProduct.IsDeleted = true;
        }
    }
}
