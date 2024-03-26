using System;
//LAB 7
//level 1
//num 1
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

class Program
{
    static void Main()
    {
        Results result = new Results(10);

        result.NewCompetitor("petrov", "club 1", 8.2, 6.8);
        result.NewCompetitor("smirnov", "club 2", 6.3, 7.2);
        result.NewCompetitor("zaitsev", "club 3", 7.5, 8.7);

        result.Disqual_Competitor("petrov");

        result.PrintResult();
    }
}
*/





//level 2
//num 6

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

    protected void SortBubble()
    {
        for (int i = 0; i < Athletes.Length - 1; i++)
        {
            for (int j = 0; j < Athletes.Length - 1 - i; j++)
            {
                if (FindOutFinalScore(j) < FindOutFinalScore(j + 1))
                {
                    Replace(j, j + 1);
                }
            }
        }
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
        SortBubble();
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
        SortBubble();
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

class Program
{
    static void Main()
    {
        Diving diving_3_meters = new Diving_3_meters();
        Diving diving_5_meters = new Diving_5_meters();

        diving_3_meters.Athletes = new Athlete[3]
        {
            new Athlete { Surname = "petrov", Result = 6.5 },
            new Athlete { Surname = "smirnov", Result = 5.5 },
            new Athlete { Surname = "zaitsev", Result = 9.5 }
        };

        diving_5_meters.Athletes = diving_3_meters.Athletes;

        /*
        double[,] scores = new double[3, 5];
        string[] surnames = new string[3];
        scores[0, 0] = 6.5;
        scores[0, 1] = 7.0;
        scores[0, 2] = 6.0;
        scores[0, 3] = 8.0;
        scores[0, 4] = 7.5;
        scores[1, 0] = 6.5;
        scores[1, 1] = 5.5;
        scores[1, 2] = 6.0;
        scores[1, 3] = 5.0;
        scores[1, 4] = 7.0;
        scores[2, 0] = 9.5;
        scores[2, 1] = 9.0;
        scores[2, 2] = 10.0;
        scores[2, 3] = 9.5;
        scores[2, 4] = 9.5;

        surnames[0] = "petrov";
        surnames[1] = "smirnov";
        surnames[2] = "zaitsev";
        */

        diving_3_meters.PrintResults();
        diving_5_meters.PrintResults();
    }
}









//level 3
//num 6
/*
class Response
{
    private string[] Animal;
    private string[]TraitOfCharacter;
    private string[] Object;
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
}

class Country
{
    protected Response country_response;

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

class Program
{
    static void Main()
    {
        Russia russia = new Russia();

        russia.NewAnimalResponse("cat");
        russia.NewAnimalResponse("cat");
        russia.NewAnimalResponse("bear");
        russia.NewAnimalResponse("dog");
        russia.NewAnimalResponse("bird");
        russia.NewAnimalResponse("bear");
        russia.NewAnimalResponse("wolf");
        russia.NewAnimalResponse("bear");

        russia.NewTraitOfCharacterResponse("kindness");
        russia.NewTraitOfCharacterResponse("creativity");
        russia.NewTraitOfCharacterResponse("creativity");
        russia.NewTraitOfCharacterResponse("kindness");
        russia.NewTraitOfCharacterResponse("politeness");
        russia.NewTraitOfCharacterResponse("sense of humour");
        russia.NewTraitOfCharacterResponse("sense of humour");
        russia.NewTraitOfCharacterResponse("responsibility");

        russia.NewObjectResponse("nature");
        russia.NewObjectResponse("food");
        russia.NewObjectResponse("flowers");
        russia.NewObjectResponse("buildings");
        russia.NewObjectResponse("sun");


        Japan japan = new Japan();

        japan.NewAnimalResponse("dog");
        japan.NewAnimalResponse("bird");
        japan.NewAnimalResponse("red panda");
        japan.NewAnimalResponse("panda");
        japan.NewAnimalResponse("panda");
        japan.NewAnimalResponse("panda");
        japan.NewAnimalResponse("dog");
        japan.NewAnimalResponse("cat");

        japan.NewTraitOfCharacterResponse("kindness");
        japan.NewTraitOfCharacterResponse("creativity");
        japan.NewTraitOfCharacterResponse("politeness");
        japan.NewTraitOfCharacterResponse("sense of humour");
        japan.NewTraitOfCharacterResponse("responsibility");

        japan.NewObjectResponse("sakura");
        japan.NewObjectResponse("sunrise");
        japan.NewObjectResponse("sun");
        japan.NewObjectResponse("food");
        japan.NewObjectResponse("technologies");

        russia.PrintTopResponses();
        japan.PrintTopResponses();

    }
}
*/