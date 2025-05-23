using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private decimal total;
        private List<Produto> produtos = new List<Produto>();

        public Form2()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            AdicionarProdutos();
            
        }


        private void AdicionarProdutos()
        {
            produtos.Add(new Produto("Pão de Queijo", 3.50m));
            produtos.Add(new Produto("Coxinha", 5.00m));
            produtos.Add(new Produto("Pastel de Carne", 6.00m));
            produtos.Add(new Produto("Pastel de Queijo", 5.50m));
            produtos.Add(new Produto("Suco Natural (300ml)", 4.00m));
            produtos.Add(new Produto("Refrigerante Lata", 4.50m));
            produtos.Add(new Produto("Hambúrguer Simples", 8.00m));
            produtos.Add(new Produto("Hambúrguer com Queijo", 9.00m));
            produtos.Add(new Produto("X-Tudo", 12.00m));
            produtos.Add(new Produto("Água Mineral (500ml)", 2.50m));

            foreach (var produto in produtos)
            {
                listBox1.Items.Add(produto);
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
                AtualizarTotal();
                MostrarTotal();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
            MostrarTotal();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                string itemComQuantidade = $"{item} - Quantidade: {numericUpDown1.Value}";
                if (!listBox2.Items.Contains(itemComQuantidade))
                {
                    listBox2.Items.Add(itemComQuantidade);
                }
                MostrarTotal();
            }

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPaymentMethod = comboBox1.SelectedItem?.ToString();
            {

                if (selectedPaymentMethod == "Cartão")
                {
                    decimal preco = MostrarTotal();
                    MessageBox.Show("Pagamento em cartão - Débito\n Valor - {total:F2}");
                       
                     
                }
            }


        }




        private decimal ObterTotal()
        {
            throw new NotImplementedException();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void AtualizarTotal()
        { }



        private void button4_Click(object sender, EventArgs e)
        {

            // button4
            // 
            button4 = new Button();
            button4.Location = new Point(920, 420); // ajuste a posição conforme necessário
            button4.Name = "button4";
            button4.Size = new Size(100, 30);
            button4.TabIndex = 21;
            button4.Text = "Calcular Troco";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            Controls.Add(button4);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
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

            public override string ToString()
            {
                return $"{Nome} - R$ {Preco:F2}";
            }
        }



        private decimal MostrarTotal()
        {
            decimal total = 0m;
            foreach (var item in listBox2.Items)
            {
                string texto = item.ToString();
                // Tenta extrair preço e quantidade do texto
                var match = Regex.Match(texto, @"R\$ (\d+,\d{2}).*Quantidade: (\d+)");
                if (match.Success)
                {
                    // Soma preço * quantidade
                    decimal preco = decimal.Parse(match.Groups[1].Value, new CultureInfo("pt-BR"));
                    int quantidade = int.Parse(match.Groups[2].Value);
                    total += preco * quantidade;
                }
                else
                {
                    // Caso não tenha quantidade, soma só o preço unitário
                    int idx = texto.IndexOf("R$");
                    if (idx >= 0)
                    {
                        string precoStr = texto.Substring(idx + 2).Trim().Split(' ')[0].Replace(",", ".");
                        if (decimal.TryParse(precoStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal preco))
                            total += preco;
                    }
                }
            }
            Resultado.Text = $"Total selecionado: R$ {total:F2}";
            return total;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MostrarTotal();
        }
    }
}

