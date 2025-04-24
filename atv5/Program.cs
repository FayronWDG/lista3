int x =1,l=0;
 int f =0;
Console.WriteLine("digite o numero da sequencia de fibonacci");
    int  n = int.Parse(Console.ReadLine());

for (int i=0; i<=n; i++){
if (n==0) {
   Console.WriteLine("numero invalido");
   break;
}

if (i==0){
    Console.WriteLine($"{i}");
}
if (i>0){
     Console.WriteLine($"{x}");
   f=x+l;
    l=x;
    x=f;

}

}
double termos=0; // Número de termos a serem usados na aproximação
        Console.Write("Digite o número de termos para a aproximação de PI: ");
        termos = int.Parse(Console.ReadLine());

        double pi = 0;
        for (int k = 0; k < termos; k++)
        {
            double termo = Math.Pow(-1, k) / (2 * k + 1);
            pi += termo;
        }

        pi *= 4;

        Console.WriteLine($"Aproximação de PI com {termos} termos: {pi}");