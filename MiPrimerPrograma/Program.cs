//1ro definir el nombre de mi clase con su respectivo metodo main
public class MiPrimerPrograma
{   
    static void Main(string[] args)
    {   // Ingresar por pantalla 2 numeros y calcular las 4 operaciones artimeticas con dichos numeros.Imprimir en pantalla el resultado de cada operacion.

        //1 definir el nombre de mi clase con su respectivo metodo main

        //2do Declaracion de mis variables (datos de entrada)

        int num1, num2, suma, resta, producto, cociente;

        //3ro Pedir los valores por consola

        Console.Write("Ingrese su primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        //4to Cálculos (Procesos)

        suma = num1 + num2;
        resta = num1 - num2;
        producto = num1 * num2;
        cociente = num1 / num2;

        //5to Imprimir los resultados (Datos de salida)
        Console.Write("la suma es: " + suma );
        Console.Write("\n");
        Console.Write("la resta es: " + resta );
        Console.Write("\n");
        Console.Write("El producto es: " + producto );
        Console.Write("\n");
        Console.Write("El cociente es: " + cociente );



    }


}


    