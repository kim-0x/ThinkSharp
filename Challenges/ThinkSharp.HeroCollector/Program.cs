// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hero Collector");
Console.WriteLine("---------------------");

IEnumerable<string> GetHeros()
{
    var list = new List<string>();
    list.Add("Thor");
    list.Add("Iron Man");
    list.Add("Hulk");
    return list;
}
foreach (var hero in GetHeros())
{
    Console.WriteLine($"Get Hero: {hero}");
}

// With yield return
Console.WriteLine("Get Hero with yield return");
Console.WriteLine("---------------------------");
IEnumerable<string> GetAvengers()
{
    yield return "Thor";
    yield return "Iron Man";
    yield return "Hulk";
}

foreach (var hero in GetAvengers())
{
    Console.WriteLine($"Get Hero: {hero}");
}

// Get Hero with .NET runtime implemention
Console.WriteLine("Get Hero with .NET runtime implemention");
Console.WriteLine("-----------------------------------------");
foreach (var hero in new Avengers()) {
    Console.WriteLine($"Get hero: {hero}");
}