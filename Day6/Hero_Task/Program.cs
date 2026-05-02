namespace Hero_Task
{
    class Program
    {
        static void Main()
        {
            Squad<Hero> squad = new Squad<Hero>();

            squad.Add(new Hero("Batman", 80));
            squad.Add(new Hero("Superman", 100));
            squad.Add(new Hero("Flash", 45));
            squad.Add(new Hero("Ironman", 60));

            var strongHeroes = squad.Where(h => h.Level > 50);

            Console.WriteLine("Heroes with Level > 50:");
            foreach (var hero in strongHeroes)
            {
                Console.WriteLine(hero.Name);
            }

            var foundHero = squad.FirstOrDefault(delegate (Hero h)
            {
                return h.Name == "Batman";
            });

            Console.WriteLine("\nSearch Result:");
            if (foundHero != null)
                Console.WriteLine(foundHero.Name + " found!");
            else
                Console.WriteLine("Hero not found");
        }
    }
}
