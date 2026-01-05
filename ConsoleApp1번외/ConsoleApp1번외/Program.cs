using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace ConsoleApp1번외
{
    internal class Program
    {
        // P/Invoke 선언
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct CONSOLE_FONT_INFO_EX
        {
            public uint cbSize;
            public uint nFont;
            public COORD dwFontSize;
            public uint FontFamily;
            public uint FontWeight;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string FaceName;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct COORD
        {
            public short X;
            public short Y;
        }

        private const int STD_OUTPUT_HANDLE = -11;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool GetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool bMaximumWindow, ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool SetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool bMaximumWindow, ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);

        static void Main(string[] args)
        {
            //// 이 함수는 1000 1초
            //// 1/1000
            //Console.Write("안");
            //Thread.Sleep(1000);//1초 대기 프로그램을 멈춤
            //// 콘솔내용 한번 싹지움
            //Console.Write("녕");
            //Console.Clear();
            //Thread.Sleep(1000);
            //Console.Write("하");
            //Thread.Sleep(1000);
            //Console.Write("세");
            //Thread.Sleep(1000);
            //Console.Write("요");
            //Thread.Sleep(1000);

            //과제
            //저번시간 만들었던 UI 하나정해서
            //비주얼하게 만들어 보세요

            Console.WriteLine("┌─────────────────────────┐");
            Console.WriteLine("│                         │");

            // 콘솔 폰트를 일시적으로 작게 바꿔서 출력
            var h = GetStdHandle(STD_OUTPUT_HANDLE);
            var original = new CONSOLE_FONT_INFO_EX();
            original.cbSize = (uint)Marshal.SizeOf(typeof(CONSOLE_FONT_INFO_EX));

            if (GetCurrentConsoleFontEx(h, false, ref original))
            {
                // 복사해서 크기만 변경
                var small = original;
                // Y는 폰트 높이(픽셀). 값은 시스템과 폰트에 따라 다르므로 적절히 조절하세요.
                small.dwFontSize.X = original.dwFontSize.X;
                small.dwFontSize.Y = 10; // 더 작게 보이게 할 높이(픽셀) — 필요하면 조정

                if (SetCurrentConsoleFontEx(h, false, ref small))
                {
                    Console.WriteLine("│ 팀                        │");
                    // 출력 후 원래 폰트로 복원
                    SetCurrentConsoleFontEx(h, false, ref original);
                }
                else
                {
                    // 실패 시 기본 출력 (폰트 변경 불가)
                    Console.WriteLine("│ 팀                        │");
                }
            }
            else
            {
                // API 호출 불가하면 기본 출력
                Console.WriteLine("│ 팀                        │");
            }










        }
    }
}