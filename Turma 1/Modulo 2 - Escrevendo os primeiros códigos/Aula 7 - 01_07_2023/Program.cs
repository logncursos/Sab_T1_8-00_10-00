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
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Saldo Bancário: " + saldoBancario);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Letra: " + letra);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Está ativo? " + isAtivo);
        Console.WriteLine("Está aprovado? " + isAprovado);
        Console.WriteLine("Data atual: " + dataAtual);
        Console.WriteLine("Duração: " + duracao);
        Console.WriteLine("Nível: " + nivel);
        Console.WriteLine("Temperatura: " + temperatura);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Total de Produtos: " + totalProdutos);
        Console.WriteLine("População: " + populacao);
        Console.WriteLine("Total de Votos: " + totalVotos);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Endereço: " + endereco);
        Console.WriteLine("Peso: " + peso);

        Console.ReadLine();