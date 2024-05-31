using System;
using System.IO;
using _9_1;
using ProtoBuf;

[ProtoContract]
[Serializable]
public class Results
{
    private Competitor[] competitors;
    [ProtoMember(1)]
    public Competitor[] Competitors { get  => competitors; set => competitors = value; }
    private int size;
    [ProtoMember(2)]
    public int Size { get => size; set => size = value; }

    public Results() { }
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
                Console.WriteLine(competitors[i].Surname + " " + Competitors[i].Final_result);
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

[ProtoContract]
[Serializable]
public class Competitor
{
    [ProtoMember(3)]
    private string surname;
    private string community;
    private double firstattempt;
    private double secondattempt;
    public string Surname { get => surname; set => surname = value; }
    [ProtoMember(4)]
    public string Community { get => community; set => community = value; }
    [ProtoMember(5)]
    public double First_attempt { get => firstattempt; set => firstattempt = value; }
    [ProtoMember(6)]
    public double Second_attempt { get => secondattempt; set => secondattempt = value; }
    private double finalresult;
    [ProtoMember(7)]
    public double Final_result { get => finalresult; set => finalresult = value; }
    private bool disqualified;
    [ProtoMember(8)]
    public bool Disqualified { get => disqualified; set => disqualified = value; }

    public Competitor() { }
    public Competitor(string surname, string community, double first_attempt, double second_attempt)
    {
        this.surname = surname;
        this.community = community;
        firstattempt = first_attempt;
        secondattempt = second_attempt;
        finalresult = firstattempt + secondattempt;
        disqualified = false;
    }
}

class Program
{
    static void Main()
    {
        Results result = new Results(3);

        result.NewCompetitor("petrov", "club 1", 8.2, 6.8);
        result.NewCompetitor("smirnov", "club 2", 6.3, 7.2);
        result.NewCompetitor("zaitsev", "club 3", 7.5, 8.7);

        //result.PrintResult();

        ISer[] serializers = new ISer[]
        {
            new MySerializeJson(),
            new MySerializeXML(),
            new MySerializeBin()
        };
        string folder = "Competitors";
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), folder);
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        string[] files = new string[]
        {
            "competitors.json",
            "competitors.xml",
            "competitors.bin"
        };
        for (int i = 0; i < serializers.Length; i++)
        {
            serializers[i].Write(result, Path.Combine(path, files[i]));
        }
        for (int i = 0; i < serializers.Length; i++)
        {
            result = serializers[i].Read<Results>(Path.Combine(path, files[i]));
            result.PrintResult();
        }
    }
}






