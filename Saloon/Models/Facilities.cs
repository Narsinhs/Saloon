using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    //done
    public class Facilities
    {
        public int F_ID { get; set; }
        public string F_Name { get; set; }
        public decimal F_Cost { get; set; }
        public List<Facilities> bypackage(int a)
        {
            SqlCommand cmd = new SqlCommand("facbypackage",Connection.Get());
            cmd.Parameters.AddWithValue("@pid",a);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Facilities> fall = new List<Facilities>();
            while (sdr.Read())
            {
                Facilities f = new Facilities();
                f.F_ID = (int)sdr[0];
                f.F_Name = (string)sdr[1];
                f.F_Cost = (decimal)sdr[2];
                fall.Add(f);
            }
            sdr.Close();
            return fall;
        }
        public List<Facilities> byappointment(int a)
        {
            SqlCommand cmd = new SqlCommand("facilitybyappointment", Connection.Get());
            cmd.Parameters.AddWithValue("@apid", a);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Facilities> fall = new List<Facilities>();
            while (sdr.Read())
            {
                Facilities f = new Facilities();
                f.F_ID = (int)sdr[0];
                f.F_Name = (string)sdr[1];
                f.F_Cost = (decimal)sdr[2];
                fall.Add(f);
            }
            sdr.Close();
            return fall;
        }
        public List<Facilities> all()
        {
            SqlCommand cmd = new SqlCommand("All_Facilities",Connection.Get());
            List<Facilities> fall = new List<Facilities>();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Facilities f = new Facilities();
                f.F_ID = (int)sdr[0];
                f.F_Name = (string)sdr[1];
                f.F_Cost = (decimal)sdr[2];
                fall.Add(f);
            }
            sdr.Close();
            return fall;
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Facilities", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", F_Name);
            cmd.Parameters.AddWithValue("@cost", F_Cost);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Facilities", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fid", F_ID);
            cmd.ExecuteNonQuery();
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Search_Facilities", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fid",F_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                F_ID = (int)sdr[0];
                F_Name = (string)sdr[1];
                F_Cost = (decimal)sdr[2];
            }
            sdr.Close();
            return;
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Facilities",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fid",F_ID);
            cmd.Parameters.AddWithValue("@name", F_Name);
            cmd.Parameters.AddWithValue("@cost", F_Cost);
            cmd.ExecuteNonQuery();
        }
    }
}