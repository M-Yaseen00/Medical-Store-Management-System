using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double PhoneNumber { get; set; }
        public int Age { get; set; }

        public string gender { get; set; }
        public string Disease { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string Admit_Date { get; set; }

        public Patient()
        {
            Id = 0;
            Name= string.Empty;
            Address = string.Empty;
            PhoneNumber = 0;
            Age = 0;
            gender= string.Empty;
            password = string.Empty;
            username = string.Empty;
            Disease= string.Empty;
            Admit_Date= string.Empty;

        }
        public Patient(int id, string name, string address, double phoneNumber, int age, string gender, string disease, string password, string username, string admit_Date)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Age = age;
            this.gender = gender;
            Disease = disease;
            this.password = password;
            this.username = username;
            Admit_Date = admit_Date;
        }
        
    }
}
