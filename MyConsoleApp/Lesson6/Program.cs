using System;
using System.Collections;
using Microsoft.VisualBasic;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //++i
            //i++

            bool isValid = true;
            var x = 5;
            var y = 10;

            // && И   Бинарные && (условное логическое И)   Эти операторы вычисляют правый операнд, только если это необходимо.
            // || ИЛИ Бинарные || (условное логическое ИЛИ) Эти операторы вычисляют правый операнд, только если это необходимо.
            // &  И   Бинарный & (логическое И)             Эти операторы всегда обрабатывают оба операнда
            // |  ИЛИ Бинарный | (логическое ИЛИ)           Эти операторы всегда обрабатывают оба операнда
            // !  НЕ  Унарный ! (логическое отрицание) оператор
            // == Бинарный операнд равенства
            // != Бинарный опернт отрицания
            var array = new int[] {1, 2, 3, 4, 5, 6, 7, 8};

            //var count1 = 10;
            //var count2 = 10;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    var sss = string.Format("Count1: {0} | Count2: {1}", (count1++).ToString(), (++count2).ToString());
            // count = count + 1; 
            // count + 1 = count

            //    Console.WriteLine(sss);
            //}

            GetInfo("x");
            Console.WriteLine(Counter);

        }

        private static int Counter = 0; 
        public static string GetInfo(string text)
        {
            Counter++;
            if (text != "xxx")
                GetInfo(text + "x");

            return text;
        }


        public static bool IfMethod(int i)
        {
            if (i > 5)
            {
                return true;
            }
            else if (i == 5)
            {
                return true;
            }
            else if (i is not 0)
            {
                return true;
            }
            else if (i is (>= 5 and <= 10) or (> 12 and < 15))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void IfMethod2(int i)
        {
            var result = i > 5 ? "White" : "Black";

            var xxx = result == "Black" ? 1 : 0;

            Console.WriteLine(result);
            var x =  i > 5;
        }


        public static void SwitchMethod1(int i)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                default:
                    Console.WriteLine(0);
                    break;
            }
        }

        public static void SwitchMethod2(int i)
        {
            var result = i switch
            {
                1 => true,
                2 => true,
                _ => false
            };

            Console.WriteLine(result);
        }

        public static void ForMethod1(int i)
        {
            //префиксное или постфиксное выражение приращения, такое как ++i или i++
            //префиксное или постфиксное выражение декремента, такое как --i или i--

            //for (initializer; condition; iterator)
            //{
            //  body
            //  continue;
            //  break;
            //}

            // Бесконечный цикл
            //for (;;)
            //{
                
            //}

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(j);
            }
        }

        //public static void ForMethod2(int[] list)
        //{
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        public static void WhileMethod()
        {
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
        }

        public static void DoWhileMethod()
        {
            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            } 
            while (n < 5);
        }

    }
}
