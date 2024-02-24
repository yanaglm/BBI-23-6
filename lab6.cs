using System;
using System.Collections.Generic;
using System.Linq;


//lab6
//level 1
//num 1
/*
Результаты соревнований по прыжкам в длину определяются по сумме двух
попыток.В протоколе для каждого участника указываются: фамилия, общество,
результаты первой и второй попыток. Вывести протокол в виде таблицы с
заголовком в порядке занятых мест.
*/
/*
struct Results
{
    private List<Competitor> competitors;

    public void Result()
    {
        competitors = new List<Competitor>();
    }

    public void NewCompetitor(string surname, string community, double first_attempt, double second_attempt)
    {
        Competitor new_member = new Competitor(surname, community, first_attempt, second_attempt);
        competitors.Add(new_member);
    }

    public void PrintResult()
    {
        var sortedCompetitors = competitors.OrderByDescending(a => a.Total_result).ToList();
        Console.WriteLine("result");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("| ranking   | surname  | community   | final result |");
        Console.WriteLine("------------------------------------");
        int ranking = 1;
        foreach (var competitor in sortedCompetitors)
        {
            Console.WriteLine($"| {ranking,-10}| {competitor.Surname,-8} |  {competitor.Community,-10} | {competitor.Total_result,-12} | ");
            ranking++;

        }
        Console.WriteLine("------------------------------------");
    }
}

struct Competitor
{
    public string Surname { get; }
    public string Community { get; }
    public double First_atttempt { get; }
    public double Second_atttempt { get; }
    public double Total_result => First_atttempt + Second_atttempt;
    

    public Competitor(string surname, string community, double first_attempt, double second_attempt)
    {
        Surname = surname;
        Community = community;
        First_atttempt = first_attempt;
        Second_atttempt = second_attempt;
    }
}

class Program
{
    static void Main()
    {
        Results result = new Results();
        result.Result();

        result.NewCompetitor("petrov", "club 1", 8.2, 6.8);
        result.NewCompetitor("smirnov", "club 2", 6.3, 7.2);
        result.NewCompetitor("zaitsev", "club 3", 7.5, 8.7);

        result.PrintResult();


       
    }
}
*/




//level 2
//num 6
/*
Протокол соревнований по прыжкам в воду содержит список фамилий спортсменов
и баллы, выставленные 5 судьями по результатам 2 прыжков. Получить итоговый
протокол, содержащий фамилии и результаты, в порядке занятых спортсменами
мест по результатам 2 прыжков.
*/
/*
struct Competitors
{
    private Dictionary<string, List<double>> scores;

    public void KeepingScores()
    {
        scores = new Dictionary<string, List<double>>();
    }

    public void NewScores(string surname, List<double> score_firstattempt, List<double> score_secondattempt)
    {
        List<double> final_scores = new List<double>();
        for(int i = 0; i< 5; i++)
        {
            final_scores.Add(score_firstattempt[i] + score_secondattempt[i] / 2);

        }
        scores.Add(surname, final_scores);
    }

    public void PrintResults()
    {
        var sorted_scores = scores.OrderByDescending(a => a.Value.Sum()).ToList();
        Console.WriteLine("final scores");
        int ranking = 1;
        foreach (var competitor in sorted_scores)
        {
            Console.WriteLine($"ranking {ranking}: {competitor.Key}, final score: {competitor.Value.Sum()}");
            ranking++;

        }

    }
    

   

}

class Program
{
    static void Main()
    {
        Competitors result = new Competitors();

        result.KeepingScores();

        result.NewScores("petrov", new List<double> { 6.5, 7.0, 6.0, 8.0, 7.5 }, new List<double> { 8.0, 8.5, 7.5, 8.5, 9.0 });
        result.NewScores("smirnov", new List<double> { 6.5, 5.5, 6.0, 5.0, 7.0 }, new List<double> { 7.5, 8.0, 7.5, 7.0, 7.0 });
        result.NewScores("zaitsev", new List<double> { 9.5, 9.0, 10.0, 9.5, 9.5 }, new List<double> { 8.5, 8.0, 9.0, 8.5, 9.5 });

        result.PrintResults();

       
    }
}
*/


//level 3
//num 6
/*
Японская радиокомпания провела опрос радиослушателей по трем вопросам:
а). Какое животное Вы связываете с Японией и японцами?
б). Какая черта характера присуща японцам больше всего?
в). Какай неодушевленный предмет или понятие Вы связываете с Японией?
Большинство опрошенных прислали ответы на все или часть вопросов.
Составить программу получения первых пяти наиболее часто встречающихся
ответов по каждому вопросу и доли (в %) каждого такого ответа.
Предусмотреть необходимость сжатия столбца ответов в случае отсутствия
ответов на некоторые вопросы.
 */
/*
struct Response
{
    private Dictionary<string, int> Japan_Animal;
    private Dictionary<string, int> Japan_TraitOfCharacter;
    private Dictionary<string, int> Japan_Object;

    public void Responses()
    {
        Japan_Animal = new Dictionary<string, int>();
        Japan_TraitOfCharacter = new Dictionary<string, int>();
        Japan_Object = new Dictionary<string, int>(); 
    }

    public void NewAnimalResponse(string response)
    {
        if (Japan_Animal.ContainsKey(response))
        {
            Japan_Animal[response]++;
        }
        else
        {
            Japan_Animal[response] = 1;
        }
    }

    public void NewTraitOfCharacterResponse(string response)
    {
        if (Japan_TraitOfCharacter.ContainsKey(response))
        {
            Japan_TraitOfCharacter[response]++;
        }
        else
        {
            Japan_TraitOfCharacter[response] = 1;
        }
    }

    public void NewObjectResponse(string response)
    {
        if (Japan_Object.ContainsKey(response))
        {
            Japan_Object[response]++;
        }
        else
        {
            Japan_Object[response] = 1;
        }
    }

    public void PrintTopResponses()
    {
        Console.WriteLine("animal results");
        PrintTopResponsesForAllQuestions(Japan_Animal);

        Console.WriteLine("traits of character results");
        PrintTopResponsesForAllQuestions(Japan_TraitOfCharacter);

        Console.WriteLine("objects results");
        PrintTopResponsesForAllQuestions(Japan_Object);
    }

    public void PrintTopResponsesForAllQuestions(Dictionary<string, int> responses)
    {
        var allResponses = responses.Sum(a => a.Value);
        var TopResponses = responses.OrderByDescending(a => a.Value).Take(5);

        foreach (var response in TopResponses)
        {
            double percent = (double)response.Value / allResponses * 100;
            Console.WriteLine($"responses: {response.Key}, count: {response.Value}, percent: {percent}%");
        }
    }
}
class Program
{
    static void Main()
    {
        Response radio_response = new Response();
        radio_response.Responses();

        radio_response.NewAnimalResponse("cat");
        radio_response.NewAnimalResponse("cat");
        radio_response.NewAnimalResponse("panda");
        radio_response.NewTraitOfCharacterResponse("kindness");
        radio_response.NewTraitOfCharacterResponse("creativity");
        radio_response.NewTraitOfCharacterResponse("creativity");
        radio_response.NewTraitOfCharacterResponse("kindness");
        radio_response.NewObjectResponse("sakura");
        radio_response.NewObjectResponse("sakura");
        radio_response.NewObjectResponse("sunrise");
        radio_response.NewObjectResponse("sakura");

        radio_response.PrintTopResponses();
    }
}
*/