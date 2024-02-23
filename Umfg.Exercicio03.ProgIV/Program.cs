namespace Umfg.Exercicio03.ProgIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distancia percorrida em quilometros: ");
            string km = Console.ReadLine();
            Console.WriteLine("Informe o seu gasto de combustivel em litros: ");
            string combustivel = Console.ReadLine();

            if (float.TryParse(km, out float kmAndado)
                && float.TryParse(combustivel, out float combustivelGasto))
            {
                Console.WriteLine("Sua media de gasto: " + kmAndado / combustivelGasto);
                return;
            }
            Console.WriteLine("Apenas Numeros...");
        }
    }
}