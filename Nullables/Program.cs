using System.ComponentModel.DataAnnotations;

var a = new NumberWrapper();

a.Name = null;

class NumberWrapper
{
    public Nullable<int> NullableValue { get; set; }
    public List<int> Reference { get; set; }
    public string Name { get; set; } = string.Empty;
}