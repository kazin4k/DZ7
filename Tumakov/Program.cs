using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumakov.Classes;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Упражнение 8.1
            Console.WriteLine("Упражнение 8.1");

            BankAccount account1 = new BankAccount(1000, TypeAccount.Save);
            BankAccount account2 = new BankAccount(500, TypeAccount.Check);

            account1.Transfer(account2, 200);



            //Упражнение 8.2
            Console.WriteLine("Упражнение 8.2");

            string input = "Hello, World!";
            string reversed = StringReverse.ReverseString(input);

            Console.WriteLine("Входная строка: " + input);
            Console.WriteLine("Перевернутая строка: " + reversed);



            //Упражнение 8.3
            Console.WriteLine("Упражнение 8.3");

            Console.Write("Введите имя файла: ");
            string inputFile = Console.ReadLine();

            string outputFile = "output.txt";

            FileProcessor fileProcessor = new FileProcessor();

            fileProcessor.ProcessFile(inputFile, outputFile);



            //Упражнение 8.4
            Console.WriteLine("Упражнение 8.4");

            object obj1 = 123;
            object obj2 = 123.45;
            object obj3 = "Hello";

            Console.WriteLine(FormattableChecker.CheckIfIFormattable(obj1)); 
            Console.WriteLine(FormattableChecker.CheckIfIFormattable(obj2)); 
            Console.WriteLine(FormattableChecker.CheckIfIFormattable(obj3));



            //Домашнее задание 8.1
            Console.WriteLine("Домашнее задание 8.1");

            string inputFilePath = "input.txt";
            string outputFilePath = "emails.txt";
            EmailExtractor extractor = new EmailExtractor();

            try
            {
                string[] lines = File.ReadAllLines(inputFilePath);
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    foreach (string line in lines)
                    {
                        string email = line;
                        extractor.SearchMail(ref email);
                        if (!string.IsNullOrEmpty(email))
                        {
                            writer.WriteLine(email);
                        }
                    }
                }
                Console.WriteLine("Адреса электронной почты успешно извлечены и записаны в файл " + outputFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }



            //Домашнее задание 8.2
            Console.WriteLine("Домашнее задание 8.2");
            List<Song> songs = new List<Song>();

            for (int i = 0; i < 4; i++)
            {
                Song song = new Song();
                Console.WriteLine($"Введите название песни {i + 1}:");
                song.SetName(Console.ReadLine());
                Console.WriteLine($"Введите автора песни {i + 1}:");
                song.SetAuthor(Console.ReadLine());
                if (i > 0)
                {
                    song.SetPrev(songs[i - 1]);
                }
                songs.Add(song);
            }

            foreach (var song in songs)
            {
                song.PrintInfo();
            }

            if (songs.Count >= 2)
            {
                bool areEqual = songs[0].Equals(songs[1]);
                Console.WriteLine($"Первая и вторая песни {(areEqual ? "равны" : "различны")}.");
            }
        }
    }
}

