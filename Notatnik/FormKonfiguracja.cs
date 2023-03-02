using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class FormKonfiguracja : Form
    {
        public FormKonfiguracja()
        {
            InitializeComponent();
        }

        public Color KolorTla 
        { 
            get
            {
                return label1.BackColor;
                
            }
            set
            {
                label1.BackColor = value;
            }
                
        }

        public Font Czcionka
        {
            get 
            {
                return label1.Font;
            }
            set
            {
                label1.Font = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = KolorTla;
            if(cd.ShowDialog() == DialogResult.OK)
            {
                KolorTla = cd.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = Czcionka;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Czcionka = fd.Font;
            }
        }
    }
}
