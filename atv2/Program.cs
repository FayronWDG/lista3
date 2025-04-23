
double altura=0,menor=double.MaxValue,maior=double.MinValue,contador=1;

Console.WriteLine("\nLeitor de Altura de 15 pessoas(especificicamente) e mostrando o menor e o maior");

while(contador<=15){
    Console.Write($"Escreva a altura do(a) {contador}º(ª): ");
    altura=double.Parse(Console.ReadLine());
    if(menor>altura){
        menor=altura;
    }
    else if(maior<altura){
        maior=altura;
    }
    contador++;
}
Console.WriteLine($"A menor pessoa mede {menor:F2} e a maior mede {maior:F2}.");

Console.ReadKey();