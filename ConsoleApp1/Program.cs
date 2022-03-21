using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            Console.Write("sum=");
            Console.WriteLine(meal_cost+ tip_percent + tax_percent);*/


            /*string input = Console.ReadLine();
            int inputint = int.Parse(input);*/

            /*if(inputint % 2 != 0){
                Console.WriteLine("Werid");
            }
            else if(inputint % 2 == 0 && inputint>=2 && inputint<=5){
                Console.WriteLine("Not Werid");
            }
            else if(inputint % 2 == 0 && inputint >=6 && inputint <=20){
                Console.WriteLine("Werid");

            }
            else if(inputint % 2 == 0 && inputint > 20){
                Console.WriteLine("Not Werid");
            
            }*/

            /* switch (inputint)
             {
                 case 2:
                     Console.WriteLine("is two");
                     break;
             }*/
            /*int sum = 0;
            for (int i = 1;i<= 10; i++)
            {
                sum += 1;
                Console.WriteLine("第" + sum + "次迴圈");
                if (i == 5) {
                    //break;
                    continue;
                }
                
                
            }*/
            /*string input = Console.ReadLine();
            int n = int.Parse(input);
            for(int i = 0; i< n;i++ )
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();*/
            /*for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("N*"+i+"="+(i*n));
            }*/
            /*for (int i = 1; i <= 9; i++){
                for(int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i+"*"+j+"="+(i*j));
                }
            }*/

            /*int[] no = {1,2,3};
            string[] name = {"Jack","Mary","Tom" };
            int[] com = {80,65,100 };
            int[] pro = {75,67,93 };
            int[] des = { 60, 62, 91 };

            while (true)
            {
                Console.WriteLine("請輸入座號");
                var inputno = Console.ReadLine();
                int input = int.Parse(inputno);
                int arrayindex = Array.IndexOf(no, input);
                if (arrayindex > -1)
                {
                    Console.WriteLine("姓名："+name[arrayindex]);
                    Console.WriteLine("電腦概論：" + com[arrayindex]);
                    Console.WriteLine("程式設計：" + pro[arrayindex]);
                    Console.WriteLine("動畫設計：" + des[arrayindex]);
                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                }*/




            /*Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,1}   ", rnd.Next(0, 101));
            }*/



        }

    }
    
}
