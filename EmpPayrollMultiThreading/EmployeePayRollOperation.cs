using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollMultiThreading
{
   public class EmployeePayRollOperation
    {
        List<EmpDetails> employeeDetails = new List<EmpDetails>();

        public void addEmployeeToPayRoll(List<EmpDetails> listemployeeDetails)
        {
            listemployeeDetails.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.EmployeeName);

            }
                );
            Console.WriteLine(this.employeeDetails.ToString());
        }

        private void addEmployeeToPayroll(EmpDetails emp)
        {
            employeeDetails.Add(emp);
        }

        public void addEmployeeToPayRollWithThread(List<EmpDetails> listemployeeDetails)
        {
            listemployeeDetails.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Console.WriteLine("Employee added: " + employeeData.EmployeeName);
                });
                thread.Start();

            }
                );
            Console.WriteLine(this.employeeDetails.ToString());
        }
    }
}
