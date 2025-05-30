
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
            components = new System.ComponentModel.Container();
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
            button6 = new Button();
            panelMenuLateral = new Panel();
            button8 = new Button();
            timerMenu = new System.Windows.Forms.Timer(components);
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(221, 251, 0);
            button1.FlatAppearance.BorderColor = Color.FromArgb(221, 251, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(443, 180);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(110, 25);
            button1.TabIndex = 0;
            button1.Text = "Adicionar cliente ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(350, 57);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.FromArgb(221, 251, 0);
            label1.Location = new Point(370, 157);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(410, 239);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 274);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(894, 180);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(305, 274);
            listBox2.TabIndex = 4;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(221, 251, 0);
            button2.Location = new Point(379, 617);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(76, 23);
            button2.TabIndex = 5;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(221, 251, 0);
            button3.FlatAppearance.BorderColor = Color.FromArgb(221, 251, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(410, 549);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(76, 23);
            button3.TabIndex = 6;
            button3.Text = "Adicionar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(221, 251, 0);
            numericUpDown1.ForeColor = SystemColors.InfoText;
            numericUpDown1.Location = new Point(532, 549);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(86, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(227, 255, 27);
            button7.FlatAppearance.BorderColor = Color.FromArgb(225, 255, 35);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(1209, 680);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(70, 22);
            button7.TabIndex = 17;
            button7.Text = "Finalizar!";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InfoText;
            comboBox1.ForeColor = Color.FromArgb(227, 255, 27);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cartão", "Dinheiro", "Pix" });
            comboBox1.Location = new Point(894, 463);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(894, 490);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.BackColor = Color.Transparent;
            Resultado.Location = new Point(1130, 518);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(40, 15);
            Resultado.TabIndex = 22;
            Resultado.Text = "Total :";
            Resultado.Click += Resultado_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(221, 251, 0);
            button5.FlatAppearance.BorderColor = Color.FromArgb(221, 251, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(1025, 463);
            button5.Name = "button5";
            button5.Size = new Size(35, 23);
            button5.TabIndex = 23;
            button5.Text = "OK";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Viagem
            // 
            Viagem.AutoSize = true;
            Viagem.BackColor = Color.FromArgb(225, 255, 35);
            Viagem.Location = new Point(1130, 463);
            Viagem.Name = "Viagem";
            Viagem.Size = new Size(68, 19);
            Viagem.TabIndex = 24;
            Viagem.Text = "Viagem";
            Viagem.UseVisualStyleBackColor = false;
            Viagem.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LabelCaixa
            // 
            LabelCaixa.AutoSize = true;
            LabelCaixa.BackColor = Color.Transparent;
            LabelCaixa.ForeColor = SystemColors.ActiveCaptionText;
            LabelCaixa.Location = new Point(1130, 490);
            LabelCaixa.Name = "LabelCaixa";
            LabelCaixa.Size = new Size(42, 15);
            LabelCaixa.TabIndex = 25;
            LabelCaixa.Text = "Caixa :";
            LabelCaixa.Click += label2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(175, 12);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 26;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.Black;
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Enabled = false;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(151, 751);
            panelMenuLateral.TabIndex = 27;
            panelMenuLateral.Paint += panel1_Paint;
            // 
            // button8
            // 
            button8.Location = new Point(202, 149);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 28;
            button8.Text = "btnMenu";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // timerMenu
            // 
            timerMenu.Interval = 10;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // button9
            // 
            button9.Location = new Point(212, 91);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 29;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AccessibleName = "grgrg";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1358, 751);
            Controls.Add(button9);
            Controls.Add(panelMenuLateral);
            Controls.Add(button8);
            Controls.Add(button6);
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
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
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
        private Button button4;
        private NumericUpDown numericUpDown1;
        
       
        private Button button7;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label Resultado;
        private Button button5;
        private CheckBox Viagem;
        private Label LabelCaixa;
        private Button button6;
        private Panel panelMenuLateral;
        private System.Windows.Forms.Timer timerMenu;
        private Button button8;
        private Button button9;
    }
}