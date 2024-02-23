namespace Umfg.Exercicio05.ProgIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Informa a operacao desejada");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");
            Console.WriteLine("5 - Resto da Divisao");

            string opcao = Console.ReadLine();


            Console.WriteLine("Informe o primeiro numero desejado");
            if (!float.TryParse(Console.ReadLine(), out float numeroUm))
                return;

            Console.WriteLine("Informe o segundo numero desejado");
            if (!float.TryParse(Console.ReadLine(), out float numeroDois))
                return;

            switch (opcao)
            {
                case "1":
                    Console.WriteLine(numeroUm + numeroDois);
                    break;
                case "2":
                    Console.WriteLine(numeroUm - numeroDois);
                    break;
                case "3":
                    Console.WriteLine(numeroUm * numeroDois);
                    break;
                case "4":
                    if (numeroDois <= 0)
                        return;

                    Console.WriteLine(numeroUm / numeroDois);
                    break;
                case "5":
                    if (numeroDois <= 0)
                        return;

                    Console.WriteLine(numeroUm % numeroDois);
                    break;
                default:
                    Console.WriteLine("Opcao Invalida");
                    break;

            }
        }
    }
}