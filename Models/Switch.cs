namespace CSharpBasico.Models;


public class Interruptor
{
    public void InterruptorCondicoes()
    {
        Console.WriteLine("Digite uma vogal:");
        string? Letra = Console.ReadLine();

        if (string.IsNullOrEmpty(Letra))
        {
            Console.WriteLine("Nenhuma letra digitada.");
        }

        else
        {
            switch (Letra)
            {
                case "a":
                case "i":
                case "o":
                case "u":
                case "e":
                case "y":
                    Console.WriteLine("Vogal valida.");
                    break;

                default:
                    Console.WriteLine("Vogal invalida.");
                    break;
            }
        }


    }
}