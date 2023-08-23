//display**

//using Entity_Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //internal class Program
//{
//    static Day08Entities2 db;
//    static void Main(string[] args)
//    {
//        try
//        {
//            db = new Day08Entities2();
//            foreach (Emp e in db.Emps)
//            {
//                Console.WriteLine("ID: " + e.Id);
//                Console.WriteLine("FirstName: " + e.Fname);
//                Console.WriteLine("LastName: " + e.Lname);
//                Console.WriteLine("Salary: " + e.Salary);
//                Console.WriteLine("Date of Joining:" + e.DOJ);
//                Console.WriteLine("Designation: " + e.Designation);
//                Console.WriteLine("");

//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);

//        }
//        finally
//        {
//            Console.ReadKey();
//        }
//    }
//}


//insert**

//using Entity_Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Entity_Framework
//{   
//    internal class Program
//        {
//        static Day08Entities2 db;
//        static void Main(string[] args)
//        {
//            try
//            {
//                db = new Day08Entities2();

//                Emp emp = new Emp();
//                Console.WriteLine("Enter ID: ");
//                emp.Id = int.Parse(Console.ReadLine());
//                Console.WriteLine(" Enter FirstName: ");
//                emp.Fname = Console.ReadLine();
//                Console.WriteLine("Enter LastName: ");
//                emp.Lname = Console.ReadLine();
//                Console.WriteLine("Enter Salary: ");
//                emp.Salary = double.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Date of Joining:");
//                emp.DOJ = DateTime.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Designation: ");
//                emp.Designation = Console.ReadLine();
//                db.Emps.Add(emp);
//                db.SaveChanges();
//                Console.WriteLine("Employee record inserted!!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);

//            }
//            finally
//            {
//                Console.ReadKey();
//            }
//        }
//    }
//}


//Update**
//using Entity_Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Entity_Framework
//{
//    internal class Program
//    {
//        static Day08Entities2 db;
//        static Emp emp;
//        static void Main(string[] args)
//        {
//            try
//            {
//                db = new Day08Entities2();
//                Console.WriteLine("Enter Id to update the details");
//                int id = int.Parse(Console.ReadLine());
//                emp = db.Emps.SingleOrDefault(e => e.Id == id);
//                if (emp == null)
//                {
//                    Console.WriteLine("No such Id " + id + "exist in Day08");
//                }
//                else
//                {

//                    Console.WriteLine("Enter New FirstName: ");
//                    emp.Fname = Console.ReadLine();
//                    Console.WriteLine("Enter New LastName: ");
//                    emp.Lname = Console.ReadLine();
//                    Console.WriteLine("Enter New Salary: ");
//                    emp.Salary = double.Parse(Console.ReadLine());
//                    Console.WriteLine("Enter New Date of Joining:");
//                    emp.DOJ = DateTime.Parse(Console.ReadLine());
//                    Console.WriteLine("Enter New Designation: ");
//                    emp.Designation = Console.ReadLine();

//                    db.SaveChanges();
//                    Console.WriteLine("Employee record updated!!");

//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);

//            }
//            finally
//            {
//                Console.ReadKey();
//            }
//        }
//    }
//}



//Delete**
using Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    internal class Program
    {
        static Day08Entities2 db;
        static Emp emp;
        static void Main(string[] args)
        {
            try
            {
                db = new Day08Entities2();
                Console.WriteLine("Enter Id to delete the details");
                int id = int.Parse(Console.ReadLine());
                emp = db.Emps.SingleOrDefault(e => e.Id == id);
                if (emp == null)
                {
                    Console.WriteLine("No such Id " + id + "exist in Day08");
                }
                else
                {
                    db.Emps.Remove(emp);
                    db.SaveChanges();
                    Console.WriteLine("Employee record deleted!!");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
