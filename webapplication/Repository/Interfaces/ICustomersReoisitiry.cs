using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ICustomersReoisitiry
    {
        Customers GetByID(string id);
        Customers GetName(string name);
        List<Customers> GetAll();
        void DeleteByID(string id);
        void Update(Customers customer);
        void Add(Customers customer);
        bool CustomersExists(string id);
    }
}
