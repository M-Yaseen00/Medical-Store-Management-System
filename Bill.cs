using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class Bill
    {
        public int Id { get; set; }
       public int PatientId { get; set; }
        public double Room_Charges { get; set; }
        public double Doctor_Charges { get; set; }
        public double Other_Charges { get; set; }

        public double Total_Charges { get; set; }

        public Bill()
        {
            Id= 0;
            PatientId= 0;
            Room_Charges= 0;
            Doctor_Charges= 0;
            Other_Charges= 0;
            Total_Charges= 0;
        }
        public Bill(int id, int patientId, double room_Charges, double doctor_Charges, double other_Charges, double total_Charges)
        {
            Id = id;
            PatientId = patientId;
            Room_Charges = room_Charges;
            Doctor_Charges = doctor_Charges;
            Other_Charges = other_Charges;
            Total_Charges = total_Charges;
        }
    }
}
