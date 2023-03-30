using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SqlClientDemo
{
    public class Repository
    {
        string connStr;

        public Repository(string connStr)
        {
            this.connStr = connStr;
        }

        public List<Passenger> GetPassengersByNameLike(string likeString)
        {
            using var conn = new SqlConnection(connStr);
            var passengers = new List<Passenger>();

            try
            {
                conn.Open();

                var query = "SELECT id, name, lastname, date_of_birth"
                    + " FROM passengers"
                    + $" WHERE name LIKE @NameLike"
                    + " ORDER BY lastname, name";

                using var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NameLike", $"%{likeString}%");

                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var idIdx = reader.GetOrdinal("id");
                    var id = reader.GetInt64(idIdx);

                    var nameIdx = reader.GetOrdinal("name");
                    var name = reader.GetString(nameIdx);

                    var lastnameIdx = reader.GetOrdinal("lastname");
                    var lastname = reader.GetString(lastnameIdx);

                    var dateOfBirthIdx = reader.GetOrdinal("date_of_birth");
                    var dateOfBirth = reader.GetDateTime(dateOfBirthIdx);

                    var p = new Passenger(id, name, lastname, dateOfBirth);
                    passengers.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return passengers;
        }

        public List<Airports.AirportSelect> GetAirportsWithoutDates()
        {
            using var conn = new SqlConnection(connStr);
            var airports = new List<Airports.AirportSelect>();

            try
            {
                conn.Open();

                var query = "SELECT id, code, name, city"
                + " FROM airports"
                + " WHERE created_at IS NULL";

                using var command = new SqlCommand(query, conn);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var idIdx = reader.GetOrdinal("id");
                    var id = reader.GetInt64(idIdx);

                    var codeIdx = reader.GetOrdinal("code");
                    var code = reader.GetString(codeIdx);

                    var nameIdx = reader.GetOrdinal("name");
                    var name = reader.GetString(nameIdx);

                    var cityIdx = reader.GetOrdinal("city");
                    var city = reader.GetString(cityIdx);

                    var a = new Airports.AirportSelect(id, code, name, city);
                    airports.Add(a);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return airports;
        }

        public void AddAirport(string code, string name, string city)
        {
            using var conn = new SqlConnection(connStr);
            
            try
            {
                conn.Open();
                using var tran = conn.BeginTransaction();

                try
                {
                    var query = "INSERT INTO airports (code, name, city)"
                        + " VALUES (@Code, @Name, @City);";

                    var cmd = new SqlCommand(query, conn, tran);
                    cmd.Parameters.AddWithValue("@Code", code);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@City", city);

                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteNonQuery();

                    Console.WriteLine("Commit");
                    tran.Commit();
                }
                catch
                {
                    Console.WriteLine("Rollback");
                    tran.Rollback();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
