// O laço for será executado 100 vezes, começando do valor 0 e incrementando o valor de 'i' em 1 a cada iteração.
// O objetivo é percorrer os números de 0 a 99.
for (int i = 0; i < 100; i++)
{
    // Aqui, estamos usando Console.WriteLine() para exibir os valores de 'i' e o caractere correspondente na tabela ASCII.
    // A expressão (char)i realiza a conversão implícita do valor inteiro 'i' para um caractere correspondente na tabela ASCII.
    // Isso permite que exibamos o caractere associado a cada número inteiro 'i'.
    // O operador + é usado para concatenar as informações a serem exibidas no Console.
    // O resultado será impresso em cada iteração do laço, resultando em uma saída como: "0", "1", "2", ..., "97 a", "98 b", "99 c".
    Console.WriteLine(i + " " + (char)i);
}
