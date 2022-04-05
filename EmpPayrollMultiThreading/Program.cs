using System;
using System.Collections.Generic;

namespace EmpPayrollMultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Payroll program using MultiTreading ");

            List<EmpDetails> employeeDetails = new List<EmpDetails>();
            employeeDetails.Add(new EmpDetails(EmployeeID: 1, EmployeeName: "Bruce1", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 2, EmployeeName: "Bruce2", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 3, EmployeeName: "Bruce3", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 4, EmployeeName: "Bruce4", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 5, EmployeeName: "Bruce5", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 6, EmployeeName: "Bruce6", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 7, EmployeeName: "Bruce7", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 8, EmployeeName: "Bruce8", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 9, EmployeeName: "Bruce9", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 10, EmployeeName: "Bruce10", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));


            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();
            DateTime startTime = DateTime.Now;
            employeePayRollOperation.addEmployeeToPayRoll(employeeDetails);
            DateTime EndTime = DateTime.Now;
            Console.WriteLine("start time=" + startTime);
            Console.WriteLine("end time=" + EndTime);
            Console.WriteLine("Duration without thread=" + (startTime - EndTime));


            DateTime ThreadStartTime = DateTime.Now;
            employeePayRollOperation.addEmployeeToPayRollWithThread(employeeDetails);
            DateTime ThreadEndTime = DateTime.Now;
            Console.WriteLine("start time=" + ThreadStartTime);
            Console.WriteLine("end time=" + ThreadEndTime);
            Console.WriteLine("Duration with thread=" + (ThreadStartTime - ThreadEndTime));

        }
    }
}
