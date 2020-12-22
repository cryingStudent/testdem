using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleShopForms.Models
{
    class Application
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public int Number{ get; set; }
        public Assortment Assortment { get; set; }
    }
}
