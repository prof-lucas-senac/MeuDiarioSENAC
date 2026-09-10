RegistroDAO dao = new RegistroDAO();

int opcao;

do
{
    Console.Clear();

    Console.WriteLine("===================================");
    Console.WriteLine("      MEU DIÁRIO SENAC");
    Console.WriteLine("===================================");
    Console.WriteLine("1 - Novo Registro");
    Console.WriteLine("2 - Listar Registros");
    Console.WriteLine("3 - Buscar por ID");
    Console.WriteLine("0 - Sair");
    Console.WriteLine();

    Console.Write("Escolha uma opção: ");

    opcao = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    switch (opcao)
    {
        case 1:

            Registro registro = new Registro();

            Console.Write("Título: ");
            registro.Titulo = Console.ReadLine();

            Console.Write("Conteúdo: ");
            registro.Conteudo = Console.ReadLine();

            registro.DataRegistro = DateTime.Now;
            registro.UsuarioId = 1; // ID do usuário logado (exemplo)   

            RegistroService registroService = new RegistroService();
            registroService.AdicionarRegistro(registro);

            Console.WriteLine();
            Console.WriteLine("Registro salvo com sucesso!");

            break;

        case 2:

            List<Registro> lista = dao.ListarTodos();

            foreach (var r in lista)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"ID: {r.Id}");
                Console.WriteLine($"Título: {r.Titulo}");
                Console.WriteLine($"Data: {r.DataRegistro:dd/MM/yyyy}");
                Console.WriteLine($"Conteúdo: {r.Conteudo}");
                Console.WriteLine();
            }

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum registro encontrado.");
            }

            break;

        case 3:

            Console.Write("Informe o ID: ");

            int id = Convert.ToInt32(Console.ReadLine());

            Registro? encontrado = dao.BuscarPorId(id);

            Console.WriteLine();

            if (encontrado != null)
            {
                Console.WriteLine($"ID: {encontrado.Id}");
                Console.WriteLine($"Título: {encontrado.Titulo}");
                Console.WriteLine($"Data: {encontrado.DataRegistro:dd/MM/yyyy}");
                Console.WriteLine($"Conteúdo:");
                Console.WriteLine(encontrado.Conteudo);
            }
            else
            {
                Console.WriteLine("Registro não encontrado.");
            }

            break;

        case 0:

            Console.WriteLine("Encerrando o sistema...");
            break;

        default:

            Console.WriteLine("Opção inválida.");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

} while (opcao != 0);