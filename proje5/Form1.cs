using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string harf = cmbHarf.SelectedItem.ToString();
            MessageBox.Show($"Seçilen Harf: {harf}, Harf Sırası: {Alfabe_Sirasi(harf)}");
        }
        private int Alfabe_Sirasi (string harf)
        {
            switch(harf[0])
            { 
            case 'a': case 'A': return 1;
            case 'b': case 'B': return 2;
            case 'c': case 'C': return 3;
            case 'ç': case 'Ç': return 4;
            case 'd': case 'D': return 5;
            case 'e': case 'E': return 6;
            case 'f': case 'F': return 7;
            case 'g': case 'G': return 8;
            case 'ğ': case 'Ğ': return 9;
            case 'h': case 'H': return 10;
            case 'ı': case 'I': return 11;
            case 'i': case 'İ': return 12;
            case 'j': case 'J': return 13;
            case 'k': case 'K': return 14;
            case 'l': case 'L': return 15;
            case 'm': case 'M': return 16;
            case 'n': case 'N': return 17;
            case 'o': case 'O': return 18;
            case 'ö': case 'Ö': return 19;
            case 'p': case 'P': return 20;
            case 'r': case 'R': return 21;
            case 's': case 'S': return 22;
            case 'ş': case 'Ş': return 23;
            case 't': case 'T': return 24;
            case 'u': case 'U': return 25;
            case 'ü': case 'Ü': return 26;
            case 'v': case 'V': return 27;
            case 'y': case 'Y': return 28;
            case 'z': case 'Z': return 29;
            }
            return 0;
        }
    }
} 
