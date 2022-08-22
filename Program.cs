List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};

//1
IEnumerable<Eruption> firstChile = eruptions.Where(e=>e.Location == "Chile");
Console.WriteLine(firstChile.First(y => y.Year < 1970));

//2
IEnumerable<Eruption> firstHawaii = eruptions.Where(e=>e.Location == "Hawaiian Is");
Console.WriteLine(firstHawaii.FirstOrDefault(y => y.Year < 2020));

//3
IEnumerable<Eruption> three = eruptions.Where(e=>e.Location == "New Zealand" && e.Year > 1900);
Console.WriteLine(three.FirstOrDefault(t=>t.Year > 1900));

//4
IEnumerable<Eruption> overTwoThousand = eruptions.Where(e=>e.ElevationInMeters > 2000);
foreach (Eruption item in overTwoThousand)
{
    Console.WriteLine(item);
}

//5
IEnumerable<Eruption> startWithZ = eruptions.Where(e=>e.Volcano.StartsWith("Z"));
foreach (Eruption i in startWithZ)
{
    Console.WriteLine(i);
}
var count = startWithZ.Count();
Console.WriteLine(count);



