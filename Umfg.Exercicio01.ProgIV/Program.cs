namespace Umfg.Exercicio01.ProgIV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o valor em reais: ");
            string valor = Console.ReadLine();

            if (decimal.TryParse(valor, out decimal valorConvertido))
            {
                Console.WriteLine("Valor convertido: " + valorConvertido * 0.193259m + " $");
                return;
            }
            Console.WriteLine("Apenas Numeros...");
        }
    }
}