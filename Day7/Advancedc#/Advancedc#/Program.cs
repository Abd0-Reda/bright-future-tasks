using System;
using Advancedc_;

class Program
{
    static void Main(string[] args)
    {
        Squad<Hero> squad = new Squad<Hero>();

        squad.Add(new Hero { Name = "Batman", Level = 40 });
        squad.Add(new Hero { Name = "Dr.Strange", Level = 100 });
        squad.Add(new Hero { Name = "Superman", Level = 80 });

        var strongHeroes = squad.FindStrongHeroes();

        Console.WriteLine("Strong Heroes:");
        foreach (var hero in strongHeroes)
        {
            Console.WriteLine(hero.Name);
        }

        var batman = squad.Find(delegate (Hero h)
        {
            return h.Name == "Batman";
        });

        Console.WriteLine("Search Result:" + batman.Name);

    }
}