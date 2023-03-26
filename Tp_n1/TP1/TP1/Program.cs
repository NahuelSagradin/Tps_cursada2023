
using TP1;

Genericos<String> cadena = new Genericos<string>(4);

cadena.agregar("Carlos");
cadena.agregar("Jorge");
cadena.agregar("Diego");
cadena.agregar("Braian");

for (int i = 0; i < cadena.getDatosElemento().Length; i++)
{
    Console.WriteLine(cadena.getElemento(i));
}

