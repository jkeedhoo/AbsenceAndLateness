﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.StudentInfo;

namespace Core
{
    public class Student : Person
    {
        public string ID;       
        public ResponsibleParty PersonResponsible { get; set; }        
        
        public Student(string studentID)
        {
            this.ID = studentID;
        }

        public Student(string ID, string first, string last)
        {
            this.ID = ID;
            Name = new FullName(first, last);
        }

        public Student(string ID, string first, string last, string studentStreet, string studentCity, string responsiblePartyFirstName, string responsiblePartyLastName, string responsiblePartyMobileNumber, string responsiblePartyHomeAddressStreet, string responsiblePartyHomeAddressCity)
        {
            this.ID = ID;
            Name = new FullName(first, last);
            PersonResponsible = new ResponsibleParty(responsiblePartyFirstName, responsiblePartyLastName, responsiblePartyMobileNumber, responsiblePartyHomeAddressStreet, responsiblePartyHomeAddressCity);
            HomeAddress = new ResidentialAddress(studentStreet, studentCity);
            ContactNumber = new PhoneNumber();            
        }        
    }
}
