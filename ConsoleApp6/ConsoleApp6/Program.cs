using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int level = 9;
            int score = 1350;
            int hp    = 100;
            int mp    = 100;
            string name = "유호균";
            string 힘 = "";  
                string 민첩 = "";
                string 지능 = "";
            힘 = 민첩;
                string 행운 = "";
            Console.WriteLine($"{힘}");
            Console.WriteLine(hp + mp); 
            Console.WriteLine("나의 이름은 " + name);
            

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ level {level}          ┃ ");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ score {score}       ┃ ");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ hp    {hp   }        ┃ ");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ mp    {mp   }        ┃ ");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━┛");
          
            
            int gp = 200, dp = 150;
            Console.WriteLine("이러쿵 저러쿵" + gp +" 저러쿵이러쿵" + dp);
        }
    }
}
