using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Models
{
    public class Teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }
        public List<Subjects> Subjects { get; set; }
        public List<ClassLevel> ClassLevels { get; set; }
    }
}
