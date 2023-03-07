public class Exercicio3
{
    public static void Media()
    {
        Console.WriteLine("3° Realize um cálculo de média final entre quatro notas e informe se ele está na média, abaixo ou acima, considerando que \r\n  abaixo (menor que 4 pontos), na média (entre 4 e menor que 7 pontos) e acima (maior ou igual que 7 pontos).");
        Console.WriteLine();

        Console.WriteLine("Digite a sua primeira nota");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua segunda nota");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua terceira nota");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua quarta nota");
        double nota4 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine("Aperte ENTER para saber a sua média");
        Console.Clear();
        Console.WriteLine($"A sua média é: {media}");

        if (media < 4)
            Console.WriteLine("Você está abaixo da média!");
        else if (media >= 4 && media < 7)
            Console.WriteLine("Você está na média!");
        else
            Console.WriteLine("Você está a cima da média!");
    }
}
