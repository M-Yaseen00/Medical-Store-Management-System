using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffAddress { get; set; }
        public double StaffPhoneNumber { get; set; }
        public string StaffDutyWork { get; set; }
        

        public Staff()
        {
            StaffId = 0;
            StaffName = string.Empty;
            StaffAddress = string.Empty;
            StaffPhoneNumber = 0;
            StaffDutyWork = string.Empty;
            
        }
        public Staff(int id, string name, string address, double phoneNumber, string staffdutyhours)
        {
            StaffId = id;
            StaffName = name;
            StaffAddress = address;
            StaffPhoneNumber = phoneNumber;
            StaffDutyWork = staffdutyhours;
           
        }
    }
}