/*Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes
tarea:
● Obtener la longitud de la cadena y muestre por pantalla.
● A partir de una segunda cadena ingresada por el usuario, concatene ambas
cadenas distintas.
● Extraer una subcadena de la cadena ingresada.
● Utilizando la calculadora creada anteriormente realizar las operaciones de dos
números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para
la suma sería:
“la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
Donde num1, num2 y resultados son los sumandos y el resultado de la operación
respectivamente.
Nota: Busque el comportamiento del Método ToString();
● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por
elemento en pantalla
● Buscar la ocurrencia de una palabra determinada en la cadena ingresada
● Convierta la cadena a mayúsculas y luego a minúsculas.
● Ingrese una cadena separada por caracteres que usted determine y muestre por
pantalla los resultados (Revisar el comportamiento de split())
● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
por pantalla “582+2” y que le devuelva la suma de 582 con 2*/

string cadena1;
int longitud;
string cadena2;
string concatenada;
string[] palabras;

Console.WriteLine("Escribe una cadena de caracteres: ");
cadena1 = Console.ReadLine();

if (cadena1 != null)
{
    //Calculo la cantidad de cadenas
    longitud = cadena1.Length;
    Console.WriteLine("La longitud de la cadena es: " + longitud);

    //Aqui pido una nueva cadena
    Console.WriteLine("Escribe otra cadena de caracteres: ");
    cadena2 = Console.ReadLine();

    //Aqui concateno ambas cadenas
    concatenada = String.Concat(cadena1, " ", cadena2);
    Console.WriteLine(concatenada);

    //Separo la cadena en partes
    palabras = cadena1.Split(' ');
    foreach (string palabra in palabras)
    {
        Console.WriteLine(palabra);
    }
}
else
{
    Console.WriteLine("La cadena ingresada es nula. No se puede seguir.");
}
