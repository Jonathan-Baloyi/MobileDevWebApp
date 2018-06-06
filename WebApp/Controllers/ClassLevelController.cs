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
    [Route("api/class")]
    public class ClassLevelController : Controller
    {

        private SchoolContext context;

        public ClassLevelController(SchoolContext _context)
        {
            this.context = _context;

        }

        // GET api/values
        [HttpGet]
        public IEnumerable<ClassLevel> Get()
        {
            return context.ClassLevels.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ClassLevel Get(int id)
        {
            return context.ClassLevels.Find(id);
        }

        // POST api/values
        [HttpPost]
        public ClassLevel Post([FromBody] ClassLevel ClassLevels)
        {
            context.ClassLevels.Add(ClassLevels);
            context.SaveChanges();
            return ClassLevels;

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ClassLevel Put(int id, [FromBody] ClassLevel ClassLevels)
        {
            if (id != ClassLevels.Id)
            {
                throw new Exception("invalid operation");
            }

            context.ClassLevels.Update(ClassLevels);
            context.SaveChanges();

            return ClassLevels;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var level = context.ClassLevels.Find(id);
            context.ClassLevels.Remove(level);
            context.SaveChanges();

        }
    }
}