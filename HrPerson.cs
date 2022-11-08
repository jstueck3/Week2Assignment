using System;

namespace Module2Assignment
{
    public class HrPerson
    {
        public object outputReport;

        public void HireEmployee(string firstName, string lastName, string ssn) {
            Employee e = new Employee(firstName, lastName, ssn);
            object employees;
            orientEmployee(e);
        }

        // HRManager delegates work to employee
        private void orientEmployee(Employee emp) {
            emp.doFirstTimeOrientation("B101");
        }

        public void OutputReport(string ssn) {

            // find employee in list
            
        }

        public void hireEmployee(string firstName, string lastName, string ssn)
        {
            throw new NotImplementedException();
        }
    }
}