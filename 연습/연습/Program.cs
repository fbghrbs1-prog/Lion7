using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("캐릭터 이름을 입력하세요");
            string name = Console.ReadLine();
            Console.WriteLine($"환영합니다 {name}님");
            Console.WriteLine($"시작 레벨을 입력해주세요: ");
            string leavel = Console.ReadLine();
            Console.WriteLine($"{name}님의 시작레벨은 {leavel} 입니다");
        }
    }
}
