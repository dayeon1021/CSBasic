using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //273;
            var name = "최" + "다" + "연";
            Console.Write("Hello C#");

            //int if = 1;

            Console.WriteLine("Hello World");
            Console.Write("Hello World");
            Console.WriteLine(53);
            Console.WriteLine('A');
            Console.WriteLine("A입니다");
            Console.WriteLine("\"A\"입니다");
            Console.WriteLine("최" + "다" + "연");
            //Console.WriteLine("안녕"[100]);

            Console.WriteLine(true);
            Console.WriteLine(false);

            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine((long)a + b);
            Console.WriteLine((long)a + (long)b);
            Console.WriteLine(a + b);       //오버플로우 발생 (범위를 벗어나서)

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(sizeof(char));

            Console.Write("input 테스트 : ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }
    }
}
