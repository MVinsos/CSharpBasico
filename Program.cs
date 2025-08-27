using CSharpBasico.Models;


class Program
{
    static void Main()
    {

        var pessoa1 = new Pessoa
        {
            Nome = "Vini",
            Idade = 28
        };
        pessoa1.Apresentar();

        var Convertido = new Conversion();
        Convertido.Conversao();

        var Condicionado = new Condicional();
        Condicionado.CondicaoAND();

        var SwitchInterruptor = new Interruptor();
        SwitchInterruptor.InterruptorCondicoes();

        var AtivarOperadores = new Operador();
        AtivarOperadores.AtivadorOR();
        AtivarOperadores.AtivadorAND();
        AtivarOperadores.AtivadorNOT();

        var calc = new Calculadora();
        calc.Somar(10, 30);
        calc.Dividir(10, 5);
        calc.Multiplicar(10, 30);
        calc.Subtrair(10, 30);
        calc.Potencia(4, 5);
        calc.Seno(30);
        calc.Coseno(30);
        calc.Tangente(30);
        calc.RaizQuadrada(30);


        var tabuada = new LacoRepeticao();
        tabuada.Incremento();

        var AcerteONumero = new LacoRepeticao();
        tabuada.AcerteNumero();

        var SomadorNumeros = new LacoRepeticao();
        SomadorNumeros.SomarNumero();

        var ClienteAcesso = new LacoRepeticao();
        ClienteAcesso.Cliente();

        var arrayIndice = new Arrays();
        arrayIndice.ArrayUsos();

        var listaString = new Lista();
        listaString.Listas();
    }
}

