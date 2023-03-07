public class Exercicio2
{
    public static void Salario()
    {
        Console.WriteLine("2° Elabore um algoritmo que recebe o salário mensal atual de um funcionário e um percentual de reajuste e exiba o novo salário.");
        Console.WriteLine();

        double salario;
        double salarioAumento;

        Console.WriteLine("Digite o seu salário:");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Você irá receber um aumento de 10%");
        Console.WriteLine("Aperte ENTER para ver o seu novo salário");
        Console.Read();
        Console.Clear();

        salarioAumento = salario + (salario * 0.10);

        Console.WriteLine($"Seu novo salário é de: {salarioAumento}");
        Console.Read();
        Console.WriteLine("Digite ENTER para encerrar.");
    }
}
