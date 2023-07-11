using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayRollAdo.net
{
    public class EmployeeRepository
    {
        //public static string connection = @"Data source = SHAIK_S\\SQLEXPRESS; initial catalog = New_Emp_Pay_Roll; integrated security=true;";
        public static string connection = @"Data Source=SHAIK_S\SQLEXPRESS;Initial Catalog=New_Emp_Pay_Roll;Integrated Security=True;";

        public static SqlConnection sqlConnection;
        public static EmployeeModel model = new EmployeeModel();
        
        public static void AddEmplyee(EmployeeModel employee)
        {
            try { 
            sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("USpAddEmployee", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@emp_id", employee.emp_id);
            cmd.Parameters.AddWithValue("@emp_name", employee.emp_name);
            cmd.Parameters.AddWithValue("@emp_salary", employee.emp_salary);
            cmd.Parameters.AddWithValue("@emp_statDate", employee.emp_statDate);
            cmd.Parameters.AddWithValue("@gender", employee.gender);
            cmd.Parameters.AddWithValue("@phone", employee.phone);
            cmd.Parameters.AddWithValue("@address", employee.address);
            cmd.Parameters.AddWithValue("@basicpay", employee.basicpay);
            cmd.Parameters.AddWithValue("@deductions", employee.deductions);
            cmd.Parameters.AddWithValue("@taxablepay", employee.taxablepay);
            cmd.Parameters.AddWithValue("@incometax", employee.incometax);
            cmd.Parameters.AddWithValue("@netpay", employee.netpay);
            cmd.Parameters.AddWithValue("@dept_id", employee.dept_id);

            sqlConnection.Open();
            int result = cmd.ExecuteNonQuery();
            if(result != 0)
            {
                Console.WriteLine("data added successfully");
            }
            else 
            {
                Console.WriteLine("data not added");
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sqlConnection.Close();

        }
        public static void GetAllEmployee()
        {
            try
            {
                using (sqlConnection = new SqlConnection(connection))
                {
                    SqlCommand cmd = new SqlCommand("GetAllDetails", sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.emp_id = Convert.ToInt32(reader["emp_id"]);
                            model.emp_name = reader["emp_name"].ToString();
                            model.emp_salary = Convert.ToInt32(reader["emp_salary"]);
                            model.emp_statDate = Convert.ToDateTime(reader["emp_statDate"]);
                            model.gender = Convert.ToChar(reader["gender"]);
                            model.phone = Convert.ToInt64(reader["phone"]);
                            model.address = reader["address"].ToString();
                            model.basicpay = Convert.ToInt32(reader["basicpay"] == DBNull.Value ? default : reader["basicpay"]);
                            model.deductions = Convert.ToInt32(reader["deductions"] == DBNull.Value ? default : reader["deductions"]);
                            model.taxablepay = Convert.ToInt32(reader["taxablepay"] == DBNull.Value ? default : reader["taxablepay"]);
                            model.incometax = Convert.ToInt32(reader["incometax"] == DBNull.Value ? default : reader["incometax"]);
                            model.netpay = Convert.ToInt32(reader["netpay"] == DBNull.Value ? default : reader["netpay"]);
                            model.dept_id = Convert.ToInt32(reader["dept_id"]);
                            Console.Out.WriteLine(model);
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UpdateEmp()
        {
            Console.WriteLine("enter the emp id you want to update address");
            int _emp_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the new address");
            string _emp_address = Console.ReadLine();

            sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("UpdateDetails", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_id", _emp_id);
            cmd.Parameters.AddWithValue("@address", _emp_address);
            sqlConnection.Open();
            int result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                Console.WriteLine("data update successfully");
            }
            else
            {
                Console.WriteLine("data not update");
            }
            sqlConnection.Close ();

        }
        public static void GetEmployee_ById()
        {
            try
            {
                Console.WriteLine("enter the emp id you want to get details");
                int emp_id = Convert.ToInt32(Console.ReadLine());
                using (sqlConnection = new SqlConnection(connection))
                {
                    SqlCommand cmd = new SqlCommand("GetDetailsById", sqlConnection);
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@emp_id",emp_id);
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.emp_id = Convert.ToInt32(reader["emp_id"]);
                            model.emp_name = reader["emp_name"].ToString();
                            model.emp_salary = Convert.ToInt32(reader["emp_salary"]);
                            model.emp_statDate = Convert.ToDateTime(reader["emp_statDate"]);
                            model.gender = Convert.ToChar(reader["gender"]);
                            model.phone = Convert.ToInt64(reader["phone"]);
                            model.address = reader["address"].ToString();
                            model.basicpay = Convert.ToInt32(reader["basicpay"] == DBNull.Value ? default : reader["basicpay"]);
                            model.deductions = Convert.ToInt32(reader["deductions"] == DBNull.Value ? default : reader["deductions"]);
                            model.taxablepay = Convert.ToInt32(reader["taxablepay"] == DBNull.Value ? default : reader["taxablepay"]);
                            model.incometax = Convert.ToInt32(reader["incometax"] == DBNull.Value ? default : reader["incometax"]);
                            model.netpay = Convert.ToInt32(reader["netpay"] == DBNull.Value ? default : reader["netpay"]);
                            model.dept_id = Convert.ToInt32(reader["dept_id"]);
                            Console.Out.WriteLine(model);
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DeleteEmpBy_Id()
        {
            Console.WriteLine("enter the emp id you want to delete data");
            int emp_id = Convert.ToInt32(Console.ReadLine());

            sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("DeleteEmpDetailsBy_Id", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_id", emp_id);
            sqlConnection.Open();
            int result = cmd.ExecuteNonQuery();
            if (result != 0)
            {
                Console.WriteLine("data deleted successfully");
            }
            else
            {
                Console.WriteLine("data not deleted");
            }
            sqlConnection.Close();

        }

    }
}