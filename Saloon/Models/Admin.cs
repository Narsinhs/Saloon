using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Saloon.Models
{
    public class Admin
    {
        public int A_ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string error { get; set; }
        public void searchbyid()
        {
            SqlCommand cmd = new SqlCommand("SearchAdmin", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@aid", A_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Name = (string)sdr[1];
                Password = (string)sdr[2];
            }
            sdr.Close();
        }
        public bool login()
        {

            SqlCommand cmd = new SqlCommand("All_Admin", Connection.Get());
            SqlDataReader sdr = cmd.ExecuteReader();
           
            while (sdr.Read())
            {
                Admin ad = new Admin();
                ad.A_ID = (int)sdr[0];
                ad.Name = (string)sdr[1];
                ad.Password = (string)sdr[2];
                if (Name == ad.Name && Password == ad.Password)
                {
                    A_ID = ad.A_ID;
                    sdr.Close();
                    return true;
                }
            }
            sdr.Close();
            return false;
        }
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