using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

public record Product
{
    string name = "";
    string description = "";

    public Product() : this(name: "") { }
    public Product(string name) : this(code: new Random().Next(), name: name) { }

    public Product(int code, string name)
    {
        Code = code;
        Name = name;
    }

    public int Code { get; private init; }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public string Description
    {
        get => description;
        set => description = value;
    }

    public double Price { get; set; }
    public double Iva { get; set; }

    public double GetBasePrice() => Price;
    public double GetPriceAfterIva() => Price * (1 + Iva);
    public string GetExtendedName() => Code.ToString().PadLeft(20, '0') + " " + Name;
}
