int decimais=0
double pi=0,termo=0;

Console.WriteLine("\n\nCalculando aproximação de PI\n\n");

Console.WriteLine("");

for (int i = 0; i < decimais; i++)
{
    // Cálculo do termo da série
    termo=Math.Pow(-1, i) / (2 * i + 1);
    // Soma o termo à aproximação de pi
    pi=pi+termo;
}
//conta final para obter o PI aproximado
pi=pi*4;
//mostrando para o usuario o resultado
Console.WriteLine($"Aproximação de pi usando a série de Leibniz: {pi}");

Console.ReadKey();