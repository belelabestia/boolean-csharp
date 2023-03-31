﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideogameManager
{
    public class VideogameRepository
    {
        private string connectionString;

        public VideogameRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Videogame? GetById(long id)
        {
            using var conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                using var cmd = new SqlCommand(VideogameQueries.SelectById, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                var reader = cmd.ExecuteReader();

                // we know it's just one or none
                if (reader.Read())
                {
                    var name = reader.GetString(1);
                    var overview = reader.GetString(2);
                    var releaseDate = reader.GetDateTime(3);
                    var softwareHouseId = reader.GetInt64(4);

                    return new Videogame(id, name, overview, releaseDate, softwareHouseId);
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool InsertVideogame(Videogame videogame)
        {
            using var conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                using var cmd = new SqlCommand(VideogameQueries.Insert, conn);

                cmd.Parameters.AddWithValue("@Name", videogame.Name);
                cmd.Parameters.AddWithValue("@Overview", videogame.Overview);
                cmd.Parameters.AddWithValue("@ReleaseDate", videogame.ReleaseDate);
                cmd.Parameters.AddWithValue("@SoftwareHouseId", videogame.SoftwareHouseId);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeleteVideogame(long id)
        {
            using var conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                using var cmd = new SqlCommand(VideogameQueries.DeleteById, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }

    public static class VideogameQueries
    {
        public const string Insert = "INSERT INTO videogames (name, overview, release_date, software_house_id) VALUES (@Name, @Overview, @ReleaseDate, @SoftwareHouseId)";
        public const string SelectById = "SELECT id, name, overview, release_date, software_house_id FROM videogames WHERE Id = @Id";
        public const string DeleteById = "DELETE FROM videogames WHERE id = @Id";
    }
}
