using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int health;
            //health = 100;

            //int maxHealth = 100;
            //int damage = 15;

            //Console.WriteLine("체력 : " + health + "/" + maxHealth);

            //Console.WriteLine("데미지수치"+ damage);    

            //같은 데이터 타입의 변수를 쉼표로 군분해 한번에 선언
            int x = 10, y = 20, z = 30; //정수형 x,y,z 선언하고 초기화

            //Console.WriteLine(x); //출력: 10 
            //Console.WriteLine(y); //출력: 20
            //Console.WriteLine(z); //출력: 30


            //int age = 20;
            //Console.WriteLine("나이:{0}", age); //출력: 나이 : 20
            //string name = "철수";
            //Console.WriteLine("이름: {0}, 나이: {1}", name, age);

            //int age = 20;
            //Console.WriteLine($"나이: {age}");

            // 3D 좌표
            int posX = 0, posY = 50, posZ = 100;

            //출력3가지방식으로 출력해보세요
            //console.writeline("이름: {0}, 나이: {1}", name, age);
            Console.WriteLine("x좌표 {0} y좌표{1} z좌표{2}", posX, posY, posZ);
            //console.writeline("나이:" + age);
            Console.WriteLine("x좌표" + posX + " y좌표" + posY + " z좌표" + posZ);
            //console.writeline($"나이:{age} 레벨: {level}");
            Console.WriteLine($"x좌표 {posX}, y좌표 {posY}, z좌표 {posZ}");
            // rgb 색상 값 예시
            int red = 255, green = 128, blue = 0;
            Console.WriteLine("red {0} ,green {1} ,blue {2}", red, green, blue);
            Console.WriteLine("red:" + red + ", green:" + green + ", blue:" + blue);
            Console.WriteLine($"red {red}  green {green}  blue {blue}");
            bool esc = false; 
            Console.WriteLine("esc키가 눌렸나요? {0}", esc);

            sbyte signedByte = -50;  // 1
            

           
            Console.WriteLine("안녕하세요{0}"  +" 누구세요{1}", red, green);

            Console.WriteLine("현재 x 좌표는 {0}" + " 현재 y 좌표는 {1} " + "현재 z 좌표는 {2}", posX, posY, posZ);
            Console.WriteLine("현재 좌표 x좌표" + posX + "현재 y 좌표" + posY + "현재 z좌표 " + posZ);
            Console.WriteLine($"safasdf{posZ}" );

        }
    }
}
