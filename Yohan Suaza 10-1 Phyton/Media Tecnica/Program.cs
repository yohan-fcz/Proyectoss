pascal case
PascaLCase

snake case
snake_case

cameL case
cameLcase

float variableEntera;
decimal variableDecimal;
double variableDouble;
int nombreVariable= 1;
variableEntera= 2.5f;
variableDouble= 1;
variableDecimal= 1.0M;

char variableChar= 'x';
string variableString = "Yohan";

bool variableBoolean = false;

suma +
resta -
multiplicacion *
division /
modulo %  -residuo division
nombreVariable++;

Console.WriteLine("El valor de la variable decimal es"  + variableDecimal + ", la variable variableString tiene" + variableString);

Console.WriteLine($"mi nombre es: {variableString}");
Console.WriteLine(nombreVariable);

Console.WriteLine(4 / 2);
Console.WriteLine(4 * 2);
Console.WriteLine(4 % 2);

Console.WriteLine("Ingrese un valor");
string numeroIngresado = Console.ReadLine();

int numero ;
= int.Parse(numeroIngresado);
if (int.TryParse(numeroIngresado, out numero))
{
    Console.WriteLine("El numero ingresado " + numero + " + " + 1 + " = " + ( numero + 1));
    && conjuncion
    || disyuncion
    if (numero>15 || numero <= 50)
    {
        Console.WriteLine("El numero es mayor a 15");
    }
    else
    {
        Console.WriteLine("El numero no se encuentra en el rango");
    }
}
else
{ 
    Console.WriteLine("El valor no es numerico");
}



Console.WriteLine("Ingrese su nombre");
string nombreIngresado = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
string edadIngresado = Console.ReadLine();
int numero ;
if (int.TryParse(edadIngresado, out numero))
{
 if (numero>18)
 {
    Console.WriteLine (nombreIngresado + "Eres mayor de edad");
 }
 else
 {
    Console.WriteLine(nombreIngresado + "Eres menor de edad");
 }
}



    Console.WriteLine("El valor no es numerico");


    string fruta="pera ";
switch (fruta)
{
    case "fresa":
       Console.WriteLine($"la {fruta} tiene un descuento de 5%");
        break;
    case "uva":
       Console.WriteLine($"la {fruta} tiene un descuento de 10%");
        break;
   default:  
        Console.WriteLine($"el {fruta} no tiene descuento");
        break;
}


Console.WriteLine("La tabla del 1");
for (int i = 1; i <= 10; i++)
{
     Console.WriteLine($"\nTabla del {i}");
     for (int j = 0; j <= 10; j++)
     {
        Console.WriteLine($"{i}x{j}: {i * j}");
     }
 }

for (int i = 1; i <= 5; i++)
 {
     Console.WriteLine($"Ingrese el nombre de los estudiantes");
 string nombre = Console.ReadLine();
     Console.WriteLine($"El nombre ingresado es {nombre}");
 }
 Console.WriteLine($"El ciclo terminó");

 int i=0;
 while (i < 5)
 {
     Console.WriteLine($"El valor de i {i}");
     i++;
 }

 Console.WriteLine($"Ingrese un numero");
 string numeroIngresado = Console.ReadLine();
 int numero;
 bool conversion = ;
 while (!int.TryParse (numeroIngresado, out numero))
 {
     Console.WriteLine($"Ingrese un numero");
     numeroIngresado = Console.ReadLine();
 }    
 Console.WriteLine($"{numeroIngresado}");
 
string numeroIngresado = Console.ReadLine();
string numero = Console.ReadLine();
do
{
    Console.WriteLine($"Ingrese un numero");
    numeroIngresado = Console.ReadLine();
} while (!int.TryParse (numeroIngresado, out numero));

La variable 'n' esta asiganada pero su valor nunca se usa

int n = 3; 
while (n < 5) 
{
   Console.WriteLine($"{n}");
   n++;
}
do
{
   Console.WriteLine($"{n}");
   n++;
} while (n < 5);

void Suma(int num1, int num2)
{
   int n1 = num1, n2 = num2;
   Console.WriteLine($"{n1 + n2}");

}   
Suma(2, 5);
Suma(3, 9);
Suma(4, 4);
Suma(7, 1);

int Suma2(int num1, int num2);
{
   return num1 + num2;
}
int resultado1= Suma2(2, 5);
Console.WriteLine($"{Suma2(3,1)+1}");()
int suma + resultado1 + 1;
Console.WriteLine($"{suma}");

void Saludar(string nombre)
{
   Console.WriteLine($"Hola {nombre}");
}

Console.WriteLine($"Ingrese un nombre");
string nombreUsuario = Console.ReadLine();

Saludar (nombreUsuario);

void Saludar2 ()
{
   Console.WriteLine($"Ingrese su nombre");
   string nombre = Console.ReadLine();

   Console.WriteLine($"Ingrese su edad");
   string edad = Console.ReadLine();

   Console.WriteLine($"Hola {nombre}, tienes {edad} años de edad");
}
Saludar2();

int num=0;

void Incrementar()
{
   num++;
}

void Decrementar()
{
   num--;
}

Incrementar();
Console.WriteLine(num);
Incrementar();
Console.WriteLine(num);
Incrementar();
Console.WriteLine(num);

Decrementar();
Console.WriteLine(num);
Decrementar();
Console.WriteLine(num);
Decrementar();
Console.WriteLine(num);
Decrementar();
Console.WriteLine(num);

string Saludar(string nombre)
{
   string saludo = "hola" + nombre;
   return saludo;
}

string saludo = Saludar ("Yohan");
Console.WriteLine($"{saludo + " Feliz tarde"}");

saludo = Saludar("Mario");
Console.WriteLine($"{saludo}");

Console.WriteLine($"{Saludar("Santiago")}");

int Suma(int n1, int n2)
{
   return n1 + n2;
}

int resultado = Suma (1, 2);

int suma = resultado + 1;
Console.WriteLine(suma);

string SolicitarNombre()
{
Console.WriteLine("Ingrese un nombre");
string nombre = Console.ReadLine();
return nombre;
}
string nombre1 = SolicitarNombre();
string nombre2 = SolicitarNombre();

Console.WriteLine("Los nombres ingresados son:");
Console.WriteLine(nombre1);
Console.WriteLine(nombre2);


Ejercicio 8
int P;
Console.WriteLine("Ingrese su edad");
string edad = Console.ReadLine();
int Edad;
int.TryParse(edad, out Edad);
P = (220 - Edad)/10;
Console.WriteLine($"El numero de tus pulsaciones son: {P}");

int num1, num2;

Console.WriteLine("Ingrese el numero");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el numero");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("La suma de los dos numeros es  " + (num1 + num2 ));
