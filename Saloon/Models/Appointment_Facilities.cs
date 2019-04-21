using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    public class Appointment_Facilities
    {
        public int Ap_ID { get; set; }
        public int F_ID { get; set; }
        public List<Appointment_Facilities> all()
        {
            SqlCommand cmd = new SqlCommand("All_Appointment_Facilities", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            List<Appointment_Facilities> apppack = new List<Appointment_Facilities>();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Appointment_Facilities ap = new Appointment_Facilities();
                ap.Ap_ID = (int)sdr[0];
                ap.F_ID = (int)sdr[1];
                apppack.Add(ap);
            }
            sdr.Close();
            return apppack;
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("add_Appointment_Facilities", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@apid", Ap_ID);
            cmd.Parameters.AddWithValue("@fid", F_ID);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Appointment_Facilities", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@apid", Ap_ID);
            cmd.ExecuteNonQuery();
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Appointment_Facilities", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("apid", Ap_ID);
            cmd.Parameters.AddWithValue("fid", F_ID);
            cmd.ExecuteNonQuery();
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Update_Appointment_Facilities", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("apid", Ap_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Ap_ID = (int)sdr[0];
                F_ID = (int)sdr[1];
            }
            sdr.Close();
        }
    }
}