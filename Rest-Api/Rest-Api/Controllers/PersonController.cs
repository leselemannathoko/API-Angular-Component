using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rest_Api.Data;

namespace Rest_Api.Controllers
{
    public class PersonController : Controller
    {
        private readonly DataContext _context;

        public PersonController(DataContext context)
        {
            _context = context;

        }

        // GET api/values
        [HttpGet]
        public IActionResult GetPeople()
        {
            var people = _context.People.ToList();
            return Ok(people);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetPeopleById(int id)
        {
            var peopleById = _context.People.FirstOrDefault(x => x.Id == id);
            return Ok(peopleById);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}