
namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            numericUpDown1 = new NumericUpDown();
            button7 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            Resultado = new Label();
            button5 = new Button();
            Viagem = new CheckBox();
            LabelCaixa = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(424, 113);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 0;
            button1.Text = "Adicionar cliente ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(129, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(63, 113);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(129, 175);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(311, 344);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(787, 95);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(447, 264);
            listBox2.TabIndex = 4;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(105, 596);
            button2.Name = "button2";
            button2.Size = new Size(91, 29);
            button2.TabIndex = 5;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(105, 548);
            button3.Name = "button3";
            button3.Size = new Size(91, 27);
            button3.TabIndex = 6;
            button3.Text = "Adicionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(267, 571);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // button7
            // 
            button7.Location = new Point(1237, 793);
            button7.Name = "button7";
            button7.Size = new Size(173, 29);
            button7.TabIndex = 17;
            button7.Text = "Finalizar pedido";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cartão", "Dinheiro", "Pix" });
            comboBox1.Location = new Point(787, 367);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(787, 420);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(1137, 499);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(49, 20);
            Resultado.TabIndex = 22;
            Resultado.Text = "Total :";
            Resultado.Click += Resultado_Click;
            // 
            // button5
            // 
            button5.Location = new Point(937, 367);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(27, 31);
            button5.TabIndex = 23;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Viagem
            // 
            Viagem.AutoSize = true;
            Viagem.Location = new Point(1150, 385);
            Viagem.Margin = new Padding(3, 4, 3, 4);
            Viagem.Name = "Viagem";
            Viagem.Size = new Size(82, 24);
            Viagem.TabIndex = 24;
            Viagem.Text = "Viagem";
            Viagem.UseVisualStyleBackColor = true;
            Viagem.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LabelCaixa
            // 
            LabelCaixa.AutoSize = true;
            LabelCaixa.Location = new Point(1137, 441);
            LabelCaixa.Name = "LabelCaixa";
            LabelCaixa.Size = new Size(52, 20);
            LabelCaixa.TabIndex = 25;
            LabelCaixa.Text = "Caixa :";
            LabelCaixa.Click += label2_Click;
            // 
            // Form2
            // 
            AccessibleName = "grgrg";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 983);
            Controls.Add(LabelCaixa);
            Controls.Add(Viagem);
            Controls.Add(button5);
            Controls.Add(Resultado);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(numericUpDown1);
            Controls.Add(button3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MostrarTotal();
        }



        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button2;
        private Button button3;
        private NumericUpDown numericUpDown1;
        
       
        private Button button7;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label Resultado;
        private Button button5;
        private CheckBox Viagem;
        private Label LabelCaixa;
    }
}