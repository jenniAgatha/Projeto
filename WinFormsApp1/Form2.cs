using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static WinFormsApp1.Form3;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private decimal saldoCaixa = 100.00m;
        private List<Produto> produtos = new List<Produto>();
        private CheckBox checkBox1;
        private Label labelCaixa;

        public Form2()
        {
            InitializeComponent();
            panelMenuLateral.Width = larguraMinima; // começa fechado
            AdicionarProdutos();

            labelCaixa = (Label)this.Controls.Find("labelCaixa", true).FirstOrDefault();
            if (labelCaixa != null)
                labelCaixa.Text = $"Saldo do caixa: R$ {saldoCaixa:F2}";
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

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
                numericUpDown1.Minimum = 1;
            
               if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                 MessageBox.Show(this, "Antes de começar por favor adicione um nome ao pedido!");return;
                }
                    
                
                 if (!listBox2.Items.Contains(itemComQuantidade))
                {
                    listBox2.Items.Add(itemComQuantidade);
                }
                



                MostrarTotal();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }




        private void button5_Click(object sender, EventArgs e)
        {
            string selectedPaymentMethod = comboBox1.SelectedItem?.ToString();

            decimal preco = MostrarTotal();

            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show(this, $"Pagamento em cartão - \nValor - {preco:F2}");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show(this, $"Pagamento em dinheiro\nValor - {preco:F2}");
                MessageBox.Show(this, "Por favor digite o valor no campo abaixo");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                MessageBox.Show(this, $"Pagamento em Pix\nValor - {preco:F2}");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal troco = 0;
            decimal recebido = 0;
            decimal totalPedido = MostrarTotal();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show(this, "Por favor adicione um nome ao pedido!");
                textBox1.Focus();
                return;
            }

            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show(this, "Nenhum item escolhido.\nPor favor, adicione um item ao pedido.");
                listBox1.Focus();
                return;
            }

            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Selecione uma forma de pagamento!");
                comboBox1.DroppedDown = true;
                return;
            }

            if (comboBox1.SelectedItem?.ToString() == "Dinheiro")
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                    !decimal.TryParse(textBox2.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out recebido))
                {
                    MessageBox.Show(this, "Digite um valor recebido válido!");
                    textBox2.Focus();
                   
                    return;
                }

                if (recebido < totalPedido)
                {
                    MessageBox.Show(this, "Valor recebido é menor que o total!");
                    textBox2.Focus();
                    return;
                }

                troco = recebido - totalPedido;
            }
            else
            {
                recebido = totalPedido;
            }

            saldoCaixa += totalPedido;
            if (labelCaixa != null)
                labelCaixa.Text = $"Saldo do caixa: R$ {saldoCaixa:F2}";

            if (saldoCaixa < 30)
            {
                MessageBox.Show(this, "Saldo do caixa baixo!");
            }

           MessageBox.Show(this, $"Troco: R$ {troco:F2}");

            string extrato = string.Join("\n", listBox2.Items.Cast<string>());
            string formaPagamento = comboBox1.SelectedItem?.ToString() ?? "Não selecionado";
            string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string viagem = Viagem.Checked ? "\nPara viagem!" : "";

            string mensagem = $"Forma de pagamento: {formaPagamento}\n\nItens escolhidos:\n{extrato}\n\n" +
                              $"Total: R$ {totalPedido:F2}\nData/Hora: {dataHora}{viagem}";

            MessageBox.Show(this, mensagem);
            string pedido = $"Pedido -> {string.Join(", ", listBox2.Items.Cast<string>())}";
            PedidosStore.Pedidos.Add(pedido);

            LimparPedido();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MostrarTotal();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged_1(object sender, EventArgs e) { }

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

                var match = Regex.Match(texto, @"R\$ (\d+,\d{2})\D*Quantidade: (\d+)");
                if (match.Success)
                {
                    decimal preco = decimal.Parse(match.Groups[1].Value, new CultureInfo("pt-BR"));
                    int quantidade = int.Parse(match.Groups[2].Value);
                    total += preco * quantidade;
                }
                else
                {
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
      
          

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }

        private void labelCaixa_Click(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged_3(object sender, EventArgs e)
        {
           // if (string.IsNullOrWhiteSpace(listBox2.Text))

           // {
          ////      MessageBox.Show(this, "Não é possível prosseguir sem itens adicionados!");return;
                
           // }
            



        }
        private void LimparPedido()
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox2.Items.Clear();

        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }
        // bool menUAberto = true;
        int larguraMaxima = 200;
        int larguraMinima = 0; 
        private bool menuAberto = false;




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuAberto)
            {
                panelMenuLateral.Width -= 20;
                if (panelMenuLateral.Width <= larguraMinima)
                {
                    timerMenu.Stop();
                    panelMenuLateral.Width = larguraMinima;
                    menuAberto = false;
                }
            }
            else
            {
                panelMenuLateral.Width += 20;
                if (panelMenuLateral.Width >= larguraMaxima)
                {
                    timerMenu.Stop();
                    panelMenuLateral.Width = larguraMaxima;
                    menuAberto = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            // Button btnMenu = new Button();
            //  btnMenu.Text = "Balcão ";
            // btnMenu.Size = new Size(180, 40);
            // btnMenu.Location = new Point(10, 10);
            // panelMenuLateral.Controls.Add(btnMenu);
            panelMenuLateral.Dock = DockStyle.Left;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


