/*Console.WriteLine("Hello, World!");*/


/* Ejercicio 1: Crea un programa que muestre por consola, Tu nombre, Tu ciudad, Tu edad, Tu comida favorita */ 

/*string nombre = "Javier Gómez-Comino";
string ciudad = "Alcázar de San Juan"; 
int  edad = 21;
string comida = "Huevos Duros";

Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Ciudad: {ciudad}");
Console.WriteLine($"Edad: {edad}");
Console.WriteLine($"Comida: {comida}");*/


/* Ejercicio 3: Pídele al usuario su nombre y su ciudad. Después muestra ambos datos por consola.*/ 

string? Nombre = "";
string? Ciudad = "";
Console.WriteLine("Introduzca su Nombre por favor: ");
Nombre = Console.ReadLine();

Console.WriteLine("Introduzca su Ciudad por favor: ");
Ciudad = Console.ReadLine();

Console.WriteLine($"Nombre: {Nombre}");
Console.WriteLine($"Ciudad: {Ciudad}");