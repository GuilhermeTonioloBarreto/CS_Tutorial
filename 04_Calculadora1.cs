class Calculadora1
{
    public static void calculadora1()
    {
        /*
        * Programa que recebe dois números e retorna as operações algébricas básicas
        */

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Console.Write("Digite o primeiro Número: ");
        string n1 = Console.ReadLine();
        Console.Write("Digite o segundo Número: ");
        string n2 = Console.ReadLine();

        int numero1 = int.Parse(n1);
        int numero2 = int.Parse(n2);
        int soma = numero1 + numero2;
        int subtracao = numero1 - numero2;
        int multiplicacao = numero1 * numero2;
        int divisao = numero1 / numero2;

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("A soma do número {0} e {1} é igual a {2}", numero1.ToString(), numero2.ToString(), soma.ToString());

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("A subtração do número {0} e {1} é igual a {2}",  numero1.ToString(), numero2.ToString(), subtracao.ToString());

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("A multiplicação do número {0} e {1} é igual a {2}", numero1.ToString(), numero2.ToString(), multiplicacao.ToString());

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("A divisão do número {0} e {1} é igual a {2}", numero1.ToString(), numero2.ToString(), divisao.ToString());
    
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }

}