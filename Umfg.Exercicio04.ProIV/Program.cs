namespace Umfg.Exercicio04.ProIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string anoAtual = DateTime.Now.ToString("yyyy");

            Console.WriteLine("Informe seu ano de nascimento");
            string anoNascimento = Console.ReadLine();

            if (int.TryParse(anoNascimento, out int anoNascimentoI))
            {
                int.TryParse(anoAtual, out int anoAtualI);
                Console.WriteLine("Sua idade e de: " + (anoAtualI - anoNascimentoI));
                return;
            }
            Console.WriteLine("Ano de nascimento invalido");
        }
    }
}