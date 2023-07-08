//Atividade 1
for(int i = 0; i <= 100; i++){
    Console.WriteLine(i + " - " + (char)i);
}

//atividade 2
const double PI = 3.14;
Console.WriteLine("Digite um numero");
double digitado = Convert.ToInt32(Console.ReadLine());
double resultado = PI * digitado;
Console.WriteLine(resultado);