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
        private CheckBox checkBox1; // Replace 'object' with 'CheckBox' for the checkBox1 field
        private decimal saldoCaixa = 100.00m; // Valor inicial do caixa, ajuste conforme necessário
        private Label labelCaixa;

        // Update the constructor to initialize checkBox1 properly
        public Form2()
        {
            InitializeComponent();
            AdicionarProdutos();
            List<Produto> produtos = new List<Produto>();

            // Assuming checkBox1 is added via the designer, ensure it is cast correctly
            checkBox1 = (CheckBox)this.Controls.Find("checkBox1", true).FirstOrDefault();
        }


        public void AdicionarProdutos()
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

        private void Cartão_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            {
                string selectedPaymentMethod = comboBox1.SelectedItem?.ToString();

                if (comboBox1.SelectedIndex == 0)

                {
                    decimal preco = MostrarTotal();
                    MessageBox.Show($"Pagamento em cartão - Débito\nValor - {preco:F2}");

                }

                else if (comboBox1.SelectedIndex == 1)
                {
                    decimal preco = MostrarTotal();
                    MessageBox.Show($"Pagamento em dinheiro\nValor - {preco:F2}");
                    MessageBox.Show("Por favor digite o valor no campo abaixo");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    decimal preco = MostrarTotal();
                    MessageBox.Show($"Pagamento em Pix\nValor - {preco:F2}");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal troco = 0;
            decimal recebido = 0; // Declare 'recebido' before using it  
            decimal totalPedido = MostrarTotal();

            if (decimal.TryParse(textBox2.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out recebido))
            {
                if (recebido < totalPedido)
                {
                    MessageBox.Show("Valor recebido é menor que o total!");
                    return;
                }
                troco = recebido - totalPedido;
                MessageBox.Show($"Troco: R$ {troco:F2}");

                // Subtrai o troco do caixa  
                saldoCaixa += recebido; // Adiciona o valor recebido ao caixa  
                saldoCaixa -= troco;    // Subtrai o troco dado ao cliente  
                MessageBox.Show($"Saldo do caixa: R$ {saldoCaixa:F2}");
            }
            else if (saldoCaixa < 30)
            {
                MessageBox.Show("Saldo do caixa baixo!");
            }
            else
            {
                MessageBox.Show("Digite um valor recebido válido!");
                return;
            }

            string extrato = string.Join("\n", listBox2.Items.Cast<string>());
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("Nenhum item escolhido\nPor favor adicione um item ao pedido");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nenhum nome adicionado ao pedido!");
                return;
            }
            string formaPagamento = comboBox1.SelectedItem?.ToString() ?? "Não selecionado";
            string v = $"Itens escolhidos:\n{extrato}\n\n";
            string total = $"Total: R$ {MostrarTotal():F2}";
            string mensagem = $"Forma de pagamento: {formaPagamento}\n\n{v}{total}";

            MessageBox.Show(mensagem);

            if (Viagem.Checked)
            {
                MessageBox.Show(
                    $"Forma de pagamento: {comboBox1.SelectedItem}\n\n" +
                    $"Itens escolhidos:\n{extrato}\n\n" +
                    $"Total: R$ {MostrarTotal():F2}\n Para viagem!");
                labelCaixa.Text = $"Saldo do caixa: R$ {saldoCaixa:F2}";
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }


}


