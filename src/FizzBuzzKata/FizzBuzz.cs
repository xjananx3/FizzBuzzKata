namespace FizzBuzzKata;

public class FizzBuzz
{
    public static IEnumerable<string> FizzBuzzListe(int groesse)
    {
        var zahlen = new List<string>();
        
        for(int i = 1; i <= groesse; i++)
            zahlen.Add(DoFizzBuZZ(i));
        
        return zahlen;
    }
}