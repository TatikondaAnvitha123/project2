using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retrieve_Student_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\anves\OneDrive\Mphasis\RetrieveStudentData\RetrieveStudentData\students.txt";

            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("Student data from a text file");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
