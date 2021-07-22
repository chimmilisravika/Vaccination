using System;
using System.Collections.Generic;
using System.Text;

namespace Vaccination
{
   public class Vaccination_Details
    {
        //Vaccination Input Details
        public Vaccination_Details()
        {
            userName = string.Empty;
            Gender = string.Empty;
            contactNumber = string.Empty;
            Age = string.Empty;
            vaccineName = string.Empty;
            Address = string.Empty;
            addressProof = string.Empty;
        }
        public string userName { get; set; }
        public string Gender { get; set; }
        public string contactNumber { get; set; }
        public string Age { get; set; }
        public string  vaccineName { get; set; }
        public string Address { get; set; }
        public string addressProof { get; set; }

    }
}
