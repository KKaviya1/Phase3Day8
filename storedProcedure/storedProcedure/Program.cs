//insert**

//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace storedProcedure
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static string connection = "server=DESKTOP-PE7BHIE;Database=Day08;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//                con = new SqlConnection(connection);
//                cmd = new SqlCommand();
//                cmd.CommandText = "usp_eEmployee";
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Connection = con;
//                con.Open();
//                Console.WriteLine("Enter Id : ");
//                cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter First Name : ");
//                cmd.Parameters.AddWithValue("@fn", Console.ReadLine());
//                Console.WriteLine("Enter Last Name : ");
//                cmd.Parameters.AddWithValue("@ln", Console.ReadLine());
//                Console.WriteLine("Enter Salary : ");
//                cmd.Parameters.AddWithValue("@sal", float.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter Date of  Joining : ");
//                cmd.Parameters.AddWithValue("@doj", DateTime.Parse(Console.ReadLine()));
//                Console.WriteLine("Enter Designation : ");
//                cmd.Parameters.AddWithValue("@desg", Console.ReadLine());
//                cmd.ExecuteNonQuery();
//                Console.WriteLine("Employee Registration Success");
//            }
//        }
//}


//delete**
using System;
using System.Data.SqlClient;
using System.Data;

namespace StoredProcedure
{

    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static string conStr = "server=DESKTOP-PE7BHIE;database=Day08; trusted_connection = true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conStr);
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "usp_dEmp";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                Console.WriteLine("Enter ID to DELETE the record");
                int id = int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@id", id);
                int noe = cmd.ExecuteNonQuery();
                if (noe >= 1)
                {
                    Console.WriteLine($"Employee Record of ID: {id} deleted Permanently!!!");
                }
                else
                {
                    Console.WriteLine($"No such Id {id}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }

        }
    }
}
