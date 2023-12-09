while(true){
	int num1 = Convert.ToInt32(Console.ReadLine());
	int num2 = Convert.ToInt32(Console.ReadLine());
	char operador = Convert.ToChar(Console.ReadLine());
	
	int resultado = SomarNumeros(num1, num2, operador);
}

int SomarNumeros(int num1, int num2, char operador)
{
	int resultado = 0;

	switch (operador)
	{
		case '*' :
			resultado = num1 * num2;
			break;
		case '+' :
			resultado = num1 + num2;
			break;
		case '-' :
			resultado = num1 - num2;
			break;
		case '/' :
			resultado = num1 / num2;
			break;
	}

	return resultado;

}