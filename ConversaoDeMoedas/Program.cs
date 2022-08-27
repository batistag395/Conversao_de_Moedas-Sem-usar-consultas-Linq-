using ConversaoDeMoedas;

Moedascs moedas;

List<Moedascs> MoedasList = new List<Moedascs>();

string[] text = System.IO.File.ReadAllLines(@"C:\Users\gorde\Desktop\Conversao_de_Moedas-Sen-usar-consultas-Linq-\moedas.txt");

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
        valorMoedaOrigem *= MoedasList[i].Rate;
    }
    if (nomeMoedaDestino == MoedasList[i].Currency)
    {
        valorMoedaOrigem /= MoedasList[i].Rate;
    }
}
Console.WriteLine($"Valor total da conversão: {nomeMoedaDestino} {(valorMoedaOrigem).ToString("F2")}");
