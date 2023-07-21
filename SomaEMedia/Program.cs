
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantidade de números entre 3 e 10:");
        int quantidade = LerQuantidade();

        List<double> numeros = LerNumeros(quantidade);

        double soma = CalcularSoma(numeros);
        double media = CalcularMedia(numeros);

        Console.WriteLine("Soma:" + soma);
        Console.WriteLine("Média:" + media);

        Console.ReadLine();
    }

    static int LerQuantidade()
    {
        int quantidade;
        do
        {
            if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade >= 3 && quantidade <= 10)
            {
                return quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade inválida. Digite novamente:");
            }
        } while (true);
    }

    static List<double> LerNumeros(int quantidade)
    {
        List<double> numeros = new List<double>();

        for (int i = 1; i <= quantidade; i++)
        {
            double numero;
            do
            {
                Console.WriteLine($"Digite o número {i}:");
            } while (!double.TryParse(Console.ReadLine(), out numero));

            numeros.Add(numero);
        }

        return numeros;
    }

    static double CalcularSoma(List<double> numeros)
    {
        double soma = 0;

        foreach (double numero in numeros)
        {
            soma += numero;
        }

        return soma;
    }

    static double CalcularMedia(List<double> numeros)
    {
        double soma = CalcularSoma(numeros);
        double media = soma / numeros.Count;

        return media;
    }
}
