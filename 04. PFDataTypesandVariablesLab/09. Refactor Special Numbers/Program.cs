using System;


namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigites = 0;
                int digites = num;
                while (digites>0)
                {
                    sumOfDigites += digites % 10;
                    digites = digites / 10;
                }
                bool specialNum = (sumOfDigites == 5) || (sumOfDigites == 7) || (sumOfDigites == 11);
                Console.WriteLine("{0}->{1}",num,specialNum);
            }
        }
    }
}
