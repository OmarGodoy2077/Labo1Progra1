int suma = 0;
int n = 0;


while (n <=0)
{
    Console.Write("Ingrese el número (debe ser positivo y mayor a cero): ");
    string input = Console.ReadLine();
 
        if (!int.TryParse(input, out n))
        {
            Console.WriteLine("Error: Ingrese un número válido.");
            n = 0;
            continue;
        }

    if (n < 0)
    {
        Console.WriteLine("Error: Ingrese un número positivo mayor a cero.");
        n = 0;
        continue;
    }
}

for (int i = 1; i <= n; i++)
{
    suma += i;
}

Console.Write("\nLos números positivos desde 1 a {0} son: ", n);
for (int i = 1; i <= n; i++)
{
    Console.Write("{0} ", i);
}
Console.ReadLine();

Console.Write("\nLos números que son impares o iguales a {0} son: ", n);

for (int i = 1; i <= n; i += 2)
{
    Console.Write("{0} ", i);
}
Console.ReadLine();

Console.WriteLine("\nLa tabla de multiplicar de {0} es: ", n);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
}
Console.ReadLine();

Console.WriteLine("\nTodos los números que empiezan en {0} y se incrementan en 2 hasta llegar a 20 son: ", n);

int j = n;

while (j <= 20)
{
    j += 2;
    Console.Write("{0} ", j);
    
}
Console.ReadLine();

Console.WriteLine("\nLos primeros números de {0} suman: {1} ", n, suma);

Console.ReadLine();
