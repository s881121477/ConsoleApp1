using System;

namespace ConsoleApp1
{
    class Program
    {
        /*static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            Console.Write("sum=");
            Console.WriteLine(meal_cost+ tip_percent + tax_percent);
        }*/
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputint = int.Parse(input);

            if(inputint % 2 != 0){
                Console.WriteLine("Werid");
            }
            else if(inputint % 2 == 0 && inputint>=2 && inputint<=5){
                Console.WriteLine("Not Werid");
            }
            else if(inputint % 2 == 0 && inputint >=6 && inputint <=20){
                Console.WriteLine("Werid");

            }
            else if(inputint % 2 == 0 && inputint > 20){
                Console.WriteLine("Not Werid")
            
            }
        
        }
    }

}
