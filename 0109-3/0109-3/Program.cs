using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0109_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[][] raid = new string[3][];

            //raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };  //4명
            //raid[1] = new string[] { "도적", "전사", "힐러" };            //3명
            //raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" }; //5명

            //Console.WriteLine("=== 레이드 파티 구성 ===");
            //for (int i = 0; i < raid.Length; i++)
            //{
            //    Console.WriteLine($"파티 {i + 1} ({raid[i].Length}명):");
            //    for (int j = 0; j < raid[i].Length; j++)
            //    {
            //        Console.WriteLine($" - {raid[i][j]}");
            //    }
            //}
            //List<int> numbers = new List<int>();           // 빈 리스트
            //List<string> names = new List<string>();       // 문자열 리스트
            //List<float> prices = new List<float>();        // 실수 리스트

            //// 초기값과 함께 선언
            //List<int> scores = new List<int> { 85, 90, 78, 95 };
            //List<string> items = new List<string> { "검", "방패", "포션" };

            //// C# 3.0 이후 간단한 초기화
            //var players = new List<string> { "철수", "영희", "민수" };

            //List<string> items = new List<string>();
            //// Add: 끝에 추가
            //items.Add("회복 포션");
            //items.Add("마나 포션");
            //Console.WriteLine(items[0]);

            //List<string> inventory = new List<string>();

            //Console.WriteLine("=== 도적 인벤토리 시스템 ==");

            ////아이템 추가 (Add)
            //inventory.Add("회복 포션");
            //inventory.Add("마나 포션");
            //inventory.Add("강철 검");
            //Console.WriteLine("아이템 3개 추가");

            ////현재 인벤토리
            //Console.WriteLine($"인벤토리 ({inventory.Count}개):");

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}
            //Console.WriteLine();
            //inventory[0] = "초록포션";

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            //Dictionary<string, int> stats = new Dictionary<string, int>();


            //////데이터추가
            //stats.Add("HP", 150);
            //stats.Add("MP", 80);
            //stats.Add("공격력", 75);
            //stats.Add("방어력", 50);
            //stats.Add("민첩", 60);


            //Console.WriteLine("=== 캐릭터 스탯 ===");

            //foreach (KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}

            ////키 존재 확인
            //string searchStat = "방어력";

            //if (stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine(stats[searchStat]);
            //}
            //else
            //{
            //    Console.WriteLine("해당스탯이 없습니다.");
            //}
            //            === 상점 아이템 ===
            //회복 포션: 50골드
            //마나 포션: 40골드
            //강철 검: 500골드
            //가죽 갑옷: 300골드
            //마법 반지: 1000골드

            //✅ '강철 검' 구매 성공!
            //남은 골드: 100

            // 아이템 가격표
        //    Console.WriteLine("\n=== 상점 아이템 ===");
        //    Dictionary<string, int> shop = new Dictionary<string, int>
        //{
        //    { "회복 포션", 50 },
        //    { "마나 포션", 40 },
        //    { "강철 검", 500 },
        //    { "가죽 갑옷", 300 },
        //    { "마법 반지", 1000 }
        //};

        //    foreach (var item in shop)
        //    {
        //        Console.WriteLine($"{item.Key}: {item.Value}골드");
        //    }

        //    // 구매 시스템
        //    string buyItem = "강철 검";
        //    int playerGold = 600;

        //    if (shop.ContainsKey(buyItem))
        //    {
        //        int price = shop[buyItem];
        //        if (playerGold >= price)
        //        {
        //            playerGold -= price;
        //            Console.WriteLine($"\n✅ '{buyItem}' 구매 성공!");
        //            Console.WriteLine($"남은 골드: {playerGold}");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"\n❌ 골드가 부족합니다!");
        //        }
        //    }




        }

       
    }
    
}
