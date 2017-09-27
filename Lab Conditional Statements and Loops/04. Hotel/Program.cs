using System;


namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            var studioPernight = 0.0;
            var doublePernight = 0.0;
            var suitePernight = 0.0;

            

            if ((month == "May") || month == "October")
            {
                if (nightCount >7)
                {
                    studioPernight = 50.0 *0.95;

                    doublePernight = 65.00;

                    suitePernight = 75.00;
                }
                else
                {
                    studioPernight = 50.0;

                    doublePernight = 65.00;

                    suitePernight = 75.00;
                }
                
            }
            else if ((month == "June") || (month == "September"))
            {
                if (nightCount >14)
                {
                    studioPernight = 60.0;
                   doublePernight = 72.00 * 0.9;
                    suitePernight = 82.00;
                }
                else
                {
                    studioPernight = 60.0;
                    doublePernight = 72.00;
                    suitePernight = 82.00;
                }
            }
            else if ((month == "July") || (month == "August") || (month == "December"))
            {
                if (nightCount >14)
                {   
                    suitePernight = 89.00 * 0.85;
                    studioPernight = 68.0;
                    doublePernight = 77.00;
                }
                else
                {
                    studioPernight = 68.0;
                    doublePernight = 77.00;
                    suitePernight = 89.00;

                }
            }

           
            var studioPrice = studioPernight * nightCount;
            var doublePrice = doublePernight * nightCount;
            var suitePrice = suitePernight * nightCount;

           if((month=="September")||(month=="Octomber"))
            {
                if(nightCount>7) 
                {
                    studioPrice = studioPernight * (nightCount - 1);
                }
                else
                {
                    studioPrice = studioPernight * nightCount;
                }
            }

            Console.WriteLine("Studio: {0:f2} lv.",studioPrice);
            Console.WriteLine("Double: {0:f2} lv.",doublePrice);
            Console.WriteLine("Suite: {0:f2} lv.",suitePrice);



            
        }
    }
}
