using System;
using System.Text.RegularExpressions;
//lab 8
//2
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
