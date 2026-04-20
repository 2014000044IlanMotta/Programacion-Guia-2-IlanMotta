Algoritmo Ejercicio1
	Definir opc Como Entero
	Definir result Como Caracter
	Escribir Sin Saltar "Ingresa un numero el 1 al 7:"
	Leer opc
	
	Segun opc Hacer
		1:
			mens="El dia de la semana es: "
			result="Lunes "
		2:
			mens="El dia de la semana es: "
			result="Martes "
		3:
			mens="El dia de la semana es: "
			result="Miercoles "
		4:
			mens="El dia de la semana es: "
			result="Jueves "
		5:
			mens="El dia de la semana es: "
			result="Viernes "
		6:
			mens="El dia de la semana es: "
			result="Sabado "
		7:
			mens="El dia de la semana es: "
			result="Domingo "	
		De Otro Modo:
			mens="Seleccione una opcion valida "
			
	Fin Segun
	Escribir mens
	Escribir result
FinAlgoritmo