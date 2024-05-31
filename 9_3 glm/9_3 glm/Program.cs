using System;
using System.IO;
using _9_3;
using ProtoBuf;


[ProtoContract]
[Serializable]
public class Response
{
    protected string[] animal;
    protected string[] traitOfCharacter;
    protected string[] _object;
    protected int[] animalCount;
    protected int[] traitOfCharacterCount;
    protected int[] objectCount;

    [ProtoMember(1)]
    public string[] Animal { get => animal; set => animal = value; }
    [ProtoMember(2)]
    public string[] TraitOfCharacter { get => traitOfCharacter; set => traitOfCharacter = value; }
    [ProtoMember(3)]
    public string[] Object { get => _object; set => _object = value; }
    [ProtoMember(4)]
    public int[] AnimalCount { get => animalCount; set => animalCount = value; }
    [ProtoMember(5)]
    public int[] TraitOfCharacterCount { get => traitOfCharacterCount; set => traitOfCharacterCount = value; }
    [ProtoMember(6)]
    public int[] ObjectCount { get => objectCount; set => objectCount = value; }

    public Response()
    {
        animal = new string[10];
        traitOfCharacter = new string[10];
        _object = new string[10];
        animalCount = new int[10];
        traitOfCharacterCount = new int[10];
        objectCount = new int[10];
    }
    public void NewAnimalResponse(string response)
    {
        for (int i = 0; i < animal.Length; i++)
        {
            if (animal[i] == null)
            {
                animal[i] = response;
                animalCount[i]++;
                break;
            }
            else if (Animal[i] == response)
            {
                animalCount[i]++;
                break;
            }
        }
    }
    public void NewTraitOfCharacterResponse(string response)
    {
        for (int i = 0; i < traitOfCharacter.Length; i++)
        {
            if (traitOfCharacter[i] == null)
            {
                traitOfCharacter[i] = response;
                traitOfCharacterCount[i]++;
                break;
            }
            else if (traitOfCharacter[i] == response)
            {
                traitOfCharacterCount[i]++;
                break;
            }
        }
    }
    public void NewObjectResponse(string response)
    {
        for (int i = 0; i < Object.Length; i++)
        {
            if (_object[i] == null)
            {
                _object[i] = response;
                objectCount[i]++;
                break;
            }
            else if (_object[i] == response)
            {
                objectCount[i]++;
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
[ProtoContract]
[Serializable]
[ProtoInclude(7, typeof(Russia))]
[ProtoInclude(8, typeof(Japan))]
[ProtoInclude(9, typeof(Combined))]
public class Country
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

[ProtoContract]
[Serializable]
public class Russia : Country
{
    public override void WriteResponsesInPercent()
    {
        Console.WriteLine("Ответы по России в %");
    }
}

[ProtoContract]
[Serializable]
class Japan : Country
{
    public override void WriteResponsesInPercent()
    {
        Console.WriteLine("Ответы по Японии в %");
    }
}

[ProtoContract]
[Serializable]
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
        Response response = new Response
        {
            Animal = new string[] { "bear", "dog", "wolf", "cat", "hamster" },
            TraitOfCharacter = new string[] { "kindness", "creativity", "politeness", "sense of humour", "fun" },
            Object = new string[] { "nature", "food", "flowers", "buildings", "sun" }
        };
        ISer[] serializers = new ISer[]
        {
            new MySerializeJson(),
            new MySerializeXML(),
            new MySerializeBin()
        };
        string folder = "Countries";
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), folder);
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        string[] files = new string[]
        {
            "countries.json",
            "countries.xml",
            "countries.bin"
        };
        for (int i = 0; i < serializers.Length; i++)
        {
            serializers[i].Write(response, Path.Combine(path, files[i]));
        }
        for (int i = 0; i < serializers.Length; i++)
        {
            response = serializers[i].Read<Response>(Path.Combine(path, files[i]));
            response.PrintTopResponses();
        }
    }
    static void PrintResponse(Response response)
    {
        Console.WriteLine("Animals: " + string.Join(", ", response.Animal));
        Console.WriteLine("Traits of Character: " + string.Join(", ", response.TraitOfCharacter));
        Console.WriteLine("Objects: " + string.Join(", ", response.Object));
        Console.WriteLine();
    }

}