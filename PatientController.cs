using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class PatientController

    {

        public static List<Patient> GetAllPatientfromDB()
        {
            Patient patient = new Patient();

            // public void GetAllDoctorsfromDB(){}    what if do like this
            List<Patient> list = new List<Patient>();


            MySqlConnection conn = new MySqlConnection(DBConnection.conString);

            conn.Open();


            Console.WriteLine("connect to database successfully");

            String Query = "Select * from patient where isdeleted='false'";

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = Query;


            MySqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-14}{4,-5}{5,-14}{6,-17}{7,-25}{8,-20}{9,-30}{10,-10}", "|   ", "|     ", "|        ", "|           ", "|    ", "|             ", "|         ", "|     ", "|         ", "|        ", "|");
            Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-14}{4,-5}{5,-14}{6,-17}{7,-25}{8,-20}{9,-30}{10,-10}", "| ID", "| NAME", "| ADDRESS", "| PHONE_NO.", "| AGE", "| GENDER", "| PASSWORD", "| USERNAME", "| DISEASE", "| ADMIT DATE", "|");
            Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-14}{4,-5}{5,-14}{6,-17}{7,-25}{8,-20}{9,-30}{10,-10}", "|   ", "|     ", "|        ", "|           ", "|    ", "|             ", "|         ", "|     ", "|         ", "|        ", "|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");



            while (reader.Read())
            {
                //int docid = reader.GetInt32(0);
                patient.Id = reader.GetInt32("Id");
                patient.Name = reader.GetString("Name");
                patient.Address = reader.GetString("Address");
                patient.Age = reader.GetInt32("Age");
                patient.PhoneNumber = reader.GetDouble("PhoneNumber");
                patient.gender = reader.GetString("gender");
                patient.Disease = reader.GetString("Disease");
                patient.Admit_Date = reader.GetString("AdmitDate");
                patient.username = reader.GetString("Username");
                patient.password = reader.GetString("Password");

                Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-14}{4,-5}{5,-14}{6,-17}{7,-25}{8,-20}{9,-30}{10,-10}", "| " + patient.Id, "| " + patient.Name, "| " + patient.Address, "| " + patient.PhoneNumber, "| " + patient.Age, "| " + patient.gender, "| " + patient.password, "| " + patient.username, "| " + patient.Disease, "|" + patient.Admit_Date, "|");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                list.Add(patient);

            }
            Console.WriteLine("\n\n");
            conn.Close();

            return list;
        }
        public static List<Patient> InsertIntoDB()
        {
            Patient patient = new Patient();

            // public void GetAllDoctorsfromDB(){}    what if do like this
            List<Patient> list = new List<Patient>();

            Console.WriteLine("Please Enter the Name: ");
            patient.Name = Console.ReadLine();
            Console.WriteLine("Please Enter the Address: ");
            patient.Address = Console.ReadLine();
            Console.WriteLine("Please Enter the Age: ");
            patient.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Phoneno: ");
            patient.PhoneNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Gender: ");
            patient.gender = Console.ReadLine();
            Console.WriteLine("Please Enter the Admit Date: ");
            patient.Admit_Date = Console.ReadLine();
            Console.WriteLine("Please Enter the Disease: ");
            patient.Disease = Console.ReadLine();
            Console.WriteLine("Please Enter the Username: ");
            patient.username = Console.ReadLine();
            Console.WriteLine("Please Enter the Password: ");
            patient.password = Console.ReadLine();
            string isDeleted = "false";
            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "INSERT INTO PATIENT VALUES('" + patient.Id + "',+'" + patient.Name + "','" + patient.Address + "','" + patient.PhoneNumber + "','" + patient.Age + "','" + patient.gender + "','" + patient.password + "','" + patient.username + "','" + patient.Disease + "','" + patient.Admit_Date + "','" + isDeleted + "')";
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
        public static List<Patient> UpdateintoDB()
        {
            Patient patient = new Patient();

            // public void GetAllDoctorsfromDB(){}    what if do like this
            List<Patient> list = new List<Patient>();
            Console.WriteLine("Please Enter the Id where you want to update");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the updated Name: ");
            patient.Name = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Address: ");
            patient.Address = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Age: ");
            patient.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the updated Phoneno: ");
            patient.PhoneNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the updated Gender: ");
            patient.gender = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Admit Date: ");
            patient.Admit_Date = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Disease: ");
            patient.Disease = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Username: ");
            patient.username = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Password: ");
            patient.password = Console.ReadLine();

            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "update patient set Name='" + patient.Name + "',Address='" + patient.Address + "',Age='" + patient.Age + "',PhoneNumber='" + patient.PhoneNumber + "',gender='" + patient.gender + "',Disease='" + patient.Disease + "',AdmitDate='" + patient.Admit_Date + "',Username='" + patient.username + "',Password='" + patient.password + "'Where id='" + id + "'";
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
        public static List<Patient> DeleteFromDB()
        {
            Patient patient = new Patient();

            List<Patient> list = new List<Patient>();
            Console.WriteLine("Please Enter the Id which you want to delete");
            int id = int.Parse(Console.ReadLine());
            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "update patient set isdeleted='true' Where id='" + id + "'";
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

