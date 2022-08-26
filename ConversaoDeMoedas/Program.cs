using ConversaoDeMoedas;

Moedascs moedas;

List<Moedascs> MoedasList = new List<Moedascs>();

string[] text = System.IO.File.ReadAllLines(@"C:\Users\gorde\Desktop\Moeda\moedas.txt");

foreach (string line in text)
{
    string[] vect = line.Split(' ');
    moedas = new Moedascs(vect[0], double.Parse(vect[1]));
    MoedasList.Add(moedas);
}

Console.WriteLine("Imprimindo a lista");

foreach (Moedascs m in MoedasList)
{
    Console.WriteLine(m);
}

Console.WriteLine("Qual a moeda que voce possui? ");
string nomeMoedaEntrada = Console.ReadLine();

Console.WriteLine("Qual valor que voce quer converter?");
double valorMoedaOrigem = double.Parse(Console.ReadLine());

Console.WriteLine("Qual a moeda de saida para conversao?");
string nomeMoedaDestino = Console.ReadLine();

for (var i = 0; i < MoedasList.Count; i++)
{
    if (nomeMoedaEntrada == MoedasList[i].Currency)
    {
        for (var j = 0; j < MoedasList.Count; j++)
        {
            if (nomeMoedaDestino == MoedasList[j].Currency)
            {
                Console.WriteLine($"Valor total da conversão: {MoedasList[j].Currency} {((MoedasList[i].Rate / MoedasList[j].Rate) * valorMoedaOrigem).ToString("F2")}");
            }

        }
    }
}
