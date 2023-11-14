Console.WriteLine("-----Alcool ou Gasolina?-----");

Console.WriteLine("Digite o preço do alcool (R$):");
decimal Alcool = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço da gasolina (R$):");
decimal Gasolina = Convert.ToDecimal(Console.ReadLine());

string Recomendacao;

if (AbastecerComGasolina (Alcool, Gasolina))
{
    Recomendacao = "Gasolina";
}
else
{
    Recomendacao = "Alcool";
}

double razao = RazaoAlcoolGasolina(Alcool, Gasolina) * 100;

Console.WriteLine ($"O Preço do alcool corresponde a {razao:N1}% do preço da gasolina");
Console.WriteLine($"\nRecomendação: Abasteça com {Recomendacao.ToUpper()}.");

double RazaoAlcoolGasolina(decimal precoAlcool, decimal precoGasolina)
{
    return Convert.ToDouble(precoAlcool / precoGasolina);
}

bool AbastecerComGasolina(decimal precoAlcool, decimal precoGasolina)
{
    const double MinRazUsoGas = 0.73;
    return RazaoAlcoolGasolina(precoAlcool, precoGasolina) >= MinRazUsoGas;
}
