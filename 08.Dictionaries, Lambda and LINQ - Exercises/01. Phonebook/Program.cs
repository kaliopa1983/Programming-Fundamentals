using System;
using System.Collections.Generic;



namespace _01.Phonebook
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] phoneParameters = input.Split(new char[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries);
                string command = phoneParameters[0];
                if (command == "A")
                {
                    string key = phoneParameters[1];
                    string value = phoneParameters[2];
                    
                    phonebook[key] = value;
                }
                else
                {
                    string key = phoneParameters[1];

                      if (phonebook.ContainsKey(key))
                       {
                        Console.WriteLine($"{key} -> {phonebook[key]}");
                       }
                       else
                       {
                        Console.WriteLine($"Contact {key} does not exist.");
                       }
                }
              input = Console.ReadLine();
            }
            
        }
    }
}
