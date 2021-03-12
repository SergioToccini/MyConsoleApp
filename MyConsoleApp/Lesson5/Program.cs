using System;
using Lesson5.Implementation;

namespace Lesson5
{
    public class Program
    {


        // 1. Выкладываем свой проект на GitHub
        // 2. Повторяем все отношения между классами:
        //      - Зависимость
        //      - Ассоциация (Агрегация по значению / Агрегация по ссылке)
        //      - Наследование
        //      - Реализация
        // 3. Разбираем домашнее задание
        // 4. Фокусы с конструкторами
        // 5. Решаем задачки
        public static void Main(string[] args)
        {
            User user = new User("Уася", 777);

            Console.ReadKey();
        }
    }
}
