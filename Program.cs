using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HomeworkDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figuresList = new List<Figure>();
            Dictionary<Figure, int> figuresDictionary = new Dictionary<Figure, int>();
            Stopwatch timeList = new Stopwatch();
            Stopwatch timeDictionary = new Stopwatch();
            double timeOneOperationInList;
            double timeOneOperationDectionary;

            for (int i = 0; i < 1000; i++)
            {
                figuresList.Add(new Figure() { SideCount = i, SideLenght = i });
                figuresDictionary.Add(new Figure() { SideCount = i, SideLenght = i }, i);
            }

            Console.WriteLine("Введите любое число от 0 до 1000.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Figure searchingFigure = new Figure() { SideCount = userInput, SideLenght = userInput };

            timeList.Start();
            for (int i = 0; i < 100000; i++)
            {
                figuresList.Contains(searchingFigure);
            }
            timeList.Stop();
            timeOneOperationInList = (double)timeList.ElapsedMilliseconds / 100000;
            Console.WriteLine(timeOneOperationInList);

            timeDictionary.Start();
            for (int i = 0; i < 100000; i++)
            {
                figuresDictionary.ContainsKey(searchingFigure);
            }
            timeDictionary.Stop();
            timeOneOperationDectionary = (double)timeDictionary.ElapsedMilliseconds / 100000;
            Console.WriteLine(timeOneOperationDectionary);

        }
    }
}
