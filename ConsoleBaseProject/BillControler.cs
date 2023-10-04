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
    internal class BillControler

    {

        public static List<Bill> GetAllStafffromDB()
        {
            Bill bill = new Bill();
            // public void GetAllStafffromDB(){}    what if do like this

            List<Bill> list = new List<Bill>();
            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            Console.WriteLine("connect to database successfully");

            string Query = "Select bill.Id,bill.Patient_Id,patient.Name,bill.RoomCharges,bill.DoctorCharges,bill.OtherCharges,bill.TotalCharges from bill inner join patient on bill.Patient_Id=patient.Id where bill.isdeleted='false'";


            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = Query;


            MySqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-8}{1,-30}{2,-30}{3,-30}{4,-30}{5,-30}{6,-30}{7,-10}", "|   ", "|     ", "|        ", "|           ", "|    ", "|             ", "|         ", "|     ", "|         ", "|        ", "|");
            Console.WriteLine("{0,-8}{1,-30}{2,-30}{3,-30}{4,-30}{5,-30}{6,-30}{7,-10}", "| ID", "| PATIENT_ID", "| PATIENT NAME", "| ROOM CHARGES", "| DOCTOR CHARGES", "| OTHER CHARGES", "| TOTAL CHARGES", "|");
            Console.WriteLine("{0,-8}{1,-30}{2,-30}{3,-30}{4,-30}{5,-30}{6,-30}{7,-10}", "|   ", "|     ", "|        ", "|           ", "|    ", "|             ", "|         ", "|     ", "|         ", "|        ", "|");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            while (reader.Read())
            {
                //int docid = reader.GetInt32(0);
              bill.Id = reader.GetInt32("Id");
                bill.PatientId = reader.GetInt32("Patient_Id");
                bill.Room_Charges = reader.GetDouble("RoomCharges");
                bill.Doctor_Charges = reader.GetDouble("DoctorCharges");
                bill.Other_Charges = reader.GetDouble("OtherCharges");
                bill.Total_Charges = reader.GetDouble("TotalCharges");

                string name = reader.GetString("Name");

                Console.WriteLine("{0,-8}{1,-30}{2,-30}{3,-30}{4,-30}{5,-30}{6,-30}{7,-10}", "| " + bill.Id, "| " + bill.PatientId, "| " + name, "| " + bill.Room_Charges, "| " + bill.Doctor_Charges, "| " + bill.Other_Charges, "| " + bill.Total_Charges, "|");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                list.Add(bill);
            }
            Console.WriteLine("\n\n");
            conn.Close();
            return list;
        }
        public static List<Bill> InsertIntoDB()
        {
            Bill bill = new Bill();

            // public void GetAllStafffromDB(){}    what if do like this
            List<Bill> list = new List<Bill>();
            
            Console.WriteLine("Please Enter the valid Patient id: ");
            bill.PatientId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the room charges: ");
            bill.Room_Charges = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the doctor charges: ");
            bill.Doctor_Charges = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the other charges: ");
            bill.Other_Charges = double.Parse(Console.ReadLine());
            double Total_Charges = bill.Room_Charges + bill.Doctor_Charges + bill.Other_Charges;

            string isDeleted = "false";

            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "INSERT INTO bill VALUES('" + bill.Id + "',+'" + bill.PatientId + "','" + bill.Room_Charges + "','" + bill.Doctor_Charges + "','" + bill.Other_Charges + "','" + Total_Charges + "','" + isDeleted + "')";
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
        public static List<Bill> UpdateintoDB()
        {
            Bill bill = new Bill();

            // public void GetAllStafffromDB(){}    what if do like this
            List<Bill> list = new List<Bill>();
            Console.WriteLine("Please Enter the Id that you want to update ");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the valid Patient id: ");
            bill.PatientId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the room charges: ");
            bill.Room_Charges = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the doctor charges: ");
            bill.Doctor_Charges = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the other charges: ");
            bill.Other_Charges = double.Parse(Console.ReadLine());
            double Total_Charges = bill.Room_Charges + bill.Doctor_Charges + bill.Other_Charges;


            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "update bill set Patient_Id='" + bill.PatientId + "',RoomCharges='" + bill.Room_Charges + "',DoctorCharges='" + bill.Doctor_Charges + "',OtherCharges='" + bill.Other_Charges + "',TotalCharges='" + Total_Charges + "'Where Id='" + id + "'";
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
        public static List<Bill> DeleteFromDB()
        {
            Bill bill = new Bill();

            List<Bill> list = new List<Bill>();
            Console.WriteLine("Please Enter the Id which you want to delete");
            int id = int.Parse(Console.ReadLine());
            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "update bill set isdeleted='true' Where id='" + id + "'";
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