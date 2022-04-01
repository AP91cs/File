using System;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сотрудники");
            Console.WriteLine("Вывести данные на экран, нажмите 1.");
            Console.WriteLine("Заполнить данные и добовить новую запись в конец файла, нажмите 2.");
            string fileName = "";
            string line = "";
            int newp = Convert.ToInt32(Console.ReadLine());
            
               
            if (newp == 2)
                {
                    static void  RecD (string fileName )
                    {
                        using StreamWriter fl = new(@"Сотрудники.txt", true);
                        string note = string.Empty;
                        Console.Write("ID:");
                        note += $"{Console.ReadLine()}#";

                        string now = DateTime.Now.ToShortDateString();
                        Console.WriteLine($"Дата и время записи: {now}");
                        note += $"{now}#";

                        Console.Write("Ф. И. О.:");
                        note += $"{Console.ReadLine()}#";

                        Console.Write("Возраст:");
                        note += $"{Console.ReadLine()}#";

                        Console.Write("Рост:");
                        note += $"{Console.ReadLine()}#";

                        Console.Write("Дата рождения:");
                        note += $"{Console.ReadLine()}#";

                        Console.Write("Место рождения:");
                        note += $"{Console.ReadLine()}#";

                        fl.WriteLine(note);
                    }
                RecD(fileName);
            }
            
            else if (newp == 1)
            {
                    static void  ShowFile (string line)
                    {
                        using StreamReader sr = new(@"Сотрудники.txt");
                         while ((line = sr.ReadLine()) != null)
                         {
                        string[] arr = line.Split('#');
                        Console.WriteLine($"{arr[0]}.{arr[1]}.{arr[2]}.{arr[3]}.{arr[4]}.{arr[5]}.{arr[6]}");
                         }
                    }   
                ShowFile(line);
            }
            Console.ReadKey();
            
        }       
    }
}
