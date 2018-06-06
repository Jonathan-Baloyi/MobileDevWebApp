using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Context;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    public class TestTypeController : Controller
    {

        private SchoolContext context;

        public TestTypeController(SchoolContext _context)
        {
            this.context = _context;

        }

        // GET api/values
        [HttpGet]
        public IEnumerable<TestType> Get()
        {
            return context.TestTypes.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public TestType Get(int id)
        {
            return context.TestTypes.Find(id);
        }

        // POST api/values
        [HttpPost]
        public TestType Post([FromBody] TestType testTypes)
        {
            context.TestTypes.Add(testTypes);
            context.SaveChanges();
            return testTypes;

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public TestType Put(int id, [FromBody] TestType testTypes)
        {
            if (id != testTypes.Id)
            {
                throw new Exception("invalid operation");
            }

            context.TestTypes.Update(testTypes);
            context.SaveChanges();

            return testTypes;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var testType = context.TestTypes.Find(id);
            context.TestTypes.Remove(testType);
            context.SaveChanges();

        }
    }
}