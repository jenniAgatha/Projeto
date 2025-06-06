using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            AtualizarListas();
        }

        private void AtualizarListas() //Classe para atualizar
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            foreach (var item in PedidosStore.Pedidos)
                listBox1.Items.Add(item);

            foreach (var item in PedidosStore.ItensSelecionados)
                listBox2.Items.Add(item);

            foreach (var item in PedidosStore.ItensFinalizados)
                listBox3.Items.Add(item);
        }
        /////////////////////////////////////////////////////

        private void button2_Click(object sender, EventArgs e)
        {
            var selecionados = listBox1.SelectedItems.Cast<object>().ToList();

            foreach (var item in selecionados)
            {
                string texto = item.ToString();

                if (!listBox2.Items.Contains(texto))
                {
                    listBox2.Items.Add(texto);
                    if (!PedidosStore.ItensSelecionados.Contains(texto))
                        PedidosStore.ItensSelecionados.Add(texto);
                }

                listBox1.Items.Remove(texto);
                PedidosStore.Pedidos.Remove(texto);
                MessageBox.Show(this, "Pedido enviado para a cozinha para preparo!");
            }
        }

      /////////////////////////////////////////////////////

        private void button4_Click(object sender, EventArgs e)
        {
            var selecionados = listBox2.SelectedItems.Cast<object>().ToList();

            foreach (var item in selecionados)
            {
                string texto = item.ToString();

                if (!listBox3.Items.Contains(texto))
                {
                    listBox3.Items.Add(texto);
                    if (!PedidosStore.ItensFinalizados.Contains(texto))
                        PedidosStore.ItensFinalizados.Add(texto);
                }

                listBox2.Items.Remove(texto);
                PedidosStore.ItensSelecionados.Remove(texto);
                MessageBox.Show(this, "Pedido entregue com sucesso!");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }

    public static class PedidosStore
    {
        public static List<string> Pedidos { get; } = new List<string>();
        public static List<string> ItensSelecionados { get; } = new List<string>();
        public static List<string> ItensFinalizados { get; } = new List<string>();
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
