using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class DoctorControler

    {

        public static List<Doctor> GetAllDoctorsfromDB()
        {
            Doctor doctor = new Doctor();

            // public void GetAllDoctorsfromDB(){}    what if do like this
            List<Doctor> list = new List<Doctor>();


            MySqlConnection conn = new MySqlConnection(DBConnection.conString);

            conn.Open();

           

            Console.WriteLine("connect to database successfully");

            String Query = "Select * from doctor where isdeleted='false'";

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = Query;


            MySqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-5}{4,-14}{5,-19}{6,-17}{7,-14}{8,-30}{9,-30}{10,-10}", "|   ", "|     ", "|        ", "|    ", "|          ", "|             ", "|              ", "|     ", "|         ", "|        ", "|");
            Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-5}{4,-14}{5,-19}{6,-17}{7,-14}{8,-30}{9,-30}{10,-10}", "| ID", "| NAME", "| ADDRESS", "| AGE", "| PHONE_NO.", "| QUAIFICATION", "| SPECILIZATION", "| CITY", "| USERNAME", "|PASSWORD", "|");
            Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-5}{4,-14}{5,-19}{6,-17}{7,-14}{8,-30}{9,-30}{10,-10}", "|   ", "|     ", "|        ", "|    ", "|          ", "|             ", "|              ", "|     ", "|         ", "|        ", "|");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");



            while (reader.Read())
            {
                //int docid = reader.GetInt32(0);
                doctor.Id = reader.GetInt32("id");
                doctor.Name = reader.GetString("name");
                doctor.Address = reader.GetString("address");
                doctor.Age = reader.GetInt32("Age");
                doctor.PhoneNumber = reader.GetDouble("PhoneNumber");
                doctor.Qualification = reader.GetString("Qualification");
                doctor.Specilization = reader.GetString("Specilization");
                doctor.City = reader.GetString("City");
                doctor.Username= reader.GetString("username");
                doctor.Password= reader.GetString("password");

                Console.WriteLine("{0,-8}{1,-16}{2,-54}{3,-5}{4,-14}{5,-19}{6,-17}{7,-14}{8,-30}{9,-30}{10,-10}", "| " + doctor.Id, "| " + doctor.Name, "| " + doctor.Address, "| " + doctor.Age, "| " + doctor.PhoneNumber, "| " + doctor.Qualification, "| " + doctor.Specilization, "| " + doctor.City, "| " + doctor.Username, "|" + doctor.Password, "|");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                list.Add(doctor);

            }
            Console.WriteLine("\n\n");
            conn.Close();

            return list;
        }
        public static List<Doctor> InsertIntoDB()
        {
            Doctor doctor = new Doctor();

            // public void GetAllDoctorsfromDB(){}    what if do like this
            List<Doctor> list = new List<Doctor>();

            Console.WriteLine("Please Enter the Name: ");
            doctor.Name=Console.ReadLine();
            Console.WriteLine("Please Enter the Address: ");
            doctor.Address=Console.ReadLine();
            Console.WriteLine("Please Enter the Age: ");
            doctor.Age=int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Phoneno: ");
            doctor.PhoneNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Qualification: ");
            doctor.Qualification=Console.ReadLine();
            Console.WriteLine("Please Enter the Specilization: ");
            doctor.Specilization=Console.ReadLine();
            Console.WriteLine("Please Enter the City: ");
            doctor.City=Console.ReadLine();
            Console.WriteLine("Please Enter the Username: ");
            doctor.Username=Console.ReadLine();
            Console.WriteLine("Please Enter the Password: ");
            doctor.Password=Console.ReadLine();
            string isDeleted = "false";
            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "INSERT INTO DOCTOR VALUES('" +doctor.Id+ "',+'" + doctor.Name + "','" + doctor.Address + "','" + doctor.Age + "','" + doctor.PhoneNumber + "','" + doctor.Qualification + "','" + doctor.Specilization + "','" + doctor.City + "','" + doctor.Username + "','" + doctor.Password + "','" + isDeleted + "')";
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
                Console.WriteLine("     AN UNEXPECTED ERROR OCCUR ..............................\n"+ex);

            }
            conn.Close();

            return list;
        }
        public static List<Doctor> UpdateintoDB()
        {
            Doctor doctor = new Doctor();

            // public void GetAllDoctorsfromDB(){}    what if do like this
            List<Doctor> list = new List<Doctor>();
            Console.WriteLine("Please Enter the Id where you want to update");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the updated Name: ");
            doctor.Name = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Address: ");
            doctor.Address = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Age: ");
            doctor.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the updated Phoneno: ");
            doctor.PhoneNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the updated Qualification: ");
            doctor.Qualification = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Specilization: ");
            doctor.Specilization = Console.ReadLine();
            Console.WriteLine("Please Enter the updated City: ");
            doctor.City = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Username: ");
            doctor.Username = Console.ReadLine();
            Console.WriteLine("Please Enter the updated Password: ");
            doctor.Password = Console.ReadLine();

            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "update doctor set name='" + doctor.Name + "',address='" + doctor.Address + "',Age='" + doctor.Age + "',PhoneNumber='" + doctor.PhoneNumber + "',Qualification='" + doctor.Qualification + "',Specilization='" + doctor.Specilization + "',City='" + doctor.City + "',Username='" + doctor.Username + "',Password='" + doctor.Password + "'Where id='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("                                     ****************DATA UPDATED SUCCESSFULLY*******************");
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
        public static List<Doctor> DeleteFromDB()
        {
            Doctor doctor = new Doctor();

            List<Doctor> list=new List<Doctor>();
            Console.WriteLine("Please Enter the Id which you want to delete");
            int id = int.Parse(Console.ReadLine());
            MySqlConnection conn = new MySqlConnection(DBConnection.conString);
            conn.Open();
            string query = "update doctor set isdeleted='true' Where id='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("                                     ****************DATA DELETED SUCCESSFULLY*******************");
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
