//declarando as variaveis
int contador=0,parte1=0,parte2=0;

//breve explicação sobre o que se trata o programa(nem um pouco breve)
Console.WriteLine("\n\nLista dos números entre 1000 e 9999 que fazem parte de \numa propriedade bizzara que faz ele virar ele mesmmo\nse dividindo e somando e depois dobrando o resultado\n\n");

//laço de repetição para fazer as contas necessarias e já mostrar para o usuario apenas os números requisitados.
for(int i=1000;i<=9999;i++){
    //calculo para desmembrar os números
    parte1=(i/100)+(i%100);
    //calculo para testar a formula e ver se esse número tem a formula requerida
    parte2=parte1*parte1;
    if(parte2==i){
        contador++;
        Console.WriteLine($"Esse é o {contador} número faz parte dessa propriedade: {i}");
    }
}
//para o programa não fechar na cara do usuario.
Console.ReadKey();