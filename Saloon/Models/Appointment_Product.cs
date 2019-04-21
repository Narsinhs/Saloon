using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    public class Appointment_Product
    {
        public int Ap_ID { get; set; }
        public int P_ID { get; set; }
        public List<Appointment_Product> all()
        {
            SqlCommand cmd = new SqlCommand("All_Appointment_Facilities", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            List<Appointment_Product> apppack = new List<Appointment_Product>();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Appointment_Product ap = new Appointment_Product();
                ap.Ap_ID = (int)sdr[0];
                ap.P_ID = (int)sdr[1];
                apppack.Add(ap);
            }
            sdr.Close();
            return apppack;
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Appointment_Product", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@apid", Ap_ID);
            cmd.Parameters.AddWithValue("@pid", P_ID);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Appointment_Product", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@apid", Ap_ID);
            cmd.ExecuteNonQuery();
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Appointment_Product", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("apid", Ap_ID);
            cmd.Parameters.AddWithValue("pid", P_ID);
            cmd.ExecuteNonQuery();
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Update_Appointment_Product", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("apid", Ap_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Ap_ID = (int)sdr[0];
                P_ID = (int)sdr[1];
            }
            sdr.Close();
        }
    }
}