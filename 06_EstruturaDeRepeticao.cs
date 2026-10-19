class EstruturaDeRepeticao
{
    public static void estruturaDeRepeticao1()
    {
        /*
        * Estrutura de repetição utilizando While
        */

        int contador = 0;

        Console.WriteLine("Início da estrutura de repetição while");
        while(contador <= 10)
        {
            Console.WriteLine("Número da repetição: {0}", contador.ToString());
            contador++;
        }
        Console.WriteLine("Fim");
    }

    public static void estruturaDeRepeticao2()
    {
        /*
        * Estrutura de repetição utilizando do While
        */

        int contador = 0;

        Console.WriteLine("Início da estrutura de repetição do while");
        do {
            Console.WriteLine("Número da repetição: {0}", contador.ToString());
            contador++;
        } while(contador <= 10);
    
        Console.WriteLine("Fim");
    }

    public static void estruturaDeRepeticao3()
    {
        /*
        * Estrutura de repetição utilizando laço for
        */

        Console.WriteLine("Início da estrutura de repetição for");
        for(int contador = 0; contador <= 10; contador++){
            Console.WriteLine("Número da repetição: {0}", contador.ToString());
        }
        Console.WriteLine("Fim");
    }

    public static void estruturaDeRepeticao4()
    {
        /*
        * Estrutura de repetição utilizando o laço for 
        * e a instrução de controle de fluxo continue
        * esta instrução interrompe o fluxo no momento que ele é chamado e vai para a próxima iteração
        * esta instrução interrompe o fluxo no momento que ele é chamado e sai do laço for
        * no código abaixo, se o número do contador for igual a 4, a instrução de controle de fluxo continue é chamada

        */

        Console.WriteLine("Início da estrutura de repetição For");
        for(int i = 0; i <= 10; i++){
            if(i == 4){
                continue;
            }
            Console.WriteLine("Número do contador: {0}",i.ToString());
        }
        Console.WriteLine("Fim");
    }

    public static void estruturaDeRepeticao5()
    {
        /*
        * Estrutura de repetição utilizando o laço for 
        * e a instrução de controle de fluxo break
        * esta instrução interrompe o fluxo no momento que ele é chamado e sai do laço for
        */

        Console.WriteLine("Início da estrutura de repetição For");
        for(int i = 0; i <= 10; i++){
            if(i == 4){
                break;
            }
            Console.WriteLine("Número do contador: {0}",i.ToString());
        }
        Console.WriteLine("Fim");
    }
}