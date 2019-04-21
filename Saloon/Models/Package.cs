using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    //done
    public class Package
    {
        public int P_ID { get; set; }
        public string P_Name { get; set; }
        public bool Status { get; set; }
        public List<Package> all()
        {
            SqlCommand cmd = new SqlCommand("All_Package", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Package> pkgal = new List<Package>();
            while (sdr.Read())
            {
                Package p = new Package();
                p.P_ID = (int)sdr[0];
                p.P_Name = (string)sdr[1];
                p.Status = (bool)sdr[2];
                pkgal.Add(p);
            }
            sdr.Close();
            return pkgal;
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Package",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name",P_Name);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {

            SqlCommand cmd = new SqlCommand("Delete_Package", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", P_ID);
            cmd.ExecuteNonQuery();
        }
        public void Search()
        {
            SqlCommand cmd = new SqlCommand("Search_Package",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", P_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                P_ID = (int)sdr[0];
                P_Name = (string)sdr[1];
                Status = (bool)sdr[2];
        
            }
            sdr.Close();
            return;
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Package",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", P_ID);
            cmd.Parameters.AddWithValue("@name", P_Name);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.ExecuteNonQuery();
        }
    }
    
}