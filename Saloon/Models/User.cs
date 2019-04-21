using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Saloon.Models
{
    public class User
    {
        [validationforid]
        public int U_ID { get; set; }
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Age { get; set; }
        public List<User> alluser()
        {
            SqlCommand cmd = new SqlCommand("All_User",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<User> au = new List<User>();
            while (sdr.Read())
            {
                User u = new User();
                u.U_ID = (int)sdr[0];
                u.Name = (string)sdr[1];
                u.Email = (string)sdr[2];
                u.Password = (string)sdr[3];
                u.Contact = (string)sdr[4];
                u.Address = (string)sdr[5];
                u.Age = (int)sdr[6];
                au.Add(u);
            }
            sdr.Close();
            return au;
        }
        public bool login()
        {
            SqlCommand cmd = new SqlCommand("All_User", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                User u = new User();
                u.U_ID = (int)sdr[0];
                u.Name = (string)sdr[1];
                u.Email = (string)sdr[2];
                u.Password = (string)sdr[3];
                u.Contact = (string)sdr[4];
                u.Address = (string)sdr[5];
                u.Age = (int)sdr[6];
                if (u.Email == Email && u.Password == Password)
                {
                    GetDetail.U_ID = u.U_ID;
                    GetDetail.Name = u.Name;
                    GetDetail.Email = u.Email;
                    GetDetail.Password = u.Password;
                    GetDetail.Contact = u.Contact;
                    GetDetail.Address = u.Address;
                    GetDetail.Age = u.Age;
                    sdr.Close();
                    return true;
                }
            }
            sdr.Close();
            return false;
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_User",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name",Name);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@contact", Contact);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.Parameters.AddWithValue("@age", Age);
            cmd.ExecuteNonQuery();
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_User",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@uid", U_ID);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@contact", Contact);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.Parameters.AddWithValue("@age", Age);
            cmd.ExecuteNonQuery();
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Search_User",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid", U_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                U_ID = (int)sdr[0];
                Name = (string)sdr[1];
                Email = (string)sdr[2];
                Password = (string)sdr[3];
                Contact = (string)sdr[4];
                Address = (string)sdr[5];
                Age = (int)sdr[6];
            }
            sdr.Close();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_User",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid", U_ID);
            cmd.ExecuteNonQuery();
        }
    }
}