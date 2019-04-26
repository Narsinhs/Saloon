using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    //Done
    public class Product
    {
        public int P_id { get; set; }
        public string P_Name { get; set; }
        public decimal P_Cost  { get; set; }

        public List<Product> productsbyappointment(int a)
        {
            SqlCommand cmd = new SqlCommand("productsbyproducts", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("apid", a);
            List<Product> packages = new List<Product>();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Product p = new Product();
                p.P_id = (int)sdr[0];
                p.P_Name = (string)sdr[1];
                p.P_Cost = (decimal)sdr[2];
                packages.Add(p);
            }
            sdr.Close();
            return packages;
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Product", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", P_Name);
            cmd.Parameters.AddWithValue("@cost", P_Cost);
            cmd.ExecuteNonQuery();
        }
        public List<Product> all()
        {
            SqlCommand cmd = new SqlCommand("All_Product",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Product> proall = new List<Product>();
            while (sdr.Read())
            {
                Product p = new Product();
                p.P_id = (int)sdr[0];
                p.P_Name = (string)sdr[1];
                p.P_Cost = (decimal)sdr[2];
                proall.Add(p);
            }
            sdr.Close();
            return proall;
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Product",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", P_id);
            cmd.ExecuteNonQuery();
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Search_Product",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid",P_id);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                P_id = (int)sdr[0];
                P_Name = (string)sdr[1];
                P_Cost = (decimal)sdr[2];
            }
            sdr.Close();
            return;
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Product",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid",P_id);
            cmd.Parameters.AddWithValue("@name", P_Name);

            cmd.Parameters.AddWithValue("@cost", P_Cost);
            cmd.ExecuteNonQuery(); 

        }
    }
}