using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackautomat
{
    class Kasse
    {
        private int fuenfCent { get; set;}
        private int zehnCent { get; set; }
        private int zwanzigCent { get; set; }
        private int funenfzigCent { get; set; }
        private int einEuro { get; set; }
        private int zweiEuro { get; set; }
        private int fuenfEuroSchein { get; set; }
        private int zehnEuroSchein { get; set; }
        private int zwanzigEuroSchein { get; set; }
        private int grenzeFuerMuenzen = 100;
        private int grenzeFuerScheine = 20;
        private Array reihenfolgeDesGeldes = new Array [20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05];
        private double [] reihenfolgeDesGeldes = new double [20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05];

        public void berechneWechselgeld(int gegebenesGeld, int zuZahlendesGeld)
        {
            int differenz = gegebenesGeld - zuZahlendesGeld;

        }


    }
}
