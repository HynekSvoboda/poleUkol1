using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poleUkol1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            /*Do pole načtěte N náhodných čísel (0,100). Pole zobrazte. 
             * Vytvořte nové pole, které bude obsahovat všechna čísla menší než zadané číslo B, pole bude setříděné. 
             * Pole zobrazte. Vytvořte nové pole, které bude obsahovat všechna čísla větší než zadané číslo B, pole bude setříděné.
             * Použijte metodu Sort, Skip a Take.*/
        }
        public int[] pole;
        public int pocet = 0;
        public int pocet2 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int n = Convert.ToInt32(numericUpDown1.Value);
            int b = Convert.ToInt32(numericUpDown2.Value);
            pocet = 0;
            pocet2 = 0;
            int[] pole2;
            pole2 = new int[n];
            pole = new int[n];
            Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
                pole[i] = rng.Next(1, 100);
                pole2[i] = pole[i];
                if (pole[i] < b) pocet++;
                if (pole[i] > b) pocet2++;
            }
            foreach (int i in pole)
            {
                listBox1.Items.Add(i);
            }
            Array.Sort(pole);
            Array.Sort(pole2);
            if (pocet2 > 0)
            {
                int vysledek = n - pocet2;
                pole2 = pole2.Skip(vysledek).ToArray();

                foreach (int i in pole2)
                {
                    listBox3.Items.Add(i);
                }
            }
            if (pocet > 0)
            {
                pole = pole.Take(pocet).ToArray();
                foreach (int i in pole)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do pole načtěte N náhodných čísel (0,100). Pole zobrazte.\nVytvořte nové pole, které bude obsahovat všechna čísla menší než zadané číslo B, pole bude setříděné.\nPole zobrazte.Vytvořte nové pole, které bude obsahovat všechna čísla větší než zadané číslo B, pole bude setříděné.\nPoužijte metodu Sort, Skip a Take.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
