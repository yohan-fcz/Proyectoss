#Ejercicio 1.
NOM = "Yohan Felipe Suaza Cano"
EDAD = 17
GRADO = "Once"
E = 1.72
print("Nombre:", NOM)
print("Edad:", EDAD)
print("Grado:", GRADO)
print("Estatura:", E)

#Ejercicio 2.
E1 = int(input("Ingresa un número entero: "))
E2 = int(input("Ingresa otro número entero: "))
F1 = float(input("Ingresa un número decimal (float): "))
F2 = float(input("Ingresa otro número decimal (float): "))
F3 = float(input("Ingresa un tercer número decimal (float): "))
TEXTO = input ("Ingresa un texto: ")
SUMA = E1 + E2 + F1
RESTA = F2 - E1
print("Resultados:")
print("Suma de dos enteros y un float:", SUMA)
print("Resta de un float y un entero:", RESTA)

#Ejercicio 3.
TEXTO1 = input("Ingresar el primer texto: ")
TExTO2 = input("Ingresar el segundo texto: ")
print(f"Has ingresado las variables de texto: "{TEXTO1}" y "{TEXTO2}"")

#Ejercicio 4.
Nombre_de_usuario = input("Ingresa tu nombre: ")
Nombre_de_madre = input("Ingresa el nombre de tu madre: ")
TEXTO = input("Ingresa un nombre para verificar su pertenencia: ")
if TEXTO in Nombre_de_usuario:
    print(f""{TEXTO}" pertenece al nombre del usuario.")
    else:
        print(f""{TEXTO}" no pertenece al nombre del usuario.")
    if TEXTO in Nombre_de_madre:
        print(f""{TEXTO}" pertenece al nombre de la madre.")
    else:
        print(f""{TEXTO}" no pertenece al nombre de la madre.")










