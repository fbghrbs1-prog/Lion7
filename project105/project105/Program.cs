using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //상수: 값을 변경할 수 없는 변수
            //const double pi = 3.14159; //상수 pi 선언 및 초기화
            //const int Maxscore = 100; //정수형 상수 선언

            ////출력
            //Console.WriteLine("Pi: " + pi);
            //Console.WriteLine("Maxscore : " + Maxscore);

            //**실행 결과 : **
            //'''
            //=== 게임 설정 ===
            //최대 플레이어 : 4명
            //시작 골드 : 1000G
            //버전 1.0.0
            //'''
            //const string MaxPlayer = "4명"; //최대 플레이어 수
            //const  int gold = 1000; //시작 골드
            //const string version = "1.0.0"; //게임 버전

            //Console.WriteLine("=== 게임 설정 ===");
            //Console.WriteLine("최대 플레이어 : " + MaxPlayer);
            //Console.WriteLine("시작 골드 : " + gold + "G");
            //Console.WriteLine("버전 "+ version);

            // 게임 설정 상수
            //const int MAX_PLAYER_COUNT = 4;      // 최대 플레이어 수
            //const int STARTING_GOLD = 1000;      // 시작 골드
            //const double PI = 3.14159;           // 원주율
            //const string GAME_VERSION = "1.0.0"; // 게임 버전

            //// 상수 사용
            //Console.WriteLine("=== 게임 설정 ===");
            //Console.WriteLine($"최대 플레이어: {MAX_PLAYER_COUNT}명");
            //Console.WriteLine($"시작 골드: {STARTING_GOLD}G");
            //Console.WriteLine($"버전: {GAME_VERSION}");

            //숫자 데이터 형식 :  정수와 실수를 다룰 때 사용하는 데이터 타입
            //int intergerNum = 10;          // 정수형 데이터
            //float floatNum = 3.14f;      // 단정밀도 실수
            //double doubleNum = 3.14159265359; // 배정밀도 실수

            //Console.WriteLine(intergerNum);//출력 : 10
            //Console.WriteLine(floatNum);//출력 : 3.14
            //Console.WriteLine(doubleNum);//출력 : 3.14159265359

            //byte level = 50;           // 0 ~ 255
            //short attack = 1500;      // -32,768 ~ 32,767
            //int gold = 1234567;        // -2,147,483,648 ~ 2,147,483,647
            //long experience = 99999999; // 매우 큰 정수

            //Console.WriteLine("===캐릭터 정보===");
            //Console.WriteLine($"레벨: {level}");
            //Console.WriteLine($"공격력: {attack}");
            //Console.WriteLine($"소지금: {gold:N0}골드 ");
            //Console.WriteLine($"경험치: {experience:N0}");

            ////타입별 최대값 확인
            //Console.WriteLine("===타입별 최대값===");
            //Console.WriteLine($"byte 최대값: {byte.MaxValue:n0}");
            //Console.WriteLine($"short 최대값: {short.MaxValue:N0}");
            //Console.WriteLine($"int 최대값: {int.MaxValue:N0}");
            //Console.WriteLine($"long 최대값: {long.MaxValue:N0}");

            //실수 데이터 형식 : 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f;        // 단정밀도 실수(4바이트) 끝에 f 또는 F를 붙임
            //double doublePrecision = 3.14159265359; // 배정밀도 실수(8바이트) 기본형
            //decimal highPrecision = 3.1415926535897932384626433833m; // 고정소수점(16바이트) 끝에 m 또는 M를 붙임

            //Console.WriteLine(singlePrecision); // 출력 : 3.14
            //Console.WriteLine(doublePrecision); // 출력 : 3.14159265359
            //Console.WriteLine(highPrecision);   // 출력 : 3.1415926535897932384626433833

            //접미사 사용: 숫자의 데이터 형식을 명시
            //int integerValue = 100;        // 정수형(int)
            //long longValue = 100L;       // 장정밀도 정수형(long)
            //float floatValue = 3.14f;    // 단정밀도 실수형(float)
            //double doubleValue = 3.14159; // 배정밀도 실수형(double)
            //decimal decimalValue = 3.14159m; // 고정소수점 실수형(decimal)

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            // char 문자형 데이터 : 단일 문자를 표현하는 데이터 타입
            //char letter = 'A';          // 문자 'A'
            //char symbol = '#';         // 특수문자 '#'
            //char number = '9';         // 문자 '9' 숫자 9가아닌 문자 '9'

            //Console.WriteLine(letter); // 출력 : A
            //Console.WriteLine(symbol); // 출력 : #
            //Console.WriteLine(number); // 출력 : 9

            //출력
            //이동속도 5.5
            //공격속도 1.25
            //아이템가격12.99
            //float speedUnit = 5.5f; 
            //double attackSpeed = 1.25;
            //decimal itemPrice = 12.99m;
            //Console.WriteLine("=== 캐릭터 능력치 ===");
            //Console.WriteLine("이동속도 " + speedUnit);
            //Console.WriteLine("공격속도 " + attackSpeed);
            //Console.WriteLine("아이템가격" + itemPrice);

            //string 문자열 데이터 : 문자들의 집합을 표현하는 데이터 타입(0개 이상의 문자)
            //string grreting = "Hello, World!"; // 문자열 선언 및 초기화
            //string name = "Alice";         // 플레이어 이름

            //Console.WriteLine(grreting+"안녕 월드라는 뜻"); // 출력 : Hello, World!
            //Console.WriteLine($"나의 이름은 {name}"); // 출력 : 플레이어 이름: Alice

            //문자열 (string) - 단 하나의문자만
            //char grade = 'A';
            //char symbol = '★';
            //char number = '9'; // 문자 '9'이지 숫자 9가 아님!

            //// 문자열 (string) - 여러 문자의 조합
            //string playerName = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다!";
            //string emptyString = ""; // 빈 문자열도 가능


            //실행 결과:
            //=== RPG 게임 ===
            //플레이어: 홍길동
            //등급: A등급 ★
            //게임에 오신 것을 환영합니다!

            //Console.WriteLine("=== RPG 게임 ===");
            //Console.WriteLine($"플레이어: {playerName}");
            //Console.WriteLine($"등급: {grade}등급 {symbol}");
            //Console.WriteLine(welcomeMessage);

            //bool 형식 : 참(true) 또는 거짓(false)을 나타내는 데이터 타입
            //bool isRunning = true;  // 게임이 실행 중인지 여부
            //bool isFinished = false;    // 플레이어가 열쇠를 가지고 있는지 여부

            //Console.WriteLine(isRunning); // 출력: 게임 실행 중: True
            //Console.WriteLine(isFinished); // 출력: 게임 종료 여부: False

            //실전 예제

            //===게임상태===
            //게임 실행 중: True
            //일시정지: False
            //열쇠 소지: False
            //문 열림: False

            //== 캐릭터 상태 ==
            //채력: 80
            //건강 상태: True
            //휘험 상태: False

            //bool isGameRunning = true;    
            //bool isPaused = false;        
            //bool hasKey = false;          
            //bool isDoorOpen = false;      
            //int health = 80;              
            //bool isHealthy = true;        
            //bool isInjured = false;       
            //Console.WriteLine("=== 게임 상태 ===");
            //Console.WriteLine($"게임 실행 중: {isGameRunning}");
            //Console.WriteLine($"일시정지: {isPaused}");
            //Console.WriteLine($"열쇠 소지: {hasKey}");
            //Console.WriteLine($"문 열림: {isDoorOpen}");
            //Console.WriteLine("\n== 캐릭터 상태 ==");
            //Console.WriteLine($"체력: {health}");
            //Console.WriteLine($"건강 상태: {isHealthy}");
            //Console.WriteLine($"부상 상태: {isInjured}");

            //bool isGameRunning = true;
            //bool isGamePaused = false;
            //bool hasKey = false;
            //bool isDoorOpen = false;
            //bool isPlayerAlive = true;

            //Console.WriteLine("=== 게임 상태 ===");
            //Console.WriteLine($"게임 실행 중: {isGameRunning}");
            //Console.WriteLine($"일시정지: {isGamePaused}");
            //Console.WriteLine($"열쇠 소지: {hasKey}");
            //Console.WriteLine($"문 열림: {isDoorOpen}");
            //Console.WriteLine($"플레이어 생존: {isPlayerAlive}");

            //// 캐릭터 상태
            //int playerHealth = 80;
            //bool isHealthy = playerHealth >= 50;
            //bool isLowHealth = playerHealth < 30;

            //Console.WriteLine("\n=== 캐릭터 상태 ===");
            //Console.WriteLine($"체력: {playerHealth}");
            //Console.WriteLine($"건강 상태: {isHealthy}");
            //Console.WriteLine($"위험 상태: {isLowHealth}");

            //// 아이템 소지 여부
            //bool hasWeapon = true;
            //bool hasArmor = false;
            //bool hasPotion = true;

            //Console.WriteLine("\n=== 인벤토리 ===");
            //Console.WriteLine($"무기 보유: {(hasWeapon ? "있음" : "없음")}");
            //Console.WriteLine($"방어구 보유: {(hasArmor ? "있음" : "없음")}");
            //Console.WriteLine($"포션 보유: {(hasPotion ? "있음" : "없음")}");
            //Console.WriteLine($"건강 상태 :{(isHealthy ? "양호" : "위험")}");
            //Console.WriteLine($"건강 상태 :{(isHealthy ? "양호" : "위험")}");

            //bool hp = playerHealth >= 80;
            //Console.WriteLine($"체력: {(hp ? "풀체력" : "모자름")}");


            //int number = 123;
            //string numberAsString = number.ToString(); //정수를 문자열로 변환

            //bool flag = true;
            //string flagAsString = flag.ToString(); //논리값을 문자열로 변화

            //Console.WriteLine(numberAsString); //"123"
            //Console.WriteLine(flagAsString); //"true"

            int sss = 153;
            string sting = sss.ToString();
            Console.WriteLine(sting);
            












        }
    }
}
