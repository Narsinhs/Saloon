using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Saloon.Models
{
    public class Appointment_Master
    {
        [Required]
        public int Ap_ID { get; set; }
        [Required]
        public int U_ID { get; set; }
        public string U_Name { get; set; }
        [Required]
        public int E_ID { get; set; }
        public string E_Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public bool Status { get; set; }

        public decimal Bill { get; set; }
        public void getlastid()
        {
            SqlCommand cmd = new SqlCommand("GetLastId", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Ap_ID = (int)sdr[0];
            }
            sdr.Close();
        }
        public List<Appointment_Master> allappbyuser(int a)
        {
            SqlCommand cmd = new SqlCommand("allappbyuser",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid",a);
            List<Appointment_Master> apall = new List<Appointment_Master>();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Appointment_Master ap = new Appointment_Master();
                ap.Ap_ID = (int)sdr[0];
                ap.E_Name = (string)sdr[1];
                ap.Date = (DateTime)sdr[2];
                ap.Status = (bool)sdr[3];
                ap.Bill = (decimal)sdr[4];
                apall.Add(ap);
            }
            sdr.Close();
            return apall;
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
                d.Date = (DateTime)sdr[3];
                d.Status = (bool)sdr[4];
                d.Bill = (decimal)sdr[5];
                appmasall.Add(d);
            }
            sdr.Close();
            Employee em = new Employee();
            List<Employee> lst = em.all();
            for (int i = 0; i < appmasall.Count; i++)
            {
                for (int j = 0; j < lst.Count; j++)
                {
                    if (appmasall[i].E_ID == lst[j].E_ID)
                    {
                        appmasall[i].E_Name = lst[j].Name;
                    }
                }
            }
            User u = new User();
            List<User> uall = u.alluser();
            for (int i = 0; i < appmasall.Count; i++)
            {
                for (int j = 0; j < uall.Count; j++)
                {
                    if (appmasall[i].U_ID == uall[j].U_ID)
                    {
                        appmasall[i].U_Name = uall[j].Name;
                    }
                }
            }
            return appmasall;
        }
        public List<Appointment_Master> getallappointemp()
        {
            SqlCommand cmd = new SqlCommand("getallappointemp", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", E_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Appointment_Master> appmasall = new List<Appointment_Master>();
            while (sdr.Read())
            {
                Appointment_Master d = new Appointment_Master();
                d.Ap_ID = (int)sdr[0];
                d.U_ID = (int)sdr[1];
                d.E_ID = (int)sdr[2];
                d.Date = (DateTime)sdr[3];
                d.Status = (bool)sdr[4];
                d.Bill = (decimal)sdr[5];
                appmasall.Add(d);
            }
            sdr.Close();
            Employee em = new Employee();
            List<Employee> lst = em.all();
            for (int i = 0; i < appmasall.Count; i++)
            {
                for (int j = 0; j < lst.Count; j++)
                {
                    if (appmasall[i].E_ID == lst[j].E_ID)
                    {
                        appmasall[i].E_Name = lst[j].Name;
                    }
                }
            }
            User u = new User();
            List<User> uall = u.alluser();
            for (int i = 0; i < appmasall.Count; i++)
            {
                for (int j = 0; j < uall.Count; j++)
                {
                    if (appmasall[i].U_ID == uall[j].U_ID)
                    {
                        appmasall[i].U_Name = uall[j].Name;
                    }
                }
            }
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
                d.Date = (DateTime)sdr[3];
                d.Status = (bool)sdr[4];
                d.Bill = (decimal)sdr[5];
                appmasall.Add(d);
            }
            sdr.Close();
            Employee em = new Employee();
            List<Employee> lst = em.all();
            for (int i = 0; i < appmasall.Count; i++)
            {
                for (int j = 0; j < lst.Count; j++)
                {
                    if (appmasall[i].E_ID == lst[j].E_ID)
                    {
                        appmasall[i].E_Name = lst[j].Name;
                    }
                }
            }
            User u = new User();
            List<User> uall = u.alluser();
            for (int i = 0; i < appmasall.Count; i++)
            {
                for (int j = 0; j < uall.Count; j++)
                {
                    if (appmasall[i].U_ID == uall[j].U_ID)
                    {
                        appmasall[i].U_Name = uall[j].Name;
                    }
                }
            }
            return appmasall;

        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Search_Appointment_Master", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@apid", Ap_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Ap_ID = (int)sdr[0];
                U_ID = (int)sdr[1];
                E_ID = (int)sdr[2];
                Date = (DateTime)sdr[3];
                Status = (bool)sdr[4];
                Bill = (decimal)sdr[5];
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
            cmd.Parameters.AddWithValue("@bill", Bill);
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
            cmd.Parameters.AddWithValue("@bill", Bill);
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