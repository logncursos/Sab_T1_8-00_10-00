// while (false)
// {
//    Console.WriteLine("while"); 
// }

// bool mercado = true;
// do
// {

//     Console.WriteLine("Estado do mercado " + mercado);

// } while (mercado);


//Pedir ao usuário para digitar números até que 
//um número negativo seja digitado utilizando um loop while

//Exibir uma contagem regressiva de 10 a 1 utilizando um loop while


// int numeroDigitado = 0;

// do
// {
//     Console.WriteLine("digite um numero");
//     numeroDigitado = Convert.ToInt32(Console.ReadLine());

// } while (numeroDigitado >= 0);

// while(numeroDigitado >= 0){
//     Console.WriteLine("digite um numero");
//     numeroDigitado = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("saiu da repeticao");

//Calcular a média de uma sequência de números digitados pelo usuário até
// que o número zero seja digitado.

//1 - Calcular a média de uma sequência de números digitados
//2 - digitados pelo usuário
//3 - ate que o numero seja zero.

//7, 4, 8 = 19 / 3

// int numeroDigitado = 1;
// int media = 0;
// int notasInseridas = 0;

// while(numeroDigitado >= 1){

//     numeroDigitado = Convert.ToInt32(Console.ReadLine());

//     media += numeroDigitado;
    
//     if(numeroDigitado == 0)
//         break;

//     notasInseridas++;
// }

// Console.WriteLine(media / notasInseridas);