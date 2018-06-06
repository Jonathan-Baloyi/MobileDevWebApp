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
    public class GradesController : Controller
    {

        private SchoolContext context;

        public GradesController(SchoolContext _context)
        {
            this.context = _context;

        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Grades> Get()
        {
            return context.Grades.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Grades Get(int id)
        {
            return context.Grades.Find(id);
        }

        // POST api/values
        [HttpPost]
        public Grades Post([FromBody] Grades grades)
        {
            context.Grades.Add(grades);
            context.SaveChanges();
            return grades;

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Grades Put(int id, [FromBody] Grades grades)
        {
            if (id != grades.Id)
            {
                throw new Exception("invalid operation");
            }

            context.Grades.Update(grades);
            context.SaveChanges();

            return grades;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var grade = context.Grades.Find(id);
            context.Grades.Remove(grade);
            context.SaveChanges();

        }
    }
}