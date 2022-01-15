using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                //Creating connection
                con = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;database=EmployeeDetails; integrated security=SSPI");

                //writing sql query
                SqlCommand cm = new SqlCommand("Select * from EmployeeDetails", con);

                //Opening Connection
                con.Open();

                //Executing the SQL query
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["FirstName"] + " || " + sdr["LastName"] + " || " + sdr["Salary"] +" || " +sdr["PhoneNumber"]+" || " +sdr["Location"]);
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong " + e);
            }


        }
    }
}
