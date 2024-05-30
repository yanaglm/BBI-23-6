using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;


//lab 9
//1
/*
class Results
{
    private Competitor[] competitors;
    private int size;

    public Results(int quantity)
    {
        competitors = new Competitor[quantity];
        size = 0;
    }

    public void NewCompetitor(string surname, string community, double first_attempt, double second_attempt)
    {
        Competitor new_member = new Competitor(surname, community, first_attempt, second_attempt);
        competitors[size] = new_member;
        size++;
    }

    public void PrintResult()
    {
        SortBubble();
        Console.WriteLine("result");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("| ranking   | surname  | community   | final result |");
        Console.WriteLine("------------------------------------");
        for (int i = 0; i < size; i++)
        {
            if (!competitors[i].Disqualified)
            {
                Console.WriteLine($"| {i + 1,-10}| {competitors[i].Surname,-8} |  {competitors[i].Community,-10} | {competitors[i].Final_result,-12} | ");
            }
        }
        Console.WriteLine("------------------------------------");
    }

    private void SortBubble()
    {
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (competitors[j].Final_result < competitors[j + 1].Final_result)
                {
                    var x = competitors[j];
                    competitors[j] = competitors[j + 1];
                    competitors[j + 1] = x;
                }
            }
        }
    }

    public void Disqual_Competitor(string surname)
    {
        for (int i = 0; i < size; i++)
        {
            if (competitors[i].Surname == surname)
            {
                competitors[i].Disqualified = true;
                break;
            }
        }
    }
}

class Competitor
{
    public string Surname { get; }
    public string Community { get; }
    public double First_attempt { get; }
    public double Second_attempt;
    public double Final_result => First_attempt + Second_attempt;
    private bool disqualified;


    public bool Disqualified
    {
        get
        {
            return disqualified;
        }
        set
        {
            if (!disqualified)
            {
                disqualified = value;
            }
        }
    }


    public Competitor(string surname, string community, double first_attempt, double second_attempt)
    {
        Surname = surname;
        Community = community;
        First_attempt = first_attempt;
        Second_attempt = second_attempt;
        Disqualified = false;
    }
}

public class Serializer<T>
{
    public void SerializeToBinary(T obj, string filePath)
    {
        using (Stream stream = File.Open(filePath, FileMode.Create))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, obj);
        }
    }

    public T DeserializeFromBinary(string filePath)
    {
        using (Stream stream = File.Open(filePath, FileMode.Open))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return (T)binaryFormatter.Deserialize(stream);
        }
    }

    public void SerializeToXml(T obj, string filePath)
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            xmlSerializer.Serialize(fileStream, obj);
        }
    }

    public T DeserializeFromXml(string filePath)
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(fileStream);
        }
    }

    public void SerializeToJson(T obj, string filePath)
    {
        string json = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public T DeserializeFromJson(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(json);
    }
}

class Program
{
    static void Main()
    {
        string serializationFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Serialization");
        Directory.CreateDirectory(serializationFolder);

        Competitor[] competitors = new Competitor[]
        {
            new Competitor("petrov", "Club 1", 8.2, 6.8),
            new Competitor("smirnov", "Club 2", 6.3, 7.2),
            new Competitor("zaitsev", "Club 3", 7.5, 8.7),
            new Competitor("ivanov", "Club 4", 9.0, 7.5),
            new Competitor("sidorov", "Club 5", 8.8, 8.0)
        };

        Serializer<Competitor[]> serializer = new Serializer<Competitor[]>();

        string binaryFilePath = Path.Combine(serializationFolder, "competitors.bin");
        serializer.SerializeToBinary(competitors, binaryFilePath);
        Competitor[] deserializedBinary = serializer.DeserializeFromBinary(binaryFilePath);

        string xmlFilePath = Path.Combine(serializationFolder, "competitors.xml");
        serializer.SerializeToXml(competitors, xmlFilePath);
        Competitor[] deserializedXml = serializer.DeserializeFromXml(xmlFilePath);

        string jsonFilePath = Path.Combine(serializationFolder, "competitors.json");
        serializer.SerializeToJson(competitors, jsonFilePath);
        Competitor[] deserializedJson = serializer.DeserializeFromJson(jsonFilePath);

        Console.WriteLine("Deserialized from Binary:");
        PrintCompetitors(deserializedBinary);

        Console.WriteLine("Deserialized from XML:");
        PrintCompetitors(deserializedXml);

        Console.WriteLine("Deserialized from JSON:");
        PrintCompetitors(deserializedJson);
    }

    static void PrintCompetitors(Competitor[] competitors)
    {
        foreach (var competitor in competitors)
        {
            Console.WriteLine($"Surname: {competitor.Surname}, Community: {competitor.Community}, Final Result: {competitor.Final_result}, Disqualified: {competitor.Disqualified}");
        }
        Console.WriteLine();
    }
}
*/

