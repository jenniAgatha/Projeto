using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            List<string> items = new List<string>()
               {
                   "Pão de Queijo - R$ 3,50",
                   "Coxinha - R$ 5,00",
                   "Pastel de Carne - R$ 6,00",
                   "Pastel de Queijo - R$ 5,50",
                   "Suco Natural (300ml) - R$ 4,00",
                   "Refrigerante Lata - R$ 4,50",
                   "Hambúrguer Simples - R$ 8,00",
                   "Hambúrguer com Queijo - R$ 9,00",
                   "X-Tudo - R$ 12,00",
                   "Água Mineral (500ml) - R$ 2,50"
               };

            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox2.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                while (listBox2.SelectedItems.Count > 0)
                {
                    listBox2.Items.Remove(listBox2.SelectedItems[0]);
                }
            }

        }
        private void button3_Click(object sender, EventArgs e)

        {

            {
                foreach (var item in listBox1.SelectedItems)
                {
                    string itemComQuantidade = $"{item} - Quantidade: {numericUpDown1.Value}";
                    if (!listBox2.Items.Contains(itemComQuantidade))
                    {
                        listBox2.Items.Add(itemComQuantidade);
                    }
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();

        }
    }
}
        

    


