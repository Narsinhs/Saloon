using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    public class Admin
    {
        public int A_ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Admin> all()
        {
            SqlCommand cmd = new SqlCommand("All_Admin",Connection.Get());
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Admin> adlst = new List<Admin>();
            while (sdr.Read())
            {
                Admin ad = new Admin();
                ad.A_ID = (int)sdr[0];
                ad.Name = (string)sdr[1];
                ad.Password = (string)sdr[2];
            }
            sdr.Close();
            return adlst;
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Admin",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name",Name);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.ExecuteReader();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Admin",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@aid",A_ID);
            cmd.ExecuteNonQuery();
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Search_Admin",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@aid", A_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                A_ID = (int)sdr[0];
                Name = (string)sdr[1];
                Password = (string)sdr[2];
            }
            sdr.Close();
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Admin",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@aid",A_ID);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.ExecuteNonQuery();
        }

    }
}