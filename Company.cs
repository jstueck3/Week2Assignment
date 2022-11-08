using System;

namespace Module2Assignment
{
    public class Company
    {
        private HrPerson hr;

        public Company() {
            hr = new HrPerson();
        }

        public void HireEmployee(string firstName, string lastName, string ssn)
        {
            hr.hireEmployee(FirstName, LastName, ssn);
            if (hr.outputReport != null) hr.OutputReport(ssn);
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}