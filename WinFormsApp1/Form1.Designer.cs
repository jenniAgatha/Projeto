﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button6 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button7 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.ForeColor = Color.Black;
            button6.Location = new Point(14, 16);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 64);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(826, 324);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(550, 531);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(822, 324);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 3;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(737, 441);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 31);
            button7.TabIndex = 3;
            button7.Text = "Pronto";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1657, 985);
            Controls.Add(button7);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button6);
            ForeColor = Color.Transparent;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button7;
    }
}
