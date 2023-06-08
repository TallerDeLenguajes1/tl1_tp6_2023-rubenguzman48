// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de b: "+b);

    int num; 
    string numero;
    bool numValido;

do
{
    Console.WriteLine("Ingrese un número:");
    numero = Console.ReadLine();

    Console.WriteLine("El numero ingresado es: "+numero);
    numValido = int.TryParse(numero, out num);

    Console.WriteLine("Valor de 'numValido'"+numValido);
    
    if(numValido == false)
    {
        Console.WriteLine("Dato no Valido!, ingrese nuevamente");
    }else
    {
        if(num <= 0)
        {
            Console.WriteLine("Vuela a intentarlo! debe ingresar un numero positivo");
        }
        numInvert(num);
    }


}
while(numValido == false);


void numInvert(int num)
{
    int aux;
    if(num < 10)
    {
        Console.WriteLine("Valor invertido: "+num);
    }else
    {
        Console.Write("Valor invertido: ");
        while(num != 0)
        {
            aux = num % 10;
            num /= 10;
            Console.Write(aux);
        }
        Console.Write("\n");
    }
}



    //Console.WriteLine("La variable numero es un "+numero.GetType());

   
