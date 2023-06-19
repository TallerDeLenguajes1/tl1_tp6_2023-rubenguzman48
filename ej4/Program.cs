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

int operaciones;
float num1;
float num2;
float resultado;

string num1s;
string num2s;
string resultados;

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
    Console.WriteLine("Concateno las dos cadenas: "+concatenada);

    //Separo la cadena en partes
    palabras = cadena1.Split(' ');
    Console.WriteLine("Separo la cadena en partes: ");
    foreach (string palabra in palabras)
    {
        Console.WriteLine(palabra);
    }


    //Aqui agrego la calculadora
    Console.WriteLine("Seleccione una opcion: ");
    Console.WriteLine("1- Suma");
    Console.WriteLine("2- Resta");
    Console.WriteLine("3- Multiplicacion");
    Console.WriteLine("4- Division");


    operaciones = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nIngrese el primer numero: ");
    num1 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("\nIngrese el segundo: ");
    num2 = Convert.ToSingle(Console.ReadLine());

    funcOperaciones(operaciones, num1, num2);

    //Busco una frase
    string frase;
    string palaBusca = "hola";

    Console.WriteLine("En el siguiente ejercicio vamos a controlar si en la frase que ingrese por pantalla se encuentra la palabra 'hola'.");
    Console.WriteLine("Ingrese una frase: ");
    frase = Console.ReadLine();

    if (frase != null)
    {
        //Recorro la frase con foreach
        Console.WriteLine("Primero muestro palabra por palabra la cadena ingresada: ");
        foreach (char f in frase) {
        Console.WriteLine(f);
}
        if (frase.Contains(palaBusca))
        {
            Console.WriteLine("La palabra "+palaBusca+" SI fue encontrada en la frase");
        }else
        {
            Console.WriteLine("La palabra "+palaBusca+" NO fue encontrada en la frase");
        }

        //Imprimo la frase en mayuscula y luego en minuscula
        string cadenaMayuscula = frase.ToUpper();
        string cadenaMinuscula = frase.ToLower();

        Console.WriteLine("Cadena '"+frase+"' en Mayusculas: "+cadenaMayuscula);
        Console.WriteLine("Cadena '"+frase+"' en Minusculas: "+cadenaMinuscula);
    }

    //Aqui vamos a separar con un simbolo y hacer el calculo
    Console.WriteLine("Ingrese dos numeros separados por el simbolo '+' para la suma, '-' para la resta, '*' para la multiplicacion y '/' para la division: ");
    string cadenaJunta = Console.ReadLine();
    string[] cadenaSeparada;

    if(cadenaJunta != null)
    {
        bool metodo1 = cadenaJunta.Contains('+');
        bool metodo2 = cadenaJunta.Contains('-');
        bool metodo3 = cadenaJunta.Contains('*');
        bool metodo4 = cadenaJunta.Contains('/');

        if(metodo1 == true)
        {
            cadenaSeparada = cadenaJunta.Split('+');
            Console.Write(cadenaSeparada[0]);
            Console.Write(cadenaSeparada[1]);
            num1 =Convert.ToSingle(cadenaSeparada[0]);
            num2 =Convert.ToSingle(cadenaSeparada[1]);
            operaciones = 1;

            //Console.WriteLine("num1: "+num1+", num2: "+num2+", operaciones: "+operaciones);
            funcOperaciones(operaciones, num1, num2);

        }else
            if(metodo2 == true)
            {
                cadenaSeparada = cadenaJunta.Split('-');
                num1 =Convert.ToSingle(cadenaSeparada[0]);
                num2 =Convert.ToSingle(cadenaSeparada[1]);
                operaciones = 2;

                funcOperaciones(operaciones, num1, num2);
            }else
                if (metodo3 == true)
                {
                    cadenaSeparada = cadenaJunta.Split('*');
                    num1 =Convert.ToSingle(cadenaSeparada[0]);
                    num2 =Convert.ToSingle(cadenaSeparada[1]);
                    operaciones = 3;

                    funcOperaciones(operaciones, num1, num2);
                }else
                    if (metodo4)
                    {
                        cadenaSeparada = cadenaJunta.Split('/');
                        num1 =Convert.ToSingle(cadenaSeparada[0]);
                        num2 =Convert.ToSingle(cadenaSeparada[1]);
                        operaciones = 4;

                        funcOperaciones(operaciones, num1, num2);
                    }
        

     //   string[] cadenaSeparada = cadenaJunta.Split('');


    }else
    {
        Console.WriteLine("La cadena ingresada es nula. No se puede seguir.");
    }



}else
{
    Console.WriteLine("No se admiten cadenas tipo null, intente de nuevo1!");
}





void funcOperaciones(int operaciones, float num1, float num2)
{
    switch (operaciones)
    {
        case 1:
            resultado = num1 + num2; 
            //int[] numString = new int[] {num1, num2, resultado};
            num1s = num1.ToString();
            num2s = num2.ToString();
            resultados =  resultado.ToString();
            Console.WriteLine("\nEl resultado de sumar {0} con {1} da como resultado {2} ",num1s,num2s,resultados);
            break;

        case 2:
            resultado = num1 - num2; 
            num1s = num1.ToString();
            num2s = num2.ToString();
            resultados =  resultado.ToString();
            Console.WriteLine("\nEl resultado de restar {0} con {1} da como resultado {2} ",num1,num2,resultado);
            break;

        case 3:
            resultado = num1 * num2; 
            num1s = num1.ToString();
            num2s = num2.ToString();
            resultados =  resultado.ToString();
            Console.WriteLine("\nEl resultado de multiplicar {0} con {1} da como resultado {2} ",num1,num2,resultado);
            break;

        case 4:
            resultado = num1 / num2; 
            num1s = num1.ToString();
            num2s = num2.ToString();
            resultados =  resultado.ToString();
            Console.WriteLine("\nEl resultado de dividir {0} con {1} da como resultado {2} ",num1,num2,resultado);
            break;

        default:
            Console.WriteLine("No entro!");
            break;
    }
}





/*string convertString(int resultado, int num1, int num2)
{
    string num1s = num1.ToString();
    string num2s = num2.ToString();
    string resultados =  resultado.ToString();
    
    return resultados + num1s + num2s;
}
*/


