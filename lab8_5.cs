using System;
using System.Text;
using System.Threading.Tasks;

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
    private string originalText;

    public Task2(string text) : base(text)
    {
        originalText = text; 
    }

    public override void Process()
    {
        string[] words = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string result = string.Empty;

        foreach (string word in words)
        {
            string reversedWord = ReverseWord(word);
            result += reversedWord + " ";
        }

        Text = result.TrimEnd();
    }

    private string ReverseWord(string word)
    {
        int start = 0;
        int end = word.Length - 1;
        while (start < end && !char.IsLetter(word[start]))
        {
            start++;
        }
        while (start < end && !char.IsLetter(word[end]))
        {
            end--;
        }

        StringBuilder reversed = new StringBuilder(word.Substring(start, end - start + 1));
        for (int i = 0; i < reversed.Length / 2; i++)
        {
            char temp = reversed[i];
            reversed[i] = reversed[reversed.Length - 1 - i];
            reversed[reversed.Length - 1 - i] = temp;
        }

        return word.Substring(0, start) + reversed.ToString() + word.Substring(end + 1);
    }

    public void PrintOriginalText()
    {
        Console.WriteLine("Изначальный текст: " + originalText);
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
        string[] words = Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string result = string.Empty;
        string currentLine = string.Empty;

        foreach (string word in words)
        {
            if (currentLine.Length + word.Length + 1 > 50)
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
        Console.WriteLine(Text);
    }

    private string JustifyText(string text, int width)
    {
        if (text.Length == width)
        {
            return text;
        }

        string[] words = text.Split(' ');
        int totalSpaces = width - text.Replace(" ", "").Length;
        int gaps = words.Length - 1;

        if (gaps > 0)
        {
            int spaceWidth = totalSpaces / gaps;
            int extraSpaces = totalSpaces % gaps;

            for (int i = 0; i < gaps; i++)
            {
                words[i] += new string(' ', spaceWidth + (i < extraSpaces ? 1 : 0));
            }
        }

        return string.Join(" ", words);
    }

    public void PrintJustifiedText()
    {
        Console.WriteLine(Text);
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
        char code = 'a'; 
        StringBuilder compressedText = new StringBuilder(text);

        for (int i = 0; i < compressedText.Length - 1; i++)
        {
            string sequence = compressedText.ToString(i, 2);
            if (text.IndexOf(sequence, i + 1) != -1) 
            {
                compressedText.Replace(sequence, code.ToString());
                code++;
            }
        }

        return compressedText.ToString();
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
        string inputText = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений. ";

        Console.WriteLine("task 2");

        Task2 task2 = new Task2(inputText);
        task2.Process();
        Console.WriteLine($"Зашифрованный текст: {task2.Text}");
        task2.PrintOriginalText();


        Console.WriteLine("task 4");
        Task4 task4 = new Task4(inputText);
        task4.Process();


        Console.WriteLine("task 6");
        Task6 task6 = new Task6(inputText);
        task6.Process();


        Console.WriteLine("task 8");
        Task8 task8 = new Task8(inputText);
        task8.Process();
        task8.PrintJustifiedText();


        Console.WriteLine("task 9");
        Task9 task9 = new Task9(inputText);
        task9.Process();


        Console.WriteLine("task 10");
        Task10 task10 = new Task10(inputText);
        task10.Process();
    }
}

