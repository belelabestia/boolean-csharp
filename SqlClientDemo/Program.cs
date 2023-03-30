using System.Data.SqlClient;
using SqlClientDemo;

var connStr = "Data Source=localhost;Initial Catalog=AirportDb;Integrated Security=True;Pooling=False";
var repo = new Repository(connStr);

repo.AddAirport("dadada", "dedede", "dididi");

//var passengers = repo.GetPassengersByNameLike("arli");

//foreach (var passenger in passengers) Console.WriteLine(passenger);

//Console.WriteLine($"Count: {passengers.Count}");