int n1=0,n2=0,n1Inicial=0,n2Inicial=0,resto=0,mdc=0,mmc=0;

do
{
    Console.Write("Digite o primeiro número inteiro positivo: ");
    n1 = int.Parse(Console.ReadLine());
    if (n1 < 0)
    {
        Console.Write("Esse número não pode ser negativo e nem nulo. ");
    }
} while (n1 <= 0);

do
{
    Console.Write("Digite o segundo número inteiro positivo: ");
    n2 = int.Parse(Console.ReadLine());
    if (n2 < 0)
    {
        Console.Write("Esse número não pode ser negativo. ");
    }
} while (n2 <= 0);

n1Inicial = n1;
n2Inicial = n2;

while (n2 != 0); // quando iguala a zero, n1 tem o mdc
{
    resto = n1 % n2;
    n1 = n2;
    n2 = resto;
}
mdc = n1;
mmc = (n1Inicial * n2Inicial) / mdc;

Console.WriteLine($"O MDC entre os dois números é: {mdc}");
Console.WriteLine($"O MMC entre os dois números é: {mmc}");