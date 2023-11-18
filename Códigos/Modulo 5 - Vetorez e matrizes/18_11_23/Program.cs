using System.Collections;

const int qnt = 4;

string[] usuarios = new string[qnt] {"bruno", "emerson", "Sabrina", "Renan"};
int[] idade = new int[qnt] {24, 52, 55, 30};
char[] sexo = new char[qnt] {'h', 'h', 'm', 'h'};

Console.WriteLine("Digite o usuario que deseja encontrar");
string numeroDigitado = Console.ReadLine().ToUpper();
int id = -1;

for(int i = 0; i < usuarios.Length; i++){
    if(usuarios[i].ToUpper() == numeroDigitado){
        id = i;
        break;
    }
}
if(id < 0)
    Console.WriteLine("Usuariio nao encontrado");
else{
    Console.WriteLine($"foi encontrado o usuario \n Nome:{usuarios[id]} \n Idade:{idade[id]} \n Sexo:{sexo[id]}");
}
ArrayList arrayList = new ArrayList() {1};
Console.WriteLine(arrayList[0]);