// Exercicio Par ou Impar
Console.WriteLine("---------Par ou Impar---------");

// Loop que itera de 0 a 4
for (int i = 0; i < 5; i++)
{
    // Verifica se o número é par
    if (i % 2 == 0)
    {
        // Imprime o número e a palavra "Par"
        Console.WriteLine(i + " Par");
    }
    else
    {
        // Imprime o número e a palavra "Impar"
        Console.WriteLine(i + " Impar");
    }
}

// Exercicio Nome e Sobrenome
Console.WriteLine("---------Digitar nome e sobrenome---------");

// Solicita ao usuário que digite o nome
Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

// Solicita ao usuário que digite o sobrenome
Console.WriteLine("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine();

// Imprime o nome completo concatenando o nome e o sobrenome
Console.WriteLine("Nome completo: " + nome + " " + sobrenome);