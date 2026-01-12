using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace 연습
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> stats = new Dictionary<string, int>();

            //데이터추가
            stats.Add("HP", 150);
            stats.Add("MP", 80);
            stats.Add("공격력", 75);
            stats.Add("방어력", 50);
            stats.Add("민첩", 60);


            Console.WriteLine("=== 캐릭터 스탯 ===");

            foreach (KeyValuePair<string, int> stat in stats)
            {
                Console.WriteLine($"{stat.Key}: {stat.Value}");
            }

            //키 존재 확인
            string searchStat = "방어력";

            if (stats.ContainsKey(searchStat))
            {
                Console.WriteLine($"방어력은?{stats[searchStat]}");
            }
            else
            {
                Console.WriteLine("해당스탯이 없습니다.");
            }
        }
    }
}
