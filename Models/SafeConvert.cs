namespace CSharpBasico.Models;


public class Conversion
{
    string a = "15b";

    int b = 0;

    public void Conversao()
    {

        int.TryParse(a, out b);

        Console.WriteLine(b);
        Console.WriteLine("Convertido com Sucesso.");

    }
}