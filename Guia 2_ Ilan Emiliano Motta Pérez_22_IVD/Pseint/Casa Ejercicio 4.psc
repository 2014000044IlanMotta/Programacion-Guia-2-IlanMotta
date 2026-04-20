Proceso Ejercicio4
    Definir med, des Como Entero
    Definir valor, resultado, metros Como Real
    
    Escribir "Seleccione unidad de Medida:"
    Escribir "1-Metros"
    Escribir "2-Pies"
    Escribir "3-Centímetros"
    Escribir "4-Pulgadas"
    Leer med
    
    Escribir "Ingrese el valor:"
    Leer valor
    
    Segun med Hacer
        1: metros = valor
        2: metros = valor / 3.28
        3: metros = valor / 100
        4: metros = valor / 39.37
    FinSegun
    
    Escribir "Seleccione unidad final:"
    Escribir "1. Metros"
    Escribir "2. Pies"
    Escribir "3. Centímetros"
    Escribir "4. Pulgadas"
    Leer des

    Segun des Hacer
        1: resultado = metros
        2: resultado = metros * 3.28
        3: resultado = metros * 100
        4: resultado = metros * 39.37
    FinSegun
    
    Escribir "Resultado: ", resultado
FinProceso