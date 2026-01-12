using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _0107_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            //for ( a = 1; a < 5; a++)
            //{
            //    Console.WriteLine("천마연산신공");
            //}

            //=== 몬스터 웨이브 시작 ===
            //  👹 고블린 #1 생성!
            //  👹 고블린 #2 생성!
            // 👹 고블린 #3 생성!
            // 👹 고블린 #4 생성!
            // 👹 고블린 #5 생성!
            //총 5마리 생성 완료!


            //for (int x =1; x <= 5; x++)
            //{
            //    Console.WriteLine($"//고블린 #{x}생산");
            //}
            //Console.WriteLine("총 5마리 생성 완료!");  

            // === 게임 시작 카운트다운 ===
            //5...
            //  4...
            //   3...
            //        2...
            //       🎮 게임 시작!

            //Console.WriteLine("카운트 다운");
            //for (int a = 5; a >= 1; ++a)
            //{
            //    Console.WriteLine($"{a}");
            //}
            //Console.WriteLine("게임 스타트");

            // 카운트다운
            //Console.WriteLine("=== 게임 시작 카운트다운 ===");
            //int count = 5;
            //for ( count = 5; count >= 1; count--)
            //{
            //    Console.WriteLine($"{count}...");
            //}
            //Console.WriteLine("🎮 게임 시작!\n");
            //for (; ; )// 무한 반복한다
            //{
            //    Console.WriteLine("d");
            //    Thread.Sleep(1000);
            //}

            //랜덤함수
            //게임에서 굉장히 중요한 기능이다.



            // Random 객체 생성
            //   Random random = new Random();

            //   //사용 방법
            //   int number = random.Next(1, 7);
            //   Console.WriteLine(number);
            //   // 주요 메서드
            //   int number1 = random.Next();           // 0 ~ int.MaxValue
            //   int number2 = random.Next(10);         // 0 ~ 9
            //   int number3 = random.Next(1, 7);       // 1 ~ 6 (주사위)
            //   double number4 = random.NextDouble();  // 0.0 ~ 1.0

            //Random a = new Random();
            //   int b = a.Next(5,8);
            //   Console.WriteLine(b);

            /*검 종류
             * 무한의 대검 10
             * 카타나       
             * 엑스칼리버
             * 정기정검
            */


            //string sword = "무한의 대검";

            //Console.WriteLine("당신은 20번뽑기가 가능합니다. 지금 실행합니다.");

            //Random rand = new Random();

            //int random = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    random = rand.Next(1, 101);

            //    if (random >= 1 && random <= 10)
            //    {
            //        sword = "무한의 대검";
            //    }
            //    else if (random >= 11 && random <= 30)
            //    {
            //        sword = "카타나";
            //    }
            //    else if (random >= 31 && random <= 60)
            //    {
            //        sword = "엑스칼리버";
            //    }
            //    else if (random >= 61 && random <= 100)
            //    {
            //        sword = "정기정검";
            //    }

            //    Console.WriteLine(sword);
            //    Thread.Sleep(500);
            //}


            //내가만든 문제 
            //검키우기 만들기 
            //검은 종류는 5개 
            //1.꽃다발 2.나무몽둥이 3.철검 4.광선검 5.무형검
            //2. 스펙 각 강화에 따른 공격력을 지님 
            //3. 강화확률 모두동일 25퍼확률 파괴 25퍼확률 유지 50퍼확률성공 
            //4. 최대 강화 15강 
            //5. 강화에 필요한 골드 100골드 
            //6. 보유골드 100000골드 
            //7. 파괴 시 랜덤 무기 지급

            Console.WriteLine("~검 키우기~");
            Console.WriteLine("검 종류\n1.꽃다발 2.나무몽둥이 3.철검 4.광선검 5.무형검");
            string 꽃다발, 나무몽두이, 철검, 광선검, 무형검;
            Console.WriteLine($"검을 뽑으시겠습니까?");
            Console.WriteLine($"뽑기 1번 아니요 2번");
            int a = int.Parse(Console.ReadLine());
            
            if (a == 1)
            {
                Random Ran = new Random();
                Random Ran1 = new Random();
                int random = Ran.Next(1,6);
                int random1 = Ran1.Next(1, 11);
                if (random == 1)
                {
                    Console.WriteLine($"꽃다발 을뽑았다");
                    Console.WriteLine($"강화 하시겠습니까?");
                    string co = Console.ReadLine();
                    if (co == "예")
                    {
                        for (; ; )
                        { int xo = 0; 
                            switch (random1)
                            { case 1:
                                    Console.WriteLine($"강화 실패 {xo}꽃다발");
                                    Console.WriteLine($"다시 강화하시겠습니까?");
                                    Console.WriteLine($"y,x");
                                    char y = char.Parse(Console.ReadLine());
                                    if (y == x)
                                    {
                                        Console.WriteLine($"그럼 이만");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine($"강화 실패 {xo}꽃다발");
                                    Console.WriteLine($"다시 강화하시겠습니까?");
                                    Console.WriteLine($"y,x");
                                    char y = char.Parse(Console.ReadLine());
                                    if (y == x)
                                    {
                                        Console.WriteLine($"그럼 이만");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine($"강화 실패 {xo}꽃다발");
                                    Console.WriteLine($"다시 강화하시겠습니까?");
                                    Console.WriteLine($"y,x");
                                    char y = char.Parse(Console.ReadLine());
                                    if (y == x)
                                    {
                                        Console.WriteLine($"그럼 이만");
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine($"강화 성공 {xo++}꽃다발");
                                    Console.WriteLine($"다시 강화하시겠습니까?");
                                    Console.WriteLine($"y,x");
                                    char y = char.Parse(Console.ReadLine());
                                    if (y == x)
                                    {
                                        Console.WriteLine($"그럼 이만");
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine($"강화 선공 {xo++}꽃다발");
                                    Console.WriteLine($"다시 강화하시겠습니까?");
                                    Console.WriteLine($"y,x");
                                    char y = char.Parse(Console.ReadLine());
                                    if (y == x)
                                    {
                                        Console.WriteLine($"그럼 이만");
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine($"강화 성공 {xo++}꽃다발");
                                    Console.WriteLine($"다시 강화하시겠습니까?");
                                    Console.WriteLine($"y,x");
                                    char y = char.Parse(Console.ReadLine());
                                    if (y == x)
                                    {
                                        Console.WriteLine($"그럼 이만");
                                    }
                                    break;
                                case 7:
                                    Console.WriteLine($"강화 성공 {xo++}꽃다발");
                                    Console.WriteLine($"다시 강화하시겠습니까?");
                                    Console.WriteLine($"y,x");
                                    char y = char.Parse(Console.ReadLine());
                                    if (y == x)
                                    {
                                        Console.WriteLine($"그럼 이만");
                                    }
                                    break;
                                case 8:
                                    Console.WriteLine($"강화 대실패 {--xo}꽃다발");
                                    Console.WriteLine($"다시 강화하시겠습니까?");
                                    Console.WriteLine($"y,x");
                                    char y = char.Parse(Console.ReadLine());
                                    if (y == x)
                                    {
                                        Console.WriteLine($"그럼 이만");
                                    }
                                    break;
                                case 9:
                                    Console.WriteLine($"강화 대성공 {xo+2}꽃다발");
                                    Console.WriteLine($"다시 강화하시겠습니까?");
                                    Console.WriteLine($"y,x");
                                    char y = char.Parse(Console.ReadLine());
                                    if (y == x)
                                    {
                                        Console.WriteLine($"그럼 이만");
                                    }
                                    break;
                                case 10:
                                    Console.WriteLine($"강화 선공 {++xo}꽃다발");
                                    Console.WriteLine($"다시 강화하시겠습니까?");
                                    Console.WriteLine($"y,x");
                                    char y = char.Parse(Console.ReadLine());
                                    if (y == x)
                                    {
                                        Console.WriteLine($"그럼 이만");
                                    }
                                    break;
                            }
                            




                        }

                    }
                    else { Console.WriteLine($"그럼 말고"); }
                }
                else if (random == 2)
                {
                    Console.WriteLine($"나무몽두이를 뽑았다");
                    Console.WriteLine($"강화 하시겠습니까?");
                    string co = Console.ReadLine();
                    if (co == "예")
                    {
                    }
                    else { Console.WriteLine($"그럼 말고"); }
                }
                else if (random == 3)
                {
                    Console.WriteLine($"철검을 뽑았다");
                    Console.WriteLine($"강화 하시겠습니까?");
                    string co = Console.ReadLine();
                    if (co == "예")
                    {
                    }
                    else { Console.WriteLine($"그럼 말고"); }
                }
                else if (random == 4)
                {
                    Console.WriteLine($"광선검을 뽑았다");
                    Console.WriteLine($"강화 하시겠습니까?");
                    string co = Console.ReadLine();
                    if (co == "예")
                    {
                    }
                    else { Console.WriteLine($"그럼 말고"); }
                }
                else 
                {
                    Console.WriteLine($"무형검을 뽑았다");
                    Console.WriteLine($"강화 하시겠습니까?");
                    string co = Console.ReadLine();
                    if (co == "예")
                    {
                    }
                    else { Console.WriteLine($"그럼 말고"); }
                }


            }
            else 
            {
                Console.WriteLine($"다음에 도전 하세요");
                Console.WriteLine($"강화 하시겠습니까?");
                string co = Console.ReadLine();
                if (co == "예")
                {
                }
                else { Console.WriteLine($"그럼 말고"); }
            }



        }
    }
}
