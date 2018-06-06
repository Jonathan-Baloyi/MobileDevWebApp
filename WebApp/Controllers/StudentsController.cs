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
    public class StudentsController : Controller
    {

        private SchoolContext context;

        public StudentsController(SchoolContext _context)
        {
            this.context = _context;

        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Students> Get()
        {
            return context.Students.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Students Get(int id)
        {
            return context.Students.Find(id);
        }

        // POST api/values
        [HttpPost]
        public Students Post([FromBody] Students students)
        {
            context.Students.Add(students);
            context.SaveChanges();
            return students;

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Students Put(int id, [FromBody] Students students)
        {
            if (id != students.Id)
            {
                throw new Exception("invalid operation");
            }

            context.Students.Update(students);
            context.SaveChanges();

            return students;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = context.Students.Find(id);
            context.Students.Remove(student);
            context.SaveChanges();

        }
    }
}