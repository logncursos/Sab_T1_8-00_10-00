// Tipos numéricos
int idade = 25; // Declara uma variável inteira chamada "idade" e atribui o valor 25 a ela. 
double salario = 2500.50; // Declara uma variável de ponto flutuante de precisão dupla chamada "salario" e atribui o valor 2500.50 a ela. //Maior precisao e 64bits 15-17 digitos significativos
decimal saldoBancario = 10000.75m; // Declara uma variável decimal chamada "saldoBancario" e atribui o valor 10000.75 a ela. //Alta precisao decimal 128bits 28-29 digitos significativos
float altura = 1.75f; // Declara uma variável de ponto flutuante de precisão simples chamada "altura" e atribui o valor 1.75 a ela. //Menor precisao 32bits 6-9 digitos significativos

// Tipos de caracteres
char letra = 'A'; // Declara uma variável de caractere chamada "letra" e atribui o valor 'A' a ela.
string nome = "João"; // Declara uma variável de cadeia de caracteres chamada "nome" e atribui o valor "João" a ela.

// Tipos booleanos
bool isAtivo = true; // Declara uma variável booleana chamada "isAtivo" e atribui o valor verdadeiro (true) a ela.
bool isAprovado = false; // Declara uma variável booleana chamada "isAprovado" e atribui o valor falso (false) a ela.

// Tipos de data e hora
DateTime dataAtual = DateTime.Now; // Declara uma variável chamada "dataAtual" do tipo DateTime e atribui a ela o valor da data e hora atuais.
TimeSpan duracao = TimeSpan.FromHours(2); // Declara uma variável chamada "duracao" do tipo TimeSpan e atribui a ela a duração de 2 horas.

// Outros tipos de dados
byte nivel = 3; // Valor numérico sem sinal de 8 bits
sbyte temperatura = -10; // Valor numérico com sinal de 8 bits
short codigo = 1001; // Valor numérico com sinal de 16 bits
ushort totalProdutos = 500; // Valor numérico sem sinal de 16 bits
long populacao = 8000000L; // Valor numérico com sinal de 64 bits
ulong totalVotos = 100000000UL; // Valor numérico sem sinal de 64 bits
char categoria = 'B'; // Caractere
string endereco = "Rua Principal, 123"; // Cadeia de caracteres
decimal peso = 68.5m; // Valor decimal com alta precisão

// Imprime os valores das variáveis
Console.WriteLine("Idade: " + idade + " " + idade.GetType());
Console.WriteLine("Salário: " + salario + " " + salario.GetType());
Console.WriteLine("Saldo Bancário: " + saldoBancario + " " + saldoBancario.GetType());
Console.WriteLine("Altura: " + altura + " " + altura.GetType());
Console.WriteLine("Letra: " + letra + " " + letra.GetType());
Console.WriteLine("Nome: " + nome + " " + nome.GetType());
Console.WriteLine("Está ativo? " + isAtivo + " " + isAtivo.GetType());
Console.WriteLine("Está aprovado? " + isAprovado + " " + isAprovado.GetType());
Console.WriteLine("Data atual: " + dataAtual + " " + dataAtual.GetType());
Console.WriteLine("Duração: " + duracao + " " + duracao.GetType());
Console.WriteLine("Nível: " + nivel + " " + nivel.GetType());
Console.WriteLine("Temperatura: " + temperatura + " " + temperatura.GetType());
Console.WriteLine("Código: " + codigo + " " + codigo.GetType());
Console.WriteLine("Total de Produtos: " + totalProdutos + " " + totalProdutos.GetType());
Console.WriteLine("População: " + populacao + " " + populacao.GetType());
Console.WriteLine("Total de Votos: " + totalVotos + " " + totalVotos.GetType());
Console.WriteLine("Categoria: " + categoria + " " + categoria.GetType());
Console.WriteLine("Endereço: " + endereco + " " + endereco.GetType());
Console.WriteLine("Peso: " + peso + " " + peso.GetType());

Console.WriteLine("pressione enter para rodar o desafio");
Console.ReadLine();

double saldoConta = 3000.00;
double saque = 300.00;
double deposito = 500.00;
string cliente = "Bruno";
string operacao = "1";

Console.WriteLine($"Bem vindo {cliente} seu saldo: {saldoConta}");

while(operacao == "1"){

Console.WriteLine("Digite 1 para deposito");
Console.WriteLine("Digite 2 para saque");
Console.WriteLine("Pressione ENTER para confirmar");

string teclaDigitada = Console.ReadLine()!;

if(teclaDigitada == "1"){
    saldoConta += deposito;
    Console.WriteLine("Operacao selecionada (Deposito)");
    Console.WriteLine($"voce depositou {deposito} agora seu saldo e de: {saldoConta}");
} else if(teclaDigitada == "2"){

    if(saldoConta >= deposito){
        saldoConta -= saque;
         Console.WriteLine("Operacao selecionada (Saque)");
         Console.WriteLine($"voce sacou {saque} agora seu saldo e de: {saldoConta}");
    } else {
        Console.WriteLine("Saldo insuficiente");
    }
} else {
    Console.WriteLine("Erro, opcao invalida");
}
    Console.WriteLine("Deseja efetuar outra operacao 1 para sim 2 para nao");
    operacao = Console.ReadLine();
}

Console.WriteLine("Obrigado, finalizando atendimento");