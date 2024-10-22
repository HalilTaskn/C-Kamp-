using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DateBaseProject
{
    internal class Connetion
    {
      public  SqlConnection connect()
        {
            SqlConnection cont = new SqlConnection("Data Source=DESKTOP-52CMIHB;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            cont.Open();
            return cont;

        }
    }
}
