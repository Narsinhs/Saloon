using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    public class Package_Facilities
    {
        public int F_ID { get; set; }
        public int P_ID { get; set; }
        public List<Package_Facilities> all()
        {
            SqlCommand cmd = new SqlCommand("All_PackFac",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            List<Package_Facilities> pfall = new List<Package_Facilities>();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Package_Facilities pf = new Package_Facilities();
                pf.F_ID = (int)sdr[0];
                pf.P_ID = (int)sdr[1];
                pfall.Add(pf);
            }
            sdr.Close();
            return pfall;
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("add_Packfac", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fid", F_ID);
            cmd.Parameters.AddWithValue("@pid", P_ID);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Packfac",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fid", F_ID);
            cmd.ExecuteNonQuery();
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Packfac",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("fid", F_ID);
            cmd.Parameters.AddWithValue("pid", P_ID);
            cmd.ExecuteNonQuery();
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Update_Packfac", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("fid", F_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                F_ID = (int)sdr[0];
                P_ID = (int)sdr[1];
            }
            sdr.Close();
        }
    }
}