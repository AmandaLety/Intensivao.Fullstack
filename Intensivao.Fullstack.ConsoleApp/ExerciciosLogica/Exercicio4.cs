public class Exercicio4
{
    public static void Vetor()
    {
        Console.WriteLine("4° Crie um vetor que com os seguintes valores: 2, 5, 15, 56, 22, 3, 9, sabendo disso, ordene os valores de forma sequencial e repita 3x o valor '22'.");
        Console.WriteLine();

        {
            int[] numerosOriginais = { 2, 5, 15, 56, 22, 3, 9 };
            Console.WriteLine("Ordem Original:");
            foreach (int numero in numerosOriginais)
            {
                Console.Write(numero + ", ");
            }
            Console.WriteLine();
            int[] numbers = { 2, 5, 15, 56, 22, 3, 9, 22, 22 };
            Array.Sort(numbers);
            Console.WriteLine("Números ordenados:");
            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }
        }
    }
}
