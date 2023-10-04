using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class Program
    {

        static void Main(string[] args)
        {
          gomain:
            while (true)
            {
                Console.Write("\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("                     *********************************************************");
                Console.WriteLine("                     *                          MAIN MENU                    *");
                Console.WriteLine("                     *********************************************************");
                Console.WriteLine("                     *                                                       *");
                Console.WriteLine("                     *  1.For Manipulating Doctor Enter 1                    *");
                Console.WriteLine("                     *                                                       *");
                Console.WriteLine("                     *  2.For Manipulating Patient Enter 2                   *");
                Console.WriteLine("                     *                                                       *");
                Console.WriteLine("                     *  3.For Manipulating Staff Enter 3                     *");
                Console.WriteLine("                     *                                                       *");
                Console.WriteLine("                     *  4.For Bill Calculation Enter 4                       *");
                Console.WriteLine("                     *                                                       *");
                Console.WriteLine("                     *  5.For Exit                                           *");
                Console.WriteLine("                     *                                                       *");
                Console.Write("                     * Enter choice--------------------------------------------------------> ");
                int choice=int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Clear();
                docupper:
                    while (true)
                    {
                        Console.Write("\n\n");
                        Console.WriteLine("                 *******************************************************************");
                        Console.WriteLine("                 *                            DOCTOR MENU                          *");
                        Console.WriteLine("                 *******************************************************************");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   1. Read Doctor Data.                                          *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   2. Add New Doctor.                                            *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   3. Update Existing Doctor.                                    *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   4. Delete Data.                                               *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   5. Return to Main Menu.                                       *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.Write("                 *   Enter Choice -----------------------------------------------------------------> ");
                        int docchoice = int.Parse(Console.ReadLine());
                        if (docchoice == 1)
                        {
                            Console.Clear();
                            List<Doctor> doc = DoctorControler.GetAllDoctorsfromDB();

                        }
                        else if (docchoice == 2)
                        {
                            Console.Clear();
                            List<Doctor> doc = DoctorControler.InsertIntoDB();
                        }
                        else if (docchoice == 3)
                        {
                            Console.Clear();
                            List<Doctor> doc = DoctorControler.UpdateintoDB();
                        }
                        else if (docchoice == 4)
                        {
                            Console.Clear();
                            List<Doctor> doc = DoctorControler.DeleteFromDB();
                        }
                        else if (docchoice == 5)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear() ;
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("<-----------------------------------------------------------------------------------PLEASE ETER WRITE CHOICE -------------------------------------------------------------------------->");
                            goto docupper;
                        }
                    }
                }
                else if (choice == 2)
                {
                    Console.Clear();
                paupper:
                    while (true)
                    {
                        Console.Write("\n\n");
                        Console.Write("\n\n");
                        Console.WriteLine("                 *******************************************************************");
                        Console.WriteLine("                 *                            PATIENT MENU                          *");
                        Console.WriteLine("                 *******************************************************************");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   1. Read Patient Data.                                          *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   2. Add New Patient.                                            *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   3. Update Existing Patient.                                    *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   4. Delete Data.                                               *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   5. Return to Main Menu.                                       *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.Write("                 *   Enter Choice -----------------------------------------------------------------> ");
                        int docchoice = int.Parse(Console.ReadLine());
                        if (docchoice == 1)
                        {
                            Console.Clear();
                            List<Patient> pt = PatientController.GetAllPatientfromDB();

                        }
                        else if (docchoice == 2)
                        {
                            Console.Clear();
                            List<Patient> pt = PatientController.InsertIntoDB();
                        }
                        else if (docchoice == 3)
                        {
                            Console.Clear();
                            List<Patient> pt = PatientController.UpdateintoDB();
                        }
                        else if (docchoice == 4)
                        {
                            Console.Clear();
                            List<Patient> pt = PatientController.DeleteFromDB();
                        }
                        else if (docchoice == 5)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("<-----------------------------------------------------------------------------------PLEASE ETER WRITE CHOICE -------------------------------------------------------------------------->");
                            goto paupper;
                        }
                    }
                }
                else if (choice == 3)
                {
                    Console.Clear();
                paupper:
                    while (true)
                    {
                        Console.Write("\n\n");
                        Console.Write("\n\n");
                        Console.WriteLine("                 *******************************************************************");
                        Console.WriteLine("                 *                            STAFF MENU                          *");
                        Console.WriteLine("                 *******************************************************************");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   1. Read Staff Data.                                          *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   2. Add New Staff.                                            *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   3. Update Existing staff.                                    *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   4. Delete Data.                                               *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   5. Return to Main Menu.                                       *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.Write("                 *   Enter Choice -----------------------------------------------------------------> ");
                        int docchoice = int.Parse(Console.ReadLine());
                        if (docchoice == 1)
                        {
                            Console.Clear();
                            List<Staff> st = StaffController.GetAllStafffromDB();

                        }
                        else if (docchoice == 2)
                        {
                            Console.Clear();
                            List<Staff> st = StaffController.InsertIntoDB();
                        }
                        else if (docchoice == 3)
                        {
                            Console.Clear();
                            List<Staff> st = StaffController.UpdateintoDB();
                        }
                        else if (docchoice == 4)
                        {
                            Console.Clear();
                            List<Staff> st = StaffController.DeleteFromDB();
                        }
                        else if (docchoice == 5)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("<-----------------------------------------------------------------------------------PLEASE ETER WRITE CHOICE -------------------------------------------------------------------------->");
                            goto paupper;
                        }
                    }
                }
                else if (choice == 4)
                {
                    Console.Clear();
                paupper:
                    while (true)
                    {
                        Console.Write("\n\n");
                        Console.Write("\n\n");
                        Console.WriteLine("                 *******************************************************************");
                        Console.WriteLine("                 *                        BILL CALCULATION                         *");
                        Console.WriteLine("                 *******************************************************************");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   1. Read Patient bill.                                          *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   2. Add New bill.                                            *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   3. Update Existing bill.                                    *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   4. Delete bill.                                               *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.WriteLine("                 *   5. Return to Main Menu.                                       *");
                        Console.WriteLine("                 *                                                                 *");
                        Console.Write("                 *   Enter Choice -----------------------------------------------------------------> ");
                        int docchoice = int.Parse(Console.ReadLine());
                        if (docchoice == 1)
                        {
                            Console.Clear();
                            List<Bill> bl = BillControler.GetAllStafffromDB();

                        }
                        else if (docchoice == 2)
                        {
                            Console.Clear();
                            List<Bill> bl = BillControler.InsertIntoDB();
                        }
                        else if (docchoice == 3)
                        {
                            Console.Clear();
                            List<Bill> bl = BillControler.UpdateintoDB();
                        }
                        else if (docchoice == 4)
                        {
                            Console.Clear();
                            List<Bill> BL = BillControler.DeleteFromDB();
                        }
                        else if (docchoice == 5)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("<-----------------------------------------------------------------------------------PLEASE ETER WRITE CHOICE -------------------------------------------------------------------------->");
                            goto paupper;
                        }
                    }
                }
                else if (choice == 5)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n");
                    Console.WriteLine("                               *****************************************************************************************************************************************************");
                    Console.WriteLine("                               *                                                                                                                                                   *");
                    Console.WriteLine("                               *                                                                THANKS FOR USING THIS SYSTEM                                                         *");
                    Console.WriteLine("                               *                                                                                                                                                   *");
                    Console.WriteLine("                               *****************************************************************************************************************************************************");
                    Console.WriteLine("\n\n\n\n\n\n");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("<-----------------------------------------------------------------------------------PLEASE ETER WRITE CHOICE -------------------------------------------------------------------------->");
                    goto gomain;
                }
            }
            
        }
    }
}
