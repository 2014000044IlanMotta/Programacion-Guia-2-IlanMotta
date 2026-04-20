Proceso Ejercicio3
    Definir opcion, cantidad Como Entero
    Definir precio, total Como Real
    
    Escribir "Seleccione el sector:"
    Escribir "1-Palco (Q300)"
    Escribir "2-Tribuna (Q125)"
    Escribir "3-Preferencia (Q75)"
    Escribir "4-General (Q50)"
    Leer opcion
    
    Escribir "Ingrese la cantidad de entradas:"
    Leer cantidad
    
    Segun opcion Hacer
        1: precio=300
        2: precio=125
        3: precio=75
        4: precio=50
        De Otro Modo:
            Escribir "Opción inválida"
    FinSegun
    
    total = precio * cantidad
    
    Escribir "Total a pagar: Q", total
FinProceso