using System;
using System.Collections.Generic;


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
            Console.WriteLine($"| {i + 1,-10}| {competitors[i].Surname,-8} |  {competitors[i].Community,-10} | {competitors[i].Final_result,-12} | ");
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
}

struct Competitor
{
    public string Surname { get; }
    public string Community { get; }
    public double First_atttempt { get; }
    public double Second_atttempt;
    public double Final_result => First_atttempt + Second_atttempt;


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
    private string[] surnames;
    private double[,] scores;

    public Competitors()
    {
        surnames = new string[3];
        scores = new double[3,5];
    }

    public void NewScores(string surname, double[] score_firstattempt, double[] score_secondattempt, int ind)
    {
        surnames[ind] = surname;
        for(int i = 0; i< 5; i++)
        {
            scores[ind, i] = (score_firstattempt[i] + score_secondattempt[i]) / 2;
        }
    }

    public void PrintResults()
    {
        SortBubble();
        Console.WriteLine("final scores");
        for(int i = 0; i< 3; i++)
        {
            double final_score = 0;
            for(int j = 0; j< 5; j++)
            {
                final_score += scores[i, j];
            }
            Console.WriteLine($"ranking {i+1}: {surnames[i]}, final score: {final_score}");
        }
    }

    public void SortBubble()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2 - i; j++)
            {
                if (FindOut_FinalScore(j) < FindOut_FinalScore(j + 1))
                {
                    Replace(j, j + 1);
                    ReplaceSurnames(j, j + 1);
                }
            }
        }
    }

    //private void SortInsert()
    //{
    //    for(int i = 1; i< 3; i++)
    //    {
    //        string first_surname = surnames[i];
    //        double[] first_scores = new double[5];

    //        for(int t = 0; t < 5; t++)
    //        {
    //            first_scores[t] = scores[i, t];
    //        }


    //        int k = i - 1;
    //        while(k>=0 && surnames[k].CompareTo(first_surname) > 0)
    //        {
    //            surnames[k + 1] = surnames[k];
    //            for(int t = 0; t<5; t++)
    //            {
    //                scores[k + 1, t] = scores[k, t];
    //            }
    //            k--;
    //        }

    //        surnames[k + 1] = first_surname;

    //        for(int t = 0; t < 5; t++)
    //        {
    //            scores[k + 1, t] = first_scores[t];
    //        }
    //    }
    //}

    private double FindOut_FinalScore(int ind)
    {
        double final_score = 0;
        for(int j = 0; j<5; j++)
        {
            final_score += scores[ind, j];
        }
        return final_score;
    }

    private void Replace(int ind1, int ind2)
    {
        for (int i = 0; i < 5; i++)
        {
            double x = scores[ind1, i];
            scores[ind1, i] = scores[ind2, i];
            scores[ind2, i] = x;
        }
    }

    private void ReplaceSurnames(int ind1, int ind2)
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
        Competitors result = new Competitors();

        //result.KeepingScores();

        result.NewScores("petrov", new double[] { 6.5, 7.0, 6.0, 8.0, 7.5 }, new double[] { 8.0, 8.5, 7.5, 8.5, 9.0 }, 0);
        result.NewScores("smirnov", new double[] { 6.5, 5.5, 6.0, 5.0, 7.0 }, new double[] { 7.5, 8.0, 7.5, 7.0, 7.0 }, 1);
        result.NewScores("zaitsev", new double[] { 9.5, 9.0, 10.0, 9.5, 9.5 }, new double[] { 8.5, 8.0, 9.0, 8.5, 9.5 }, 2);

        result.PrintResults();
    }
}
*/
// keepingscores перенести в конструктор 
// сортировку вставками


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
    private string[] Japan_Animal;
    private string[] Japan_TraitOfCharacter;
    private string[] Japan_Object;
    private int[] Japan_AnimalCount;
    private int[] Japan_TraitOfCharacterCount;
    private int[] Japan_ObjectCount;

    private static int quantity_of_responses = 0;

    public void Responses()
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
        quantity_of_responses++;

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
        quantity_of_responses++;

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
        quantity_of_responses++;

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

    public static int GetFinalResponses()
    {
        return quantity_of_responses;
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

        Console.WriteLine($"final responses: {Response.GetFinalResponses()}");
    }
}
*/
// общее колво считать через стат переменную




