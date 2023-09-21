using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query_DB_Videogames
{
    public static class VideogameManager
    {
        private static string connectionString = "Data Source=localhost;Initial Catalog=videogames;Integrated Security=True";

        public static List<Videogame> GetVideogames()
        {
            List<Videogame> videogame = new List<Videogame>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id, name, overview, release_date FROM videogames;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader data = cmd.ExecuteReader())
                    {
                        while (data.Read())
                        {
                            Videogame videogameReaded = new Videogame(data.GetInt64(0), data.GetString(1), data.GetString(2), data.GetDateTime(3));

                            videogame.Add(videogameReaded);
                        }

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return videogame;
            }
        }
    }
}
