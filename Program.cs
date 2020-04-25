using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opçãoUsuario = ObterOpçaoUsuario();

            while (opçãoUsuario.ToUpper() != "x")
            {
                switch (opçãoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;
                    case "2":
                        foreach(var a in alunos)
                        if (!string.IsNullOrEmpty(a.Nome))
                        {
                            Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                        }
                        break;
                    case "3":
                        //TODO: calcular media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                 
                opçãoUsuario = ObterOpçaoUsuario();
            }

        }

        private static string ObterOpçaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1-Inserir novo aluno");
            Console.WriteLine("2-Listar alunos");
            Console.WriteLine("3-Calcular média geral");
            Console.WriteLine("x-Sair");
            Console.WriteLine();

            string opçãoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opçãoUsuario;
        }
    }
}

        