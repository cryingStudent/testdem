using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppleShopForms.Models;
using System.Security.Cryptography;

namespace AppleShopForms.Service
{
    class UserProvider
    {
        private SqlConnection _connection = new SqlConnection();
        public UserProvider(SqlConnection connection)
        {
            _connection = connection; 
        }

        public User SearchClient(string login)
        {
            User user = null;

            try
            {
                _connection.Open();

                using (SqlCommand command = new SqlCommand(@"SELECT * FROM [User] WHERE Login = (@login)", _connection))
                {
                    command.Parameters.AddWithValue("@login", login);

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        user = new User()
                        {
                            Id = reader.GetInt32(0),
                            Login = reader.GetString(1),
                            Password = reader.GetString(2),
                            Name = reader.GetString(3),
                            Card = reader.GetString(4),
                            Status = reader.GetString(5)
                        };
                    }

                }
                 
            }
            finally
            {
                _connection.Close();
            }


            return user;
        }

        public bool CheckAccount(User user, string password)
        {
            bool check = false;

            if (user != null)
            {
                if (user.Password == password)
                    check = true;
            }

            return check;
        }

        public string GetHashedPassword(string passwordInp)
        {
            var bytes = Encoding.UTF8.GetBytes(passwordInp);
            var key = Encoding.UTF8.GetBytes("key");
            var h = new HMACSHA256(key);
            var hash = h.ComputeHash(bytes);
            var password = Convert.ToBase64String(hash);

            return password;
        }


    }
}
