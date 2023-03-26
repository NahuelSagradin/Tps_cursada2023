using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Genericos<T>
    {
        // La programacion generica nos facilita la reutilizacion de codigo,
        // consiste en crear una clase comodin que me permita crear objetos
        // de distintos tipos (int, String, etc). Por tal motivo nos brinda
        // la opcion de trabajar con un codigo mas sencillo a la vez que la
        // comprobacion de errores se realiza en tiempo de compilacion!

        // Esto lo conseguimos al momento de instanciar dicha clase, a
        // continuacion del nombre de la clase entre parentesis angulares
        // colocamos el tipo de objeto que vamos a manejar como parametro.

        // EjemploGenerico <Tipo> xObjeto = new EjemploGenerico<Tipo>();

        private T[] datosElemento;
        private int i = 0;

        public Genericos(int indice) {
            datosElemento = new T[indice];
        }

        public void agregar(T obj) {
            datosElemento[i] = obj;
            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];
        }

        public T[] getDatosElemento() => datosElemento;


    }
}
