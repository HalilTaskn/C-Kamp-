using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProduckId { get; set; }

        public string ProduckName { get; set; }

        public int ProductStock { get; set; }

        public decimal ProductPrice{ get; set; }

        public string ProduckDescription { get; set; }
    }
}
    