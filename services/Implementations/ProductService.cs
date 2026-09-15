using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using WebApplication2.Data;
using WebApplication2.DTOS;
using WebApplication2.Models;
using WebApplication2.services.Interfaces;

namespace WebApplication2.services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context; 
        }
        //bai 1
        public List<Product> ListProduc()
        {
            var bai1 = _context.Products.ToList();
            return bai1;

        }
        //bai 2
        public Product Search(int id)
        {
            var bai2 = _context.Products.FirstOrDefault(p => p.Id == id);
            return bai2;
        }
        //bai 3
        public Product AddProduc(NewProduct product)
        {
            var bai3 = new Product
            {
                Name = product.Name,
                CategoryId = product.CategoryId,
                Price = product.Price,
                Stock = product.Stock
            };
            _context.Products.Add(bai3);
            _context.SaveChanges();
            return bai3;
        }
        //bai 4
        public bool UpDateProduc(int id, UpdateProduct updateProduct)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product is null)
            {
                return false;
            }
            product.Name = updateProduct.Name;
            product.Price = updateProduct.Price;
            product.Stock = updateProduct.Stock;
            _context.SaveChanges();

            return true;
        }

        // bai 5
       public bool DeleteProduc(int id)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product is null)
            {
                return false;
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;
        }
    }
}
