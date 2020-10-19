using System;
using System.Collections.Generic;
using System.Text;

namespace Bartolini.Liam._4H.PoligonoXml.Models
{
    class Poligono
    {
        public double nLati;
        public double L_lati;
        public double apotema;
        public double perimetro;
        public double area;
        public double fisso;

        public Poligono()
        {
            //costruisce il quadrato di lato 1
            nLati = 4;
            L_lati = 1;
        }

        //costruttore con nLati e Llati
        public Poligono(double lati, double lLati)
        {
            nLati = lati;
            L_lati = lLati;
        }

        //costruttore di un poligono regolare di lato 1
        public Poligono(int lati)
        {
            L_lati = 1;
            nLati = lati;
        }

        public void Area()
        {
            this.area = this.perimetro * this.fisso / 2;
        }

        public void Perimetro()
        {
            this.perimetro = this.nLati * this.L_lati;
        }

        public void Apotema()
        {
            this.apotema = this.L_lati / (2 * Math.Tan(Math.PI / this.nLati));
        }

        public void Fisso()
        {
            this.fisso = this.apotema / this.L_lati;
        }

        public string Nome()
        {
            string strR;

            if (this.nLati < 3)
                return "Non è un poligono";

            string[] array = new string[] { "triangolo", "quadrato", "pentagono", "esagono", "ettagono", "ottagono", "ennagono", "decagono", "endecagono", "dodecagono" };

            strR = array[(int)this.nLati - 3];

            return strR;
        }

        public string Confronta(Poligono p2)
        {
            if (this.nLati == p2.nLati)
            {
                if (this.L_lati == p2.L_lati)
                    return "Uguale";
                if (this.L_lati < p2.L_lati)
                    return "Più piccolo";
                else
                    return "Più grande";
            }
            else
                return "Non confrontabili";
        }
    }
}
