using System;


namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var totalSum = 0.0;
            var count = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {

                    if (totalSum >= maxSum)
                    {
                        break;
                    }
                    
                    totalSum += (i*j)*3;
                    count++;
                }
            }

            if(totalSum>=maxSum)
            {
               Console.WriteLine($"{count} combinations");
               Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
            }
            else
             {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {totalSum}");
             }

                  
                   
                } 
                

                   
                }

            }

        
    


        
    


                
                
            
        

               


            
            

        
        
    

