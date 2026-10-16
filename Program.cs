using System;

bool continuar = true;

// Estructura para que el usuario elija su opcion
while (continuar)
{
    Console.Clear();
    Console.WriteLine("==========================================");
    Console.WriteLine("            MENU PRINCIPAL          ");
    Console.WriteLine("==========================================");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Evaluar Estudiante (¿Aprobó o Reprobó?)");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opción (1-6): ");

    string opcion = Console.ReadLine();
    
    switch (opcion)
    {
        case "1":
            RealizarOperacion("Suma");
            break;
        case "2":
            RealizarOperacion("Resta");
            break;
        case "3":
            RealizarOperacion("Multiplicacion");
            break;
        case "4":
            RealizarOperacion("Division");
            break;
        case "5":
            EvaluarEstudiante();
            break;
        case "6":
            Console.WriteLine("OK ten un buen dia ");
            continuar = false;
            break;
        default:
            Console.WriteLine(" ¡¡¡Error!!! Por favor, elige otro número.");
            break;
    }

    if (continuar)
    {
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
    }
}

static void RealizarOperacion(string tipo)
{
    Console.WriteLine($"--- Operación: {tipo} ---");
    try
    {
        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        switch (tipo)
        {
            case "Suma":
                resultado = num1 + num2;
                break;
            case "Resta":
                resultado = num1 - num2;
                break;
            case "Multiplicacion":
                resultado = num1 * num2;
                break;
            case "Division":
                if (num2 == 0)
                {
                    Console.WriteLine("[Error] ¡No se puede dividir entre cero!");
                    return;
                }
                resultado = num1 / num2;
                break;
        }

        Console.WriteLine($"El resultado de la {tipo.ToLower()} es: {resultado}");
    }
    catch (FormatException)
    {
        Console.WriteLine("¡¡¡Error!!! Por favor, ingresar solo números.");
    }
}

static void EvaluarEstudiante()
{
    Console.WriteLine("--- Evaluación de Estudiante ---");
    try
    {
        Console.Write("Ingresa la calificación final (0 - 100): ");
        double calificacion = Convert.ToDouble(Console.ReadLine());

        if (calificacion < 0 || calificacion > 100)
        {
            Console.WriteLine("¡¡¡Error!!! La calificación debe estar en el rango de 0 a 100.");
            return;
        }

        if (calificacion >= 70)
        {
            Console.WriteLine($"Felicidades! Con {calificacion} puntos, el estudiante ha **APROBADO**.Suerte la proxima estudie mas que esta flojo");
        }
        else
        {
            Console.WriteLine($"Lo sentimos. Con {calificacion} puntos, el estudiante ha **REPROBADO**.Muy bien te mereces un chicle");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("¡¡¡Error!!! Por favor, ingresa un valor numérico para la calificación.");
    }
}