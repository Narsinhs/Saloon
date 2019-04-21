using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    //done
    public class Department
    {
        public int Dep_ID { get; set; }
        public string Dep_Name { get; set; }
        public List<Department> all()
        {
            SqlCommand cmd = new SqlCommand("All_Department", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Department> dall = new List<Department>();
            while (sdr.Read())
            {
                Department d = new Department();
                d.Dep_ID = (int)sdr[0];
                d.Dep_Name = (string)sdr[1];
                dall.Add(d);
            }
            sdr.Close();
            return dall;

        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("All_Department", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@depid", Dep_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Dep_ID = (int)sdr[0];
                Dep_Name = (string)sdr[1];
            }
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Department", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", Dep_Name);
            cmd.Parameters.AddWithValue("@depid", Dep_ID);
            cmd.ExecuteNonQuery();

        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Department", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", Dep_Name);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Department", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@depid", Dep_ID);
            cmd.ExecuteNonQuery();
        }
    }
}