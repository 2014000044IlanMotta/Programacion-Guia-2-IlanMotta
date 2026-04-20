Proceso Trigonometria
    Definir radian Como Real
    Definir ops, a Como Entero
    Escribir "Ingrese el ángulo:"
    Leer a
    
    radian = a * PI / 180
    Escribir " CALCULADORA FUNCIONES TRIGONOMETRICAS "
    Escribir "*************************************"
	Escribir "Lista de Funciones Trigonometricas:"
    Escribir "1-Seno"
    Escribir "2-Coseno"
    Escribir "3-Tangente"
	Escribir "*************************************"
    Leer ops
    
    Segun ops Hacer
        1:
            Escribir "Seno: ", Sen(rad)
        2:
            Escribir "Coseno: ", Cos(rad)
        3:
            Escribir "Tangente: ", Tan(rad)
        De Otro Modo:
            Escribir "Opción inválida"
    FinSegun
FinProceso