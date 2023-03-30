using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlClientDemo.Airports
{
    public class AirportSelect
    {
        public AirportSelect(long id, string code, string name, string city)
        {
            Id = id;
            Code = code;
            Name = name;
            City = city;
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }

    public class AirportInsert
    {
        public AirportInsert(string code, string name, string city)
        {
            Code = code;
            Name = name;
            City = city;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
