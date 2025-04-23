//definindo variaveis
int contador=0,resultado=0;

//fazendo a conta e usando a repetição para testar os números necessarios
for(int i=1;i<=500;i++){
    if((i%2)!=0 && (i%3)==0){
        resultado=resultado+i;
        contador++;
    }
}
//mostrando na tela do usuario.
Console.WriteLine($"\nExistem {contador} números impares multiplos de 3 entre 1 e 500 \ne a soma desses números resulta em: {resultado}.");
//pra dar tempo da pessoa ver sem o programa fechar na cara dela.
Console.ReadKey();