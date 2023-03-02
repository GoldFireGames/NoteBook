using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class FormEdytor : Form
    {
        private String sciezka;
        String Sciezka
        {
            set
            {
                sciezka = value;
                robInfo();
            }

            get
            {
                return sciezka;
            }

        }

        public bool CzyEdytowane 
        {
          get => czyEdytowane;
            set
            {
                czyEdytowane = value;
                robInfo();
            }
        }

        private bool czyEdytowane;
        public FormEdytor()
        {
            InitializeComponent();
            Sciezka = "";
            CzyEdytowane = false;
        }
           
        private void ZapiszJakoStripMenuItem5_Click(object sender, EventArgs e) //zapisz jako
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Plik tekstowy|*.txt|Plik skryptowy|*.bat";
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, RichTextBoxEdytor.Text);
                sciezka = sfd.FileName;
                czyEdytowane = false;
            
            }
           
        
        }

        private void OtworzStripMenuItem3_Click(object sender, EventArgs e) //otworz
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Plik tekstowy|*.txt|Plik skryptowy|*.bat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sciezka = ofd.FileName;
                RichTextBoxEdytor.Text = File.ReadAllText(sciezka);
                CzyEdytowane = false;
                robInfo();
            }
        }
        
  

        private void ZapiszStripMenuItem4_Click(object sender, EventArgs e) //zapisz
        {
          // jesli nie ma pliku odwolaj sie do zapisz jako
            SaveFileDialog sfd2 = new SaveFileDialog();
            if(sciezka == "")
            {
                ZapiszJakoStripMenuItem5_Click(null, null);
            }
            else
            {
                File.WriteAllText(sciezka, RichTextBoxEdytor.Text);
                CzyEdytowane = false;               
            }
            robInfo();
        }

        private void NowylStripMenuItem2_Click(object sender, EventArgs e) // nowy
        {
            RichTextBoxEdytor.Text = "";
            sciezka = "";
            // this.Text = sciezka;
            robInfo();
            
            
        }

        private void RichTextBoxEdytor_TextChanged(object sender, EventArgs e)
        {
            CzyEdytowane = true;
            robInfo();
        }

        private void robInfo()
        {
            if(Sciezka == "")
            {
                Text = "Nowy";
            }
            else
            {
                Text = sciezka;
            }
            if(CzyEdytowane)
            {
                Text += "*";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(czyEdytowane)
            {
                DialogResult result = MessageBox.Show("Czy chcesz zapisac zmiany?",
                                                      "Uwaga!",
                                                       MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;

                }
                else if (result == DialogResult.Yes)
                {
                    ZapiszStripMenuItem4_Click(null, null);
                }
            }
          
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void konfiguratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKonfiguracja fk = new FormKonfiguracja();
            fk.KolorTla = RichTextBoxEdytor.BackColor;
            fk.Czcionka = RichTextBoxEdytor.Font;
            if(fk.ShowDialog() == DialogResult.OK)
            {
                
                RichTextBoxEdytor.BackColor = fk.KolorTla;
                RichTextBoxEdytor.Font = fk.Czcionka;
                
            }
        }
    }
}
