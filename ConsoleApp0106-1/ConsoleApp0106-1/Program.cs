using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0106_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////3. 문자열을 숫자로 변환
            //string scoreText = "95";
            //int score = int.Parse(scoreText); //문자열>정수

            //string priceText = "19.99";
            //double price = double.Parse(priceText);

            //Console.WriteLine("\n===문자열 변환===");
            //Console.WriteLine($"점수(문자열): {scoreText}> 숫자: {score}");
            //Console.WriteLine($"가격(문자열) : {priceText}> 숫자: {price}");

            ////4 숫자를 문자열로 변환
            //int playerLevel = 50;
            //string levelText = playerLevel.ToString();

            //Console.WriteLine("==== 숫자를 문자열로");
            //Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열 : {levelText}");

            //// 연산자
            //int a= 5, b= 10;
            //int sum = (a + b);
            //bool isEqual = (a == b); //관계형 연산자 사용
            //Console.WriteLine($"합 : {sum}");
            //Console.WriteLine($"a와b가 같은가? {isEqual}");

            //단항 연산자
            //int number = 5;
            //Console.WriteLine(+number); // 양수 출력 ; 5
            //Console.WriteLine(-number); // 음수 -5

            //bool flag = false;
            //Console.WriteLine(!flag);// 논리 부정 : 반대로 바꿔준다.

            //int a = 1, b = 3;
            //Console.WriteLine(a+b);
            //Console.WriteLine(a-b);
            //Console.WriteLine(a*b);
            //Console.WriteLine(a/b);
            //Console.WriteLine(a%b);

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + $" {lastName} " + lastName);// 출력: Alice Smith


            //int a = 5;
            //int b = 4;

            //a = a + b;
            //Console.WriteLine("합계 : {0} ", a, b);
            //a = 5;
            //a = a - b;
            //Console.WriteLine("합계 : {0} ", a, b);
            //a = 5;
            //a = a * b;
            //Console.WriteLine("합계 : {0} ", a, b);
            //a = 5;
            //a = a / b;
            //Console.WriteLine("합계 : {0} ", a, b);


            ////할당 연산자
            //a = 5;
            //a += b;

            //Console.WriteLine($"합계 : {a} ");
            //a = 5;
            //a -= b;
            //Console.WriteLine("합계 : {0} ", a, b);
            //a = 5;
            //a *= b;
            //Console.WriteLine("합계 : {0} ", a, b);
            //a = 5;
            //a /= b;
            //Console.WriteLine("합계 : {0} ", a, b);
            //a = 5;
            //a %= b;
            //Console.WriteLine("합계 : {0} ", a, b);

            //캐릭터 스탯 계산
            //int baseAttack = 50;
            //int weaponDamage = 30;
            //int totalAttack = baseAttack + weaponDamage;

            //Console.WriteLine("===공격력 계산===");
            //Console.WriteLine($"기본 공격력 : {baseAttack}");
            //Console.WriteLine($"무기 데미지 : {weaponDamage}");
            //Console.WriteLine($"총 공격력 : {totalAttack}");

            ////데미지 계산
            //int playerHealth = 100;
            //int damage = 25;
            //playerHealth = playerHealth - damage;

            //Console.WriteLine("\n===데미지 계산===");
            //Console.WriteLine($"받는 데미지 {damage}");
            //Console.WriteLine($"남는 체력 {playerHealth}");

            ////경험치 계산
            //int monsterSkilled = 5;
            //int expPerMonster = 100;
            //int totalExp = monsterSkilled * expPerMonster;
            //Console.WriteLine("\n====경험치 획득====");
            //Console.WriteLine($"처치한 몬스터 : {monsterSkilled}");
            //Console.WriteLine($"몬스터당 경험치 : {expPerMonster}");
            //Console.WriteLine($"총 경험치 : {totalExp}");

            ////아이템 분배
            //int totalGold = 1000;
            //int playerCount = 4;
            //int goldPerPlayer = totalGold / playerCount;
            //int remainingGold = totalGold % playerCount;
            //Console.WriteLine($"\n===골드 분배===");
            //Console.WriteLine($"총 골드 : {totalGold}");
            //Console.WriteLine($"플레이어수 : {playerCount}");
            //Console.WriteLine($"1인당 골드 : {goldPerPlayer}");
            //Console.WriteLine($"남는 골드 : {remainingGold}");

            //증감 연산자 ++ --
            //int b = 3;
            //b++;// 후위증가
            //Console.WriteLine(b);
            //b = 3;
            //--b;
            //Console.WriteLine(b);

            //전위 후위 증가 중요
            //int count = 5;

            //count++;

            /*Console.WriteLine(count)*/
            
            //int count = 1;
            //Console.WriteLine("===몬스터 처치===");
            //Console.WriteLine($"고블린 처치!(킬 카운트: {count})");
            //Console.WriteLine($"오크 처치!(킬 카운트 : {++count})");
            //Console.WriteLine($"드래곤 처치! (킬 카운트 : {++count} )");
            //Console.WriteLine($"{count}마리");
            //int gun = 30; 
            //Console.WriteLine($"\n===사격===");
            //Console.WriteLine($"남은 탄약: {gun}");
            //Console.WriteLine($"발사 남은 탄약: {--gun}");
            //Console.WriteLine($"발사 남은 탄약: {--gun}");
            //Console.WriteLine($"발사 남은 탄약: {--gun}");

            //Console.WriteLine($"\n=== 카운트다운 ===");
            //Console.WriteLine($"{count}");
            //Console.WriteLine($"{--count}");
            //    Console.WriteLine($"{--count}");


            //int x = 5;
            //int y = 10;
            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x <= y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x != y); // 같지않지않냐? t
            //Console.WriteLine(x == y); // 같지? f

            //AND
            //bool a = true;
            //bool b = true;
            //Console.WriteLine(a && b);
            //a = false;
            //b = true;
            //Console.WriteLine(a && b);
            //a = true;
            //b = false;
            //Console.WriteLine(a && b);
            //a = false;
            //b = false;
            //Console.WriteLine(a && b);


            ////OR
            //bool a = false, b = false;
            //Console.WriteLine(a || b);
            //a = false; b = true;
            //Console.WriteLine(a || b);
            //a = true;  b = false;
            //Console.WriteLine(a || b);
            //a = true;  b = true;
            //Console.WriteLine(a || b);

            //!
            //bool a = false;

            //Console.WriteLine(!a);

            //비트 연산

            //int x = 5; // 0101
            //int y = 3; // 0011
            //Console.WriteLine(x & y); // AND 1 0001
            //Console.WriteLine(x | y); // OR 7 0111
            //Console.WriteLine(x ^ y); // XOR 6 0110
            //Console.WriteLine(~x);    // NOT 6

            //쉬프트 연산자
            // << >> 이동시킬수있다
            //int value = 4;
            //string binary = Convert.ToString(value<<1, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");
            //binary = Convert.ToString(value >> 1, 2);
            ////<< >>
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //int inventory = 0; // 0000 0000

            //Console.WriteLine($"초기 인벤토리 : {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            /*플레이어의 현재 체력이 80이고, 최대 체력이 100입니다.
              몬스터에게 25의 데미지를 받았습니다
              회복 포션으로 30을 회복했습니다
              독 데미지로 5를 받았습니다
              최종 체력을 계산하여 출력하세요*/.
            int maxHp = 100;
            int playerHp = 80;
            int mamege = -25;
            int hill = +30;
            int dog = -5;
            Console.WriteLine($"초기 체력: {playerHp}/{maxHp}");
            Console.WriteLine($"데미지:{mamege}  {playerHp += mamege}/{maxHp}");
            Console.WriteLine($"회복 {+hill}: {playerHp += hill}/{maxHp}");
            Console.WriteLine($"독 데미지 {dog}: {playerHp += dog}/{maxHp} ");


















        }
        }
    }
}
