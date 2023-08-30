// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sea = Seasons.Summer | Seasons.Autumn;
var all = Seasons.All;
var turnip = SomeRootVegetable.Turnip;
(string, int) t1;
t1 = ("Tarun", 32);
Console.WriteLine(sea+"\n"+all+ "\n"+turnip);
Console.WriteLine($"value of tuple is {t1.Item1}");
Console.WriteLine(add(3,6));
Console.ReadLine();

int add(int x,int y) => x+y;

public enum SomeRootVegetable
{
    HorseRadish,
    Radish,
    Turnip
}

public enum Seasons
{
    None   = 0,
    Summer = 1,
    Autumn = 2,
    Winter = 4,
    Spring = 8,
    All    = Summer | Autumn | Winter | Spring
}

class Progra
{
   
}
