
namespace WinFormsApp1
{
    partial class Form3
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(243, 241, 238);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(23, 258);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(289, 464);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(243, 241, 238);
            listBox2.ForeColor = SystemColors.WindowText;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(538, 258);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(304, 464);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.FromArgb(243, 241, 238);
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(1057, 258);
            listBox3.Margin = new Padding(3, 4, 3, 4);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(282, 464);
            listBox3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(225, 255, 35);
            button2.FlatAppearance.BorderColor = Color.FromArgb(225, 255, 35);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.Design_sem_nome__4_1;
            button2.Location = new Point(381, 467);
            button2.Name = "button2";
            button2.Size = new Size(88, 29);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(225, 255, 35);
            button3.Image = Properties.Resources.Design_sem_nome__1_;
            button3.Location = new Point(12, 72);
            button3.Name = "button3";
            button3.Size = new Size(97, 44);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(225, 255, 35);
            button4.FlatAppearance.BorderColor = Color.FromArgb(225, 255, 35);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.Design_sem_nome__4_2;
            button4.Location = new Point(919, 467);
            button4.Name = "button4";
            button4.Size = new Size(91, 29);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 702);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 12;
            label1.Text = "Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(745, 702);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 13;
            label2.Text = "Preparando";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1256, 702);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 14;
            label3.Text = "Entregue";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1374, 779);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
     
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}