        // ---------- Encabezado con el planteamiento del problema ----------
        Console.WriteLine("===================================================");
        Console.WriteLine(" EJERCICIO 3: Simulacion de carga de bateria (12.6 V)");
        Console.WriteLine(" Se ingresa voltaje inicial e incremento por ciclo.");
        Console.WriteLine(" Un ciclo while aumenta el voltaje hasta 12.6 V.");
        Console.WriteLine(" Si el incremento es <= 0, se muestra un error.");
        Console.WriteLine("===================================================\n");

        // ---------- Declaracion de variables ----------
        const double VOLTAJE_OBJETIVO = 12.6; // Voltaje meta de la bateria (V)
        double voltajeInicial;                 // Voltaje inicial ingresado (V)
        double incremento;                     // Incremento de voltaje por ciclo (V)
        double voltajeActual;                  // Voltaje actual durante la simulacion (V)
        int ciclo = 0;                          // Contador de ciclos de carga

        // ---------- Entrada de datos ----------
        Console.Write("Ingrese el voltaje inicial de la bateria (V): ");
        voltajeInicial = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el incremento de voltaje por ciclo (V): ");
        incremento = Convert.ToDouble(Console.ReadLine());

        // ---------- Proceso ----------
        if (incremento <= 0)
        {
            // Validacion del incremento
            Console.WriteLine("\nERROR: El incremento debe ser mayor que cero.");
            Console.WriteLine("No se ejecutara la simulacion.");
        }
        else
        {
            voltajeActual = voltajeInicial;

            while (voltajeActual < VOLTAJE_OBJETIVO)
            {
                ciclo++;
                voltajeActual += incremento;

                // Evitar que el voltaje muestre un valor mayor al objetivo
                if (voltajeActual > VOLTAJE_OBJETIVO)
                {
                    voltajeActual = VOLTAJE_OBJETIVO;
                }

                Console.WriteLine($"Ciclo {ciclo}: Voltaje actual = {voltajeActual:F2} V");
            }

            Console.WriteLine("\nLa bateria alcanzo el voltaje objetivo de 12.6 V.");
        }

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();