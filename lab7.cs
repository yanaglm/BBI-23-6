using System;
//LAB 7
//level 1
//num 1
/*
class Results
{
    private Competitor[] competitors;
    private int size;

    public Results()
    {
        competitors = new Competitor[10];
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
    public bool Disqualified { get; set; }

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
        Results result = new Results();

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
abstract class Diving
{
    public string NameOfDiscipline
    {
        get;
        protected set;
    }

    public abstract void PrintResults(double[,] scores, string[] surnames);
}

class Diving_3_meters : Diving
{
    public Diving_3_meters()
    {
        NameOfDiscipline = "3 meters diving";
    }

    public override void PrintResults(double[,] scores, string[] surnames)
    {
        SortBubble(scores, surnames);
        Console.WriteLine(NameOfDiscipline);
        Console.WriteLine("final scores");
        for (int i = 0; i < 3; i++)
        {
            double finalScore = 0;
            for (int j = 0; j < 5; j++)
            {
                finalScore += scores[i, j];
            }
            Console.WriteLine($"ranking {i + 1}: {surnames[i]}, final score: {finalScore}");
        }
    }

    private void SortBubble(double[,] scores, string[] surnames)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2 - i; j++)
            {
                if (FindOutFinalScore(scores, j) < FindOutFinalScore(scores, j + 1))
                {
                    Replace(scores, j, j + 1);
                    ReplaceSurnames(surnames, j, j + 1);
                }
            }
        }
    }

    private double FindOutFinalScore(double[,] scores, int ind)
    {
        double finalScore = 0;
        for (int j = 0; j < 5; j++)
        {
            finalScore += scores[ind, j];
        }
        return finalScore;
    }

    private void Replace(double[,] scores, int ind1, int ind2)
    {
        for (int i = 0; i < 5; i++)
        {
            double x = scores[ind1, i];
            scores[ind1, i] = scores[ind2, i];
            scores[ind2, i] = x;
        }
    }

    private void ReplaceSurnames(string[] surnames, int ind1, int ind2)
    {
        string x = surnames[ind1];
        surnames[ind1] = surnames[ind2];
        surnames[ind2] = x;
    }
}

class Diving_5_meters : Diving
{
    public Diving_5_meters()
    {
        NameOfDiscipline = "5 meters diving";
    }

    public override void PrintResults(double[,] scores, string[] surnames)
    {
        SortBubble(scores, surnames);
        Console.WriteLine(" ");
        Console.WriteLine(NameOfDiscipline);
        Console.WriteLine("final scores");
        for (int i = 0; i < 3; i++)
        {
            double finalScore = 0;
            for (int j = 0; j < 5; j++)
            {
                finalScore += scores[i, j];
            }
            Console.WriteLine($"ranking {i + 1}: {surnames[i]}, final score: {finalScore}");
        }
    }

    private void SortBubble(double[,] scores, string[] surnames)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2 - i; j++)
            {
                if (FindOutFinalScore(scores, j) < FindOutFinalScore(scores, j + 1))
                {
                    Replace(scores, j, j + 1);
                    ReplaceSurnames(surnames, j, j + 1);
                }
            }
        }
    }

    private double FindOutFinalScore(double[,] scores, int ind)
    {
        double finalScore = 0;
        for (int j = 0; j < 5; j++)
        {
            finalScore += scores[ind, j];
        }
        return finalScore;
    }

    private void Replace(double[,] scores, int ind1, int ind2)
    {
        for (int i = 0; i < 5; i++)
        {
            double x = scores[ind1, i];
            scores[ind1, i] = scores[ind2, i];
            scores[ind2, i] = x;
        }
    }

    private void ReplaceSurnames(string[] surnames, int ind1, int ind2)
    {
        string x = surnames[ind1];
        surnames[ind1] = surnames[ind2];
        surnames[ind2] = x;
    }
}

class Program
{
    static void Main()
    {
        Diving diving_3_meters = new Diving_3_meters();
        Diving diving_5_meters = new Diving_5_meters();

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

        diving_3_meters.PrintResults(scores, surnames);
        diving_5_meters.PrintResults(scores, surnames);
    }
}
*/





