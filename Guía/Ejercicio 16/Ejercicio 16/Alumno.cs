using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{

    /* a.Se pide crear 3 instancias de la clase Alumno(3 objetos) en la función Main.Colocarle
        nombre, apellido y legajo a cada uno de ellos.
        b.Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
         c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
        iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
        el método de instancia Next de la clase Random.
         d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
        mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
        desaprobado".*/
    class Alumno
    {
        private int legajo;
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string nombre;
        private string apellido;

       public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar(byte nota1,byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public float CalcularFinal()
        {
            //int final = -1;
            this.notaFinal = -1;
            Random r = new Random();

            if(this.nota1>=4 && this.nota2>= 4)
            {
                //final = new Random();
                this.notaFinal = r.Next();
            }

            return this.notaFinal;
        }

        public string Mostrar()
        {
            string retorno = $"{this.nombre} {this.apellido} {this.legajo} {this.nota1} {this.nota2} ";
            if(this.notaFinal != -1)
            {
                retorno += notaFinal;
            }

            return retorno;
        }

    }
}
