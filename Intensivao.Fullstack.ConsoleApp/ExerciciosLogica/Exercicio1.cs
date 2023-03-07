public class Exercicio1
{
    public static void Calcular()
    {
        Console.WriteLine("1° Crie um vetor com nomes de todos os integrantes do intensivão exiba todos os nomes, \r\n  e também faça com que acrescente os sobrenomes para cada integrante e exiba novamente com os nomes completos.");
        Console.WriteLine();


        string[] integrantes = {

    "Amanda", "Laura", "Luciana", "Sergio", "Mateus", "Ruana", "Victor", "Nicoly", "Junior", "Marlei", "Jean", "Tiago"
};

        for (int i = 0; i < integrantes.Length; i++)
        {
            if (i == integrantes.Length - 1)
            {
                Console.Write(integrantes[i]);
            }
            else
            {
                Console.Write(integrantes[i] + ", ");
            }
        }
        Console.WriteLine();

        string[] sobrenomes =
        {
    "Letícia", "Montenegro", "Isis", "Ono", "Lemos", "Rodrigues", "Pessoa", "Kethylin",
    "Soac", "Silva", "Jesus", "Freitas"
};

        for (int i = 0; i < sobrenomes.Length; i++)
        {
            if (i == sobrenomes.Length - 1)
            {
                Console.Write(integrantes[i] + " " + sobrenomes[i]);
            }
            else
            {
                Console.Write(integrantes[i] + " " + sobrenomes[i] + ", ");
            }
        }
    }
}

