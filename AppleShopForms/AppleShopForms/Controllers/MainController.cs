using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppleShopForms.Controllers
{
    class MainController
    {
        public string ConnectionDataInfo()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "localhost";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "Apple shop";

            string stringBuilder = builder.ToString();

            return stringBuilder;
        }
    }
}
