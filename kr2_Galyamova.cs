using System;
using System.IO;
using System.Text.Json;


abstract class Task<T>
{
    public string Text { get; set; }
    public Task(string text)
    {
        Text = text;
    }
    public Task()
    {
    }
    public abstract T Process();
}

class Task1 : Task<string>
{
    public Task1(string text) : base(text)
    {
    }

    public override string Process()
    {
        char[] alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        char[] newText = Text.ToCharArray();
        for (int i = 0; i < newText.Length; i++)
        {
            char c = newText[i];
            if (char.IsLetter(c))
            {
                int index = Array.IndexOf(alphabet, char.ToLower(c));
                if (index >= 0)
                {
                    int newIndex = (index + 10) % alphabet.Length;
                    char newChar = char.IsUpper(c) ? char.ToUpper(alphabet[newIndex]) : alphabet[newIndex];
                    newText[i] = newChar;
                }
            }
        }
        return new string(newText);
    }
}



class Task2 : Task<char[]>
{
    public Task2(string text) : base(text)
    {
    }

    public override char[] Process()
    {
        string[] words = Text.Split(' ');
        char[] firstWordChars = words[0].ToCharArray();
        char[] secondWordChars = words[1].ToCharArray();

        var commonChars = new List<char>();
        foreach (char c in firstWordChars)
        {
            if (Array.IndexOf(secondWordChars, c) != -1 && !commonChars.Contains(c))
            {
                commonChars.Add(c);
            }
        }
        return commonChars.ToArray();
    }
}

class JsonIO<T>
{
    public T Deserialize(string json)
    {
        return JsonSerializer.Deserialize<T>(json);
    }

    public string Serialize(T obj)
    {
        return JsonSerializer.Serialize(obj);
    }
}






class Program
{
    static void Main()
    {
        Console.WriteLine("text:");
        string inputText = Console.ReadLine();


        Task1 task1 = new Task1(inputText);
        string shiftedText = task1.Process();
        Console.WriteLine($"new text: {shiftedText}");


        Console.WriteLine("два слова (разделенные пробелом):");
        string inputWords = Console.ReadLine();
        Task2 task2 = new Task2(inputWords);
        char[] commonChars = task2.Process();
        Console.WriteLine("буквы в обоих словах:");
        foreach (char c in commonChars)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();

        string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Answer");
        Directory.CreateDirectory(directoryPath);

        string task1FilePath = Path.Combine(directoryPath, "cw2_1.json");
        string task2FilePath = Path.Combine(directoryPath, "cw2_2.json");

        JsonIO<Task1> jsonIO1 = new JsonIO<Task1>();
        if (!File.Exists(task1FilePath))
        {
            string task1Json = jsonIO1.Serialize(task1);
            File.WriteAllText(task1FilePath, task1Json);
            Console.WriteLine($"Файл {task1FilePath} for task 1");
        }
        else
        {
            string existingTask1Json = File.ReadAllText(task1FilePath);
            Task1 existingTask1 = jsonIO1.Deserialize(existingTask1Json);
            Console.WriteLine($"information about task 1 {task1FilePath}: {existingTask1.Text}");
        }

        JsonIO<Task2> jsonIO2 = new JsonIO<Task2>();
        if (!File.Exists(task2FilePath))
        {
            string task2Json = jsonIO2.Serialize(task2);
            File.WriteAllText(task2FilePath, task2Json);
            Console.WriteLine($"Файл {task2FilePath} for task 2");
        }
        else
        {
            string existingTask2Json = File.ReadAllText(task2FilePath);
            Task2 existingTask2 = jsonIO2.Deserialize(existingTask2Json);
            Console.WriteLine($"information about task 2 {task2FilePath}: {existingTask2.Text}");
        }
    }
}





















