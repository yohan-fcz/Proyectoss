// ejercicio 05/07/23

int num1, num2;

Console.WriteLine("Ingrese el numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el numero");
num2 = int.Parse(Console.ReadLine());¿

Console.WriteLine("La suma de los dos numeros es  " + (num1 + num2));

 
Console.WriteLine("Ingrese un numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("El resultado es " + ((num1 + num2) * 5));




// ejercicio 2 06/07/23

using System;

public class HelloWorld
{
    private static void Main(string[] args)
    {
       if(args is null)
{
    throw new ArgumentNullException(nameof(args));
}
       int resultado;
       const int constante=5;
       
       Console.WriteLine("Ingrese dos numeros y multipliquelos por 5 ");
       Console.WriteLine("Ingrese el primer número entero");
       int num1=Convert.ToInt32(Console.ReadLine());
       
        Console.WriteLine("Ingrese el primer número entero");
       int num2=Convert.ToInt32(Console.ReadLine());
       
       resultado=(num1+num2)*constante;
       
       Console.WriteLine("El resultado es: "+ resultado);
    }
}



//Ejercicio 3

manera larga
int a;
int b;
string linea;

Console.WriteLine("Ingresar dos valores enteros");

Console.WriteLine("Ingresar el valor a");
linea=Console.ReadLine();
 =int.Parse(linea);

Console.WriteLine("Ingrresar el valor a");
linea=Console.ReadLine();
b=int.Parse(linea);

if (a > b)
{
    Console.WriteLine("El valor a es mayor que b");
}


manera medianamente larga
int a, b;

Console.WriteLine("Ingrese dos valores en números enteros");

Console.Write("Ingresae el valor de a:");
a=int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor de b");
b=int.Parse(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("El valor de a es mayor b");
}

Manera corta


Console.WriteLine("Ingrese un número entero");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese otro número entero");
int b= Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("El valor b es mayor que a:"+a);
}

Manera medianamente corto/lo hice yo solo.
int num1, num2;

Console.WriteLine("Ingresar un número entero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro número entero");
num2 = int.Parse(Console.ReadLine());
if (num1>num2) 
{
    Console.WriteLine("El nuémero mayor es: " + num1);
}

Mi trabajo
Console.WriteLine("Ingrese su edad");
int edad= Convert.ToInt32(Console.ReadLine());
int t, P;
t = (18000*25)/100; P = (18000-t);
if (edad<18)
{
    Console.WriteLine("Tienes que pagar: " + P);
}
else
{
    Console.WriteLine("Debe pagar 18000");
}

Trabajo de el profe

int edad;
int total;
int descuento;

Console.WriteLine("Ingrese su edad");
edad=int.Parse(Console.ReadLine());

if(edad<18)
{
    descuento=(18000*25)/100;
    total=(18000-descuento);
    Console.WriteLine("El valor a pagar es " + total);
}

Console.WriteLine("Ingrese el numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el numero");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Los números ingresados son:")
Console.WriteLine(num1);
Console.WriteLine(num2);

int suma, pro;

Console.WriteLine("Ingrese un número entero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un número entero");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un número entero");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un número entero");
int num4 = int.Parse(Console.ReadLine());

suma= (num1 + num2);
Console.WriteLine("La suma de los dos primeros números son: " + suma);

pro = (num3 * num4);
Console.WriteLine("El producto de los dos ultimos numeros es: " + pro);

Console.WriteLine("Ingresar un número entero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar un número entero");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("El número mayor es " + num1);
}
else
{
    Console.WriteLine("El número menor es: " + num2);
}

Console.WriteLine("Ingrese su edad");
int edad = int.Parse(Console.ReadLine());
if (edad < 18)
{
    Console.WriteLine("Eres menor de edad ");
}
else
{
    Console.WriteLine("Eres mayor de edad");
}

