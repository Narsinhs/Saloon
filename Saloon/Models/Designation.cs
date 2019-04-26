using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    //done
    public class Designation
    {
        public int D_ID { get; set; }
        public string D_Name { get; set; }
        public List<Designation> all()
        {
            SqlCommand cmd = new SqlCommand("All_Designation", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Designation> dall = new List<Designation>();
            while (sdr.Read())
            {
                Designation d = new Designation();
                d.D_ID = (int)sdr[0];
                d.D_Name = (string)sdr[1];
                dall.Add(d);
            }
            sdr.Close();
            return dall;

        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Search_Designation", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@did", D_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                D_ID = (int)sdr[0];
                D_Name = (string)sdr[1];
            }
            sdr.Close();    
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Designation", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", D_Name);
            cmd.Parameters.AddWithValue("@did", D_ID);
            cmd.ExecuteNonQuery();

        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Designation", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", D_Name);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Designation", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@did", D_ID);
            cmd.ExecuteNonQuery();
        }
    }
}