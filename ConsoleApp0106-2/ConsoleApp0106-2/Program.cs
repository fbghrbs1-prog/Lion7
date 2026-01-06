using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0106_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1. 암시적 변환 (작은 타입 > 큰 타입)
            //int smallNumber = 100;
            //long bigNumber = smallNumber; // int에서 long(자동변환)
            //double doubleNumer = smallNumber; //int 에서 double로 자돈 변환

            //Console.WriteLine("===암시적 변환==");
            //Console.WriteLine($"int: {smallNumber.GetType()}");
            //Console.WriteLine($"long: {bigNumber.GetType()}");
            //Console.WriteLine($"double: {doubleNumer.GetType()}");
            ////2 명시적 변환 (큰타입 작은 타입)
            //double pi = 3.14159;
            //int intPi = (int)pi;
            //Console.WriteLine("\n===명시적 변환===");
            //Console.WriteLine($"double : {pi}");
            //Console.WriteLine($"int로 변환 : {intPi}");
            int maxHp = 100;
            int playerHp = 80;
            int damege = -25;
            int hill = +30;
            int dog = -5;
            Console.WriteLine($"초기 체력: {playerHp}/{maxHp}");
            Console.WriteLine($"데미지:{damege}  {playerHp += damege}/{maxHp}");
            Console.WriteLine($"회복 {+hill}: {playerHp += hill}/{maxHp}");
            Console.WriteLine($"독 데미지 {dog}: {playerHp += dog}/{maxHp} ");

            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;
            int exp = expPerMonster * monstersKilled;

            Console.WriteLine($"\n처치한 몬스터 {monstersKilled}마리");
            Console.WriteLine($"획득한 경험치{expPerMonster*monstersKilled}exp");
            Console.WriteLine($"레벨업까지 필요한 경험치 {expForLevelUp -exp}");

            int totalGold = 1234;
            int partyMembers = 5;
            Console.WriteLine($"\n총 골드: {totalGold}");
            Console.WriteLine($"파티원: {partyMembers}명");
            Console.WriteLine($"1인당 골드: {totalGold/partyMembers}골드");
            Console.WriteLine($"남은골드:{totalGold % partyMembers}골드");

            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int currentHP = 60;
            int maxHP = 100;
            int xa = maxHp - currentHP;

            Console.WriteLine($"\n===던전 입장 조건===");
            Console.WriteLine($"레벨 조건 (30% 이상): {playerLevel>=requiredLevel}");
            Console.WriteLine($"열쇠 보유: {hasKey}");
            Console.WriteLine($"체력 조건 (50% 이상): { currentHP >=  maxHP/2 }");
            Console.WriteLine($"입장 가능?: {playerLevel >= requiredLevel&&hasKey&&currentHP >= maxHP / 2}");

            int originalPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;
            double sale = 0.8;
            int coupon = -500;


            Console.WriteLine($"\n원가: {originalPrice}골드");
            Console.WriteLine($"vip 할인 (20%): {originalPrice * sale}골드 ");
            Console.WriteLine($"쿠폰 할인 (-500) {(originalPrice * sale) + coupon}골드");
            Console.WriteLine($"최종 가격: {(originalPrice * sale) + coupon}골드");









        }
    }
}
