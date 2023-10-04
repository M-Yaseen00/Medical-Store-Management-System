using System;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleBaseProject
{
    internal class StaffController

    {

        public static List<Staff> GetAllStafffromDB()
        {
            Staff staff = new Staff();
            // public void GetAllStafffromDB(){}    what if do like this

            List<Staff> list = new List<Staff>();
            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            Console.WriteLine("connect to database successfully");

            String Query = "Select * from staff where isdeleted='false'";

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = Query;


            MySqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-15}{4,-20}{5,-10}", "|   ", "|     ", "|        ", "|             ", "|     ", "|");
            Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-15}{4,-20}{5,-10}", "| ID", "| NAME", "| ADDRESS", "| PHONE NUMBER", "| WORK", "|");
            Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-15}{4,-20}{5,-10}", "|   ", "|     ", "|        ", "|             ", "|     ", "|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");



            while (reader.Read())
            {
                //int docid = reader.GetInt32(0);
                staff.StaffId = reader.GetInt32("Id");
                staff.StaffName = reader.GetString("Name");
                staff.StaffAddress = reader.GetString("Address");
                staff.StaffPhoneNumber = reader.GetInt32("PhoneNumber");
                staff.StaffDutyWork = reader.GetString("Work");
               
                Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-15}{4,-20}{5,-10}", "| " + staff.StaffId, "| " + staff.StaffName, "| " + staff.StaffAddress, "| " + staff.StaffPhoneNumber, "| " + staff.StaffDutyWork, "|");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                list.Add(staff);
            }
            Console.WriteLine("\n\n");
            conn.Close();
            return list;
        }
        public static List<Staff> InsertIntoDB()
        {
            Staff staff = new Staff();

            // public void GetAllStafffromDB(){}    what if do like this
            List<Staff> list = new List<Staff>();
            Console.WriteLine("Please Enter the Name: ");
            staff.StaffName = Console.ReadLine();
            Console.WriteLine("Please Enter the Address: ");
            staff.StaffAddress = Console.ReadLine();
            Console.WriteLine("Please Enter the Staff Work: ");
            staff.StaffDutyWork = Console.ReadLine();
            Console.WriteLine("Please Enter the Phoneno: ");
            staff.StaffPhoneNumber = double.Parse(Console.ReadLine());
            
            string isDeleted = "false";
            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "INSERT INTO STAFF VALUES('" + staff.StaffId + "',+'" + staff.StaffName + "','" + staff.StaffAddress + "','" + staff.StaffPhoneNumber + "','" + staff.StaffDutyWork +"','" + isDeleted + "')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("                                     ****************DATA INSERTED*******************");
                }
                else
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("                                     ****************DATA NOT INSERTED*******************");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("     AN UNEXPECTED ERROR OCCUR ..............................\n" + ex);

            }
            conn.Close();

            return list;
        }
        public static List<Staff> UpdateintoDB()
        {
            Staff staff = new Staff();

            // public void GetAllStafffromDB(){}    what if do like this
            List<Staff> list = new List<Staff>();
            Console.WriteLine("Please Enter the Id where you want to update");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Name: ");
            staff.StaffName = Console.ReadLine();
            Console.WriteLine("Please Enter the Address: ");
            staff.StaffAddress = Console.ReadLine();
            Console.WriteLine("Please Enter the Staff Work: ");
            staff.StaffDutyWork = Console.ReadLine();
            Console.WriteLine("Please Enter the Phoneno: ");
            staff.StaffPhoneNumber = double.Parse(Console.ReadLine());

            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "update staff set Name='" + staff.StaffName + "',Address='" + staff.StaffAddress + "',PhoneNumber='" + staff.StaffPhoneNumber + "',Work='" + staff.StaffDutyWork + "'Where Id='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("                                     ****************DATA UPDATED*******************");
                }
                else
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("                                     ****************DATA NOT UPDATED*******************");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("     AN UNEXPECTED ERROR OCCUR ..............................\n" + ex);

            }
            conn.Close();

            return list;
        }
        public static List<Staff> DeleteFromDB()
        {
            Staff staff = new Staff();

            List<Staff> list = new List<Staff>();
            Console.WriteLine("Please Enter the Id which you want to delete");
            int id = int.Parse(Console.ReadLine());
            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "update staff set isdeleted='true' Where id='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("                                     ****************DATA DELETED*******************");
                }
                else
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("                                     ****************DATA NOT DELETED*******************");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("     AN UNEXPECTED ERROR OCCUR ..............................\n" + ex);

            }
            conn.Close();

            return list;
        }
    }
}