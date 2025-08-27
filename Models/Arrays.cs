namespace CSharpBasico.Models;

public class Arrays
{
    public void ArrayUsos()
    {
        int[] arrayInteiro = [1, 55, 27, 23, 89];

        Array.Resize(ref arrayInteiro, arrayInteiro.Length * 2);

        Console.WriteLine("Exibindo pelo FOR:");
        for (int contador = 0; contador < arrayInteiro.Length; contador++)
        {
            Console.WriteLine($"Posição N° {contador} = {arrayInteiro[contador]}");
        }

        int contadorForeach = 0;
        Console.WriteLine("Exibindo pelo FOREACH:");
        foreach (int valor in arrayInteiro)
        {
            Console.WriteLine($"Posição N° {contadorForeach} = {valor}");
            contadorForeach++;
        }
    }
}