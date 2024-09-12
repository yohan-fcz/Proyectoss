def EPSs():
    print("Seleccione su EPS")
    print("1. SURA")
    print("2. Salud total")
    print("3. Sumi medica")
    print("4. Otras...")
    Otra = input("Ingrese el número 4 para otra EPS")
    if Otra == "4":
        input("Ingrese el nombre de la eps")
    elif Otra == "1":
        return EPSs
    elif Otra == "2":
        return EPSs
    elif Otra == "3":
        return EPSs
    else:
        print("El número ingresado es invalido")
        return EPSs()
EPSs()
input("Ingrese su nombre completo")
input("Ingrese su documento de identidad")

def Opciones_de_citas():
    print("Opciones de citas:")
    print("1.Solicitar cita prioritaria")
    print("2.Solicitar toma de muestras")
    print("3.Solicitar resultados de muestras")
    print("4.Asignar cita de optometría")
    print("5.Finalizar proceso")
    opcion = input("Seleccione el servicio que requiere")
    if opcion == "1":
        from datetime import datetime, timedelta
        hora_actual = datetime.now()
        prioritaria = hora_actual + timedelta(hours=4)
        print("La cita a sido solicitada. La cita se le asignara este mismo día en 4 horas", prioritaria)
        confirmar=input("¿Aceptas la cita? Ingresa 1. para confirmar y 2. para rechazar")
        if confirmar == "1":
            print("Cita confirmada para el",prioritaria)
        elif confirmar == "2":
            print ("La cita a sido rechazada")
            return Opciones_de_citas()
        
        elif opcion == "2":
            from datetime import date
            hora_formateada = hora_actual.strftime("6:00")
            print("La toma de muestras sera para el", hora_formateada)
Opciones_de_citas()




    
