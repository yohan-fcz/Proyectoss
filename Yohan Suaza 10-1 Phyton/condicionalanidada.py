NOTA1= float(input('Ingresar la nota de la asignatura'))
NOTA2= float(input('Ingresar la nota de la asignatura'))
NOTA3= float(input('Ingresar la nota de la asignatura'))
SUMA= NOTA1+NOTA2+NOTA3
PRO= SUMA/3
if PRO <= 3.5:
    print ('Basico')
elif 3.5 >= 4.5: 
    print ('Alto')
elif 4.5 >= 5.0 or PRO <=5.0:
    print ('Superior')
