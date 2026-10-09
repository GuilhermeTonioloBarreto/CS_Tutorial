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
        * É possível realizar operações lógicas entre variáveis
        * ! = NOT lógico (utilizado para variáveis do tipo bool)
        * & = AND lógico (utilizado para variáveis do tipo bool ou inteiro)
        * | = OR lógico (utilizado para variáveis do tipo bool ou inteiro)
        * ^ = XOR lógico (utilizado para variáveis do tipo bool ou inteiro)
        */

        bool bool1 = false;
        bool bool2 = !bool1;
        Console.WriteLine("Operação lógica NOT na variável {0}: {1}", bool1, bool2);
        Console.WriteLine();

        int inteiro1 = 54;
        int inteiro2 = 101;

        // inteiro1 = 54 (decimal)  = 0011 0110 (binario)
        // inteiro2 = 101 (decimal) = 0110 0101 (binario)
        // inteiro1 & inteiro2      = 0010 0100 (binario) = 36 (decimal) 
        int resultadoAnd = inteiro1 & inteiro2;
        Console.WriteLine("Operação lógica AND entre {0} e {1}: {2}", 
            inteiro1, inteiro2, resultadoAnd);
        Console.WriteLine();

        // inteiro1 = 54 (decimal)  = 0011 0110 (binario)
        // inteiro2 = 101 (decimal) = 0110 0101 (binario)
        // inteiro1 | inteiro2      = 0111 0111 (binario) = 119 (decimal) 
        int resultadoOr = inteiro1 | inteiro2;
        Console.WriteLine("Operação lógica OR entre {0} e {1}: {2}", 
            inteiro1, inteiro2, resultadoOr);
        Console.WriteLine();

        // inteiro1 = 54 (decimal)  = 0011 0110 (binario)
        // inteiro2 = 101 (decimal) = 0110 0101 (binario)
        // inteiro1 | inteiro2      = 0101 0011 (binario) = 83 (decimal) 
        int resultadoXor = inteiro1 ^ inteiro2;
        Console.WriteLine("Operação lógica XOR entre {0} e {1}: {2}", 
            inteiro1, inteiro2, resultadoXor);
        Console.WriteLine();
    }

    public static void variaveis12(){
        /*
        * Variaveis do tipo int podem ser convertidas para o tipo double 
        * de forma implícita ou explicita, sem perda de dados
        */

        Console.WriteLine("Conversão de valores do tipo int para double:");

        int idadeInt = 32;
        Console.WriteLine("Idade (Int): {0}", idadeInt);
        
        // Conversão implícita
        double idadeDouble1 = idadeInt;
        Console.WriteLine("Idade (double - conversão implícita): {0}", idadeDouble1);
        
        // Conversão explicita
        double idadeDouble2 = (double) idadeInt;
        Console.WriteLine("Idade (double - conversão explícita): {0}", idadeDouble2);
        Console.WriteLine();

        /*
        * Variaveis do tipo double só podem ser convertidas para o tipo int explicitamente, 
        * com perda de dados. Os valores depois da vírgula são então truncados
        */

        Console.WriteLine("Conversão de valores do tipo double para int:");

        double salarioDouble = 1403.76;
        Console.WriteLine("Salario (double): {0}", salarioDouble);

        // Conversão explicita
        int salarioInt = (int) salarioDouble;
        Console.WriteLine("Salario (int - conversão explícita): {0}", salarioInt);
        Console.WriteLine();

        /*
        * Para converter variáveis numéricas (int e double) para o tipo string, 
        utiliza-se o método ToString()
        */

        Console.WriteLine("Conversão de valores do tipo int e double para o tipo string:");

        string nome = "Toniolo";
        int idade = 31;
        double salario = 1600.78;

        string apresentacao =
            "meu nome é " + nome + ", " +
            "tenho " + idade.ToString() + "anos e " +
            "meu salaário é igual a " + salario.ToString() + " reais";
        Console.WriteLine(apresentacao);
        Console.WriteLine();

        /*
        * Para converter variáveis do tipo string para o tipo numérico, 
        * utiliza-se o método Parse()
        */

        Console.WriteLine("Conversão de valores do tipo string para os tipos int e double:");

        string idadeString = "31";
        string salarioString = "1600,78";

        idadeInt = int.Parse(idadeString);
        Console.WriteLine(idadeInt);

        salarioDouble = double.Parse(salarioString);
        Console.WriteLine(salarioDouble);
        
        






        
    }
}