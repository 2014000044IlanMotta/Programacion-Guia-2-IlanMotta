Proceso Ejercico5
    Definir cant, opc Como Entero
    Definir precio, total, descuento, totalFinal Como Real
    
    precio = 650 * 1.12
    
    Escribir "Ingrese cantidad de impresoras(650):"
    Leer cantidad
    
    Escribir "Forma de pago:"
    Escribir "1. Efectivo (10%)"
    Escribir "2. Tarjeta (5%)"
    Escribir "3. Vale (15%)"
    Leer opcion
    
    total = cantidad * precio
    
    Segun opcion Hacer
        1: descuento = total * 0.10
        2: descuento = total * 0.05
        3: descuento = total * 0.15
        De Otro Modo:
            descuento = 0
    FinSegun
    
    totalFinal = total - descuento
    
    Escribir "Cantidad: ", cantidad
    Escribir "Precio unitario con IVA: Q", precio
    Escribir "Total sin descuento: Q", total
    Escribir "Descuento: Q", descuento
    Escribir "Total a pagar: Q", totalFinal
FinProceso