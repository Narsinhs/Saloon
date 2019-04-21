using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    //done
    public class Employee
    {
        public int E_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string NIC { get; set; }
        public int D_ID { get; set; }
        public int Dep_ID { get; set; }
        public List<Employee> all()
        {
            SqlCommand cmd = new SqlCommand("All_Employee", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Employee> empall = new List<Employee>();
            while (sdr.Read())
            {
                Employee e = new Employee();
                e.E_ID = (int)sdr[0];
                e.Name = (string)sdr[1];
                e.Email = (string)sdr[2];
                e.Contact = (string)sdr[3];
                e.NIC = (string)sdr[4];
                e.D_ID = (int)sdr[5];
                e.Dep_ID = (int)sdr[6];
                empall.Add(e);
            }
            sdr.Close();
            return empall;
            
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Search_Employee", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", E_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                E_ID = (int)sdr[0];
                Name = (string)sdr[1];
                Email = (string)sdr[2];
                Contact = (string)sdr[3];
                NIC = (string)sdr[4];
                D_ID = (int)sdr[5];
                Dep_ID = (int)sdr[6];
            }
            sdr.Close();
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Employee",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid",E_ID);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@contact", Contact);
            cmd.Parameters.AddWithValue("@nic", NIC);
            cmd.Parameters.AddWithValue("@did", D_ID);
            cmd.Parameters.AddWithValue("@depid", Dep_ID);
            cmd.ExecuteNonQuery();

        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Employee", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", Name);

            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@contact", Contact);
            cmd.Parameters.AddWithValue("@nic", NIC);
            cmd.Parameters.AddWithValue("@did", D_ID);
            cmd.Parameters.AddWithValue("@depid", Dep_ID);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Employee", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", E_ID);
            cmd.ExecuteNonQuery();
        }
    }
}