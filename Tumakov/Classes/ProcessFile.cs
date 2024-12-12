using System;
using System.IO;

public class FileProcessor
{
    public void ProcessFile(string inputFile, string outputFile)
    {
        if (!File.Exists(inputFile))
        {
            Console.WriteLine("Файл не существует.");
            return;
        }

        try
        {
            string content = File.ReadAllText(inputFile);
            File.WriteAllText(outputFile, content.ToUpper());

            Console.WriteLine($"Содержимое файла '{inputFile}' записано в '{outputFile}' заглавными буквами.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
