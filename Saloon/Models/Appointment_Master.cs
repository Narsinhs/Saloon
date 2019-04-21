using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Saloon.Models
{
    public class Appointment_Master
    {
        [Required]
        public int Ap_ID { get; set; }
        [Required]
        public int U_ID { get; set; }
        [Required]
        public int E_ID { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public bool Status { get; set; }
        public List<Facilities> facilities { get; set; }
        public List<Product> products { get; set; }
        public List<Package> packages { get; set; }
        public void getlastid()
        {
            SqlCommand cmd = new SqlCommand("GetLastId", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            Ap_ID = (int)sdr[0];
            sdr.Close();
        }
        public List<Appointment_Master> getallappoint()
        {
            SqlCommand cmd = new SqlCommand("User_Appointment_Master", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid", U_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Appointment_Master> appmasall = new List<Appointment_Master>();
            while (sdr.Read())
            {
                Appointment_Master d = new Appointment_Master();
                d.Ap_ID = (int)sdr[0];
                d.U_ID = (int)sdr[1];
                d.E_ID = (int)sdr[2];
                d.Date = (string)sdr[3];
                d.Status = (bool)sdr[4];
                appmasall.Add(d);
            }
            sdr.Close();
            return appmasall;
        }
        public List<Appointment_Master> all()
        {
            SqlCommand cmd = new SqlCommand("All_Appointment_Master", Connection.Get());
            
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Appointment_Master> appmasall = new List<Appointment_Master>();
            while (sdr.Read())
            {  
                Appointment_Master d = new Appointment_Master();
                d.Ap_ID = (int)sdr[0];
                d.U_ID = (int)sdr[1];
                d.E_ID = (int)sdr[2];
                d.Date = (string)sdr[3];
                d.Status = (bool)sdr[4];
                appmasall.Add(d);
            }
            sdr.Close();
            return appmasall;

        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("All_Appointment_Master", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@apid", Ap_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Ap_ID = (int)sdr[0];
                ///////////////--- Getting Facilities Of Each Appointment ---------////////
                SqlCommand cmdd = new SqlCommand("AllFacilities_Apointment_Master", Connection.Get());
                cmdd.CommandType = System.Data.CommandType.StoredProcedure;
                List<Facilities> fall = new List<Facilities>();
                cmdd.Parameters.AddWithValue("@apid", Ap_ID);
                SqlDataReader sdrr = cmdd.ExecuteReader();
                while (sdrr.Read())
                {
                    Facilities f = new Facilities();
                    f.F_ID = (int)sdr[0];
                    f.F_Name = (string)sdr[1];
                    f.F_Cost = (decimal)sdr[2];
                    fall.Add(f);
                }
                sdrr.Close();
                ///////////////////////////----- Getting Products Of Each Appointment -----/////////////
                List<Product> pall = new List<Product>();
                SqlCommand cmddd = new SqlCommand("AllProducts_Apointment_Master");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@aid", Ap_ID);
                SqlDataReader sdrrr = cmddd.ExecuteReader();
                while (sdrrr.Read())
                {
                    Product p = new Product();
                    p.P_id = (int)sdr[0];
                    p.P_Name = (string)sdr[1];
                    p.P_Cost = (decimal)sdr[2];
                    pall.Add(p);
                }
                products = pall;
                sdrrr.Close();
                ///////////////////////////----- Getting Packages Of Each Appointment -----/////////////
                List<Package> packall = new List<Package>();
                SqlCommand cmdddd = new SqlCommand("AllPackages_Apointment_Master");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@aid", Ap_ID);
                SqlDataReader sdrrrr = cmddd.ExecuteReader();
                while (sdrrr.Read())
                {
                    Package p = new Package();
                    p.P_ID = (int)sdr[0];
                    p.P_Name = (string)sdr[1];
                    p.Status = (bool)sdr[2];
                    packall.Add(p);
                }
                packages = packall;
                sdrrrr.Close();
                //////////////////////////------ END -----////////////
                E_ID = (int)sdr[1];
                Date = (string)sdr[2];
                Status = (bool)sdr[3];
            }
            sdr.Close();
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Appointment_Master", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", E_ID);
            cmd.Parameters.AddWithValue("@uid", U_ID);
            cmd.Parameters.AddWithValue("@apid", Ap_ID);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.ExecuteNonQuery();
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Appointment_Master", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@uid", U_ID);
            cmd.Parameters.AddWithValue("@eid", E_ID);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Appointment_Master", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@apid", Ap_ID);
            cmd.ExecuteNonQuery();
        }
    }
}