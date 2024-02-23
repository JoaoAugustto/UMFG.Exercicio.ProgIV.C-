namespace Umfg.Exercicio10.ProgIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlunoService service = new AlunoService();
            uint opcao = 0;

            while (opcao != 5)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Lancar notas");
                Console.WriteLine("3 - Lancar faltas");
                Console.WriteLine("4 - Listagem de alunos");
                Console.WriteLine("5 - Sair");

                if (!uint.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opcao Invalida");
                    return;
                }

                switch (opcao)
                {
                    case 1:
                        service.CadastrarAluno();
                        break;
                    case 2:
                        service.LancarNotas();
                        break;
                    case 3:
                        service.LancarFaltas();
                        break;
                    case 4:
                        service.ListarAlunos();
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        return;
                        break;
                }


            }

        }
    }
}