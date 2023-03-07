public class Exercicio5
{
    public static void NomesIguais()
    {
        Console.WriteLine("5° Verifique se duas strings são iguais, independente da caixa das letras. Por exemplo, este programa deve dizer que 'Teste' é igual a 'TeStE', mas isso \r\n  deve equivaler pra outros valores de entradas.");
        Console.WriteLine();

        {
            Console.WriteLine("Digite uma palavra");
            string string1 = Console.ReadLine();
            Console.WriteLine("Digite outra palavra");
            string string2 = Console.ReadLine();

            if (string1.Equals(string2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("As strings são iguais.");
            }
            else
            {
                Console.WriteLine("As strings são diferentes.");
            }
        }
    }
}
