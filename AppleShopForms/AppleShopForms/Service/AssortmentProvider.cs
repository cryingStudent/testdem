using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppleShopForms.Models;

namespace AppleShopForms.Service
{
    class AssortmentProvider
    {
        private SqlConnection _connection = new SqlConnection();
        public AssortmentProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Assortment> ShowAll()
        {
            List<Assortment> list = new List<Assortment>();
            try
            {
                _connection.Open();

                using (SqlCommand command = new SqlCommand(@"SELECT * FROM [Assortment]",_connection))
                {
                    var reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        Assortment assortment = new Assortment()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Price = reader.GetInt32(2),
                            Color = reader.GetString(3)
                        };

                        list.Add(assortment);
                    }

                }
            }

            finally
            {
                _connection.Close();
            }

            return list;
        }
    }
}
