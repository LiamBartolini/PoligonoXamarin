using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Bartolini.Liam._4H.PoligonoXml.Models;

namespace Bartolini.Liam._4H.PoligonoXml
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calcola(object sender, EventArgs e)
        {
            //controlla l'input dul numero di lati
            string strLlati = lLati.Text;
            string strNlati = NumeroLati.Text;

            //controllo per l'input dei dati
            if (InputCheckNLati(strNlati) || InputCheckLlati(strLlati))
            {
                DisplayAlert("Attenzione", "Il numero/lunghezza dei lati inserito non è accettato", "Ok");
            }
            else
            {
                Poligono figura = new Poligono(Convert.ToDouble(strNlati), Convert.ToDouble(strLlati));

                figura.Apotema();

                figura.Fisso();

                figura.Perimetro();
                figura.Area();

                //stampa per il nome del calcolo
                lblRisultatoCol1.Text = $"Risultati:\r\nArea: \r\nPerimetro: \r\nApotema: \r\nNumero fisso: \r\nNome: ";

                //stampa per i risultati
                lblRisultatoCol2.Text = $"\r\n{figura._area:n2} cm^2\r\n{figura._perimetro:n2} cm\r\n{figura._apotema:n2} cm\r\n{figura._fisso:n2}\r\n{figura.Nome()}";
            }
        }

        private void Confronta(object sender, EventArgs e)
        {
            string strNLati = NumeroLati.Text;
            string strLLati = lLati.Text;

            double Nlati = Convert.ToDouble(strNLati);
            double Llati = Convert.ToDouble(strLLati);

            Poligono figura = new Poligono(Nlati, Llati);
            Poligono personale = new Poligono(4, 7);

            lblRisultatoCol1.Text = $"Poligo di confronto: \r\nLati: \r\nLunghezza lato: \r\n\r\nL'esito del confronto";
            lblRisultatoCol2.Text = $"\r\n{personale._nLati}\r\n{personale._l_lati}\r\n\r\n{figura.Confronta(personale)}";
            DrawPrint(Nlati);
        }

        private void DrawPrint(double nlati)
        {
            switch(nlati)
            {
                case 3:
                    triangolo.IsVisible = true;
                    break;
                case 4:
                    quadrato.IsVisible = true;
                    break;
                case 5:
                    pentagono.IsVisible = true;
                    break;
                case 6:
                    esagono.IsVisible = true;
                    break;
                case 7:
                    ettagono.IsVisible = true;
                    break;
                case 8:
                    ottagono.IsVisible = true;
                    break;
                case 9:
                    ennagono.IsVisible = true;
                    break;
                case 10:
                    decagono.IsVisible = true;
                    break;
                case 11:
                    endecagono.IsVisible = true;
                    break;
                case 12:
                    dodecagono.IsVisible = true;
                    break;
            }

            quadratoPersonale.IsVisible = true;
        }

        private bool InputCheckNLati(string nLati)
        {
            if (string.IsNullOrEmpty(nLati))
                return true;

            if (Convert.ToInt32(nLati) < 3 || Convert.ToInt32(nLati) > 12)
                return true;

            return false;
        }

        private bool InputCheckLlati(string LLati)
        {
            if (string.IsNullOrEmpty(LLati))
                return true;

            if (Convert.ToInt32(LLati) < 0)
                return true;
            else
                return false;
        }
    }
}