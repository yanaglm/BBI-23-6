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
/*
public class Athlete
{
    public string Surname
    {
        get;
        
    }

    public double Result
    {
        get;
        
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

        Diving diving_3_meters = new Diving_3_meters
        {
            Athletes = new Athlete[3]
            {
                new Athlete("poyasyn", 7.5),
                new Athlete("muhabat", 9.5),
                new Athlete("otasyn", 6.5)
            }
        };

        Diving diving_5_meters = new Diving_5_meters
        {
            Athletes = diving_3_meters.Athletes
        };

       

        diving_3_meters.PrintResults();
        diving_5_meters.PrintResults();
    }
}
*/



//level 3
//num 6

class Response
{
    public string[] Animal;
    public string[]TraitOfCharacter;
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
        for (int i =0; i < 25; i++)
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

    private int GetCount(string[] responses, string response)
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

class Program
{
    static void Main()
    {
        Russia russia = new Russia();

        russia.NewAnimalResponse("bear");
        russia.NewAnimalResponse("dog");
        russia.NewAnimalResponse("bear");
        russia.NewAnimalResponse("wolf");
        russia.NewAnimalResponse("bear");

        russia.NewTraitOfCharacterResponse("kindness");
        russia.NewTraitOfCharacterResponse("creativity");
        russia.NewTraitOfCharacterResponse("creativity");
        russia.NewTraitOfCharacterResponse("kindness");
        russia.NewTraitOfCharacterResponse("politeness");
        russia.NewTraitOfCharacterResponse("sense of humour");

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
        

        japan.NewTraitOfCharacterResponse("kindness");
        japan.NewTraitOfCharacterResponse("creativity");
        japan.NewTraitOfCharacterResponse("politeness");
        japan.NewTraitOfCharacterResponse("sense of humour");


        japan.NewObjectResponse("sakura");
        japan.NewObjectResponse("sunrise");
        japan.NewObjectResponse("sun");
        japan.NewObjectResponse("food");
        japan.NewObjectResponse("technologies");

        Console.WriteLine("Russia");
        russia.PrintTopResponses();

        Console.WriteLine(" ");
        Console.WriteLine("Japan");
        japan.PrintTopResponses();

        Console.WriteLine(" ");
        Console.WriteLine("Top responses from both countries:");
        string[] allResponses = new string[50];
        int index = 0;

        foreach (var response in russia.country_response.GetAllResponses())
        {
            allResponses[index] = response;
            index++;
        }

        foreach (var response in japan.country_response.GetAllResponses())
        {
            allResponses[index] = response;
            index++;
        }

        var topResponses = russia.country_response.GetTopResponses();
        foreach (var response in topResponses)
        {
            Console.WriteLine(response);
        }
    }
}
