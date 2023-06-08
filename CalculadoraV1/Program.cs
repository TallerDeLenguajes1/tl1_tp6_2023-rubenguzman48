/*Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/
Console.WriteLine("Hello, World!");

int operaciones;
int num1;
int num2;
int resultado;

Console.WriteLine("Seleccione una opcion: ");
Console.WriteLine("1- Suma");
Console.WriteLine("2- Resta");
Console.WriteLine("3- Multiplicacion");
Console.WriteLine("4- Division");


operaciones = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngrese el primer numero: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngrese el segundo: ");
num2 = Convert.ToInt32(Console.ReadLine());

funcOperaciones(operaciones, num1, num2);



void funcOperaciones(int operaciones, int num1, int num2)
{
    switch (operaciones)
    {
        case 1:
            resultado = num1 + num2; 
            Console.WriteLine("\nEl resultado de la suma es: "+resultado);
            break;

        case 2:
            resultado = num1 - num2; 
            Console.WriteLine("\nEl resultado de la resta es: "+resultado);
            break;

        case 3:
            resultado = num1 * num2; 
            Console.WriteLine("\nEl resultado de la multiplicacion es: "+resultado);
            break;

        case 4:
            resultado = num1 / num2; 
            Console.WriteLine("\nEl resultado de la division es: "+resultado);
            break;

        default:
            break;
    }
}