using System;


namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int iMagic = 0;
            int jMagic = 0;
            int counter = 0;

            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    if (i + j == magic)
                    {
                        iMagic = i; jMagic = j;
                    }
                    counter++;
                }
            }

            if (iMagic != 0)
            {
                Console.WriteLine($"Number found! {iMagic} + {jMagic} = {magic}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }

        }
    }
}
