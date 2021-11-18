Console.WriteLine("Calculando Poupança");

double valorInvestido = 1000;
//0.36% = 0.0036
int contadorMes = 1;

while (contadorMes <= 12)
{
    valorInvestido = valorInvestido + valorInvestido * 0.0036;
    Console.WriteLine("Após " + contadorMes + "mês, você terá R$ " + valorInvestido);
    contadorMes += 1;
}



Console.ReadLine();