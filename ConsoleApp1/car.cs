using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        string color = "red";
        int cc = 1500;
        string brand = "BMW";

        public void StartEngin()
        {
            Console.WriteLine("啟動引擎");
        }
        public void Showinfo()
        {
            Console.WriteLine("顏色"+ color);
            Console.WriteLine("CC數"+ cc);
            Console.WriteLine("品牌" + brand);
        }
    }
}
