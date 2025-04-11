int contador = 1;
int numero;
int mayor = int.MinValue;

while (contador <= 3)
{
    Console.WriteLine($"Ingrese número {contador}: ");
    numero = int.Parse(Console.ReadLine());

    if (numero > mayor)
    {
        mayor = numero;
    }

    contador++;
}

Console.WriteLine("El número mayor es: " + mayor);
