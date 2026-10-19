class Calculadora2
{
    public static void calculadora2()
    /*
    * programa que realiza calculadora de potência e calculadora de juros compostos
    * se selecionar o numero 1 no terminal, o modo de calculadora de potência é ativado
    * se selecioanr o número 2 no terminal, o modo de calculadora de juros compostos é ativado
    */

    {
        // texto selecionando qual tipo de calculadora selecionar
        Console.Write("Digite o número 1 para calculadora de potência e 2 para calculadora de juros: ");
        int selecao = int.Parse(Console.ReadLine());

        switch (selecao)
        {
            // calculadora de potência
            case 1:
                Console.WriteLine("Calculadora de potência selecionada: ");

                Console.Write("Digite a base: ");
                double base1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o expoente - deve ser um número inteiro: ");
                int expoente1 = int.Parse(Console.ReadLine());

                double resultado = 1;
                for(int i = 0; i < expoente1; i++){
                    resultado *= base1;
                }

                Console.WriteLine("O resultado é {0}", resultado);
                break;

            // calculadora de juros compostos
            case 2:
                Console.WriteLine("Calculadora de juros selecionada: ");

                Console.Write("Digite o investimento inicial: ");
                double base2 = double.Parse(Console.ReadLine());

                Console.Write("Digite a porcentagem de juros: ");
                double porcentagem1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o período em anos: ");
                int periodo1 = int.Parse(Console.ReadLine());

                double porcentagem2 = 1 + (porcentagem1/100);

                double porcentagem3 = 1;
                for(int i = 0; i < periodo1; i++){
                    porcentagem3 *= porcentagem2;
                }

                resultado = base2*porcentagem3;

                Console.WriteLine("O resultado é {0}", resultado);
                break;
            
            // nenhuma calculadora selecionada
            default:
                Console.WriteLine("Nenhuma opção válida selecionada");
                break;
        }
    }
}