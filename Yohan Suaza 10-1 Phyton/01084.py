P = int(input('Ingrese la cantidad de preguntas correctas'))
R = (P * 9)
if (R <= 90):
    print ('Su puntaje es maximo')
elif (R >= 75):
    print ('Su8 puntaje es medio')
elif (R >= 50) and (R < 75):
    print ('Su puntaje es regulas')
else:
    print ('Beca negada')
