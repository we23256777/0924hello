using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            String ipt;
            Console.WriteLine("Hello CSharp World!");
            Console.WriteLine("정수 입력  :");
            /*
            ipt = console.ReadLine();
            num1 * int.parse(ipt);
            */
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째정수 입력  :");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 = "+" = num2 + "=" + (num1 + num2));
            Console.WriteLine(num1 = "-" = num2 + "=" + (num1 - num2));
            Console.WriteLine(num1 = "*" = num2 + "=" + (num1 * num2));
            Console.WriteLine(num1 = "/" = num2 + "=" + (num1 / num2));



        }
    }
}
