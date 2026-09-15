using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.DTOS;
using WebApplication2.Models;
using WebApplication2.services.Interfaces;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        //bai 1
        [HttpGet("")]
        public List<Product> ListProduc()
        {
            var bai1 = _productService.ListProduc();
            return bai1;
        }
        //bai 2
        [HttpGet("{id}")]
        public Product Search(int id)
        {
            var bai2 = _productService.Search(id);
            return bai2;
        }
        //bai 3
        [HttpPost("")]
        public Product AddProduc(NewProduct product)
        {
            var bai3 = _productService.AddProduc(product);
            return bai3;
        }
        // bai 4
        [HttpPut("{id}")]
        public bool UpDateProduc(int id, UpdateProduct updateProduct)
        {
            var bai4 = _productService.UpDateProduc(id,updateProduct);
            return bai4;
        }
        //bai 5
        [HttpDelete("{id}")]
        public bool DeleteProduc(int id)
        {
            var bai5 = _productService.DeleteProduc(id);
            return bai5;
        }
    }
}
