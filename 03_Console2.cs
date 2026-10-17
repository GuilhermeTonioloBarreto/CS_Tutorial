class Console2
{
    public static void console1(){
        /* 
        * Para que o usuário digite apenas um caractere do teclado no CLI,
        * utiliza-se o método Console.Read()
        * Perceba que o valor digitado no teclado será atribuído a uma variável int,
        * mesmo que seja uma letra do alfabeto. A razão para isso é que este método 
        * armazena o código numérico ASCII daquela tecla do teclado
        * Por exemplo, ao digitar a letra A, o valor lido pelo programa será 65
        * Caso sejam digitados mais de um caractere antes de pressionar o enter, 
        * o Console.Read() considerará apenas o primeiro caractere digitado
        */

        Console.WriteLine("Digite um caractere do teclado:");
        int teclaTeclado = Console.Read();
        Console.WriteLine("A tecla digitada foi {0} em código ASCII", teclaTeclado);
    }
    
    public static void console2(){
        /*
        * Para que o usuário possa digitar vários caracteres no CLI, 
        * utiliza-se o método Console.ReadLine()
        * Deve-se utilizar variáveis do tipo string para retornar o valor deste método
        */

        Console.Write("Digite um nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("O nome digitado foi {0}", nome);
    }

    public static void console3(){
        /*
        * Para capturar a tecla digitada pelo usuário no CLI,
        * utiliza-se o método Console.ReadKey();
        */
        
        Console.Write("Digite uma tecla: ");
        ConsoleKeyInfo myKey = Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Código ASCII do caractere digitado: {0}", (int) myKey.KeyChar);
        Console.WriteLine("Tecla Digitada: {0}", myKey.Key);
    }

    public static void console4(){
        /*
        * Altera o título do console CLI
        * O método Console.Read() só está sendo utilizado para manter o terminal aberto
        * e ajudar a visualizar o título sendo alterado
        */

        Console.Title = "Novo título do CLI";
        Console.Read();
    }

    public static void console5(){
        /*
        * Apaga o conteúdo do terminal
        */

        Console.Clear();
    }

    public static void console6(){
        /*
        * Altera a cor de fundo do terminal CLI
        */

        Console.WriteLine("Texto antes da mudança de cor");
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Texto depois da mudança de cor");
    }

    public static void console7(){
        /*
        * Altera a cor do texto exibida no terminal 
        */

        Console.WriteLine("Texto antes da mudança de cor");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Texto depois da mudança de cor");
    }

    public static void console8(){
        /*
        * Reseta as cores de background e foreground que estava configuradas antes do programa C# ser executado 
        */

        Console.WriteLine("Texto antes da mudança de cor");
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Texto depois da mudança de cor");
        Console.ResetColor();
        Console.WriteLine("Texto com as configurações de cor inicialmente setadas");
    }
}