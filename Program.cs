
    string opUsuario = ObterOpcaoUsuario();

    while (opUsuario.toUpper() != "X")
    {
        switch(opUsuario)
        {
            case "1":
                // Adicionar aluno
                break;

            case "2":
                // Listar alunos
                break;

            case "3":
                //Calcular media geral
                break;
            
            default:
                throw new ArgumentOutOfRangeException();
        }

       opUsuario = ObterOpcaoUsuario();
    }

    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine("Informe a opção desejada: ");
        Console.WriteLine("1 - Inserir novo aluno");
        Console.WriteLine("2 - Listar alunos");
        Console.WriteLine("3 - Calcular média geral");
        Console.WriteLine("X - Sair");
        Console.WriteLine();

        string opUsuario = Console.ReadLine();

        return opUsuario;
    }