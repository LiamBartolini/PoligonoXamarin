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
            bool f = true;
            string strNlati = "";
            string strLlati = "";

            //ciclo per controllare l'input dell'utente
            while (f)
            {                
                strNlati = NumeroLati.Text;
                strLlati = lLAti.Text;
                f = InputCheck(strNlati);
                DisplayAlert("Attenzione", "Il numero di lati inserito non corrisponde ad un poligono...", "Ok");
            }

            Poligono figura = new Poligono(Convert.ToDouble(strNlati), Convert.ToDouble(strLlati));

            figura.Apotema();
            figura.Fisso();

            figura.Perimetro();
            figura.Area();

            //stampa per il nome del calcolo
            lblRisultatoCol1.Text = $"Risultati:\r\nArea: \r\nPerimetro: \r\nApotema: \r\nNumero fisso: \r\nNome: ";

            //stampa per i risultati
            lblRisultatoCol2.Text = $"\r\n{figura.area:n2} cm^2\r\n{figura.perimetro:n2} cm\r\n{figura.apotema:n2} cm\r\n{figura.fisso:n2}\r\n{figura.Nome()}";

        }

        private bool InputCheck(string nLati)
        {
            bool f = false;

            if (Convert.ToInt32(nLati) < 3)
            {
                f = true;

                
            }

            return f;
        }

        private void Confronta(object sender, EventArgs e)
        {
            string strNLati = NumeroLati.Text;
            string strLLati = lLAti.Text;

            double Nlati = Convert.ToDouble(strNLati);
            double Llati = Convert.ToDouble(strLLati);

            Poligono figura = new Poligono(Nlati, Llati);
            Poligono personale = new Poligono(4, 7);

            lblRisultatoCol1.Text = $"Poligo di confronto: \r\nLati: \r\nLunghezza lato: \r\n\r\nL'esito del confronto";
            lblRisultatoCol2.Text = $"\r\n{personale.nLati}\r\n{personale.L_lati}\r\n\r\n{figura.Confronta(personale)}";
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
    }
}