using ConsoleBaseProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Qualification { get; set; }
        public string Specilization { get; set; }
        public string City { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Doctor()
        {
            Id= 0;
            Name = String.Empty;
            Address= String.Empty;
            PhoneNumber = 0;
            Age = 0;
            Qualification= String.Empty;
            Specilization= String.Empty;
            City= String.Empty;
            Username= String.Empty;
            Password= String.Empty;
        }
        public Doctor(int id, string name, string address, double phoneNumber, int age, string qualification, string specilization, string city, string username, string password)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Age = age;
            Qualification = qualification;
            Specilization = specilization;
            City = city;
            Username = username;
            Password = password;
        }
    }
}