//2
/*
public class Athlete
{
    public string Surname
    {
        get;
        set;

    }

    public double Result
    {
        get;
        set;

    }

    public Athlete(string surname, double result)
    {
        Surname = surname;
        Result = result;
    }

}
abstract class Diving
{
    public string NameOfDiscipline
    {
        get;
        protected set;
    }

    public Athlete[] Athletes
    {
        get;
        set;
    }

    public abstract void PrintResults();


    protected void SortMerge()
    {
        if (Athletes != null)
        {
            Athletes = MergeSort(Athletes);
        }
    }

    private Athlete[] MergeSort(Athlete[] athletes)
    {
        if (athletes.Length <= 1)
        {
            return athletes;
        }

        int mid = athletes.Length / 2;
        Athlete[] left = new Athlete[mid];
        Athlete[] right = new Athlete[athletes.Length - mid];

        Array.Copy(athletes, 0, left, 0, mid);
        Array.Copy(athletes, mid, right, 0, athletes.Length - mid);

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    private Athlete[] Merge(Athlete[] left, Athlete[] right)
    {
        Athlete[] merged = new Athlete[left.Length + right.Length];
        int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (FindOutFinalScore(left[leftIndex]) >= FindOutFinalScore(right[rightIndex]))
            {
                merged[mergedIndex++] = left[leftIndex++];
            }
            else
            {
                merged[mergedIndex++] = right[rightIndex++];
            }
        }

        while (leftIndex < left.Length)
        {
            merged[mergedIndex++] = left[leftIndex++];
        }

        while (rightIndex < right.Length)
        {
            merged[mergedIndex++] = right[rightIndex++];
        }

        return merged;
    }



    protected double FindOutFinalScore(Athlete athlete)
    {
        return athlete.Result;
    }


    protected double FindOutFinalScore(int ind)
    {
        double finalScore = 0;
        for (int j = 0; j < 5; j++)
        {
            finalScore += Athletes[ind].Result;
        }
        return finalScore;
    }

    protected void Replace(int ind1, int ind2)
    {
        var x = Athletes[ind1];
        Athletes[ind1] = Athletes[ind2];
        Athletes[ind2] = x;
    }
}

class Diving_3_meters : Diving
{
    public Diving_3_meters()
    {
        NameOfDiscipline = "3 meters diving";
    }

    public override void PrintResults()
    {
        SortMerge();
        Console.WriteLine(NameOfDiscipline);
        Console.WriteLine("Final scores");
        for (int i = 0; i < 3; i++)
        {
            double finalScore = 0;
            for (int j = 0; j < 5; j++)
            {
                finalScore += Athletes[i].Result;
            }
            Console.WriteLine($"Ranking {i + 1}: {Athletes[i].Surname}, final score: {finalScore}");
        }
    }
}

class Diving_5_meters : Diving
{
    public Diving_5_meters()
    {
        NameOfDiscipline = "5 meters diving";
    }

    public override void PrintResults()
    {
        SortMerge();
        Console.WriteLine(NameOfDiscipline);
        Console.WriteLine("Final scores");
        for (int i = 0; i < 3; i++)
        {
            double finalScore = 0;
            for (int j = 0; j < 5; j++)
            {
                finalScore += Athletes[i].Result;
            }
            Console.WriteLine($"Ranking {i + 1}: {Athletes[i].Surname}, final score: {finalScore}");
        }
    }
}



public class Serializer<T>
{
    public void SerializeToBinary(T obj, string filePath)
    {
        throw new NotSupportedException("Binary serialization is not supported without ProtoBuf.");
    }

    public T DeserializeFromBinary(string filePath)
    {
        throw new NotSupportedException("Binary deserialization is not supported without ProtoBuf.");
    }

    public void SerializeToXml(T obj, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, obj);
        }
    }

    public T DeserializeFromXml(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using (StreamReader reader = new StreamReader(filePath))
        {
            return (T)serializer.Deserialize(reader);
        }
    }

    public void SerializeToJson(T obj, string filePath)
    {
        string json = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public T DeserializeFromJson(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(json);
    }
}
class Program
{
    static void Main()
    {
        string serializationFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Serialization");
        Directory.CreateDirectory(serializationFolder);

        Athlete[] athletes = new Athlete[]
        {
            new Athlete("petrov", 7.5),
            new Athlete("smirnov", 1.5),
            new Athlete("ivanov", 6.5),
            new Athlete("sidorov", 8.0),
            new Athlete("popov", 7.0)
        };

        Serializer<Athlete[]> serializer = new Serializer<Athlete[]>();

        string xmlFilePath = Path.Combine(serializationFolder, "athletes.xml");
        serializer.SerializeToXml(athletes, xmlFilePath);
        Athlete[] deserializedXml = serializer.DeserializeFromXml(xmlFilePath);

        string jsonFilePath = Path.Combine(serializationFolder, "athletes.json");
        serializer.SerializeToJson(athletes, jsonFilePath);
        Athlete[] deserializedJson = serializer.DeserializeFromJson(jsonFilePath);

        Console.WriteLine("Deserialized from XML:");
        PrintAthletes(deserializedXml);

        Console.WriteLine("Deserialized from JSON:");
        PrintAthletes(deserializedJson);
    }

    static void PrintAthletes(Athlete[] athletes)
    {
        foreach (var athlete in athletes)
        {
            Console.WriteLine($"Surname: {athlete.Surname}, Result: {athlete.Result}");
        }
        Console.WriteLine();
    }
}
*/


