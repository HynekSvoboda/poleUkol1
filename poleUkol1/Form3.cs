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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        /*V komponentě ListBox jsou nezáporná celá čísla, mezi nimi se vyskytuje alespoň minimálně jedna 0. 
* Kladná čísla z ListBox až po první 0 uložte do pole. Vypište podíl prvního prvku a posledního prvku pole. 
* Vypište všechny prvky včetně jejich pořadí v poli, které jsou menší než poslední prvek pole.*/
        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int a=listBox1.Items.Count;
            int[] pole = new int[a];
            int [] pole2 = new int[a];
            label2.Text = Convert.ToString(a);
            string b = "0";
            for(int i = 0; i < a && listBox1.Items[i].ToString()!=b ; i++)
            {
                    pole[i] = Convert.ToInt32(listBox1.Items[i].ToString());
                listBox2.Items.Add(pole[i]);
                
            }
            double podil = 0;
            for(int i=0; i<a; i++)
            {
                pole2[i]= Convert.ToInt32(listBox1.Items[i].ToString());
            }
            double prvni = pole2.First();
            double posledni = pole2.Last();
            if ( posledni > 0)
            {
                podil = prvni / posledni;
                label2.Text=podil.ToString();
            }
            else
            {
                label2.Text="Nelze urcit";
            }
            int c = 0;
            while(c<a)
            {
                if (pole2[c]<posledni)
                {
                    listBox3.Items.Add(string.Format("Pole[{0}] = {1}", c, pole2[c]));
                }
                c++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V komponentě ListBox jsou nezáporná celá čísla, mezi nimi se vyskytuje alespoň minimálně jedna 0.\nKladná čísla z ListBox až po první 0 uložte do pole.\nVypište podíl prvního prvku a posledního prvku pole.\nVypište všechny prvky včetně jejich pořadí v poli, které jsou menší než poslední prvek pole.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
