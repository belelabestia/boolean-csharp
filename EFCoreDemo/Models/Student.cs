using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }

        public IEnumerable<Course>? Courses { get; set; }
        public IEnumerable<Review>? Reviews { get; set; }
    }
}
