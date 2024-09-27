using NiceHouse.Models;

namespace NiceHouse.Services
{
    public interface IProductService
    {
        void AddProduct(Products product);
        void DeleteProduct(int id);
        IEnumerable<Products> GetAllProducts();
        Products GetProductById(int id);
        void UpdateProduct(Products product);
        IEnumerable<Products> SearchProducts(float rent, float price, int rooms, string address, bool isRent);
    }
}
