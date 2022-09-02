using ConversaoDeMoedas;

Moedascs moedas;

List<Moedascs> MoedasList = new List<Moedascs>();

string[] text = System.IO.File.ReadAllLines(@"C:\Users\gorde\Desktop\treinamento pericles\ConversaoDeMoedas\moedas.txt");

foreach (string line in text)
{
    string[] vect = line.Split(' ');
    moedas = new Moedascs(vect[0], double.Parse(vect[1]));
    MoedasList.Add(moedas);
}

Console.WriteLine("Lista de moedas:");

foreach (Moedascs moeda in MoedasList)
{
    Console.WriteLine(moeda);
}

string nomeMoedaEntrada = string.Empty;

double valorMoedaOrigem;

string nomeMoedaDestino = string.Empty;

Console.WriteLine(" A para adicionar uma nova moeda \n B para atualizar uma moeda \n C para deletr uma moeda \n D para uma conversao \n E para mostrar a lista de moedas  \n F Para sair");

char escolha = char.Parse(Console.ReadLine());

while (escolha != 'f' || escolha != 'f')
{

    if (escolha == 'A' || escolha == 'a')
    {
        Console.WriteLine("Qual o nome da moeda? ");
        nomeMoedaEntrada = Console.ReadLine().ToUpper();
        Console.WriteLine("Qual o rate da moeda?");
        valorMoedaOrigem = double.Parse(Console.ReadLine());
        moedas = new Moedascs(nomeMoedaEntrada, valorMoedaOrigem);
        MoedasList.Add((moedas));

        Console.WriteLine("Lista atualizada");

        foreach (Moedascs moeda in MoedasList)
        {
            Console.WriteLine(moeda);
        }

    }
    else if (escolha == 'B' || escolha == 'b')
    {
        Console.WriteLine("Digite o nome da moeda ao qual o rate sera atualizado:");
        nomeMoedaEntrada = Console.ReadLine().ToUpper();
        Console.WriteLine("Qual o rate da moeda?");
        valorMoedaOrigem = double.Parse(Console.ReadLine());
        Moedascs moedaAtualizada = MoedasList.FirstOrDefault(x => x.Currency == (nomeMoedaEntrada));
        moedaAtualizada.Rate = valorMoedaOrigem;

        Console.WriteLine("Lista atualizada");

        foreach (Moedascs moeda in MoedasList)
        {
            Console.WriteLine(moeda);
        }

    }
    else if (escolha == 'C' || escolha == 'c')
    {
        Console.WriteLine("Digite o nome da moeda a ser removida:");
        nomeMoedaEntrada = Console.ReadLine().ToUpper();
        Moedascs moedaRemovida = MoedasList.FirstOrDefault(x => x.Currency == (nomeMoedaEntrada));

        if (!MoedasList.Contains(moedaRemovida))
        {
            Console.WriteLine("Falha na remoção");
        }
        else
        {
            Console.WriteLine($"Moeda removida com sucesso ");
            MoedasList.Remove(moedaRemovida);
        }

    }
    else if (escolha == 'D' || escolha == 'd')
    {
        Console.WriteLine("Qual a moeda que voce possui? ");
        nomeMoedaEntrada = Console.ReadLine().ToUpper();

        Console.WriteLine("Qual valor que voce quer converter?");
        valorMoedaOrigem = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a moeda de saida para conversao?");
        nomeMoedaDestino = Console.ReadLine().ToUpper();
        Moedascs moedaEntrada = MoedasList.FirstOrDefault(x => x.Currency == (nomeMoedaEntrada));

        Moedascs moedaSaida = MoedasList.FirstOrDefault(x => x.Currency == (nomeMoedaDestino));

        valorMoedaOrigem *= (moedaEntrada.Rate / moedaSaida.Rate);

        Console.WriteLine($"Valor final do cambio: {moedaSaida.Currency} {valorMoedaOrigem.ToString("F2")}");
    }
    else if (escolha == 'E' || escolha == 'e')
    {
        Console.WriteLine("Lista de moedas: ");

        foreach (Moedascs moeda in MoedasList)
        {
            Console.WriteLine(moeda);
        }
    }
    else
    {
        break;
    }
    Console.WriteLine(" A para adicionar uma nova moeda \n B para atualizar uma moeda \n C para deletr uma moeda \n D para uma conversao \n E Para sair \n F para mostrar a lista de moedas");
    escolha = char.Parse(Console.ReadLine());
}