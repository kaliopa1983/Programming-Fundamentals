using System;


namespace _03.NameLastDigit
{
    class NameLastDigit
    {
        static void Main()
        {
             long number = long.Parse(Console.ReadLine());

            string text = " ";

            Console.WriteLine( LastDigitName(number,text));
        }

        
        static string LastDigitName(long number,string name )

        {

         
           
            if (number%10==0)
            {
              name = "zero";
            }
         else if (number%10==1)
            {
                 name= "one";
            }
          else if (number%10==2)
            {
                name= "two";
            } 
            else if (number%10==3)
            {
                 name= "three";
            }
            else if (number%10==4)
            {
                 name= "four"; 
            }
            else if (number%10==5)
            {
                 name= "five"; 
            }
            else if (number%10==6)
            {
                 name= "six"; 
            }
            else if (number%10==7)
            {
                 name= "seven"; 
            }
            else if (number%10==8)
            {
                name= "eight";
            }
            else if(number%10==9)
            {
                name= "nine"; 
            }


            return name;   
         
                
            }
        }
    }

