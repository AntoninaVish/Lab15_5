using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();//создаем арифметическую прогрессию, экземпляр класса
            arith.setStart(10);//устанавливаем стартовое значение 10
            arith.setStep(2);  // устанавливаем значения шага 2
            Console.WriteLine(arith.getNext());// вывод первого члена арифметической прогрессии
            Console.WriteLine(arith.getNext());// вывод второго члена арифметической прогрессии
            Console.WriteLine(arith.getNext());// вывод третьего члена арифметической прогрессии
            arith.reset();// сброс до 10
            Console.WriteLine(arith.getNext());// выводим на экран арифметическое значение метода
            Console.WriteLine(arith.getNext());// выводим на экран арифметическое значение метода
                       
            GeomProgression arith1 = new GeomProgression();//создаем геометрическую прогрессию, экземпляр класса
            arith1.setStart(8);//устанавливаем стартовое значение 8
            arith1.setStep(2); // устанавливаем значения шага 2
            Console.WriteLine(arith1.getNext());// вывод первого члена геометрической прогрессии
            Console.WriteLine(arith1.getNext());// вывод второго члена геометрической прогрессии
            Console.WriteLine(arith1.getNext());// вывод третьего члена геометрической прогрессии
            arith1.reset();// сброс до 8
            Console.WriteLine(arith1.getNext());// выводим на экран геометрическое значение метода
            Console.WriteLine(arith1.getNext());// выводим на экран геометрическое значение метода
            Console.ReadKey();
        }
    }
}
