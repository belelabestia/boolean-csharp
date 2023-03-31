using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class CourseImage
    {
        public int CourseImageId { get; set; }
        public byte[]? Image { get; set; }
        public string? Caption { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
