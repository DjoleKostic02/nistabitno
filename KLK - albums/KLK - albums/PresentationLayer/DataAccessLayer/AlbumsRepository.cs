using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AlbumsRepository
    {
        public List<Album> GetAllAlbums()
        {
            List<Album> results = new List<Album>();

            using(SqlConnection sqlConnection = new SqlConnection(Constants.conectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Albums";
                
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Album a = new Album();
                    a.Id = sqlDataReader.GetInt32(0);
                    a.Title = sqlDataReader.GetString(1);
                    a.Artist = sqlDataReader.GetString(2);
                    a.Price = sqlDataReader.GetDecimal(3);

                    results.Add(a);
                }

            }

             return results;
        }
        public int InsertAlbum(Album a) {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.conectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = String.Format
                    ("INSERT INTO Albums VALUES('{0}','{1}','{2}')", a.Title, a.Artist, a.Price) ;

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }

            }
    }
}
