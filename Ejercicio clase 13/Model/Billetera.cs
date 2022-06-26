using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase_13.Model
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            var total = BilletesDe10 * 10 +
                        BilletesDe20 * 20 +
                        BilletesDe50 * 50 +
                        BilletesDe100 * 100 +
                        BilletesDe200 * 200 +
                        BilletesDe500 * 500 +
                        BilletesDe1000 * 1000;
            return total;
        }

        public Billetera Combinar (Billetera segundaBilletera)
        {
            var nuevaBilletera = new Billetera();

            //COMBINAMOS LAS DOS BILLETERAS

            nuevaBilletera.BilletesDe10 = BilletesDe10 + segundaBilletera.BilletesDe10;
            nuevaBilletera.BilletesDe20 = BilletesDe20 + segundaBilletera.BilletesDe20;
            nuevaBilletera.BilletesDe50 = BilletesDe50 + segundaBilletera.BilletesDe50;
            nuevaBilletera.BilletesDe100 = BilletesDe100 + segundaBilletera.BilletesDe100;
            nuevaBilletera.BilletesDe200 = BilletesDe200 + segundaBilletera.BilletesDe200;
            nuevaBilletera.BilletesDe500 = BilletesDe500 + segundaBilletera.BilletesDe500;
            nuevaBilletera.BilletesDe1000 = BilletesDe1000 + segundaBilletera.BilletesDe1000;

            //VACIAMOS LA PRIMER BILLETERA

            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;

            //VACIAMOS LA SEGUNDA BILLETERA

            segundaBilletera.BilletesDe10 = 0;
            segundaBilletera.BilletesDe20 = 0;
            segundaBilletera.BilletesDe50 = 0;
            segundaBilletera.BilletesDe100 = 0;
            segundaBilletera.BilletesDe200 = 0;
            segundaBilletera.BilletesDe500 = 0;
            segundaBilletera.BilletesDe1000 = 0;

            return nuevaBilletera;
            

        }
    }
}
