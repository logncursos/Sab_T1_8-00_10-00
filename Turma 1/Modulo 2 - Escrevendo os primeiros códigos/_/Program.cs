﻿// string senha = "fafa";
// string usuario = "bruno";
// int tentativas = 3;
// bool acesso = false;

// for(int i = 0; i < tentativas; i++){

//     Console.WriteLine("----------tentativa "+(i+1)+"/"+tentativas+"---------");

//     Console.WriteLine("Digite seu usuario");
//     string usuarioDigitado = Console.ReadLine()!;

//     Console.WriteLine("Digite sua senha");
//     string senhaDigitada = Console.ReadLine()!;

//     if(usuarioDigitado == usuario && senha == senhaDigitada){
//         i = tentativas;
//         acesso = true;
//     } else {
//         Console.WriteLine("Usuario ou senha invalido");

//     }
// }

// Console.WriteLine("------------------");
// if(acesso){
//     Console.WriteLine("Usuario logado");
// } else {
//     Console.WriteLine("Usuario ou senha invalido");
// }


//o número de combinações possíveis seria 62^n.

//Por exemplo, se a senha tiver 4 caracteres, o número de combinações possíveis seria 62^4 = 14.776.336.

public class BruteForcePasswordCracker
{
    public static void Main()
    {
        string senha = "baaf"; // Senha a ser quebrada
        string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Caracteres possíveis 62 exponenciação senha

       double numeroMaximoTentativas = Math.Pow(caracteres.Length, senha.Length);

        Console.WriteLine("Número máximo de tentativas: " + numeroMaximoTentativas.ToString("N2", new System.Globalization.CultureInfo("en-US")));

        Console.WriteLine("pressione qualquer tecla para comecar");
        Console.ReadLine();

        int tamanhoMaximo = 8; // Tamanho máximo da senha

        bool senhaEncontrada = false;
        string senhaQuebrada = "";
        double tentativas = 0;

        // Loop para gerar todas as combinações possíveis
        for (int tamanho = 1; tamanho <= tamanhoMaximo; tamanho++)
        {
            if (senhaEncontrada)
                break;

            GerarSenhas(tamanho, caracteres, "", ref senhaEncontrada, ref senhaQuebrada, senha, ref tentativas);
        }

        if (senhaEncontrada)
            Console.WriteLine("Senha encontrada: " + senhaQuebrada);
        else
            Console.WriteLine("Senha não encontrada.");

        Console.WriteLine("Número de tentativas: " + tentativas.ToString("N2", new System.Globalization.CultureInfo("en-US")));
    }

    // Função recursiva para gerar todas as combinações de senha possíveis
    public static void GerarSenhas(int tamanho, string caracteres, string tentativaAtual, ref bool senhaEncontrada, ref string senhaQuebrada, string senhaAlvo, ref double tentativas)
    {
        if (senhaEncontrada)
            return;

        if (tamanho == 0)
        {
            if (tentativaAtual == senhaAlvo)
            {
                senhaEncontrada = true;
                senhaQuebrada = tentativaAtual;
            }
        }
        else
        {
            for (int i = 0; i < caracteres.Length; i++)
            {
                string novaTentativa = tentativaAtual + caracteres[i];
                tentativas++;
                Console.WriteLine(novaTentativa + " - " + tentativas.ToString("N2", new System.Globalization.CultureInfo("en-US")));
                GerarSenhas(tamanho - 1, caracteres, novaTentativa, ref senhaEncontrada, ref senhaQuebrada, senhaAlvo, ref tentativas);
            }
        }
    }
}
