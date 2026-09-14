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

/*string? Nombre = "";
string? Ciudad = "";
Console.WriteLine("Introduzca su Nombre por favor: ");
Nombre = Console.ReadLine();

Console.WriteLine("Introduzca su Ciudad por favor: ");
Ciudad = Console.ReadLine();

Console.WriteLine($"Nombre: {Nombre}");
Console.WriteLine($"Ciudad: {Ciudad}");*/

/*Después muestra la edad introducida.*/
 /*Console.WriteLine("Introduzca su edad por favor: ");
int? Edad = 0;
Edad = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Edad: {Edad}");

/* Pide al usuario: Nombre de un producto. Precio del producto.El precio deberá almacenarse como double.Después muestra ambos datos/*

string? producto = "";
Double? precio = 0.0;

Console.WriteLine("Introduzca el nombre del producto por favor: ");
producto = Console.ReadLine();
Console.WriteLine("Introduzca el precio  del producto por favor: ");
precio = double.Parse(Console.ReadLine()!);
Console.WriteLine($"precio: {precio} ¨producto:¨{producto}");

/*Pide dos números enteros.Convierte los valores y calcula: Suma. Resta. Multiplicación. Muestra los tres resultados.*/
//Double? suma = 0.0; 
//Double? resta = 0.0;
//Double? multiplicacion = 0.0;

//Console.Write("Dame un numero: ");
//int n1 = int.Parse(Console.ReadLine() ?? "0");
//Console.Write("Dame otro número: ");
//int n2 = int.Parse(Console.ReadLine() ?? "0");

//Console.WriteLine($"{n1 + n2} {n1 - n2} {n1 * n2}");

/*Pide dos números enteros. Calcula: División. Resto de la división */
//Double? division = 0.0;
//Double? restoDivision = 0.0;
//Console.Write("Dame un numero: ");
//int n3 = int.Parse(Console.ReadLine() ?? "0");
//Console.Write("Dame otro número: ");
//int n4 = int.Parse(Console.ReadLine() ?? "0");

//Console.WriteLine($"{n1 / n2}"); 

/*Pide al usuario una cantidad de minutos. Calcula cuántas horas completas representan y cuántos minutos sobran.*/
//int minutos = int.Parse(Console.ReadLine() ?? "0");
//Console.Write("Dame unos minutos: ");

//int horas = minutos / 60;
//int minutosRestantes = minutos % 60;
//Console.WriteLine ($"{minutos} minutos son {horas} horas y {minutosRestantes} minutos.");

/*Ejercicio 9 — Área de un rectángulo Pide:Base.Altura.*/
Console.Write("Dame la base: ");
double baseRect = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Dame la altura: ");
double altura = double.Parse(Console.ReadLine() ?? "0");

double area = baseRect * altura;

Console.WriteLine($"El área del rectángulo es: {area}");

/*Ejercicio 10 — Precio final Pide:Precio de un producto.Precio de otro producto.Calcula:Precio total.Precio medio.*/
Console.Write("Dame precio de un producto: ");
double p1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Dame precio de otro producto: ");
double p2 = double.Parse(Console.ReadLine() ?? "0");

double precioTotal = p1 + p2;
double mediaProd = precioTotal /2;

Console.WriteLine($"El precio total es: {precioTotal}");
Console.WriteLine($"El precio medio es de: {mediaProd}");


/* Pide una temperatura en grados Celsiu. Convierte el valor a Fahrenheit utilizando: F = C × 9 / 5 + 32
*/

Console.WriteLine("Introduce la temperatura en Celsius: ");
double celsius = double.Parse(Console.ReadLine() ?? "0");
double Fahrenheit = celsius * 9 / 5 + 32;

Console.WriteLine($"Los grados convertidos son: {Fahrenheit}");
