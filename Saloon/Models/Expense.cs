using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon.Models
{
    //done
    public class Expense
    {
        public int E_ID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }
        public int EC_ID { get; set; }
        public string Add_By { get; set; }
        public List<Expense> all()
        {
            SqlCommand cmd = new SqlCommand("All_Expense", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Expense> exall = new List<Expense>();
            while (sdr.Read())
            {
                Expense e = new Expense();
                e.E_ID = (int)sdr[0];
                e.Name = (string)sdr[1];
                e.Amount = (decimal)sdr[2];
                e.Date = (string)sdr[3];
                e.EC_ID = (int)sdr[4];
                e.Add_By = (string)sdr[5];
                exall.Add(e);
            }
            sdr.Close();
            return exall;
        }
        public void search()
        {
            SqlCommand cmd = new SqlCommand("Search_Expense", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", E_ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                E_ID = (int)sdr[0];
                Name = (string)sdr[1];
                Amount = (decimal)sdr[2];
                Date = (string)sdr[3];
                EC_ID = (int)sdr[4];
                Add_By = (string)sdr[5];
        
            }
            sdr.Close();
        }
        public void add()
        {
            SqlCommand cmd = new SqlCommand("Add_Expense",Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@amount", Amount);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@ecid", EC_ID);
            cmd.Parameters.AddWithValue("@addby", Add_By);
            cmd.ExecuteNonQuery();
        }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Delete_Expense", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("eid", E_ID);
            cmd.ExecuteNonQuery();
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("Update_Expense", Connection.Get());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", E_ID);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@amount", Amount);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@ecid", EC_ID);
            cmd.Parameters.AddWithValue("@addby", Add_By);
            cmd.ExecuteNonQuery();
        }
        
    }
}