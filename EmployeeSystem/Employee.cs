using System;
using System.Text;
using System.IO;
namespace EmployeeSystem
{
   
   
    public delegate void exDelegate(Employee employee, int itr);
    class exceptions : Exception
    {
        public exceptions(string message) : base(message)
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

                if (string.IsNullOrEmpty(qualification))
                {
                    throw new exceptions("Please enter qualification");
                }
                else
                {
                    Console.WriteLine(this.name + " id: " + this.id + " succesfully added under " + this.accountType);
                }
                if (qualification == "BCA" || qualification == "BSC" || qualification == "BCA")
                {
                    this.accountType = "IT Department";
                }
                else if (qualification == "BCA" || qualification == "BSC" || qualification == "BCA")
                {
                    this.accountType = "Accounts Department";
                }
            }
            catch (exceptions E)
            {
              //  Console.WriteLine("working");
                Console.WriteLine(E.Message);

                if (!File.Exists(directory))
                {
                    // Create a file to write to.
                    using (StreamWriter writer = File.AppendText(directory))
                    {
                        writer.WriteLine("Message ex.StackTrace +"+E.StackTrace);
                    }
                }
            }
        }
    }
}
