using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:

            //метод void setStart(int x) -устанавливает начальное значение
            //метод int getNext() -возвращает следующее число ряда
            //метод void reset() -выполняет сброс к начальному значению
            //Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
            ArithProgression arithProgression = new ArithProgression();
            Console.WriteLine("Введите первое число прогрессии");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг прогрессии");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Начало с числа {x} с шагом-{y} - Арифметическая:");
            arithProgression.setStart(x,y);
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine($"{i+1}-число= {arithProgression.getNext()}");
            }
            Console.Write($"Возвращает на начало:\t - Введенное число: ");
            arithProgression.reset();
            Console.WriteLine();
            GeomProgression geomProgression = new GeomProgression();
            Console.WriteLine("Введите первое число прогрессии");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг прогрессии");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Начало с числа {x} с шагом-{y} - Геометрическая:");
            geomProgression.setStart(x, y);
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine($"{i + 1}-число= {geomProgression.getNext()}");
            }
            Console.Write($"Возвращает на начало:\t - Введенное число: ");
            geomProgression.reset();
            Console.ReadKey();
        }
        interface ISeries
        {
            void setStart(int x,int y);
            int getNext();
            void reset();

        }
        class ArithProgression : ISeries
        {
            int start;
            int step;
            int nextNumber;
            public void setStart(int x, int y)
            {
                start = x;
                step = y;
                nextNumber = start;
            }
            public int getNext()
            {
                nextNumber+= step;
                return nextNumber;
            }

            public void reset()
            {
                nextNumber = start;
                Console.WriteLine($"{nextNumber}");
            }

        }
        class GeomProgression : ISeries
        {
            int start;
            int step;
            int nextNumber;
            public void setStart(int x, int y)
            {
                start = x;
                step = y;
                nextNumber = start;
            }
            public int getNext()
            {
                nextNumber *= step;
                return nextNumber;
            }

            public void reset()
            {
                nextNumber = start;
                Console.WriteLine($"{nextNumber}");
            }

        }

    }
}
