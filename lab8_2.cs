using System;

//lab 8


abstract class Task
{
    public string Text { get; set; }

    public Task(string text)
    {
        Text = text;
    }

    public Task()
    {
    }

    public abstract void Process();
}



class Task2 : Task
{
    public Task2(string text) : base(text)
    {
    }

    public override void Process()
    {
        //char[] textArray = Text.ToCharArray();
        //Array.Reverse(textArray);
        //Text = new string(textArray);


        string[] words = Text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string result = string.Empty;
        int wordIndex = 0;

        foreach (char c in Text)
        {
            if (char.IsLetter(c))
            {
                if (wordIndex < words.Length)
                {
                    string reversedWord = ReverseWord(words[wordIndex]);
                    result += reversedWord[wordIndex % reversedWord.Length];
                    wordIndex++;
                }
            }
            else
            {
                result += c;
                if (char.IsPunctuation(c) || char.IsWhiteSpace(c))
                {
                    wordIndex = 0; 
                }
            }
        }

        Text = result;

        string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}



class Task4 : Task
{
    public Task4(string text) : base(text)
    {
    }

    public override void Process()
    {
        int complexity = 0;
        string[] words = Text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        complexity += words.Length;
        foreach (char c in Text)
        {
            if (char.IsPunctuation(c))
            {
                complexity++;
            }
        }
        Console.WriteLine($"Сложность предложения: {complexity}");
    }
}



class Task6 : Task
{
    public Task6(string text) : base(text)
    {
    }

    public override void Process()
    {
        string[] words = Text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int[] syllableCount = new int[10]; 
        foreach (string word in words)
        {
            int syllables = CountSyllables(word);
            if (syllables > 0 && syllables < 10) 
            {
                syllableCount[syllables - 1]++;
            }
        }
        Console.WriteLine("Количество слов по количеству слогов:");
        for (int i = 0; i < 10; i++)
        {
            if (syllableCount[i] > 0)
            {
                Console.WriteLine($"{i + 1} слог: {syllableCount[i]}");
            }
        }
    }

    private int CountSyllables(string word)
    {
        int count = 0;
        bool prevWasVowel = false;
        foreach (char c in word.ToLower())
        {
            if ("аеёиоуыэюя".Contains(c))
            {
                if (!prevWasVowel)
                {
                    count++;
                }
                prevWasVowel = true;
            }
            else
            {
                prevWasVowel = false;
            }
        }
        return count;
    }
}



class Task8 : Task
{
    public Task8(string text) : base(text)
    {
    }

    public override void Process()
    {
        //const int maxLineLength = 50;
        //string[] words = Text.Split(' ');
        //string result = "";
        //int lineLength = 0;
        //foreach (string word in words)
        //{
        //    if (lineLength + word.Length <= maxLineLength)
        //    {
        //        result += word + " ";
        //        lineLength += word.Length + 1;
        //    }
        //    else
        //    {
        //        result = result.TrimEnd(); 
        //        result += Environment.NewLine + word + " ";
        //        lineLength = word.Length + 1;
        //    }
        //}
        //result = result.TrimEnd();
        //Console.WriteLine(result);

        string[] words = Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string result = string.Empty;
        string currentLine = string.Empty;

        foreach (string word in words)
        {
            if (currentLine.Length + word.Length > 50)
            {
                result += JustifyText(currentLine.Trim(), 50) + Environment.NewLine;
                currentLine = word + " ";
            }
            else
            {
                currentLine += word + " ";
            }
        }

        if (!string.IsNullOrEmpty(currentLine))
        {
            result += JustifyText(currentLine.Trim(), 50); 
        }

        Text = result;
    }

    private string JustifyText(string text, int width)
    {
        int spacesToAdd = width - text.Length;
        string[] words = text.Split(' ');
        int gaps = words.Length - 1;

        if (gaps > 0)
        {
            int spaceWidth = spacesToAdd / gaps;
            int extraSpaces = spacesToAdd % gaps;

            for (int i = 0; i < gaps; i++)
            {
                words[i] += new string(' ', spaceWidth + (i < extraSpaces ? 1 : 0));
            }
        }

        return string.Join("", words);
    }
}



class Task9 : Task
{
    public Task9(string text) : base(text)
    {
    }

    public override void Process()
    {
        string compressedText = CompressText(Text);
        Console.WriteLine($"Сжатый текст: {compressedText}");
    }

    private string CompressText(string text)
    {
        return text.Replace("th", "þ").Replace("ea", "æ");
    }
}



class Task10 : Task
{
    public Task10(string text) : base(text)
    {
    }

    public override void Process()
    {
        string decodedText = DecompressText(Text);
        Console.WriteLine($"Декодированный текст: {decodedText}");
    }

    private string DecompressText(string text)
    {
        return text.Replace("þ", "th").Replace("æ", "ea");
    }
}




class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();


        Task2 task2 = new Task2(inputText);
        task2.Process();
        Console.WriteLine($"Зашифрованный текст: {task2.Text}");



        Task4 task4 = new Task4(inputText);
        task4.Process();


        Task6 task6 = new Task6(inputText);
        task6.Process();


        Task8 task8 = new Task8(inputText);
        task8.Process();


        Task9 task9 = new Task9(inputText);
        task9.Process();


        Task10 task10 = new Task10(inputText);
        task10.Process();
    }
}

