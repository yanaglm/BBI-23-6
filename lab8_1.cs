﻿using System;
using System.Text.Json;
using System.IO;
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



class Task1 : Task
{
    public Task1(string text) : base(text)
    {
    }

    public override void Process()
    {
        char[] textArray = Text.ToCharArray();
        Array.Reverse(textArray);
        Text = new string(textArray);
    }
}



class Task2 : Task
{
    public Task2(string text) : base(text)
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



class Task3 : Task
{
    public Task3(string text) : base(text)
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



class Task4 : Task
{
    public Task4(string text) : base(text)
    {
    }

    public override void Process()
    {
        const int maxLineLength = 50;
        string[] words = Text.Split(' ');
        string result = "";
        int lineLength = 0;
        foreach (string word in words)
        {
            if (lineLength + word.Length <= maxLineLength)
            {
                result += word + " ";
                lineLength += word.Length + 1;
            }
            else
            {
                result = result.TrimEnd(); 
                result += Environment.NewLine + word + " ";
                lineLength = word.Length + 1;
            }
        }
        result = result.TrimEnd();
        Console.WriteLine(result);
    }
}



class Task5 : Task
{
    public Task5(string text) : base(text)
    {
    }

    public override void Process()
    {
    }
}



class Task6 : Task
{
    public Task6(string text) : base(text)
    {
    }

    public override void Process()
    {
    }
}



class JsonIO<T> where T : Task
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
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();


        Task1 task1 = new Task1(inputText);
        task1.Process();
        Console.WriteLine($"Зашифрованный текст: {task1.Text}");



        Task2 task2 = new Task2(inputText);
        task2.Process();


        Task3 task3 = new Task3(inputText);
        task3.Process();



        Task4 task4 = new Task4(inputText);
        task4.Process();



        string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Answer");
        Directory.CreateDirectory(directoryPath);

        string task1FilePath = Path.Combine(directoryPath, "cw2_1.json");
        string task2FilePath = Path.Combine(directoryPath, "cw2_2.json");



        JsonIO<Task1> jsonIO1 = new JsonIO<Task1>();
        if (!File.Exists(task1FilePath))
        {
            string task1Json = jsonIO1.Serialize(task1);
            File.WriteAllText(task1FilePath, task1Json);
            Console.WriteLine($"Файл {task1FilePath} успешно создан с информацией по заданию 1.");
        }
        else
        {
            string existingTask1Json = File.ReadAllText(task1FilePath);
            Task1 existingTask1 = jsonIO1.Deserialize(existingTask1Json);
            Console.WriteLine($"Информация по заданию 1 из файла {task1FilePath}: {existingTask1.Text}");
        }

        JsonIO<Task2> jsonIO2 = new JsonIO<Task2>();
        if (!File.Exists(task2FilePath))
        {
            string task2Json = jsonIO2.Serialize(task2);
            File.WriteAllText(task2FilePath, task2Json);
            Console.WriteLine($"Файл {task2FilePath} успешно создан с информацией по заданию 2.");
        }
        else
        {
            string existingTask2Json = File.ReadAllText(task2FilePath);
            Task2 existingTask2 = jsonIO2.Deserialize(existingTask2Json);
            Console.WriteLine($"Информация по заданию 2 из файла {task2FilePath}: {existingTask2.Text}");
        }
    }
}











/*
class Program
{
    static void Main()
    {
        Console.WriteLine("сообщение для шифрования:");
        string message = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";

        string encrypted_message = Encrypt(message);

        Console.WriteLine("зашифрованное сообщение: " + encrypted_message);

        Console.WriteLine("\nзашифрованное сообщение для расшифровки:");
        string decrypted_message = encrypted_message;
        string decrypted__message = Decrypt(decrypted_message);

        Console.WriteLine("Расшифрованное сообщение: " + decrypted__message);
    }

    static string Encrypt(string start_message)
    {
        char[] symbols = start_message.ToCharArray();
        ReverseText(symbols);
        return new string(symbols);
    }

    static string Decrypt(string encrypted_message)
    {
        char[] symbols = encrypted_message.ToCharArray();
        ReverseText(symbols);
        return new string(symbols);
    }

    static void ReverseText(char[] array)
    {
        int start = 0;
        int finish = array.Length - 1;
        while(start < finish)
        {
            char x = array[start];
            array[start] = array[finish];
            array[finish] = x;
            start++;
            finish--;
        }
    }
}
*/




//4

/*
class Program
{
    static void Main()
    {
        string sentence = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений. ";
        int complexity = CalculateComplexity(sentence);
        Console.WriteLine($"сложность предложения: {complexity}");
    }

    static int CalculateComplexity(string sentence)
    {
        char[] punctuation = { '.', ',', '!', '?', ':', ';' };
        int word_Count = 0;
        int punctuation_Count = 0;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (char.IsLetterOrDigit(sentence[i]))
            {
                word_Count++;
                while (char.IsLetterOrDigit(sentence[i]) && i < sentence.Length - 1)
                {
                    i++;
                }
                i--;
            }
            else if (IsPunctuation(sentence[i], punctuation))
            {
                punctuation_Count++;
            }
        }
        return word_Count + punctuation_Count;
    }

    static bool IsPunctuation(char c, char[] punctuations)
    {
        foreach (char punctuation in punctuations)
        {
            if (c == punctuation)
            {
                return true;
            }
        }
        return false;
    }
}
*/




