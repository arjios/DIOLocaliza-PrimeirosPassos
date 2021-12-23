using System;

namespace Revisao
{
    class program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indexAluno = 0;

            string opcaoUsuario = menuUsuario();

            while (opcaoUsuario != "S")
            {
                Console.WriteLine(" ");
                switch (opcaoUsuario)
                {
                    case "1":

                        var aluno = new Aluno();

                        Console.WriteLine(" ");
                        Console.WriteLine("Informe o nome do aluno: ");
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine(" ");
                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                            alunos[indexAluno] = aluno;
                            indexAluno++;
                            Console.WriteLine(" ");
                            Console.WriteLine("Usuario inserido com sucessso!");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            throw new ArgumentException("Nota invalida");
                        }
                        break;

                    case "2":
                        Console.WriteLine("+---------------------------------------------+");
                        foreach (var item in alunos)
                        {
                            if (item.Nome != null)
                            {
                                Console.WriteLine($"| Nome: {item.Nome} - Nota: {item.Nota}");
                            }
                        }
                        Console.WriteLine("+---------------------------------------------+");
                        Console.WriteLine(" ");
                        break;

                    case "3":
                        decimal m = 0;
                        decimal i = 0;
                        foreach (var item in alunos)
                        {
                            if (item.Nome != null)
                            {
                                m += item.Nota;
                                i++;
                            }
                        }
                        Console.WriteLine($"Média geral: {m/i}");
                        Console.WriteLine(" ");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = menuUsuario();
            }
        }

        private static string menuUsuario()
        {
            Console.WriteLine("Informe a opção a desejada");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("S - Sair da aplicação");
            return Console.ReadLine().ToUpper();
        }
    }
}



