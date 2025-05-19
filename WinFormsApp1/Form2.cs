using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


        private Label labelTotal;
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

        }

        private void button6_Click(object sender, EventArgs e)


        {
            decimal total = 0m;
            var culture = new CultureInfo("pt-BR");

            foreach (var item in listBox2.Items)
            {
                string itemText = item.ToString();

                var match = Regex.Match(itemText, @"R\$ (\d+,\d{2}).*Quantidade: (\d+)");
                if (match.Success)
                {
                    decimal preco = decimal.Parse(match.Groups[1].Value, culture);
                    int quantidade = int.Parse(match.Groups[2].Value, culture);

                    total += preco * quantidade;
                }
            }


            string totalStr = total.ToString("F2", culture);


            MessageBox.Show(
                $"Pagamento em dinheiro confirmado!\nValor pago: R$ {totalStr}",
                "Pagamento",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );


            labelTotal.Text = $"Total: R$ {totalStr}";
        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void SalvarHistoricoPedido(List<string> itens, decimal total)
        {
            string caminho = "historico_pedidos.txt";
            string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pedido em {dataHora}:");
            foreach (var item in itens)
            {
                sb.AppendLine($"- {item}");
            }
            sb.AppendLine($"Total: R$ {total:F2}");
            sb.AppendLine(new string('-', 40));


            File.AppendAllText(caminho, sb.ToString());
        }

        private void button7_Click(object sender, EventArgs e)

        {
            Form3 form = new Form3();
            form.Show();


            decimal total = 0;
            List<string> itensPedido = new List<string>();
            foreach (var item in listBox2.Items)
            {
                itensPedido.Add(item.ToString());


                int idxPreco = item.ToString().IndexOf("R$");
                if (idxPreco >= 0)
                {
                    string precoStr = item.ToString().Substring(idxPreco + 2).Trim();
                    precoStr = precoStr.Split(' ')[0].Replace(",", ".");
                    decimal preco = 0;
                    decimal.TryParse(precoStr, out preco);

                    int quantidade = 1;
                    int idxQtd = item.ToString().IndexOf("Quantidade:");
                    if (idxQtd >= 0)
                    {
                        string qtdStr = item.ToString().Substring(idxQtd + 11).Trim();
                        int.TryParse(qtdStr, out quantidade);
                    }

                    total += preco * quantidade;
                }
            }

            SalvarHistoricoPedido(itensPedido, total);


            listBox2.Items.Clear();

            MessageBox.Show("Pedido enviado e salvo no histórico!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal total = 0m; 
            var culture = new CultureInfo("pt-BR");

            foreach (var item in listBox2.Items)
            {
                string itemText = item.ToString();
          
                var match = Regex.Match(itemText, @"R\$ (\d+,\d{2}).*Quantidade: (\d+)");
                if (match.Success)
                {
                    
                    decimal preco = decimal.Parse(match.Groups[1].Value, culture);
                    int quantidade = int.Parse(match.Groups[2].Value, culture);

                    total += preco * quantidade;
                }
            }

     
            string totalStr = total.ToString("F2", culture);

            MessageBox.Show($"Pagamento em cartão o valor é de R$ {totalStr}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPaymentMethod = comboBox1.SelectedItem?.ToString();

            if (selectedPaymentMethod == "Cartao")
            {
                MessageBox.Show("Pagamento em cartão confirmado!");
            }
            else if (selectedPaymentMethod == "Dinheiro")
            {
                MessageBox.Show("Pagamento em dinheiro confirmado!");
            }
            else
            {
                MessageBox.Show("Pagamento em pix confirmado!");
            }
        }

   
       
            
        

           
        }
    }




            

    


