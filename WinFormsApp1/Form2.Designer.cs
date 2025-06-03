
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            timerMenu = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panelMenuLateral.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(221, 251, 0);
            button1.FlatAppearance.BorderColor = Color.FromArgb(221, 251, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(668, 141);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(41, 33);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(410, 147);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.FromArgb(221, 251, 0);
            label1.Location = new Point(352, 154);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(409, 209);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 264);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(894, 180);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(305, 264);
            listBox2.TabIndex = 4;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(221, 251, 0);
            button2.Location = new Point(410, 562);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(51, 52);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.botao_adicionar;
            button3.FlatAppearance.BorderColor = Color.FromArgb(221, 251, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.BottomCenter;
            button3.Location = new Point(410, 495);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 6;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(221, 251, 0);
            numericUpDown1.ForeColor = SystemColors.InfoText;
            numericUpDown1.Location = new Point(623, 518);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(86, 27);
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
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(894, 490);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.BackColor = Color.Transparent;
            Resultado.Location = new Point(1130, 518);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(52, 20);
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
            button5.Size = new Size(41, 28);
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
            Viagem.Size = new Size(84, 24);
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
            LabelCaixa.Size = new Size(54, 20);
            LabelCaixa.TabIndex = 25;
            LabelCaixa.Text = "Caixa :";
            LabelCaixa.Click += label2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(221, 251, 0);
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(244, 25);
            button6.Name = "button6";
            button6.Size = new Size(46, 46);
            button6.TabIndex = 26;
            button6.Text = ">";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.Black;
            panelMenuLateral.BackgroundImage = (Image)resources.GetObject("panelMenuLateral.BackgroundImage");
            panelMenuLateral.Controls.Add(button4);
            panelMenuLateral.Controls.Add(button9);
            panelMenuLateral.Controls.Add(button8);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(171, 722);
            panelMenuLateral.TabIndex = 27;
            panelMenuLateral.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(221, 251, 0);
            button4.FlatAppearance.BorderColor = Color.FromArgb(221, 251, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(46, 333);
            button4.Name = "button4";
            button4.Size = new Size(88, 28);
            button4.TabIndex = 30;
            button4.Text = "Gerenciar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(221, 251, 0);
            button9.FlatAppearance.BorderColor = Color.FromArgb(221, 251, 0);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(46, 265);
            button9.Name = "button9";
            button9.Size = new Size(88, 30);
            button9.TabIndex = 29;
            button9.Text = "Cozinha";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(221, 251, 0);
            button8.FlatAppearance.BorderColor = Color.FromArgb(221, 251, 0);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(46, 193);
            button8.Name = "button8";
            button8.Size = new Size(88, 28);
            button8.TabIndex = 28;
            button8.Text = "Balcão";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // timerMenu
            // 
            timerMenu.Interval = 10;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // Form2
            // 
            AccessibleName = "grgrg";
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1345, 722);
            Controls.Add(panelMenuLateral);
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
            Controls.Add(button1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panelMenuLateral.ResumeLayout(false);
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
        private Button button6;
        private Panel panelMenuLateral;
        private System.Windows.Forms.Timer timerMenu;
        private Button button8;
        private Button button9;
        private Button button4;
    }
}