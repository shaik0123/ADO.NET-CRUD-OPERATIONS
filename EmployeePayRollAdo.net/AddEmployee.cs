using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayRollAdo.net
{
    public class AddEmployee
    {

        public static EmployeeModel AddEmpData(EmployeeModel employeeModel)
        {
            //Console.WriteLine("enter id : ");
            //employeeModel.emp_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  name : ");
            employeeModel.emp_name = Console.ReadLine();
            Console.WriteLine("enter salary : ");
            employeeModel.emp_salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter start date : ");
            employeeModel.emp_statDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter gender : ");
            employeeModel.gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter phone : ");
            employeeModel.phone = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter address : ");
            employeeModel.address = Console.ReadLine();
            Console.WriteLine("enter basicpay : ");
            employeeModel.basicpay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter deductions : ");
            employeeModel.deductions = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter taxablepay : ");
            employeeModel.taxablepay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter incometax : ");
            employeeModel.incometax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter netpay : ");
            employeeModel.netpay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter dept_id : ");
            employeeModel.dept_id = Convert.ToInt32(Console.ReadLine());

            return employeeModel;
        }
    }
}
