using Projeto_Prático;

string opcaoUsuario = ObterOpcaoUsuario();

SerieRepositorio repositorio = new SerieRepositorio();


//Opções escolhidas pelo Usuário
while (opcaoUsuario.ToUpper() != "X")
{
    switch (opcaoUsuario)
    {
        case "1":
            ListarSeries();
            break;

        case "2":
            InserirSerie();
            break;
        case "3":
            AtualizarSerie();
            break;
        case "4":
            ExcluirSerie();
            break;
        case "5":
            VisualizarSerieID();
            break;
        case "c":
            Console.Clear();
            break;
        default:
            throw new ArgumentOutOfRangeException();

    }

    opcaoUsuario = ObterOpcaoUsuario();
}



Console.WriteLine("Obrigado por utilizar nossos Serviços!");
Console.WriteLine("Pressione qualquer botão para sair");
Console.ReadLine();


//Métodos
void ListarSeries()
{
    Console.WriteLine("Listar Séries");
    var lista = repositorio.Lista();

    if (lista.Count == 0)
    {
        Console.WriteLine("Nenhuma série cadastrada.");
        Console.WriteLine();
        return;


    }

    foreach (var serie in lista)
    {
        var excluido = serie.retornaExcluido();
        
         Console.WriteLine("#ID {0}: - Título: {1} - Gênero: {2} - Ano: {3} - Temporadas: {4} {5} ", serie.retornaId(), serie.retornaTitulo(), serie.retornaGenero(), serie.retornaAno(), serie.retornaTemporadas(), (excluido ? "*SÉRIE EXCLUÍDA*" : ""));
       
     
       

    }
}

void InserirSerie()
{
    Console.WriteLine("Inserir nova Série");
    Console.WriteLine();
    Console.WriteLine("Gêneros: ");
    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
    }
    Console.Write("Digite o gênero entre as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o Título da Série: ");
    string entrataTitulo = Console.ReadLine();

    Console.Write("Digite o Ano de lançamento da Série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a Descrição da Série: ");
    string entradaDescricao = Console.ReadLine();

    Console.WriteLine("Digite a Classificação Indicativa da Série: ");
    int entradaClassificacaoIndicativa = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o número de Temporadas: ");
    int entradaTemporadas = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite os nomes do elenco principal da Série: ");
    string entradaElenco = Console.ReadLine();

    Console.WriteLine("Digite o nome do Diretor(a) ou Diretores(as) da Série: ");
    string entradaDiretor = Console.ReadLine();

    Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                    Genero: (Genero)entradaGenero,
                                    Titulo: entrataTitulo,
                                    Ano: entradaAno,
                                    Descricao: entradaDescricao,
                                    ClassificacaoIndicativa: entradaClassificacaoIndicativa,
                                    Temporadas: entradaTemporadas,
                                    Elenco: entradaElenco,
                                    Diretor: entradaDiretor);
                repositorio.Insere(novaSerie);

            return;
}

void AtualizarSerie()
{
    Console.WriteLine("Digite o ID da Série: ");
    int indiceSerie = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Gêneros:");
    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    }
    Console.WriteLine("Digite o Gênero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o Título da Série: ");
    string entrataTitulo = Console.ReadLine();

    Console.Write("Digite o Ano de lançamento da Série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a Descrição da Série: ");
    string entradaDescricao = Console.ReadLine();

    Console.WriteLine("Digite a Classificação Indicativa da Série: ");
    int entradaClassificacaoIndicativa = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o número de Temporadas: ");
    int entradaTemporadas = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite os nomes do elenco principal da Série: ");
    string entradaElenco = Console.ReadLine();

    Console.WriteLine("Digite o nome do Diretor(a) ou Diretores(as) da Série: ");
    string entradaDiretor = Console.ReadLine();

    Serie atualizaSerie = new Serie(id: indiceSerie,
                                    Genero: (Genero)entradaGenero,
                                    Titulo: entrataTitulo,
                                    Ano: entradaAno,
                                    Descricao: entradaDescricao,
                                    ClassificacaoIndicativa: entradaClassificacaoIndicativa,
                                    Temporadas: entradaTemporadas,
                                    Elenco: entradaElenco,
                                    Diretor: entradaDiretor);
    repositorio.Atualiza(indiceSerie, atualizaSerie);

}

void ExcluirSerie()
{
    
    Console.WriteLine("Digite o ID da Série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    Console.WriteLine("Você tem certeza que deseja excluir essa série? (S/N)");
    string Confirmacao = Console.ReadLine();
    while(Confirmacao.ToUpper() != "N")
    {
        repositorio.Exclui(indiceSerie);
        return;
    }
    return;
    
}

void VisualizarSerieID()
{
    Console.Write("Digite o ID da Série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    var serie = repositorio.RetornaId(indiceSerie);

    Console.WriteLine(serie);
}


//Menu
static string ObterOpcaoUsuario()
{
    Console.WriteLine("_____________________________________");
    Console.WriteLine("Por favor, Informe a opção desejada: ");
    Console.WriteLine("1- Listar Séries");
    Console.WriteLine("2- Inserir nova Série");
    Console.WriteLine("3- Atualizar Série");
    Console.WriteLine("4- Excluir Série");
    Console.WriteLine("5- Informações sobre a Série por ID");
    Console.WriteLine("C - Limpar Console");
    Console.WriteLine("X- Sair");
    Console.WriteLine("_____________________________________");

    string opcaoUsuario = Console.ReadLine();
    Console.WriteLine();
    return opcaoUsuario;
}