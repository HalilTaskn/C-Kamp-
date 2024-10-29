using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crud -- > create - read - update - delete 


            Console.WriteLine("****** Menü Sipariş İşlem Paneli****");
            Console.WriteLine();

            Console.WriteLine("***-----------------------------***");
            #region Kategori Ekleme İşlemi
            //Console.Write("Lütfen eklemek istediğiniz kategordi adı:  ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-52CMIHB;initial catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Tbl_kategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Kategori eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal prodcutPrice;
            ////Bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyat: ");
            //prodcutPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-52CMIHB;initial catalog=EgitimKampiDb; integrated security=true");
            // connection.Open();
            //SqlCommand command = new SqlCommand("insert into Tbl_Product (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)",connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", prodcutPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();  
            //connection.Close();

            //Console.Write("Ürün Eklendi");

            #endregion

            #region Ürün Listeleme
            //SqlConnection command = new SqlConnection("Data Source=DESKTOP-52CMIHB; initial catalog=EgitimKampiDb;integrated security=true;");
            //command.Open();
            //SqlCommand cmd = new SqlCommand("select * from Tbl_Product",command);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id");
            //int productId = int .Parse(Console.ReadLine());


            //SqlConnection command = new SqlConnection("Data Source=DESKTOP-52CMIHB; initial catalog=EgitimKampiDb;integrated security=true;");
            //command.Open();
            //SqlCommand cmd = new SqlCommand("Delete from Tbl_Product where ProductId=@p1", command);
            //cmd.Parameters.AddWithValue("@p1", productId);

            //cmd.ExecuteNonQuery();
            //command.Close();
            //Console.WriteLine("Silme İşlemi Gerçekleşti");
            #endregion


            #region Ürün Güncelleme İşlemi
            //Console.Write("Güncellenicek Id Girini: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenicek İsim Girini: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenicek Fiyat Girini: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection command = new SqlConnection("Data Source=DESKTOP-52CMIHB; initial catalog=EgitimKampiDb;integrated security=true;");
            //command.Open();
            //SqlCommand cmd = new SqlCommand("Update Tbl_Product set ProductName=@p1, ProductPrice=@p2 where ProductId=@p3", command);
            //cmd.Parameters.AddWithValue("@p1", productName);
            //cmd.Parameters.AddWithValue("@p2", productPrice);
            //cmd.Parameters.AddWithValue("@p3", productId);
            //cmd.ExecuteNonQuery();
            //command.Close();

            //Console.WriteLine("Güncelleme Tamamlandı!!");


            #endregion

            Console.Read();

        }
    }
}
