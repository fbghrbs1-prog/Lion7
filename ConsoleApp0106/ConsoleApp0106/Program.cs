using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //사용자 입력을 문자열로 받기
            //Console.WriteLine("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); //사용자로부터 입력 받기
            //Console.Clear();
            //Console.WriteLine($"안녕하세요,{userName}님!");
            Console.WriteLine($"이름을 적어주세요");
            string 이름 = Console.ReadLine();
            Console.WriteLine($"아름이 {이름} 시군요 반갑습니다 {이름}님");
            Console.WriteLine("혹시 나이는 어떻게 되시나요?");
            string 나이 = Console.ReadLine();
            int 숫자 = int.Parse(나이);
            Console.WriteLine($"나이는{나이}되시는군요");


            //문자열을 정수로 변환
            //Console.WriteLine("나이를 입력하세요:");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);
            //Console.WriteLine($"너의 나이는{age}살 구나");

            ////이진수를 정수로 변환
            //Console.WriteLine("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수 >10진수 변환

            ////정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryInput}");

            //=== 캐릭터 생성 ===
            //캐릭터 이름을 입력하세요: 홍길동
            //환영합니다 홍길동님!
            //시작 레벨을 입력하세요: 5
            //홍길동님의 시작 레벨은 5입니다

            //Console.WriteLine("\n캐릭터 이름을 입력하세요");
            //string name = Console.ReadLine();
            //Console.WriteLine($"\n환영합니다, {name}님!");
            //Console.WriteLine("시작 레벨을 입력하세요:");
            //string level = Console.ReadLine() ;
            //int level1 = int.Parse(level);
            //Console.WriteLine($"{name}의 시작 레벨은 {level1}");

            //var를 사용하여 변수 선언
            //var name = "Alice"; //문자열로 추론
            //var age = 25; //정수로 추론
            //var isStudent = true;//논리값으로 추론

            //Console.WriteLine($"이름 {name}, \n나이 {age}, \n학생여부{isStudent}");

            //default 키워드를 사용한 기본값 설정
            //int defaultIn = default; //인트는 0
            //string defaulString = default; //null
            //bool defaultBool = default; //false

            //Console.WriteLine($"정수 기본값: {defaultIn}");
            //Console.WriteLine($"문자열 기본값: {defaulString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");












        }
    }
}
