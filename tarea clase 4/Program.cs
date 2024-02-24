using System;
using System.Diagnostics.CodeAnalysis;

//ejercicio1
int x = 2;

while (x<=8)
{
    Console.WriteLine(x);
    
    x = x + 2;
}

//ejercicio 1.2
for (int i = 0; i <= 10; i++)
{
    int suma = 0;
    suma +=i;
}

//Ejercicio 2.1
Console.WriteLine("ingresa numeros enteros positivos: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = n; i <= 10; i++)
{
    
    n += i;
}

