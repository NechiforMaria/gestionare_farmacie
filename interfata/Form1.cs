using gestionarea_farmaciei;
using System;
using System.Windows.Forms;

namespace Interfata
{
    public partial class Form1 : Form
    {
        public Medicament[] medicamente = new Medicament[20];
        Medicament temp;
        public int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void adaugare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Introduceti numele");
            }
            else
            if (string.IsNullOrEmpty(numar.Text))
            {
                MessageBox.Show("Introduceti numarul de capsule");
            }
            else
            if (string.IsNullOrEmpty(data_expirare.Text))
            {
                MessageBox.Show("Introduceti data de expirare");
            }
            else
            if (string.IsNullOrEmpty(afectiune.Text))
            {
                MessageBox.Show("Introduceti o afectiune");
            }
            else     
            {
                temp = new Medicament(textBox1.Text, Int32.Parse(numar.Text), data_expirare.Text, afectiune.Text);
            }
            if (n == 0)
                medicamente[n++] = temp;
            else
            {
                for (int i = 0; i < n; i++)
                {
                   
                        medicamente[n] = temp;
                    
                }
                n++;
            }
            textBox1.Clear();
            numar.Clear();
            data_expirare.Clear();
            afectiune.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;

        }

        private void afisare_med_Click(object sender, EventArgs e)
        {
            afisare.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                string info = medicamente[i].ToString();
                afisare.Items.Insert(i, info);
            }
        }

        private void cautare_Click(object sender, EventArgs e)
        {
            
        }

        private void modificare_Click(object sender, EventArgs e)
        {
            
        }
    }
}
