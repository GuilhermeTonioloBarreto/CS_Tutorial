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
        * Outra forma de juntar estes textos é utilizando a interpolação de strings
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
}