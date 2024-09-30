using Microsoft.EntityFrameworkCore;
using NiceHouse.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace NiceHouse.Repositories
{
    public class ProductRepository : Repository<Products>, IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context) : base(context)
        {
            _context = context;

        }

        public void Add(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Products.Remove(_context.Products.Find(id));
        }

        public IEnumerable<Products> GetAll()
        {
            return _context.Products;
        }

        public Products GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Insert(Products entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Products> Search(float maxRent, float maxPrice, int rooms, string address, bool isRent)
        {
            var products = _context.Products.AsQueryable();

            if (maxRent > 0)
            {
                products = products.Where(p => p.Rent <= maxRent);
            }

            if (maxPrice > 0)
            {
                products = products.Where(p => p.Price <= maxPrice);
            }

            if (rooms > 0)
            {
                products = products.Where(p => p.Rooms == rooms);
            }

            if (!string.IsNullOrEmpty(address))
            {
                products = products.Where(p => p.Address.Contains(address));
            }

            products = products.Where(p => p.IsRent == isRent);

            products = products.OrderBy(p => p.Price);

            return products.Include(p => p.Images).ToList();
        }

        public void Update(Products product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
