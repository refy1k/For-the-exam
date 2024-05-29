using System;
using System.Text.RegularExpressions;

namespace For_the_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор задачи: ");
            int choiceTask = Convert.ToInt32(Console.ReadLine());

            switch (choiceTask)
            {
                case 1:
                    {
                        string textFile = "Привет мир! Хорошая сегодня! ";
                        string pattern = ". ";
                        string result = Regex.Replace(textFile, pattern, "");
                        Console.WriteLine(result);
                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }
                case 5:
                    {

                        break;
                    }
                case 6:
                    {

                        break;
                    }
                case 7:
                    {

                        break;
                    }
                case 8:
                    {

                        break;
                    }
                case 9:
                    {

                        break;
                    }
                case 10:
                    {

                        break;
                    }
                case 11:
                    {

                        break;
                    }
                case 12:
                    {

                        break;
                    }
                case 13:
                    {

                        break;
                    }
                case 14:
                    {

                        break;
                    }
                case 15:
                    {

                        break;
                    }
                case 16:
                    {

                        break;
                    }
                case 17:
                    {

                        break;
                    }
                case 18:
                    {

                        break;
                    }
                case 19:
                    {

                        break;
                    }
                case 20:
                    {

                        break;
                    }
                case 21:
                    {

                        break;
                    }
                case 22:
                    {

                        break;
                    }
                case 23:
                    {

                        break;
                    }
                case 24:
                    {
                        break;
                    }
            }
        }
    }
}
