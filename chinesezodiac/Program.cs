using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("자신이 태어난 해를 입력하세요 : ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("나머지 : " + (year % 12));
            switch(year%12)
            {
                case 0:
                    Console.WriteLine("당신은 원숭이 띠입니다~");
                    break;
                case 1:
                    Console.WriteLine("당신은 닭 띠입니다~");
                    break;
                case 2:
                    Console.WriteLine("당신은 개 띠입니다~");
                    break;
                case 3:
                    Console.WriteLine("당신은 돼지 띠입니다~");
                    break;
                case 4:
                    Console.WriteLine("당신은 쥐 띠입니다~");
                    break;
                case 5:
                    Console.WriteLine("당신은 소 띠입니다~");
                    break;
                case 6:
                    Console.WriteLine("당신은 호랑이 띠입니다~");
                    break;
                case 7:
                    Console.WriteLine("당신은 토끼 띠입니다~");
                    break;
                case 8:
                    Console.WriteLine("당신은 용 띠입니다~");
                    break;
                case 9:
                    Console.WriteLine("당신은 뱀 띠입니다~");
                    break;
                case 10:
                    Console.WriteLine("당신은 말 띠입니다~");
                    break;
                case 11:
                    Console.WriteLine("당신은 양 띠입니다~");
                    break;
            }
        }
    }
}
