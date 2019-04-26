using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    //done
    public class Exp_Cat
    {
        public int EC_ID { get; set; }
        public string Name { get; set; }
        public List<Exp_Cat> all()
        {
            SqlCommand cmd = new SqlCommand("All_Exp_Cat",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Exp_Cat> expall = new List<Exp_Cat>();
            while (sdr.Read())
            {
                Exp_Cat ex = new Exp_Cat();
                ex.EC_ID = (int)sdr[0];
                ex.Name = (string)sdr[1];
                expall.Add(ex);
            }
            sdr.Close();
            return expall;
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Exp_Cat",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
      
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Exp_Cat",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ecid", EC_ID);
            cmd.ExecuteNonQuery();
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Exp_Cat", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ecid", EC_ID);
            cmd.Parameters.AddWithValue("name", Name);
            cmd.ExecuteNonQuery();
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Search_Exp_Cat", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ecid", EC_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                EC_ID = (int)sdr[0];
                Name = (string)sdr[1];
            }
            sdr.Close();
            return;
        }
        public void searchbyname()
        {
            List<Exp_Cat> ec = all();
            for (int i = 0; i < ec.Count; i++)
            {
                if (ec[i].Name == Name)
                {
                    EC_ID = ec[i].EC_ID;
                    break;
                }
            }
        }
    }
}