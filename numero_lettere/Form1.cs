using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numero_lettere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {

            lstRisultati.Items.Clear();
            string Stringa = txt_n1.Text;
           

            if (string.IsNullOrWhiteSpace(Stringa) )
            {
                MessageBox.Show("Inserire almeno una stringa",
                    "Attenzione",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int[] conta = new int[26];

                foreach (char c in Stringa)
                {
                    char lettera = char.ToUpper(c);
                    if (lettera >= 'A' && lettera <= 'Z')
                    {
                        int indice = lettera - 'A';
                        conta[indice]++;
                    }
                }
                for (int i = 0; i < 26; i++)
                {
                    if (conta[i] > 0)
                    {
                        char letteraT = (char)('A' + i);
                        lstRisultati.Items.Add("lettera " + letteraT +  ": "+ conta[i]);
                    }
                }
                    
            }
        }

        private void btn_n2_Click(object sender, EventArgs e)
        {
            string lettera = lbl_n2.Text;



        }
    }
}
