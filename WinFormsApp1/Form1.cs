using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var item in listBox1.Items)
            {

                listBox2.Items.Add(item);
            }


        }

        public event Action<List<string>> ItensSelecionadosConfirmados;

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {

            
        }

        public void AdicionarItensNaListBox1(IEnumerable<string> itens)
        {
            foreach (var item in itens)
            {
                if (!listBox1.Items.Contains(item))
                    listBox1.Items.Add(item);
            }
        }
    }
}

















































