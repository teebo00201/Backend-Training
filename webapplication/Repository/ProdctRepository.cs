using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Interfaces
{
    public class ProdctRepository : IProductReoisitiry
    {
        private readonly NORTHWNDContext _context;
        public ProdctRepository(NORTHWNDContext context)
        {
            _context = context;
        }
        public void Add(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteByID(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Products> GetAll()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Products GetByID(int id)
        {
            return _context.Products.Find(id);
        }
        public Products GetName(string name)
        {
            return _context.Products.Find(name);
        }
        public bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

        public void Update(Database.Models.Products product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
