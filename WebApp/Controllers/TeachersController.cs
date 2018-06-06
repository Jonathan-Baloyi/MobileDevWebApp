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
    public class TeachersController : Controller
    {

        private SchoolContext context;

        public TeachersController(SchoolContext _context)
        {
            this.context = _context;

        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Teachers> Get()
        {
            return context.Teachers.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Teachers Get(int id)
        {
            return context.Teachers.Find(id);
        }

        // POST api/values
        [HttpPost]
        public Teachers Post([FromBody] Teachers teachers)
        {
            context.Teachers.Add(teachers);
            context.SaveChanges();
            return teachers;

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Teachers Put(int id, [FromBody] Teachers teachers)
        {
            if (id != teachers.Id)
            {
                throw new Exception("invalid operation");
            }

            context.Teachers.Update(teachers);
            context.SaveChanges();

            return teachers;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var teacher = context.Teachers.Find(id);
            context.Teachers.Remove(teacher);
            context.SaveChanges();

        }
    }
}