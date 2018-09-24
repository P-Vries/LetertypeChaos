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
        private void FontChange(RichTextBox rtb)
        {
            int index = 0;
            int chars = rtb.Text.Length;
            for (int charlength = 0; charlength < chars; charlength++)
            {
                //
                //Fonts
                //
                Font font1 = new Font("Arial", 16, FontStyle.Regular);
                Font font2 = new Font("Consolas", 13, FontStyle.Regular);
                Font font3 = new Font("Consolas", 14, FontStyle.Bold);
                Font font4 = new Font("Arial", 12, FontStyle.Italic);
                Font font5 = new Font("Arial", 10, FontStyle.Regular);
                Font font6 = new Font("Consolas", 18, FontStyle.Regular);
                Font font7 = new Font("Consolas", 40, FontStyle.Bold);
                Font font8 = new Font("Arial", 6, FontStyle.Italic);
                rtb.SelectionStart = index;
                rtb.SelectionLength = 1;
                Random rnd = new Random();
                byte rando = (byte)rnd.Next(1, 8);
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
            FontChange(rtbIO);
        }
    }
}
