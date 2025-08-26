namespace CSharpBasico.Models;


public class Operador
{
    public void AtivadorOR()
    {
        bool maiorDeIdade = true;
        bool possuiAutorizacaoDoResponsavel = false;

        if (maiorDeIdade || possuiAutorizacaoDoResponsavel)
        {
            Console.WriteLine("Entrada autorizada.");
        }
        else
        {
            Console.WriteLine("Entrada negada.");
        }
    }

    public void AtivadorAND()
    {
        bool presencaMinima = true;
        double media = 7.5;

        if (presencaMinima && media >= 7)
        {
            Console.WriteLine("Aprovado.");
        }
        else
        {
            Console.WriteLine("Reprovado.");
        }
    }

    public void AtivadorNOT()
    {
        bool choveu = false;
        bool estaTarde = false;

        if (!choveu && !estaTarde)
        {
            Console.WriteLine("Vou pedalar");

        }
        else
        {
            Console.WriteLine("Pedalar outro dia.");
        }
    }
}

