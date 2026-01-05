using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //리터럴 : 코드에서 고정된 값을 의미한다
            //int number = 10;
            //double pi = 3.14;
            //char letter = 'a';
            //string name = "Alice";

            //Console.WriteLine(number);
            //Console.WriteLine(pi);
            //Console.WriteLine(letter);
            //Console.WriteLine(name);


            //정수 리터럴 연습
            //플레이스코어 100
            //파이 3.14
            //등급 'A'
            //플레이어이름 홍길동
            //결과 출력하기

            //int score = 100;
            //double pi = 3.14;
            //char 등급 = 'A';
            //string 이름 = "홍길동";

            //Console.WriteLine(score);
            //Console.WriteLine(pi);
            //Console.WriteLine(등급);
            //Console.WriteLine(이름);


            // 정수 리터럴
            int playerScore = 100;        // 100이 정수 리터럴

            // 실수 리터럴
            double pi = 3.14;             // 3.14가 실수 리터럴

            // 문자 리터럴 (작은따옴표)
            char grade = 'A';             // 'A'가 문자 리터럴

            // 문자열 리터럴 (큰따옴표)
            string playerName = "홍길동";  // "홍길동"이 문자열 리터럴

            // 논리 리터럴
            bool isGameOver = false;      // false가 논리 리터럴

            // 결과 출력
            Console.WriteLine("플레이어: " + playerName);
            Console.WriteLine("점수: " + playerScore);
            Console.WriteLine("등급: " + grade);
            Console.WriteLine("파이 값: " + pi);
            Console.WriteLine("게임오버: " + isGameOver);


        }
    }
}
