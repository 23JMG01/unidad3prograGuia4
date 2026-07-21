Inicio
    Escribir "Ingrese la cantidad en metros:"
    Leer metros
    Escribir "Seleccione la unidad a convertir (a. Milímetros, b. Centímetros, c. Decímetros, d. Hectómetros, e. Kilómetros):"
    Leer opcion
    Según opcion Hacer
        'a': resultado = metros * 1000; unidad = "milímetros"
        'b': resultado = metros * 100; unidad = "centímetros"
        'c': resultado = metros * 10; unidad = "decímetros"
        'd': resultado = metros / 100; unidad = "hectómetros"
        'e': resultado = metros / 1000; unidad = "kilómetros"
        De Otro Modo: Escribir "Opción inválida"
    FinSegún
    Escribir metros, " metros equivale a ", resultado, " ", unidad
Fin
