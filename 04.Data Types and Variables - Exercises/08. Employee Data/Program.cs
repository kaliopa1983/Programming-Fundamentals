using System;


namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
     
                string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            ulong idNumber = ulong.Parse(Console.ReadLine());
            ulong employeeNum= ulong.Parse(Console.ReadLine());
            
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " +lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: "+idNumber);
            Console.WriteLine("Unique Employee number: "+ employeeNum);






        }
    }
}
