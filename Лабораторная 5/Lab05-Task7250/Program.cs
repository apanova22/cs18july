﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Пользователь вводит координаты точки x и y.
/// Программа проверяет, принадлежит ли эта точка закрашенной области.
/// Изображение областей можно найти по адресу:
/// ${папка с заданиями}/images/Области 6.png
/// 
/// В исходном коде решения намеренно допущена логическая ошибка.
/// 
/// Чтобы выполнить задание, нужно:
/// - Подобрать исходные данные для проверки задачи.
/// - Выяснить в каком случае программа работает неверно.
/// - Оформить отчет о тестировании.
/// 
/// Исправлять ошибку не нужно.
/// 
/// </summary>

// ОТЧЕТ О ТЕСТИРОВАНИИ
// В программе присутствует ограничения:
// Эти ограничения образуют  области.
// Результаты проверки:
// Точки внутри областей.
//
// Точки на границах.
//
// Точки на пересечении границ.
//

namespace Lab05_Task7250
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = double.Parse(Console.ReadLine());
            if (2 < x)
            {
                Console.WriteLine("Не принадлежит");
            }
            else {
                if (y >= 1)
                {
                    Console.WriteLine("Принадлежит");
                }
                if (y <= -1.5)
                {
                    Console.WriteLine("Принадлежит");
                }
                if (y < 1)
                {
                    if (1.5 < y)
                    {
                        Console.WriteLine("Не принадлежит");
                    }
                    else {
                        Console.WriteLine("Принадлежит");
                    }
                }
                else {
                    Console.WriteLine("Принадлежит");
                }
            }
        }
    }
}
