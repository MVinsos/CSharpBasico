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
        bool SistemaCliente = true;
        
        while (SistemaCliente)
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
                    Console.WriteLine("Digite seu nome completo.");
                    string? Nome = Console.ReadLine();

                    Console.WriteLine("Digite sua idade.");
                    string? Idade = Console.ReadLine();

                    if (int.TryParse(Idade, out int IdadeConvertida))
                    {
                        Random Conta = new Random();
                        int NumeroConta = Conta.Next(1000, 9999);
                        DateTime agora = DateTime.Now;

                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
                        Console.WriteLine($"Sua conta é {NumeroConta}.\nCadastro concluido as {agora}");
                        Console.WriteLine("Retornando ao menu principal.\n");

                    }
                    else
                    {
                        Console.WriteLine("Idade inválida, digite um número inteiro.\n");
                    }

                    break;

                case "2":
                    Console.WriteLine("Banco de dados inacessivel no momento, tente novamente mais tarde.\n");
                    break;

                case "3":
                    Console.WriteLine("Banco de dados inacessivel no momento, tente novamente mais tarde.\n");
                    break;

                case "4":
                    Console.WriteLine("Encerrando operação.");
                    SistemaCliente = false;
                    break;
                    
                default:
                    Console.WriteLine("Opção inválida, digite novamente.");
                    break;
            }

        }


    }
}

