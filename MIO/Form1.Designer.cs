﻿namespace MIO
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxPrecyzja = new TextBox();
            textBoxN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonGeneruj = new Button();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(44, 34);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(31, 23);
            textBoxA.TabIndex = 0;
            textBoxA.Text = "-4";
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(122, 34);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(30, 23);
            textBoxB.TabIndex = 1;
            textBoxB.Text = "12";
            // 
            // textBoxPrecyzja
            // 
            textBoxPrecyzja.Location = new Point(205, 34);
            textBoxPrecyzja.Name = "textBoxPrecyzja";
            textBoxPrecyzja.Size = new Size(49, 23);
            textBoxPrecyzja.TabIndex = 2;
            textBoxPrecyzja.Text = "0,001";
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(296, 34);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(41, 23);
            textBoxN.TabIndex = 3;
            textBoxN.Text = "10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 4;
            label1.Text = "a =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 37);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 5;
            label2.Text = "b =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 37);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 6;
            label3.Text = "D = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 37);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "N = ";
            // 
            // buttonGeneruj
            // 
            buttonGeneruj.Location = new Point(585, 37);
            buttonGeneruj.Name = "buttonGeneruj";
            buttonGeneruj.Size = new Size(75, 23);
            buttonGeneruj.TabIndex = 8;
            buttonGeneruj.Text = "Generuj";
            buttonGeneruj.UseVisualStyleBackColor = true;
            buttonGeneruj.Click += buttonGeneruj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGeneruj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxN);
            Controls.Add(textBoxPrecyzja);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxPrecyzja;
        private TextBox textBoxN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonGeneruj;
    }
}