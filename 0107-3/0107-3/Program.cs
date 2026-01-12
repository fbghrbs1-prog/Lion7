using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0107_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 아이템 구매 시스템
            //int playerGold = 500;
            //int itemPrice = 250;
            //string itemName = "강철 검";

            //Console.WriteLine("==상점==");
            //Console.WriteLine($"아이템 : {itemName}");
            //Console.WriteLine($"가격 : {itemPrice}골드");
            //Console.WriteLine($"소지금 : {playerGold}");
            //Console.WriteLine();

            //if (playerGold >= itemPrice)
            //{ 
            ////구매
            //playerGold -= itemPrice;
            //    Console.WriteLine("구매 완료");
            //    Console.WriteLine($"{itemName}을 획득하였습니다");

            //}
            //else
            //{
            //    //구매 불가
            //    int needGold = itemPrice - playerGold;
            //    Console.WriteLine("골드가 부족합니다!");
            //    Console.WriteLine($"필요한 골드: {needGold}골드 더 필요");
            //}


            //Console.WriteLine("=== 던전 입장 ===");
            //int playerLevel = 60;
            //int requiredLevel = 50;

            //if (playerLevel >= requiredLevel)
            //{
            //    Console.WriteLine("던전에 입장합니다.!");
            //    Console.WriteLine("전투 준비!");
            //}
            //else
            //{
            //    Console.WriteLine("레벨이 부족합니다!");
            //    Console.WriteLine($"필요 레벨 : {requiredLevel}");
            //    Console.WriteLine($"현재 레벨 : {playerLevel}");
            //    Console.WriteLine($"레벨업이 필요합니다: {requiredLevel - playerLevel}레벨");
            //}

            //점수의 따른 등급 판정
            //int score = 3500;
            //string rank;

            //Console.WriteLine($"=== 게임 랭크 시스템 ===" );
            //Console.WriteLine($"스코어를 입력하세요");
            //score = int.Parse( Console.ReadLine() );
            //Console.WriteLine($"점수 : {score}");

            //if (score >= 10000)
            //{
            //    rank = "SSS";
            //    Console.WriteLine($"등급 : {rank} (레전드)");
            //    Console.WriteLine("보상: 전설 아이템 + 골드 10000");
            //}
            //else if (score >= 8000)
            //{
            //    rank = "SS";
            //    Console.WriteLine($"등급 : {rank} (마스터)");
            //    Console.WriteLine("보상: 영웅 아이템 + 골드 5000");
            //}
            //else if (score >= 6000)
            //{
            //    rank = "S";
            //    Console.WriteLine($"등급 : {rank} (다이아)");
            //    Console.WriteLine("보상: 희귀 아이템 + 골드 3000");
            //}
            //else if (score >= 4000)
            //{
            //    rank = "A";
            //    Console.WriteLine($"등급 : {rank} (플래티넘)");
            //    Console.WriteLine("보상: 고급 아이템 + 골드 1500");
            //}
            //else
            //{
            //    rank = "B";
            //    Console.WriteLine($"등급 : {rank} (골드)");
            //    Console.WriteLine("보상: 일반 아이템 + 골드 500");
            //}
            // 캐릭터 상태 판정
            //Console.WriteLine("\n=== 캐릭터 상태 ===");
            //int health = 50;
            ////헬스값을 입력받아서 테스트해보시오.
            //Console.WriteLine(" 체력을 입력하세요 ");
            //health = int.Parse(Console.ReadLine());


            //if (health >= 80)
            //{
            //    Console.WriteLine(" 상태: 매우 좋음");
            //}
            //else if (health >= 60)
            //{
            //    Console.WriteLine(" 상태: 좋음");
            //}
            //else if (health >= 40)
            //{
            //    Console.WriteLine(" 상태: 보통");
            //}
            //else if (health >= 20)
            //{
            //    Console.WriteLine(" 상태: 위험");
            //}
            //else if (health > 0)
            //{
            //    Console.WriteLine(" 상태: 매우 위험!");
            //}
            //else
            //{
            //    Console.WriteLine(" 상태: 사망");
            //}

            //스위치
            //int day = 4;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    default:
            //        Console.WriteLine("유효하지 않은 요일입니다");
            //        break;


            //캐릭터선택화면을 switch 만드시오
            int jobChice = 2;


            Console.WriteLine("캐릭터 생선");
            Console.WriteLine("캐릭터 직업을 선택하세요");
            Console.WriteLine("1전사 2 마법사 3 궁수 4 도적");
            jobChice = int.Parse(Console.ReadLine());
            switch (jobChice)
            {
                case 1:
                    Console.WriteLine("=== 캐릭터 생선 ===");
                    Console.WriteLine("직업 : 전사");
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("직업: 🔮 마법사");
                    Console.WriteLine("특성: 강력한 마법 공격");
                    Console.WriteLine("주 무기: 지팡이, 마법서");
                    Console.WriteLine("스탯: 마나 +100, 마법력 +20");
                    break;

                case 3:
                    Console.WriteLine("직업: 🏹 궁수");
                    Console.WriteLine("특성: 원거리 공격 특화");
                    Console.WriteLine("주 무기: 활, 석궁");
                    Console.WriteLine("스탯: 민첩 +15, 크리티컬 +10%");
                    break;

                case 4:
                    Console.WriteLine("직업: 🗡️ 도적");
                    Console.WriteLine("특성: 빠른 속도와 치명타");
                    Console.WriteLine("주 무기: 단검, 쌍검");
                    Console.WriteLine("스탯: 민첩 +20, 회피율 +15%");
                    break;

                default:
                    Console.WriteLine("❌ 잘못된 선택입니다.");
                    Console.WriteLine("1~4 중에서 선택해주세요.");
                    break;
            }
        }






            }



           




            }

    

