using System.Net;

class EstruturaDeDecisao
{
    public static void estruturaDeDecisao1()
    {
        /*
        * Estrutura de decisão utilizando if, else if e else
        */
        
        Console.Write("Digite uma idade: ");
        int idade = int.Parse(Console.ReadLine());
        
        if(idade < 18){
            Console.WriteLine("Esta pessoa tem menos de 18 anos");
        } else if(idade == 18){
            Console.WriteLine("Esta pessoa tem 18 anos");
        } else {
            Console.WriteLine("Esta pessoa tem mais de 18 anos");
        }
    }

    
    public static void estruturaDeDecisao2()
    {
        /*
        * Estrutura de decisão utilizando switch case
        */

        Console.Write("Digite um número de 1 a 3: ");
        int numero = int.Parse(Console.ReadLine());

        switch (numero){
            case 1:
                Console.WriteLine("O número 1 foi digitado");
                break;
            case 2:
                Console.WriteLine("O número 2 foi digitado");
                break;
            case 3:
                Console.WriteLine("O número 3 foi digitado");
                break;
            default:
                Console.WriteLine("Um numero diferente de 1, 2 ou 3 foi digitado");
                break;
        }
    }
    
}