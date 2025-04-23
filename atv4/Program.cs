//declarando variaveis
int sequenciaA=0,sequencia=1,sequenciaF=0,sequencial=0;

//titulo
Console.WriteLine("\n\nA série de Fibonacci\n\n");

//lendo o número total que o usuario pediu da sequencia
Console.Write("Escreva o total de números da série de Fibonacci que sera apresentado: ");
sequencial=int.Parse(Console.ReadLine());

for(int i=0;i<=sequencial;i++){
    if(sequencial==0){
        break;
    }
    if(i==0){
        //mostrando o primeiro da sequencia
        Console.WriteLine(i);
    }
    else if(i>0){
        //mostrando a sequencia na tela
        Console.WriteLine(sequencia);
    //contas para a sequencia continuar
    sequenciaF=sequencia+sequenciaA;
    sequenciaA=sequencia;
    sequencia=sequenciaF;
    }
    
}
//para o programa não fechar na cara do usuario
Console.ReadKey();