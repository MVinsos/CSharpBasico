namespace CSharpBasico.Models;

public class Pessoa
{
    public required string Nome { get; set; }
    public int Idade { get; set; }
    DateTime dataAtual = DateTime.Now;    

    public void Apresentar()
    {
              Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. \n Hoje é {dataAtual.ToString("dd/MM/yyyy")} às {dataAtual.ToString("HH:mm")}");
    }
}
