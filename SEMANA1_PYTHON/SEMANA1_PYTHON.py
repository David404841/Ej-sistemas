def ejer1():
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido al curso de fudamentos de algoritmo de la carrera {carrera}")

def ejer2():
    print("\"Yordan\"")

def ejer3():
    num1 = int(input("Ingrese número 1: "))
    num2 = int(input("Ingrese número 2: "))

    print("Suma: ", (num1+num2))
    print("Resta: ", (num1-num2))
    print("Multiplicación: ", (num1*num2))
    print("Dvisión: ", (num1/num2))

def ejer4():
    num = float (input("Ingrese numero decimal:"))
    raiz = math.sqrt (num)
    redo = round (num ,2)
    cubo = math.pow (num , 3)
    cubico =num ** (1/3)
    print("Raiz cuadrada:" ,raiz)
    print("Redondead:" ,redo)
    print("Al cubo:" ,dubo)
    print("Cubica:" ,cubico)

ejer4()