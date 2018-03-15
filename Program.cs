using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入身高(cm): ");
            string height = Console.ReadLine();
            float h = float.Parse(height) / 100;
            Console.Write("請輸入體重(kg): ");
            string weight = Console.ReadLine();
            float w = float.Parse(weight);
            float BMI = (w / (h * h));
            if (BMI < 16.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 不只體重過輕還不用當兵...");
            }
            if (16.5 <= BMI && BMI < 18.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 體重過輕喔...");
            }
            if (18.5 <= BMI && BMI < 24)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 您的體重正常喔");
            }
            if (24 <= BMI && BMI < 28)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 您的體重超重喔...");
            }
            if (28 <= BMI && BMI <= 31.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 您是肥宅吧?");
            }
            if (BMI > 31.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 你不只肥宅還免役不用當兵");
            }

            Console.ReadLine();


        }
    }
}
