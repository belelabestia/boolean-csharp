using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public CourseImage? Image { get; set; }
        public IEnumerable<Student>? Students { get; set; }
    }
}
