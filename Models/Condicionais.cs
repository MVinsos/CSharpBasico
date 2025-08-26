namespace CSharpBasico.Models;


public class Condicional
{
    public void CondicaoAND()
    {
        int quantidadeEmEstoque = 10;
        int quantidadeCompra = 4;
        bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

        if (quantidadeCompra == 0)
        {
            Console.WriteLine("Compra Invalida.");
        }

        else if (possivelVenda)
        {
            Console.WriteLine("Compra realizada com sucesso.");
        }
        else
        {
            Console.WriteLine("Não temos a quantidade em estoque.");
        }        
     }
}