//6
/*
class Program
{
    static void Main()
    {
        string text = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений. ";


        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);


        int[] syllable_Counts = new int[10]; 

        foreach (var word in words)
        {
            int syllable_Count = CountSyllables(word);
            if (syllable_Count < syllable_Counts.Length)
            {
                syllable_Counts[syllable_Count]++;
            }
        }

        for (int i = 1; i < syllable_Counts.Length; i++)
        {
            if (syllable_Counts[i] > 0)
            {
                Console.WriteLine($"{i} слога: {syllable_Counts[i]} слов");
            }
        }
    }

    static int CountSyllables(string word)
    {
        string vowels = "аеёиоуыэюяaeiouy";
        int count = 0;
        word = word.ToLower();
        for (int i = 0; i < word.Length; i++)
        {
            if (vowels.Contains(word[i]))
            {
                if (i == 0 || !vowels.Contains(word[i - 1]))
                {
                    count++;
                }
            }
        }
        if (word.EndsWith("e"))
        {
            count--;
        }
        return count;
    }
}
*/




//8
/*
class Program
{
    static void Main()
    {
        string text = "Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна."; 

        string formattedText = FormatText(text, 50);
        Console.WriteLine(formattedText);
    }

    static string FormatText(string text, int lineLength)
    {
        int currentIndex = 0;
        string formattedText = "";

        while (currentIndex < text.Length)
        {
            int endIndex = Math.Min(currentIndex + lineLength, text.Length);

            if (endIndex < text.Length && !Char.IsWhiteSpace(text[endIndex]))
            {
                int spaceIndex = text.LastIndexOf(' ', endIndex, endIndex - currentIndex);
                if (spaceIndex != -1)
                {
                    endIndex = spaceIndex;
                }
            }

            formattedText += text.Substring(currentIndex, endIndex - currentIndex).Trim() + Environment.NewLine;

            currentIndex = endIndex;
        }

        return formattedText;
    }
}
*/


//9
/*
class Program
{
    static void Main()
    {
        string text = "Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.";
        char code = 'ъ'; 
        string[] bigrams = new string[text.Length - 1];
        char[] codes = new char[text.Length - 1];

        for (int i = 0; i < text.Length - 1; i++)
        {
            string bigram = text.Substring(i, 2);
            int индекс = Array.IndexOf(bigrams, bigram);
            if (индекс == -1)
            {
                bigrams[i] = bigram;
                codes[i] = code;
                code++;
            }
            else
            {
                codes[i] = codes[индекс];
            }
        }

        string short_text = text;
        for (int i = 0; i < bigrams.Length; i++)
        {
            if (bigrams[i] != null)
            {
                short_text = short_text.Replace(bigrams[i], codes[i].ToString());
            }
        }

        Console.WriteLine("Сжатый текст: " + short_text);
    }
}
*/



//10
/*
class Program
{
    static void Main()
    {
        string short_text = "ъьюѐђєіјњќўѠѓѣѥѧѩѫѭѯѦѨѲѴѶѸѺѼѾҀ҂҄҆҈щѧҋҍҏмѽғҕвјҘеѩҜыѬҘҚвҟҢҤҦҨҪѓҭѠүѩҲҴѤеѵвћѲҸѳѭѠһѱҽҿйѩзѱоѠӄӆьҕљ ҇ѥӊӌоёҟѾӎеӁҕӒѨӓӕҘӗаҨВӉѶѭѮеҒѵӍйѵвѡҿэялѨӤӦӨљҟѓӪѨѲмҔҁҬӭѱѕѯуѓӰҕнѻѽӲӴѪуѩѓӷяӸҒҔҖјҘѨиѾӻҽдѭѻҨԀѪѺԄҕбӂыѾсҵ҇ҫнћҡңԈҵ-Ѡԍ҆ҵйѓмҁԑѱоѠрѧҋҍвѯэљԕѓжюԙѽҡ҂лѕѭѭԙѩ ҕԜԞѭԙѽѿҁ҃҅вѧҜыѬҘҚҡңԈҵӰѓԡѦ."; // Замените это на ваш сжатый текст
        char[] codes = { 'ъ', 'ю', 'щ', 'ь' }; 

        string[] bigrams = new string[codes.Length];
        
        for (int i = 0; i < codes.Length; i++)
        {
            bigrams[i] = "ъь " + (i + 1);
            Console.WriteLine(bigrams[i]);
        }

        string decoded_text = short_text;
        for (int i = 0; i < codes.Length; i++)
        {
            decoded_text = decoded_text.Replace(bigrams[i], codes[i].ToString());
        }

        Console.WriteLine("Декодированный текст: " + decoded_text);
        
    }
}
*/



