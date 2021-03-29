using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*b. Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo
retornarán el valor del mismo).*/
/*c. Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
i. tinta será el valor a agregar de tinta, pudiendo ser positivo (cargar tinta) o negativo
(gastar tinta)
ii. Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a
0 y menor o igual a cantidadTintaMaxima.*/
/*Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.*/

namespace BibliotecaBoligrafo
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta; 

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;//this.tinta = this.tinta + tinta;
            if(this.tinta < 0)
            {
                this.tinta = 0;
            }else if(this.tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;//aca hay que llamar a this.tintaMaxima o con poner tintaMaxima ya esta?
            }
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        /*f. El método Pintar(short, out string) restará la tinta gastada (reutilizar código SetTinta), sin
        poder quedar el nivel en negativo, avisando si pudo pintar (nivel de tinta mayor a 0).
        También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de
        tinta. O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es 10 "***". */
       public bool Pintar(short tintaGastada,out string gasto)
        {
            this.SetTinta(tintaGastada);
            gasto = " ";

            if(this.tinta < 0)
            {
                return false;
            }else
            {
                for(int i=0; i < tintaGastada; i++)
                {
                    gasto += "*";
                }
            }

            return true;
        }

        /*public bool Pintar(short gasto, out string dibujar)
        {
            SetTinta(gasto);
            dibujar = " ";
            if (this.tinta > 0)
            {
                for (int i = 0; i < gasto; i++)
                {
                    dibujar = dibujar.Insert(0, "*");
                }
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }

  
}
