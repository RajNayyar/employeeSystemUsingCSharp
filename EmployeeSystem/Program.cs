﻿using System;
using System.Collections.Generic;

namespace EmployeeSystem
{

    class Program
    {
        static void Main(string[] args)
        {
            int option = 0; 
            List<Employee> EmpObjList = new List<Employee>();
            Employee empObj = new Employee();
            while (option != 2)
            {
                Console.WriteLine("Enter 1 to add data and 2 to exit");
                option = int.Parse(Console.ReadLine());
              
                    
                if (option == 1)
                {
                    Console.WriteLine("Enter Name, id and qualification of employee");
                    empObj.setEmployeeData();
                    EmpObjList.Add(empObj);


                }
            }
            

        }
    }
}
