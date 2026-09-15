using WebApplication2.DTOS;
using WebApplication2.Models;
namespace WebApplication2.services.Interfaces

{
    public interface IProductService
    {
        //bai 1
        List<Product> ListProduc();
        //bai 2
        Product Search(int id);
        //bai 3
        Product AddProduc(NewProduct product);
        //bai 4
        bool UpDateProduc(int id, UpdateProduct updateProduct);
        //bai 5
        bool DeleteProduc(int id);
    }   
}
