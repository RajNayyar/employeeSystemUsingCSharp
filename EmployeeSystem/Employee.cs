using System;
using System.Text;
using System.IO;
namespace EmployeeSystem
{
   
   
    public delegate void Del(Employee employee, int itr);
    class Empty_Exceptions : Exception
    {
        public Empty_Exceptions(string message) : base(message)
        {

        }
    }
    public class Employee
    {
        public string directory = @"/Users/rajpreet/Documents/EmployeeSystem/history.txt";
        public string name;
        public int id;
        public string qualification;
        public string accountType;
       public void setEmployeeData()
        {
            this.name = Console.ReadLine();

            this.id = int.Parse(Console.ReadLine());
            try
            {
                this.qualification = Console.ReadLine();
                if (qualification == "BCA" || qualification == "BSC" || qualification == "BE")
                {
                    this.accountType = "IT Department";
                }
                else if (qualification == "BCOM" || qualification == "BSC" || qualification == "CA")
                {
                    this.accountType = "Accounts Department";
                }
                if (string.IsNullOrEmpty(qualification))
                {
                    throw new Empty_Exceptions("Please enter qualification");
                }
                else
                {
                    Console.WriteLine(this.name + " id: " + this.id + " succesfully added under " + this.accountType);
                }
            }
            catch (Empty_Exceptions empty)
            {
                Console.WriteLine("working");
                Console.WriteLine(empty.Message);

                if (!File.Exists(directory))
                {
                    // Create a file to write to.
                    using (StreamWriter writer = File.AppendText(directory))
                    {
                        writer.WriteLine("Message ex.StackTrace +"+empty.StackTrace);
                    }
                }
            }
        }
    }
}
