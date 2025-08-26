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

    public void SomarNumero()
    {
        int Soma = 0, numero = 0;

        do
        {
            Console.WriteLine("Digite um número (0 para parar): ");
            numero = Convert.ToInt32(Console.ReadLine());
            Soma += numero;

        }
        while (numero != 0);

        Console.WriteLine($"A soma dos números digitados é: {Soma}");
    }
    
        public void Cliente()
    {

        while (true)
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar cliente.");
            Console.WriteLine("2 - Buscar cliente.");
            Console.WriteLine("3 - Apagar cliente.");
            Console.WriteLine("4 - Encerrar operação.");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastro de cliente.");
                    break;
                case "2":
                    Console.WriteLine("Busca de cliente.");
                    break;
                case "3":
                    Console.WriteLine("Apagar cliente.");
                    break;
                case "4":
                    Console.WriteLine("Encerrando operação.");
                    return;
                default:
                    Console.WriteLine("Opção inválida, digite novamente.");
                    break;
            }
            
        }


    }
}