Console.WriteLine("Ingrese un número entero");
int NUM1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro número entero");
int NUM2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese de nuevo otro número");
int NUM3 = int.Parse(Console.ReadLine());

if (NUM1 > NUM2 / NUM3 )
{
    Console.WriteLine("El número mayor es " + NUM1);
}
if (NUM2 > NUM1 / NUM3)
{
    Console.WriteLine("El número mayor es: " + NUM2);
}
if (NUM3 > NUM1 / NUM2)
{
    Console.WriteLine("El número mayor es: " + NUM3);
}

int num1;
int num2;
int num3;
int pro;
string linea;

Console.WriteLine("Ingrese la primera nota");
linea = Console.ReadLine();
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la segunda nota");
num2 = int.Parse(Console.ReadLine());
linea = Console.ReadLine();
Console.WriteLine("Ingrese el tercer nota");
num3 = int.Parse(Console.ReadLine());
linea = Console.ReadLine();

pro = (num1 + num2 + num3)/3;

if (pro > 3)
{
    Console.WriteLine("Aprovaste");
}
else
{
    Console.WriteLine("Reprobaste");
}



int numero;
        
Console.WriteLine("Ingresa el numero: ");

if (numero%2==0)
{
    Console.Write("El numero que ingreso es par");
}
else
{
    Console.Write("El numero que ingreso es impar");
}

int dia, mes, año;
string linea;

Console.WriteLine("Ingrese el día");
linea = (Console.ReadLine());
dia = int.Parse(linea);

Console.WriteLine("Ingrese el mes");
linea = (Console.ReadLine());
mes = int.Parse(linea);

Console.WriteLine("Ingrese el año");
linea = (Console.ReadLine());
año = int.Parse(linea);

if (mes==1 || mes==2 || mes==3)
{
    Console.WriteLine("Esta en el primer trimestre");
}
Console.ReadKey();

int num1, num2, num3, mayor, Mayor, mayoR;

Console.WriteLine("Ingrese un número");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un número");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un número");
num3 = int.Parse(Console.ReadLine());

mayor = num1;
if (mayor > num2)
if (mayor > num3)

Console.WriteLine("El número mayor es: " + mayor);

Mayor = num2;
if (Mayor > num1)
if (Mayor > num3)

Console.WriteLine("El número mayor es: " + Mayor);

mayoR = num3;
if (mayoR > num1)
if (mayoR > num2)

Console.WriteLine("El número mayor es: " + mayoR);

Console.ReadKey();

int edad;
Console.WriteLine("Ingrese su edad");
edad=Convert.ToInt32(Console.ReadLine());
if(edad>=18)
{
    Console.WriteLine("Adulto");

}
else if(edad<=12)
{
    Console.WriteLine("Adolecente");
}
else
{
    Console.WriteLine("Niño");
}

Console.WriteLine("Ingrese un número");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer número");
int n3= int.Parse(Console.ReadLine());

if(n1>n2 && n1>n3)
{
    Console.WriteLine("El número mayor es: " + n1);
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine("El número mayor es: " + n2);
}
else
{
    Console.WriteLine("El número mayor es: " + n3);
}

Console.WriteLine("Ingrese un número");
int n1 = int.Parse(Console.ReadLine());

if (n1<10)
{
    Console.WriteLine("El número es de tres cifras");
}
else if (n1>9 && n1<100)
{
    Console.WriteLine("El número es de 2 cifras");
}
else
{
    Console.WriteLine("El número es de tres cifras");
}

string dia;
Console.WriteLine("Ingrese el día de la semana sabiendo que el lunes es el día 1 y el domingo es el día 7");
dia = Console.ReadLine();
switch(dia)
{
    case "1":
    Console.WriteLine("Lunes");
    break;

    case "2":
    Console.WriteLine("Martes");
    break;

    case "3":
    Console.WriteLine("Miercoles");
    break;

    case "4":
    Console.WriteLine("Jueves");
    break;

    case "5":
    Console.WriteLine("Viernes");
    break;

    case "6":
    Console.WriteLine("Sabado");
    break;

    case "7":
    Console.WriteLine("Domingo");
    break;

    default:
    Console.WriteLine("ERROR");
    break;
}

