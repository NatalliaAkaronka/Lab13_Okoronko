using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Okoronko
{
    class Program
    {
        public static string StandartConverter(int number)
        {
            return Convert.ToString(number, 2);
        }
        public static string MyConverter(int number)
        {
            string result = string.Empty;
            int modulo;

            while (true)
            {
                if (number == 0)
                    break;

                modulo = number % 2;
                number /= 2;
                result += modulo;
            }
            char[] symbols = result.ToCharArray();
            result = string.Empty;

            for (int i = symbols.Length - 1; i >= 0; i--)
            {
                result += symbols[i];
            }
            return result;
        }
            static void Main(string[] args)
        {

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            string Binnumber = StandartConverter(number);
            Console.WriteLine("Число в двоичной системе, используя стандартный метод: " + Binnumber);

            Binnumber = MyConverter(number);
            Console.WriteLine("Число в двоичной системе, используя свой собственный метод: " + Binnumber);

            Console.ReadLine();

        }
    }
}
