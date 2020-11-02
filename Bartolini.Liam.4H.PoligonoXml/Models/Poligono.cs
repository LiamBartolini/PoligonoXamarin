using System;
using System.Collections.Generic;
using System.Text;

namespace Bartolini.Liam._4H.PoligonoXml.Models
{
    class Poligono
    {
        private double _nLati;
        public double NLati
        {
            get
            {
                return _nLati;
            }

            set
            {
                _nLati = value;
            }
        }
        
        private double _l_lati;
        public double LLati
        {
            get
            {
                return _l_lati;
            }

            set
            {
                _l_lati = value;
            }
        }

        private double _apotema;
        public double Apotema
        {
            get
            {
                return _apotema;
            }

            set
            {
                _apotema = value;
            }
        }
        
        private double _perimetro;
        public double Perimetro
        {
            get
            {
                return _perimetro;
            }

            set
            {
                _perimetro = value;
            }
        }

        private double _area;
        public double Area
        {
            get
            {
                return _area;
            }

            set
            {
                _area = value;
            }
        }

        private double _fisso;
        public double Fisso
        {
            get
            {
                return _fisso;
            }

            set
            {
                _fisso = value;
            }
        }
        
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

        public void CalcoloArea()
        {
            this._area = this._perimetro * this._fisso / 2;
        }

        public void CalcoloPerimetro()
        {
            this._perimetro = this._nLati * this._l_lati;
        }

        public void CalcoloApotema()
        {
            this._apotema = this._l_lati / (2 * Math.Tan(Math.PI / this._nLati));
        }

        public void CalcoloFisso()
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