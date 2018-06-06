using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Grades
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public int TestTypeId { get; set; }
        public int StudentId { get; set; }

    }
}
