namespace FizzBuzzKata;

public class FizzBuzz
{
    public static IEnumerable<string> FizzBuzzListe(int groesse)
    {
        var zahlen = new List<string>();
        
        for(int i = 1; i <= groesse; i++)
            zahlen.Add(DoFizzBuzZ(i));
        
        return zahlen;
    }

    private static string DoFizzBuzZ(int zahl)
    {
        if (zahl % 3 == 0 && zahl % 5 == 0)
            return "FizzBuzZ";
        
        if (zahl % 3 == 0)
            return "Fizz";

        if (zahl % 5 == 0)
            return "Buzz";

        return zahl.ToString();
    }
}