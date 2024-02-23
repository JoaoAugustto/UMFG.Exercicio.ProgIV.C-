using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Exercicio10.ProgIV
{
    public class AlunoService
    {
        private readonly Dictionary<string, Aluno> _hashMap = new Dictionary<string, Aluno>();
        public void CadastrarAluno()
        {
            Console.WriteLine("Insira o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o RA do aluno: ");
            string ra = Console.ReadLine();

            Aluno aluno = new Aluno(nome, ra);

            _hashMap.Add(aluno.Nome, aluno);

        }
        public void LancarNotas()
        {
            Console.WriteLine("Insira o nome do aluno: ");
            string nome = Console.ReadLine();

            if (!_hashMap.ContainsKey(nome))
            {
                Console.WriteLine("Aluno nao encontrado");
                return;
            }

            Aluno aluno = _hashMap[nome];

            Console.WriteLine("Insira a nota da prova do aluno");
            if (!float.TryParse(Console.ReadLine(), out float notaProva))
            {
                Console.WriteLine("Nota invalida");
                return;
            }

            Console.WriteLine("Insira a nota do trabalho do aluno");
            if (!float.TryParse(Console.ReadLine(), out float notaTrabalho))
            {
                Console.WriteLine("Nota invalida");
                return;
            }

            if (notaProva > 10 || notaTrabalho > 10 || notaProva < 0 || notaTrabalho < 0)
            {
                Console.WriteLine("Notas Invalidas");
                return;
            }

            aluno.NotaProva = notaProva;
            aluno.NotaTrabalho = notaTrabalho;

            _hashMap[nome] = aluno;

        }

        public void LancarFaltas()
        {
            Console.WriteLine("Insira o nome do aluno: ");
            string nome = Console.ReadLine();

            if (!_hashMap.ContainsKey(nome))
            {
                Console.WriteLine("Aluno nao encontrado");
                return;
            }

            Aluno aluno = _hashMap[nome];

            Console.WriteLine("Insira a quantidade de faltas do aluno");
            if (!uint.TryParse(Console.ReadLine(), out uint faltas))
            {
                Console.WriteLine("Faltas invalidas");
                return;
            }

            aluno.Faltas = faltas;

            _hashMap[nome] = aluno;

        }

        public void ListarAlunos()
        {
            string situacao;
            foreach (Aluno aluno in _hashMap.Values)
            {
                double media = CalcularMedia(aluno.NotaProva, aluno.NotaTrabalho);
                double percentualFrequencia = CalcularPercentualFrequencia(aluno.Faltas);

                if (media >= 7 && percentualFrequencia >= 75)
                {
                    situacao = "APROVADO";
                }
                else
                {
                    situacao = "REPROVADO";
                }

                Console.WriteLine($"{aluno.Nome} - Nota Prova: {aluno.NotaProva}, Nota Trabalho: {aluno.NotaTrabalho}, Média: {CalcularMedia(aluno.NotaProva, aluno.NotaTrabalho):F2}, " + "\n" +
               $"Faltas: {aluno.Faltas}, Percentual de Frequência: {CalcularPercentualFrequencia(aluno.Faltas):F2}%, Situação: {situacao}" + "\n");
            }

        }

        public float CalcularMedia(float notaProva, float notaTrabalho)
        {
            return (notaProva * 7 + notaTrabalho * 3) / 10;
        }

        public float CalcularPercentualFrequencia(float faltas)
        {
            return (25 - faltas) / 25.0f * 100.0f;
        }

    }
}
