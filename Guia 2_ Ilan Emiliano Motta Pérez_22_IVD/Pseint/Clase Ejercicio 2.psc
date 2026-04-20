Algoritmo Ejercicio2
	Definir uno,dos,opc,result Como Entero
	Definir mens Como Caracter
	Escribir Sin Saltar "Ingresa numero 1 y numero 2:"
	Leer uno 
	Leer dos
	Escribir "****************************************************"
	Escribir"Menu Principal"
	Escribir"1-suma"
	Escribir"2-resta"
	Escribir"3-multiplicacion"
	Escribir"4-divicion"
	Escribir"Salir"
	Escribir Sin Saltar "Ingresa el numero segun su operacion:"
	Leer opc
	Segun opc Hacer
		1:
			mens="El resultado de la suma es: "
			result=uno+dos
		2:
			mens="El resultado de la resta es: "
			result=uno-dos
		3:
			mens="El resultado de la multiplicacion es: "
			result=uno*dos
		4:
			mens="El resultado de la division es: "
			result=uno/dos
		5:
			mens="Saliendo del sistema: "
			
		De Otro Modo:
			mens="Seleccione una opcion valida "
			
	Fin Segun
	Escribir mens
	Escribir result
FinAlgoritmo
