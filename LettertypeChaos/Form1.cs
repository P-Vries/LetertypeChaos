using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettertypeChaos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        //Methodes
        //
        private void FontChange(RichTextBox rtb)//Methode om font te veranderen
        {
            int index = 0;//Een int om de positie te telen
            int chars = rtb.Text.Length;//Hier veranderen we de richtextbox in en int die de lengte bevat.
            for (int charlength = 0; charlength < chars; charlength++)//we maken een for loop die het font vervangt
            {
                //
                //Fonts
                //
                //Hier maken we de verschilende Fonts aan
                Font font1 = new Font("Arial", 16, FontStyle.Regular);
                Font font2 = new Font("Consolas", 13, FontStyle.Regular);
                Font font3 = new Font("Consolas", 14, FontStyle.Bold);
                Font font4 = new Font("Arial", 12, FontStyle.Italic);
                Font font5 = new Font("Arial", 10, FontStyle.Regular);
                Font font6 = new Font("Consolas", 18, FontStyle.Regular);
                Font font7 = new Font("Consolas", 40, FontStyle.Bold);
                Font font8 = new Font("Arial", 6, FontStyle.Italic);
                rtb.SelectionStart = index;//Hier selecteren we een deel van de textbox.
                rtb.SelectionLength = 1;// Hier zeggen we hoelang de selectie is in dit geval 1
                Random rnd = new Random();//Hier maken we een Random number generator aan die we rnd noemen.
                byte rando = (byte)rnd.Next(1, 8);//Hier maken we een willekeurig nummer aan tussen 1 en 8.
                //Hier kijken we welk nummer er uitkomt en stemmen daar de font op af.
                if (rando == 1) { rtb.SelectionFont = font1; }
                if (rando == 2) { rtb.SelectionFont = font2; }
                if (rando == 3) { rtb.SelectionFont = font3; }
                if (rando == 4) { rtb.SelectionFont = font4; }
                if (rando == 5) { rtb.SelectionFont = font5; }
                if (rando == 6) { rtb.SelectionFont = font6; }
                if (rando == 7) { rtb.SelectionFont = font7; }
                if (rando == 8) { rtb.SelectionFont = font8; }
                index++;
            }
        }

        private void btnVerander_Click(object sender, EventArgs e)
        {
            FontChange(rtbIO);//Hier verwijzen we naar de Merhode
        }
    }
}
