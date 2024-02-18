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
class Competitors
{
    public string Surname
    {
        get;
        set;
    }
    public string Community
    {
        get;
        set;
    }
    public double FirstAttempt
    {
        get;
        set;
    }
    public double SecondAttempt
    {
        get;
        set;
    }
}

class Program
{
    static void Main()
    {
        // Создаем список участников
        List<Competitors> competitors = new List<Competitors>
        {
            new Competitors
            {
                Surname = "petrov", Community = "club 1", FirstAttempt = 8.2, SecondAttempt = 6.8
            },
            new Competitors
            {
                Surname = "smirnov", Community = "club 2", FirstAttempt = 6.3, SecondAttempt = 7.2
            },
            new Competitors
            {
                Surname = "zaitsev", Community = "club 3", FirstAttempt = 7.5, SecondAttempt = 8.7
            }
        };

        // Сортируем участников по результатам
        var sortedCompetitors = competitors.OrderBy(c => Math.Max(c.FirstAttempt, c.SecondAttempt)).ToList();

        // Выводим таблицу протокола соревнований
        Console.WriteLine("results");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("| surname  | community   | first attempt | second attempt |");
        Console.WriteLine("------------------------------------");
        foreach (var competitor in sortedCompetitors)
        {
            Console.WriteLine($"| {competitor.Surname,-8} | {competitor.Community,-11} | {competitor.FirstAttempt,-13} | {competitor.SecondAttempt,-14} |");
        }
        Console.WriteLine("------------------------------------");
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
class Competitors
{
    public string Surname
    {
        get;
        set;
    }

    public List<double> Score_firstattempt
    {
        get;
        set;
    }
    public List<double> Score_secondattempt
    {
        get;
        set;
    }

    public double GetResult()
    {
        var totalScore = Score_firstattempt.Average() + Score_secondattempt.Average();
        return Math.Round(totalScore, 2);
    }

}
class Program
{
    static void Main()
    {
        List<Competitors> competitors = new List<Competitors>
        {
            new Competitors
            {
                Surname = "petrov", Score_firstattempt = new List<double> {6.5, 7.0, 6.0, 8.0, 7.5}, Score_secondattempt = new List<double> {8.0, 8.5, 7.5, 8.5, 9.0}
            },
            new Competitors
            {
                Surname = "smirnov", Score_firstattempt = new List<double> {6.5, 5.5, 6.0, 5.0, 7.0}, Score_secondattempt = new List<double> {7.5, 8.0, 7.5, 7.0, 7.0}
            },
            new Competitors
            {
                Surname = "zaitsev", Score_firstattempt = new List<double> { 9.5, 9.0, 10.0, 9.5, 9.5 }, Score_secondattempt = new List<double> { 8.5, 8.0, 9.0, 8.5, 9.5 }
            }
        };

        var sort_competitors = competitors.OrderBy(d => d.GetResult()).ToList();

        Console.WriteLine("result");
        Console.WriteLine("---------------------------");
        Console.WriteLine("| surname   | final result   |");
        Console.WriteLine("---------------------------");
        foreach(var competitor in sort_competitors)
        {
            Console.WriteLine($"| {competitor.Surname,-9} | {competitor.GetResult(),-14} |");
        }
        Console.WriteLine("---------------------------");
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
class Response
{
    public Dictionary<string, int> Japan_Animal { get; set; }
    public Dictionary<string, int> Japan_TraitOfCharacter { get; set; }
    public Dictionary<string, int> Japan_Object { get; set; }

    public Response()
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

    public void PrintTopResponses(int k, Dictionary<string, int> responses)
    {
        var allResponses = responses.Sum(a => a.Value);
        var TopResponses = responses.OrderByDescending(a => a.Value).Take(k);
        Console.WriteLine("top responses");
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

        Console.WriteLine("animal results");
        radio_response.PrintTopResponses(5, radio_response.Japan_Animal);

        Console.WriteLine("traits of character results");
        radio_response.PrintTopResponses(5, radio_response.Japan_TraitOfCharacter);

        Console.WriteLine("objects results");
        radio_response.PrintTopResponses(5, radio_response.Japan_Object);
    }
}
*/