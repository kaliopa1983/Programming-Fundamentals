using System;


namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());


            if (number1 >= 0 && number1<=100 && number2>=0 &&  number2 <= 100)
            {
                if (number1 < number2)
                {
                    for (int i = number1; i <= number2; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    for (int i = number2; i <=number1; i++)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            else
            {

            }    
        }
    }
}

