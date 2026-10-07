class ExibicaoDeTexto{
    public static void exibicaoDeTexto1(){
        /*
        * É possível exibir mensagens no terminal CLI utilizando o método Console.WriteLine()
        */

        Console.WriteLine("Bom Dia");
        Console.WriteLine("Tudo bem com você?");
    }

    public static void exibicaoDeTexto2(){
        /*
        * Toda vez que o método Console.WriteLine() é utilizado, uma quebra de linha é 
        * realizada. Caso deseje que não ocorra esta quebra de linha, 
        * utilize o método Console.Write()
        */

        Console.Write("Bom Dia");
        Console.Write("Tudo bem com você?");
    }
}