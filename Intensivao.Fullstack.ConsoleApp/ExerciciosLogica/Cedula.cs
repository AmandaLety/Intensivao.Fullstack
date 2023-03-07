public class Cedula
{
    public static void CaixaEletronico()
    {
        {
            Console.WriteLine("Digite o valor que deseja sacar");

            int[] notas = new int[7] { 100, 50, 20, 10, 5, 2, 1 };
            int valor = int.Parse(Console.ReadLine());


            Console.WriteLine(valor);

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine(valor / notas[i] + "nota(s) de R$ " + notas[i] + ",00");
                valor = (valor % notas[i]);
            }

            Console.ReadKey();
        }
    }
}