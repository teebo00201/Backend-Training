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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomersReoisitiry _CustomersReoisitiry;

        public CustomerController(ICustomersReoisitiry CustomersReoisitiry)
        {
            _CustomersReoisitiry = CustomersReoisitiry;
        }

        // GET: api/Customers
        [HttpGet]
        public ActionResult<List<Customers>> GetCustomers()
        {
            return _CustomersReoisitiry.GetAll();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public ActionResult<Customers> GetCustomers(string id)
        {
            var customers = _CustomersReoisitiry.GetByID(id);

            if (customers == null)
            {
                return NotFound();
            }

            return customers;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public IActionResult PutCustomers(string id, Customers customers)
        {
            if (id != customers.CustomersId)
            {
                return BadRequest();
            }

            try
            {
                _CustomersReoisitiry.Update(customers);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_CustomersReoisitiry.CustomersExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<Customers> PostCustomers(Customers customers)
        {
            _CustomersReoisitiry.Add(customers);
            
             return CreatedAtAction("GetCustomers", new { id = customers.CustomersId }, customers);
            

        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomers(string id)
        {
            _CustomersReoisitiry.DeleteByID(id);

            return Ok();
        }
    }
}
