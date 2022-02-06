using FiFaDio.Models;
Knight Arus = new Knight("Arus",23, "Knight",78,20);
Wizard Jenica = new Wizard("Jenica", 23, "White Wizard",60,150);
Wizard Topapa = new Wizard("Topapa", 23, "Black Wizard",50,180);
Ninja Wedge = new Ninja("Wedge", 23, "Ninja",150,50);
Console.WriteLine(@$"{Wedge.Attack()}
{Topapa.Attack(2)}
{Jenica.Attack()}
{Arus.Attack()}
{Wedge.Attack()}
{Topapa.Attack(7)}");