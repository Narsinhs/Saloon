using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    public class Appointment_Package
    {
        public int Ap_ID { get; set; }
        public int P_ID { get; set; }
        public string P_Name { get; set; }

        public List<Appointment_Package> all()
        {
            SqlCommand cmd = new SqlCommand("All_Appointment_Package", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            List<Appointment_Package> apppack = new List<Appointment_Package>();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Appointment_Package ap = new Appointment_Package();
                ap.Ap_ID = (int)sdr[0];
                ap.P_ID = (int)sdr[1];
                apppack.Add(ap);
            }
            sdr.Close();
            Package p = new Package();
            List<Package> pall = p.all();
            for (int i = 0; i < apppack.Count; i++)
            {
                for (int j = 0; j < pall.Count; j++)
                {
                    if (pall[j].P_ID == apppack[i].P_ID)
                    {
                        apppack[i].P_Name = pall[j].P_Name;
                    }
                }
            }
            return apppack;
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("add_Appointment_Package", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@apid", Ap_ID);
            cmd.Parameters.AddWithValue("@pid", P_ID);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Appointment_Package", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@apid", Ap_ID);
            cmd.ExecuteNonQuery();
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Appointment_Package", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("apid", Ap_ID);
            cmd.Parameters.AddWithValue("pid", P_ID);
            cmd.ExecuteNonQuery();
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Update_Appointment_Package", Connection.Get());
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