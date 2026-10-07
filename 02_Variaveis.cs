class Variaveis{
    
    public static void variaveis1(){
        /*
        * A tabela abaixo mostra as variáveis mais utilizadas em C#:
        *
        * bool: Valor binário.
        * Exemplos: true / false
        *
        * int: Número inteiro de 32 bits, podendo representar valores 
        * entre -2.147.483.648 e 2.147.483.647.
        * Exemplo: -1002
        *
        * uint: Número inteiro de 32 bits sem valores negativos, podendo
        * representar valores entre 0 e 4.294.967.295.
        * Exemplo: 3001
        *
        * double: Número de ponto flutuante de 64 bits.
        * Exemplo: 4.32
        *
        * char: Representa um único caractere.
        * Exemplo: 'F'
        *
        * string: Representa um conjunto de caracteres.
        * Exemplo: "automacao"
        */

        bool maiorDeIdade;
        uint idade;
        string nomePessoa;
    }

    public static void variaveis2(){
        /*
        * A atribuição de variáveis é feita utilizando o operador =
        */

        bool maiorDeIdade = true;
        uint idade = 31;
        string nomePessoa = "Toniolo";

    }

    public static void variaveis3(){
        /*
        * É possível exibir variáveis utilizando o método Console.WriteLine()
        */

        bool maiorDeIdade = true;
        uint idade = 31;
        string nomePessoa = "Toniolo";

        Console.WriteLine(maiorDeIdade);
        Console.WriteLine(idade);
        Console.WriteLine(nomePessoa);
    }

    public static void variaveis4(){
        /*
        * É possível juntar textos com valores de variáveis utilizando concatenação de strings
        */

        uint idade = 31;
        string nomePessoa = "Toniolo";

        Console.WriteLine("Meu nome é " + nomePessoa + " e tenho " + idade + " anos");
    }

    public static void variaveis5(){
        /*
        * Uma segunda forma de juntar estes textos é utilizando a interpolação de strings
        */

        uint idade = 31;
        string nomePessoa = "Toniolo";

        Console.WriteLine($"Meu nome é {nomePessoa} e tenho {idade} anos");
    }

    public static void variaveis6(){
        /*
        * Uma terceira forma de juntar estes texto é utilizando a formatação composta
        */

        uint idade = 31;
        string nomePessoa = "Toniolo";

        Console.WriteLine("Meu nome é {0} e tenho {1} anos", nomePessoa, idade);
    }

    public static void variaveis7(){
        /*
        * A vantagem da formatação composta é que é possível editar quantos números 
        * antes e depois da vírgula serão exibidos
        */

        uint idade = 31;
        string nomePessoa = "Toniolo";
        double pi = 3.14159265359;
        Console.WriteLine("Meu nome é {0} e tenho {1:000} anos", nomePessoa, idade);
        Console.WriteLine("O número PI é igual a {0:00.000}", pi);
    }

    public static void variaveis8(){
        /*
        * É possível realizar operações aritméticas entre variáveis
        */
        int a = 5;
        int b = 10;

        int soma = a + b;
        Console.WriteLine("Soma: {0}", soma);

        int subtracao = a - b;
        Console.WriteLine("Subtração: {0}", subtracao);

        int multiplicacao = a * b;
        Console.WriteLine("Multiplicação: {0}", multiplicacao);

        int divisao = a / b;
        Console.WriteLine("Divisão: {0}", divisao);

        int moduloDivisao = a % b;
        Console.WriteLine("Módulo da divisão: {0}", moduloDivisao);
    }

    public static void variaveis9(){
        /*
        * Quando se deseja realizar uma operação aritmética entre seu próprio valor, 
        * é possível utilizar operadores de atribuição composta
        */

        int numero = 15;
        Console.WriteLine("Número inicial: {0}", numero);

        numero += 5;
        Console.WriteLine("O número foi somado por 5. Agora ele é igual a {0}", numero);

        numero -= 4;
        Console.WriteLine("O número foi subtraído por 4. Agora ele é igual a {0}", numero);

        numero *= 3;
        Console.WriteLine("O número foi multiplicado por 3. Agora ele é igual a {0}", numero);

        numero /= 2;
        Console.WriteLine("O número foi dividido por 2. Agora ele é igual a {0}", numero);
    }

    public static void variaveis10(){
        /*
        * Quando se deseja apenas incrementar uma unidade no valor da sua variável, 
        * é possível utilizar operadores de incremento.
        */

        int numero = 15;
        Console.WriteLine("Número inicial: {0}", numero);

        numero++;
        Console.WriteLine("O número foi incrementado uma unidade. Agora ele é igual a {0}", numero);

        numero--;
        Console.WriteLine("O número foi decrementado uma unidade. Agora ele é igual a {0}", numero);
    }

    public static void variaveis11(){
        /*
        É possível realizar operações lógicas entre variáveis
        ! = NOT lógico (utilizado para variáveis do tipo bool)
        & = AND lógico (utilizado para variáveis do tipo bool ou inteiro)
        | = OR lógico (utilizado para variáveis do tipo bool ou inteiro)
        ^ = XOR lógico (utilizado para variáveis do tipo bool ou inteiro)
        */

        bool bool1 = false;
        Console.WriteLine("Valor da variável original: {0}", bool1);

        bool bool2 = !bool1;
        Console.WriteLine("Valor da variável invertida: {0}", bool2);
    }
}