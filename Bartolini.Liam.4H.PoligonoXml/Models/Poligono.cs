using System;
using System.Collections.Generic;
using System.Text;

namespace Bartolini.Liam._4H.PoligonoXml.Models
{
    class Poligono
    {
        public double _nLati;
        public double _l_lati;
        public double _apotema;
        public double _perimetro;
        public double _area;
        public double _fisso;

        public Poligono()
        {
            //costruisce il quadrato di lato 1
            _nLati = 4;
            _l_lati = 1;
        }

        //costruttore con nLati e Llati
        public Poligono(double lati, double lLati)
        {
            _nLati = lati;
           _l_lati = lLati;
        }

        //costruttore di un poligono regolare di lato 1
        public Poligono(int lati)
        {
            _l_lati = 1;
            _nLati = lati;
        }

        public void Area()
        {
            this._area = this._perimetro * this._fisso / 2;
        }

        public void Perimetro()
        {
            this._perimetro = this._nLati * this._l_lati;
        }

        public void Apotema()
        {
            this._apotema = this._l_lati / (2 * Math.Tan(Math.PI / this._nLati));
        }

        public void Fisso()
        {
            this._fisso = this._apotema / this._l_lati;
        }

        public string Nome()
        {
            string[] array = new string[] { "triangolo", "quadrato", "pentagono", "esagono", "ettagono", "ottagono", "ennagono", "decagono", "endecagono", "dodecagono" };

            if (this._nLati < 3)
                return "Non è un poligono";
            
            if (this._nLati > 12)
                return "Poligono non supportato";
            else
                return array[(int)this._nLati - 3];
        }

        public string Confronta(Poligono p2)
        {
            if (this._nLati == p2._nLati)
            {
                if (this._l_lati == p2._l_lati)
                    return "Uguale";
                if (this._l_lati < p2._l_lati)
                    return "Più piccolo";
                else
                    return "Più grande";
            }
            else
                return "Non confrontabili";
        }
    }
}