Console.WriteLine("Tente acertar o numero:");


for(int i = (int)Adivinhacao.minimo; i <= (int)Adivinhacao.quantidadeTentativa; i++){

    int digitado = Convert.ToInt32(Console.ReadLine());
    string mensagemErro = $"Tente novamente: {i} / {(int)Adivinhacao.quantidadeTentativa}";
    string mensagemNumeroInvalido = $"Voce digitou um numero menor que {(int)Adivinhacao.minimo} ou maior que {(int)Adivinhacao.maximo}";

    if(digitado >= (int)Adivinhacao.minimo && digitado <= (int)Adivinhacao.maximo){

        if((int)Adivinhacao.numeroCerto == digitado){

            Console.WriteLine("Acertou");
            break;

        } else {

            Console.WriteLine(mensagemErro);

            if(i == (int)Adivinhacao.quantidadeTentativa){
                Console.WriteLine("Perdeu");
            }
            else if(digitado < (int)Adivinhacao.numeroCerto){
                Console.WriteLine($"Tente um numero maior que {digitado}");
            }
            else if(digitado > (int)Adivinhacao.numeroCerto){
                Console.WriteLine($"Tente um numero menor que {digitado}");
            }
        }
    } else {
        
        Console.WriteLine(mensagemNumeroInvalido);
        i--;
    
    }
}



enum Adivinhacao{
    minimo = 1,
    maximo = 10,
    numeroCerto = 5,
    quantidadeTentativa = 3
}