//level 3
//num 6
/*
class Response
{
    private string[] Japan_Animal;
    private string[] Japan_TraitOfCharacter;
    private string[] Japan_Object;
    private int[] Japan_AnimalCount;
    private int[] Japan_TraitOfCharacterCount;
    private int[] Japan_ObjectCount;

    public Response()
    {
        Japan_Animal = new string[10];
        Japan_TraitOfCharacter = new string[10];
        Japan_Object = new string[10];
        Japan_AnimalCount = new int[10];
        Japan_TraitOfCharacterCount = new int[10];
        Japan_ObjectCount = new int[10];
    }

    public void NewAnimalResponse(string response)
    {
        for (int i = 0; i < Japan_Animal.Length; i++)
        {
            if (Japan_Animal[i] == null)
            {
                Japan_Animal[i] = response;
                Japan_AnimalCount[i]++;
                break;
            }
            else if (Japan_Animal[i] == response)
            {
                Japan_AnimalCount[i]++;
                break;
            }
        }
    }

    public void NewTraitOfCharacterResponse(string response)
    {
        for (int i = 0; i < Japan_TraitOfCharacter.Length; i++)
        {
            if (Japan_TraitOfCharacter[i] == null)
            {
                Japan_TraitOfCharacter[i] = response;
                Japan_TraitOfCharacterCount[i]++;
                break;
            }
            else if (Japan_TraitOfCharacter[i] == response)
            {
                Japan_TraitOfCharacterCount[i]++;
                break;
            }
        }
    }

    public void NewObjectResponse(string response)
    {
        for (int i = 0; i < Japan_Object.Length; i++)
        {
            if (Japan_Object[i] == null)
            {
                Japan_Object[i] = response;
                Japan_ObjectCount[i]++;
                break;
            }
            else if (Japan_Object[i] == response)
            {
                Japan_ObjectCount[i]++;
                break;
            }
        }
    }

    public void PrintTopResponses()
    {
        Console.WriteLine("animal results");
        PrintTopResponsesForAllQuestions(Japan_Animal, Japan_AnimalCount);

        Console.WriteLine("traits of character results");
        PrintTopResponsesForAllQuestions(Japan_TraitOfCharacter, Japan_TraitOfCharacterCount);

        Console.WriteLine("objects results");
        PrintTopResponsesForAllQuestions(Japan_Object, Japan_ObjectCount);
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
    public virtual void WriteResponsesInPercent()
    {
        Console.WriteLine("Базовый класс Страна");
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
        Response radio_response = new Response();

        radio_response.NewAnimalResponse("cat");
        radio_response.NewAnimalResponse("cat");
        radio_response.NewAnimalResponse("panda");
        radio_response.NewAnimalResponse("dog");
        radio_response.NewAnimalResponse("bird");
        radio_response.NewAnimalResponse("red panda");

        radio_response.NewTraitOfCharacterResponse("kindness");
        radio_response.NewTraitOfCharacterResponse("creativity");
        radio_response.NewTraitOfCharacterResponse("creativity");
        radio_response.NewTraitOfCharacterResponse("kindness");
        radio_response.NewTraitOfCharacterResponse("politeness");
        radio_response.NewTraitOfCharacterResponse("sense of humour");
        radio_response.NewTraitOfCharacterResponse("responsibility");

        radio_response.NewObjectResponse("sakura");
        radio_response.NewObjectResponse("sakura");
        radio_response.NewObjectResponse("sunrise");
        radio_response.NewObjectResponse("sakura");
        radio_response.NewObjectResponse("sun");
        radio_response.NewObjectResponse("food");
        radio_response.NewObjectResponse("technologies");

        radio_response.PrintTopResponses();

        Country country1 = new Russia();
        Country country2 = new Japan();

        ((Russia)country1).WriteResponsesInPercent();
        ((Japan)country2).WriteResponsesInPercent();
    }
}
*/