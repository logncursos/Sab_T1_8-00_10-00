// Declarando uma variável chamada "dia" do tipo "DiasDaSemana".
// Atribuindo o valor "Sexta" ao enumerador "dia".
DiasDaSemana dia = DiasDaSemana.Sexta;

// Exibindo o valor da variável "dia" no Console.
// O operador "+" é usado para concatenar (juntar) o valor do enumerador com uma mensagem de texto.
Console.WriteLine("Dia da semana: " + dia);

// Definindo um enumerador chamado "DiasDaSemana".
// Enumeradores são tipos de dados especiais que permitem representar um conjunto de valores relacionados.
// Neste caso, o enumerador "DiasDaSemana" representa os dias da semana.
enum DiasDaSemana
{
    Domingo,   // Membro 0 do enumerador (valor implícito).
    Segunda,   // Membro 1 do enumerador (valor implícito).
    Terca,     // Membro 2 do enumerador (valor implícito).
    Quarta,    // Membro 3 do enumerador (valor implícito).
    Quinta,    // Membro 4 do enumerador (valor implícito).
    Sexta,     // Membro 5 do enumerador (valor implícito).
    Sabado     // Membro 6 do enumerador (valor implícito).
}