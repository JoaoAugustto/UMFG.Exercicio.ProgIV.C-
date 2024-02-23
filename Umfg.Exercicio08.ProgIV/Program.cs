namespace Umfg.Exercicio08.ProgIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua data de nascimento: ");
            string dataNascimento = Console.ReadLine();

            if (!DateTime.TryParse(dataNascimento, out DateTime dataNascimentoC))
                return;

            var idade = DateTime.Now.Year - dataNascimentoC.Year;

            if (dataNascimentoC > DateTime.Now.AddYears(-idade))
                idade--;


            switch (idade)
            {
                case < 20:
                    Console.WriteLine("Nome: " + nome + ". Idade: " + idade + " Jovem");
                    break;
                case > 60:
                    Console.WriteLine("Nome: " + nome + ". Idade: " + idade + " Idoso");
                    break;
                default:
                    Console.WriteLine("Nome: " + nome + ". Idade: " + idade + " Adulto");
                    break;
            }
        }
    }
}