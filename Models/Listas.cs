namespace CSharpBasico.Models;


public class Lista
{
    public void Listas()
    {
        List<string> ListaString = ["SP", "BA", "MG", "RJ"];

        foreach (string item in ListaString)
        {
            Console.WriteLine($"Estados na lista: {item}");
        }

        Console.WriteLine($"Quantidade de itens na lista: {ListaString.Count}\n");

        ListaString.Remove("MG");


        foreach (string item in ListaString)
        {
            Console.WriteLine($"Estados na lista: {item}");
        }
        Console.WriteLine($"Itens na lista após remoção: {ListaString.Count}");

    }
}