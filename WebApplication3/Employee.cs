using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerializationDeserializaton
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public DateOfBirth DOB = new DateOfBirth();
    }
    public class DateOfBirth
    {
        public int Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}