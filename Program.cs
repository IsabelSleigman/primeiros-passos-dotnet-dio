
using primeiros_passos_dotnet_dio;

Aluno[] alunos = new Aluno[5];
    var indiceAluno = 0;
    string opUsuario = ObterOpcaoUsuario();

    while (opUsuario.toUpper() != "X")
    {
        switch(opUsuario)
        {
            case "1":
                Console.WriteLine("Informe o nome do aluno: ");
                Aluno aluno = new Aluno();
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Informe a nota: ");

                if(double.TryParce(Console.ReadLine(), out double nota))
                {
                    aluno.Nota = nota;
                }
                else 
                {
                    throw new ArgumentOutOfRangeException("Valor da nota deve ser decimal");
                }
                alunos[indiceAluno] = aluno;
                indiceAluno++;
                break;

            case "2":
                foreach(var a in alunos)
                {   if(!string.IsNullOrEmpty(a.Nome))
                        Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                }
                break;

            case "3":
                double notaTotal = 0.0;
                var nrAlunos = 0;
                for(int i = 0; i < alunos.Length; i++)
                {
                    if(!string.IsNullOrEmpty(alunos[i].Nome))
                    {
                        notaTotal = notaTotal + alunos[i].Nota;
                        nrAlunos++;
                    }
                }

                var mediaGeral = notaTotal / nrAlunos;
                ConceitoEnum conceito;

                if(mediaGeral <= 2)
                {
                    conceito = ConceitoEnum.E;
                }
                else if(mediaGeral <= 4)
                {
                    conceito = ConceitoEnum.D;
                }
                else if(mediaGeral <= 5)
                {
                    conceito = ConceitoEnum.C;
                }
                else if(mediaGeral <= 8)
                {
                    conceito = ConceitoEnum.B;
                }
                else
                {
                    conceito = ConceitoEnum.A;
                }

                Console.WriteLine($"Média Geral: {mediaGeral} - Conceito Geral: {conceito}");
                break;
            
            default:
                throw new ArgumentOutOfRangeException("Valor inválido!");
        }

       opUsuario = ObterOpcaoUsuario();
    }

    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("Informe a opção desejada: ");
        Console.WriteLine("1 - Inserir novo aluno");
        Console.WriteLine("2 - Listar alunos");
        Console.WriteLine("3 - Calcular média geral");
        Console.WriteLine("X - Sair");
        Console.WriteLine();

        string opUsuario = Console.ReadLine();

        return opUsuario;
    }