using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Interfaces
{
    public class CustomersRepository : ICustomersReoisitiry
    {
        private readonly NORTHWNDContext _context;
        public CustomersRepository(NORTHWNDContext context)
        {
             _context = context;
        }
        
        public void Add(Customers customer)
        {

            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

           
        public void DeleteByID(string id)
        {
            var customer = _context.Customers.Find(id);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public List<Customers> GetAll()
        {
            try
            {
                return _context.Customers.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Customers GetByID(string id)
        {
            return _context.Customers.Find(id);
        }

        public Customers GetName(string name)
        {
            return _context.Customers.Find(name);
        }

        public bool CustomersExists(string id)
        {
            return _context.Customers.Any(e => e.CustomersId == id);
        }

        public void Update(Customers customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