//3
/*
public class Response
{
    public string[] Animal;
    public string[] TraitOfCharacter;
    public string[] Object;
    private int[] AnimalCount;
    private int[] TraitOfCharacterCount;
    private int[] ObjectCount;


    public Response()
    {
        Animal = new string[10];
        TraitOfCharacter = new string[10];
        Object = new string[10];
        AnimalCount = new int[10];
        TraitOfCharacterCount = new int[10];
        ObjectCount = new int[10];
    }

    public void NewAnimalResponse(string response)
    {

        for (int i = 0; i < Animal.Length; i++)
        {
            if (Animal[i] == null)
            {
                Animal[i] = response;
                AnimalCount[i]++;
                break;
            }
            else if (Animal[i] == response)
            {
                AnimalCount[i]++;
                break;
            }
        }
    }

    public void NewTraitOfCharacterResponse(string response)
    {

        for (int i = 0; i < TraitOfCharacter.Length; i++)
        {
            if (TraitOfCharacter[i] == null)
            {
                TraitOfCharacter[i] = response;
                TraitOfCharacterCount[i]++;
                break;
            }
            else if (TraitOfCharacter[i] == response)
            {
                TraitOfCharacterCount[i]++;
                break;
            }
        }
    }

    public void NewObjectResponse(string response)
    {

        for (int i = 0; i < Object.Length; i++)
        {
            if (Object[i] == null)
            {
                Object[i] = response;
                ObjectCount[i]++;
                break;
            }
            else if (Object[i] == response)
            {
                ObjectCount[i]++;
                break;
            }
        }
    }

    public void Responeses(string response)
    {
        string[] responses = new string[25];
        for (int i = 0; i < 25; i++)
        {
            responses[i] = Animal[i];

        }
    }

    public void PrintTopResponses()
    {
        Console.WriteLine("animal results");
        PrintTopResponsesForAllQuestions(Animal, AnimalCount);

        Console.WriteLine("traits of character results");
        PrintTopResponsesForAllQuestions(TraitOfCharacter, TraitOfCharacterCount);

        Console.WriteLine("objects results");
        PrintTopResponsesForAllQuestions(Object, ObjectCount);
    }

    public void PrintTopResponsesForAllQuestions(string[] responses, int[] counts)
    {
        for (int i = 0; i < responses.Length; i++)
        {
            for (int j = 0; j < responses.Length - 1; j++)
            {
                if (counts[j] < counts[j + 1])
                {

                    int x = counts[j];
                    counts[j] = counts[j + 1];
                    counts[j + 1] = x;

                    string y = responses[j];
                    responses[j] = responses[j + 1];
                    responses[j + 1] = y;
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            double percent = (double)counts[i] / (counts[0] + counts[1] + counts[2] + counts[3] + counts[4]) * 100;
            Console.WriteLine($"responses: {responses[i]}, count: {counts[i]}, percent: {percent}%");
        }


    }


    private int AddResponsesToArray(string[] source, string[] destination, int index)
    {
        foreach (var response in source)
        {
            if (!string.IsNullOrEmpty(response))
            {
                destination[index] = response;
                index++;
            }
        }
        return index;
    }

    public void BubbleSort(string[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    string temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public string[] GetTopResponses()
    {
        string[] allResponses = GetAllResponses();

        BubbleSort(allResponses);

        string[] topResponses = new string[5];
        Array.Copy(allResponses, topResponses, 5);

        return topResponses;
    }

    public int GetCount(string[] responses, string response)
    {
        int count = 0;
        foreach (var r in responses)
        {
            if (r == response)
            {
                count++;
            }
        }
        return count;
    }


    public string[] GetAllResponses()
    {
        string[] allResponses = new string[30];
        int index = 0;

        index = AddResponsesToArray(Animal, allResponses, index);
        index = AddResponsesToArray(TraitOfCharacter, allResponses, index);
        index = AddResponsesToArray(Object, allResponses, index);

        string[] result = new string[index];
        Array.Copy(allResponses, result, index);

        return result;
    }

    public string[] GetTraitOfCharacterResponses()
    {
        string[] traitOfCharacterResponses = new string[10];
        int index = 0;

        index = AddResponsesToArray(TraitOfCharacter, traitOfCharacterResponses, index);

        string[] result = new string[index];
        Array.Copy(traitOfCharacterResponses, result, index);

        return result;
    }

    public string[] GetObjectResponses()
    {
        string[] objectResponses = new string[10];
        int index = 0;

        index = AddResponsesToArray(Object, objectResponses, index);

        string[] result = new string[index];
        Array.Copy(objectResponses, result, index);

        return result;
    }
}

class Country
{
    public Response country_response;

    public Country()
    {
        country_response = new Response();
    }

    public virtual void WriteResponsesInPercent()
    {
        Console.WriteLine("ordinal class Country");
    }

    public void NewAnimalResponse(string response)
    {
        country_response.NewAnimalResponse(response);
    }



    public void NewTraitOfCharacterResponse(string response)
    {
        country_response.NewTraitOfCharacterResponse(response);
    }

    public void NewObjectResponse(string response)
    {
        country_response.NewObjectResponse(response);
    }

    public void PrintTopResponses()
    {
        country_response.PrintTopResponses();
    }

}

class Russia : Country
{
    public override void WriteResponsesInPercent()
    {
        Console.WriteLine("Ответы по России в %");

    }
}

class Japan : Country
{
    public override void WriteResponsesInPercent()
    {
        Console.WriteLine("Ответы по Японии в %");

    }
}

class Combined : Country
{



    public override void WriteResponsesInPercent()
    {
        Console.WriteLine("Ответы по всем в %");

    }
}

public class CustomSerializer<T>
{
    public void SerializeToXml(T obj, string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(writer, obj);
        }
    }

    public T DeserializeFromXml(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(reader);
        }
    }

    public void SerializeToJson(T obj, string filePath)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(obj, options);
        File.WriteAllText(filePath, json);
    }

    public T DeserializeFromJson(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(json);
    }
}

class Program
{
    static void Main()
    {
        string serializationFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Serialization");
        Directory.CreateDirectory(serializationFolder);

        Response response = new Response
        {
            Animal = new string[] { "bear", "dog", "wolf", "cat", "hamster" },
            TraitOfCharacter = new string[] { "kindness", "creativity", "politeness", "sense of humour", "fun" },
            Object = new string[] { "nature", "food", "flowers", "buildings", "sun" }
        };

        CustomSerializer<Response> serializer = new CustomSerializer<Response>();

        string xmlFilePath = Path.Combine(serializationFolder, "response.xml");
        serializer.SerializeToXml(response, xmlFilePath);
        Response deserializedXml = serializer.DeserializeFromXml(xmlFilePath);

        string jsonFilePath = Path.Combine(serializationFolder, "response.json");
        serializer.SerializeToJson(response, jsonFilePath);
        Response deserializedJson = serializer.DeserializeFromJson(jsonFilePath);

        Console.WriteLine("Deserialized from XML:");
        PrintResponse(deserializedXml);

        Console.WriteLine("Deserialized from JSON:");
        PrintResponse(deserializedJson);
    }

    static void PrintResponse(Response response)
    {
        Console.WriteLine("Animals: " + string.Join(", ", response.Animal));
        Console.WriteLine("Traits of Character: " + string.Join(", ", response.TraitOfCharacter));
        Console.WriteLine("Objects: " + string.Join(", ", response.Object));
        Console.WriteLine();
    }
}
*/
