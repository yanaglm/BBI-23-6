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

        foreach (string word in words)
        {
            string reversedWord = ReverseWord(word);
            result += reversedWord + " ";
        }

        Text = result.TrimEnd();
    }

    private string ReverseWord(string word)
    {
        char[] charArray = word.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;
        while (left < right)
        {
            char x = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = x;
            left++;
            right--;
        }
        return new string(charArray);
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
        Console.WriteLine(Text);
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


        Task2 task2 = new Task2(inputText);
        task2.Process();
        Console.WriteLine($"Зашифрованный текст: {task2.Text}");


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

