namespace Umfg.Exercicio02.ProgIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor em doleres: ");
            string valor = Console.ReadLine();

            if (decimal.TryParse(valor, out decimal valorConvertido))
            {
                Console.WriteLine("Valor convertido: " + valorConvertido * 5.22m + " R$");
                return;
            }
            Console.WriteLine("Apenas Numeros...");
        }
    }
}