int dia;
Console.WriteLine("Ingresar el día de la semana");
dia = int.Parse(Console.ReadLine());

switch(dia)

{
    case 1:
    Console.WriteLine("Lunes");
    break;

    case 2:
    Console.WriteLine("Martes");
    break;

    case 3:
    Console.WriteLine("Miercoles");
    break;

    case 4:
    Console.WriteLine("Jueves");
    break;

    case 5:
    Console.WriteLine("Viernes");
    break;

    case 6:
    Console.WriteLine("Sabado");
    break;

    case 7:
    Console.WriteLine("Domingo");
    break;

    default:
    Console.WriteLine("ERROR!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
    break;
}

Console.WriteLine("Ingresar la calificación");
int n1 = int.Parse(Console.ReadLine());

switch(n1)

{
    case 1:
    Console.WriteLine("Deficiente");
    break;
    case 2:
    Console.WriteLine("Malo");
    break;
    case 3:
    Console.WriteLine("Regular");
    break;
    case 4:
    Console.WriteLine("Buena");
    break;
    case 5:
    Console.WriteLine("Exelente");
    break;
    default:
    Console.WriteLine("ERROR, Debes de calificar un número entre 1 y 5");
    break;
}

using System;
public class ejercicio
{
    public static int par(int a)
    {
        int num;
        num=(a%2);
        if(num==0)
        {
            Console.WriteLine("\nPar");
        }
        else
        {
            Console.WriteLine("\nimpar");
        }
        return num;
    }
    public static void Main()
    {
        Console.WriteLine("Ingrese un número entero");
        int numero=int.Parse(Console.ReadLine());
        par(numero);
        Console.Write("\n");
    }
}

using System;
public class Funsiones 
{
    public static int Mayor(int n1, int n2)
    {
        int num;
        if(n1>n2)
        {
            num=n1;
            Console.WriteLine(n1 + " Es mayor a" + n2);
        }
        else
        {
            num=n2;
            Console.WriteLine(n2 + " Es mayor a " + n1);
        }
        return num;
    }
    public static void Main()
    {
        Console.WriteLine("Ingrese dos números tipo entero");

        Console.WriteLine("Ingresar el primer número entero");
        int nu1=int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar el segundo número entero");
        int nu2=int.Parse(Console.ReadLine());

        Console.WriteLine(Mayor(nu1, nu2));
    }
}

using System;
public class Funsiones 
{
    public static int suma(int n1, int n2)
    {
        int num;
        num=(n1+n2);
        return num;
    }
    public static void Main()
    {
        Console.WriteLine("Ingrese dos números para sumarlos");

        Console.WriteLine("Ingrese el primer número");
        int nu1=int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número");
        int nu2=int.Parse(Console.ReadLine());

        Console.WriteLine(suma(nu1,nu2));
    }
}

using System;
public class Write
{
   public static void Main()
   {
    int num;
    num=1;
    while(num<100);
    {
        Console.Write(num);
        Console.Write(" - ");
        num=num+1;
    }
   }
}

using System;
public class Write
{
    public static void Main()
    {
        int i=0;
        while(i<6)
        {
            Console.WriteLine(i);
            Console.Write(" . ");
            i++;
        }
    }
}

using System;
public class Write
{
    public static void Main()
    {
        int num;
        num=100;
        while(num>=0)
        {
            Console.Write(num);
            Console.Write(" . ");
            num--;
        }
    }
}

using System;
public class Write
{
    public static void Main()
    {

        int num=11;
        while(num<=250);
        {
            Console.Write(num);
            Console.Write(" - ");
            num++;
        }
    }
}