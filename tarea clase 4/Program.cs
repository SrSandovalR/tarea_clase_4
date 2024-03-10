using System;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;



//Enunciado 1:
//ejercicio1


for (int x = 0; x <= 8; x++)
{
    if (x % 2 == 0)
    {

        Console.WriteLine(x);
    }

}





//ejercicio 2

int suma = 0;

for (int i = 1; i <= 10; i++)
{

    suma += i;

    Console.WriteLine(i);


}

Console.WriteLine("La suma es: " + suma);



//Enunciado 2: 
// Ejercicio 1

int n = 0;
int suma3 = 0;

do
{
    Console.WriteLine("ingresa numeros enteros positivos: ");
    n = Convert.ToInt32(Console.ReadLine());

    suma3 += n;


} while (n > 0);

Console.WriteLine($"La suma de los numeros es: {suma3}");



//Ejercicio 2

int num = 1;

while (true)
{
    if (num % 7 == 0 && num % 11 == 0)
    {
        Console.WriteLine($"El primer numero divisible entre 7 y 11 es: {num}");
        break;
    }
    num++;
}




//Enunciado 3: 
//Ejercicio 1


while (true)
{
    Console.WriteLine("Ingrese la contrasena: ");
    string contrasena = Console.ReadLine();

    if (contrasena == "jutiapa")
    {
        Console.WriteLine("Contrasena Correcta");
        break;
    }

}


//Ejercicio 2


Random random = new Random();   
int enterorandom = random.Next(1,100);
Console.WriteLine("Se repetira hasta que lo encuentre.");
while (true)
{
    
    Console.WriteLine("Adivine el numero, ingrese cualquier numero: ");
	int adivinarnumero= Convert.ToInt32(Console.ReadLine());
	if (adivinarnumero == enterorandom)
	{
		Console.WriteLine("Adivinaste el numero"); break;
	}
	
}





// Ejercicio para todos:
//Ejercicio 7


Console.WriteLine("Ingrese su nombre: ");
string nombre2 = Console.ReadLine();

Console.WriteLine("Ingrese nota de matematica: ");
int nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese nota de Cinecias: ");
int nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese nota de Artes: ");
int nota3 = Convert.ToInt32(Console.ReadLine());



int promedio = 0;
promedio = nota1 + nota2 + nota3 / 3;

string sanciones = "Bryan";

if (nota1 >= 61 && nota2 >= 61 && nota3 >= 61 && promedio >= 70 && nombre2 != sanciones)
{
    Console.WriteLine("Aprobaste");
}
else
{
    Console.WriteLine("Reprobaste");
}








