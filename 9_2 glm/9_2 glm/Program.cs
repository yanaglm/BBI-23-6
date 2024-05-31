using System.Text.Json;
using System.Xml.Serialization;
using _9_2;
using ProtoBuf;

[ProtoContract]
[Serializable]
public class Athlete
{
    protected string surname;
    protected double result;
    [ProtoMember(1)]
    public string Surname
    {
        get => surname;
        set => surname = value;
    }
    [ProtoMember(2)]
    public double Result
    {
        get => result;
        set => result = value;
    }
    public Athlete() { }
    public Athlete(string surname, double result)
    {
        this.surname = surname;
        this.result = result;
    }
}

[ProtoContract]
[Serializable]
[ProtoInclude(3, typeof(Diving_3_meters))]
[ProtoInclude(4, typeof(Diving_5_meters))]
public abstract class Diving
{
    protected string nameOfDiscipline;
    protected Athlete[] athletes;
    [ProtoMember(4)]
    public string NameOfDiscipline
    {
        get => nameOfDiscipline;
        set => nameOfDiscipline = value;
    }
    [ProtoMember(5)]
    public Athlete[] Athletes
    {
        get => athletes;
        set => athletes = value;
    }
    public abstract void PrintResults();
    protected void SortMerge()
    {
        if (athletes != null)
        {
            athletes = MergeSort(Athletes);
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

[ProtoContract]
[Serializable]
public class Diving_3_meters : Diving
{
    public Diving_3_meters()
    {
        nameOfDiscipline = "3 meters diving";
    }
    public override void PrintResults()
    {
        SortMerge();
        Console.WriteLine(nameOfDiscipline);
        Console.WriteLine("Final scores");
        for (int i = 0; i < 3; i++)
        {
            double finalScore = 0;
            for (int j = 0; j < 5; j++)
            {
                finalScore += Athletes[i].Result;
            }
            Console.WriteLine($"Ranking {i + 1}: {athletes[i].Surname}, final score: {finalScore}");
        }
    }
}

[ProtoContract]
[Serializable]
public class Diving_5_meters : Diving
{
    public Diving_5_meters()
    {
        nameOfDiscipline = "5 meters diving";
    }
    public override void PrintResults()
    {
        SortMerge();
        Console.WriteLine(nameOfDiscipline);
        Console.WriteLine("Final scores");
        for (int i = 0; i < 3; i++)
        {
            double finalScore = 0;
            for (int j = 0; j < 5; j++)
            {
                finalScore += Athletes[i].Result;
            }
            Console.WriteLine($"Ranking {i + 1}: {athletes[i].Surname}, final score: {finalScore}");
        }
    }
}

class Program
{
    static void Main()
    {
        Athlete[] athletes = new Athlete[]
        {
            new Athlete("petrov", 7.5),
            new Athlete("smirnov", 1.5),
            new Athlete("ivanov", 6.5),
            new Athlete("sidorov", 8.0),
            new Athlete("popov", 7.0)
        };
        ISer[] serializers = new ISer[]
        {
            new MySerializeJson(),
            new MySerializeXML(),
            new MySerializeBin()
        };
        string folder = "Athletes";
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), folder);
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        string[] files = new string[]
        {
            "athletes.json",
            "athletes.xml",
            "athletes.bin"
        };
        for (int i = 0; i < serializers.Length; i++)
        {
            serializers[i].Write(athletes, Path.Combine(path, files[i]));
        }
        for (int i = 0; i < serializers.Length; i++)
        {
            athletes = serializers[i].Read<Athlete[]>(Path.Combine(path, files[i]));
            PrintAthletes(athletes);
        }
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
