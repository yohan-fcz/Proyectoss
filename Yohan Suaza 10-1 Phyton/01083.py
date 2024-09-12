NUM = int(input('Ingresar un número entero'))
if (NUM>0) and (NUM<10):
    print ('El número es de 1 cifra')
elif (NUM>10) and (NUM<99):
    print ('El número es de 2 cifras')
elif (NUM>99) and (NUM<1000):
    print ('El número es de 4 cifras')
else:
    print ('ERROR, el número tiene más de tres cifras')
