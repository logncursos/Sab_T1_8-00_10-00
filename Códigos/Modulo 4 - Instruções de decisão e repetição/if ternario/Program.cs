// string numeros = "-5 3 8 10 12 -2 7";

int[] numeros = new int[7] {-5, 3, 8, 10, 12, -2, 7};

int qntNumeros = numeros.Length;

int maiorNumero = 0;
int menorNumero = 0;
int qntNegativos = 0;
int qntPositivos = 0;

double total = 0;

for(int i = 0; i < numeros.Length; i++){
    total += numeros[i];

    maiorNumero = maiorNumero < numeros[i] ? numeros[i] : maiorNumero;

    // if(maiorNumero < numeros[i])
    //     maiorNumero = numeros[i];

    menorNumero = menorNumero > numeros[i] ? numeros[i] : menorNumero;

    // if(menorNumero > numeros[i])
    //     menorNumero = numeros[i];

    int teste = numeros[i] < 0 ? qntNegativos++ : qntPositivos++;

    // if(numeros[i] < 0)
    //     qntNegativos++;
    // else
    //     qntPositivos++;
}


Console.WriteLine($"Media {total / qntNumeros}");
Console.WriteLine($"Maior numero {maiorNumero}");
Console.WriteLine($"Menor numero {menorNumero}");
Console.WriteLine($"quantidade positivos {qntPositivos}");
Console.WriteLine($"quantidade negativos {qntNegativos}");

// Média: 4.71
// Maior número: 12
// Menor número: -5
// Números positivos: 5
// Números negativos: 2