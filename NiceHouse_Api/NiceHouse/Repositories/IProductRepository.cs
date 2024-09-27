using NiceHouse.Models;

namespace NiceHouse.Repositories
{
    public interface IProductRepository : IRepository<Products>
    {
        void Add(Products product);
        void Update(Products product);
        void Delete(int id);
        IEnumerable<Products> GetAll();
        Products GetById(int id);
        //search by rent,rooms,price, address
        IEnumerable<Products> Search(float rent, float price, int rooms, string address, bool isRent);

    }
}
