using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IProductReoisitiry
    {
        Products GetByID(int id);
        Products GetName(string name);
        List<Products> GetAll();
        void DeleteByID(int id);
        void Update(Products product);
        void Add(Products product);
        bool ProductsExists(int id);
    }
}
