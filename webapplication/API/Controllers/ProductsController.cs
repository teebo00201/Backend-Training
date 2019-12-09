using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database.Models;
using Repository;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReoisitiry _ProductRepositiry;
        public ProductsController(IProductReoisitiry ProductRepositiry)
        {
            _ProductRepositiry = ProductRepositiry;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<List<Products>> GetProducts()
        {
            return _ProductRepositiry.GetAll();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<Products> GetProducts(int id)
        {
            var products = _ProductRepositiry.GetByID(id);

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public IActionResult PutProducts(int id, Products products)
        {
            if (id != products.ProductId)
            {
                return BadRequest();
            }

            try
            {
                _ProductRepositiry.Update(products);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_ProductRepositiry.ProductsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<Products> PostProducts(Products products)
        {
            _ProductRepositiry.Add(products);

            return CreatedAtAction("GetProducts", new { id = products.ProductId }, products);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProducts(int id)
        {
            _ProductRepositiry.DeleteByID(id);

            return Ok();
        }
    }
}
