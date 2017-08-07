using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
       // static void Main(string[] args)

        

            public class CongruencialMixto

        {
            //constante a
            public int a { get; set; }
            //constante c
            public int c { get; set; }
            //raiz x0
            public int x0 { get; set; }
            //constante m 
            public int m { get; set; }



            int [] numAleatorios ;




            //valida si se puede generar segun las variables ingresadas
            public  bool puedoGenerar()
            {

                    return a != 0 && c != 0 && m != 0 && m > x0 && m > a && m > c;
                
            }

            //genera 20 numero aleatorios s
            public void generar20()

            {
                for (int i = 0; i < 20; i++)
                {
                  numAleatorios.SetValue ((  x0 = ((a * x0) + c) % m),i);
                   
                }
            }
            //generera el sig numero aleatrorio
            public  int generarSiguiente()
            {
                return ((a * x0) + c) % m;
            }


            public override string ToString()
            {
                return string.Format("X₁ = (({0} ٠ {1}) + {3}) mod {2}", a, x0, m, c);
            }
        }

    

    }
    
}
