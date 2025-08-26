namespace CSharpBasico.Models;

public class LacoRepeticao
{
    public void Incremento()
    {
        Console.WriteLine("Digite um número para ver a tabuada: ");
        string? entrada = Console.ReadLine();
        if (int.TryParse(entrada, out int numero))
        {
            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido, digite um número inteiro.");
        }
    }

    public void AcerteNumero()
    {
        int NumeroSecreto = 7;
        int NumeroUsuario = 0;

        while (NumeroUsuario != NumeroSecreto)
        {
            Console.WriteLine("Digite um número de 1 a 10 para adivinhar o número correto: ");
            string? Tentativa = Console.ReadLine();
            if (int.TryParse(Tentativa, out int numero))
            {
                NumeroUsuario = numero;
                
                if (numero != NumeroSecreto)
                {
                    Console.WriteLine("Número errado, tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Número inválido, digite um número inteiro.");
            }
        }

        Console.WriteLine("Párabens, você acertou!");

    }
}
