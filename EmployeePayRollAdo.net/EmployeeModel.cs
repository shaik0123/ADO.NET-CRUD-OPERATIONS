using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayRollAdo.net
{
    public class EmployeeModel
    {
        public int emp_id { get; set; }
        public string emp_name { get; set;}
        public int emp_salary { get; set;}
        public DateTime emp_statDate { get; set;}
        public char gender { get; set;} 
        public long phone { get;set;}
        public string  address { get; set;}
        public int basicpay { get; set;}
        public int deductions { get; set;}
        public int taxablepay { get; set;}
        public int incometax { get; set;}
        public int netpay { get; set;}
        public int dept_id { get; set;}


        public override string ToString()
        {
            return $"employee details for {emp_name} is listed below : \n id ={emp_id}\n name = {emp_name}\n salary ={emp_salary}\nstart date ={emp_statDate}" +
                $"\ngender = {gender}\n phone ={phone}\n address ={address}\n basicpay ={basicpay}\n deductions = {deductions}\n taxablepay={taxablepay}" +
                $"\nincometax ={incometax}\n netpay = {netpay}\ndept_id={dept_id}";
        }

    }
}
