using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
