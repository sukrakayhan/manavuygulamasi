// if-else kullanarak yazalım
using System.ComponentModel.Design;

Console.WriteLine("Rüya manavına hoşgeldiniz");
Console.WriteLine("elma=2tl, armut=3tl, çilek=2tl, muz=3tl diğer tüm meyveler=4tl");
Console.WriteLine("hangi meyveyi almak istersiniz?");
string meyve = Console.ReadLine().ToLower();

if (meyve == "elma")
{
    Console.WriteLine("Elma=2tl");
}
else if (meyve == "armut")
{
    Console.WriteLine("Armut=3tl");
}

else if (meyve == "çilek")
{
    Console.WriteLine("çilek=2 tl)");


}

else if (meyve == "muz")
{
    Console.WriteLine("muz 3 tl");

}
else
{ Console.WriteLine("diğer tüm meyveler = 4 tl");

}


//switch-case kullanarak yazalım

Console.WriteLine("hangi meyveyi istersiniz?");
string meyve = Console.ReadLine().ToLower();

switch (meyve)
{
    case "elma":

        Console.WriteLine("elma 2tl");
        break;
    case "armut":
        Console.WriteLine("armut 3tl");
        break;
    case "çilek":
        Console.WriteLine("çilek 2tl");
        break;
    case "muz":
        Console.WriteLine("muz 3tl");
        break;
    default:
        Console.WriteLine("diğer tüm meyveler 4 tl");
        break;
}