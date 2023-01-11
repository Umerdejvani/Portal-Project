using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal_Project.Models
{
    public class RoundOne
    {
        public int Id { get; set; }
        public string canidateName { get; set; }
        public string fatherName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PhoneOne { get; set; }
        public string PhoneSec { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CNIC { get; set; }
        public string PositionAF { get; set; }
        public string DesiredSalary { get; set; }
        public DateTime StartEmpDate { get; set; }
        public string OldEmp { get; set; }

        public string HSCEdu { get; set; }
        public string FSCEdu { get; set; }
        public string BSEdu { get; set; }
        public string MSEdu { get; set; }

        public string Skills { get; set; }
        public string Qualification { get; set; }



        public string CurrentEmp { get; set; }
        public string CE_Position { get; set; }
        public string CE_Salary { get; set; }
        public string CE_Reason { get; set; }
        public DateTime CE_StartDate { get; set; }
        public Boolean CE_MayContact { get; set; }


        public string LastEmp { get; set; }
        public string LE_Position { get; set; }
        public string LE_Salary { get; set; }
        public string LE_Reason { get; set; }
        public DateTime LE_StartDate { get; set; }
        public DateTime LE_EndDate { get; set; }

        public string SecondLastEmp { get; set; }
        public string SLE_Position { get; set; }
        public string SLE_Salary { get; set; }
        public string SLE_Reason { get; set; }
        public DateTime SLE_StartDate { get; set; }
        public DateTime SLE_EndDate { get; set; }

    }
}
