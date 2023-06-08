/*Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las 
mejoras en la calculadora.. Solicite al usuario un número y muestre 
por pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.
Luego de esto, solicite dos números al usuario y determine:
● El Máximo entre los dos números
● El Mínimo entre los dos números
*/

double num;
double valorAbs;
double cuadrado;
double seno;
double coseno;
int parteEntera;
double num1;
double num2;


Console.WriteLine("Ingrese un numero: ");
num = Convert.ToDouble(Console.ReadLine());


//Valor absoluto
if(num <= 0)
{
    valorAbs = -num;
    Console.WriteLine("El valor absoluto del numero es: "+valorAbs);
}else
{
    valorAbs = num;
    Console.WriteLine("El valor absoluto del numero es: "+valorAbs);
}

//Cuadrado
cuadrado = num * num;
Console.WriteLine("El cuadrado del numero es: "+cuadrado);

//seno y coseno
seno = Math.Sin(num);
Console.WriteLine("El seno del numero es: "+seno);

coseno = Math.Cos(num);
Console.WriteLine("El coseno del numero es: "+coseno);

//Mostrar parte entera de float
parteEntera = (int)num;
Console.WriteLine("La parte entera es: "+parteEntera);

//Pido dos numero por pantalla
Console.WriteLine("Ingrese el primer numero: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
num2 = Convert.ToDouble(Console.ReadLine());

if(num1 < num2)
{
    Console.WriteLine("El numero mas grande es: "+num2);
    Console.WriteLine("El numero mas bajo es: "+num1);
}else
{
    if(num1 > num2)
    {
        Console.WriteLine("El numero mas grande es: "+num1);
        Console.WriteLine("El numero mas bajo es: "+num2);
    }else
    {
        Console.WriteLine("Los dos numeros son iguales");
    }
}
