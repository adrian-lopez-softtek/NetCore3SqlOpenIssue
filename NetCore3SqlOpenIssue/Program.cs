using System;
using Microsoft.Data.SqlClient;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
            using (var conn = new SqlConnection("Data Source=DBHOST;Initial Catalog=DATABASE;User ID=USER;Password=PASS;Connect Timeout=30;"))
            {
                //This doesn't work with our SQL Server 2016 Service Pack 1 CU7 version from Linux container
                conn.Open();                
            }
            //This code is never executed
            Console.WriteLine("Goodbye World!");
        }
    }
}
