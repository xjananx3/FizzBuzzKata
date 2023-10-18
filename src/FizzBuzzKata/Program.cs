// See https://aka.ms/new-console-template for more information

using FizzBuzzKata;

Console.WriteLine("FizzBuzZ");

var ergebnis = FizzBuzz.FizzBuzzListe(100);

foreach (var element in ergebnis)
{
    Console.WriteLine(element);
}
