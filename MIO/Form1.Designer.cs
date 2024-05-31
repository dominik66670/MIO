namespace MIO
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
            components = new System.ComponentModel.Container();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxPrecyzja = new TextBox();
            textBoxN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonGeneruj = new Button();
            dataGridView1 = new DataGridView();
            xRealDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            XBin = new DataGridViewTextBoxColumn();
            Gx = new DataGridViewTextBoxColumn();
            osobnikBindingSource = new BindingSource(components);
            label5 = new Label();
            label6 = new Label();
            texBoxPk = new TextBox();
            textBoxPm = new TextBox();
            label7 = new Label();
            textBoxT = new TextBox();
            formsPlotWyniki = new ScottPlot.WinForms.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)osobnikBindingSource).BeginInit();
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
            buttonGeneruj.Location = new Point(640, 38);
            buttonGeneruj.Name = "buttonGeneruj";
            buttonGeneruj.Size = new Size(75, 23);
            buttonGeneruj.TabIndex = 8;
            buttonGeneruj.Text = "Generuj";
            buttonGeneruj.UseVisualStyleBackColor = true;
            buttonGeneruj.Click += buttonGeneruj_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { xRealDataGridViewTextBoxColumn, fxDataGridViewTextBoxColumn, XBin, Gx });
            dataGridView1.DataSource = osobnikBindingSource;
            dataGridView1.Location = new Point(14, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(549, 491);
            dataGridView1.TabIndex = 9;
            // 
            // xRealDataGridViewTextBoxColumn
            // 
            xRealDataGridViewTextBoxColumn.DataPropertyName = "XReal";
            xRealDataGridViewTextBoxColumn.HeaderText = "XReal";
            xRealDataGridViewTextBoxColumn.Name = "xRealDataGridViewTextBoxColumn";
            xRealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fxDataGridViewTextBoxColumn
            // 
            fxDataGridViewTextBoxColumn.DataPropertyName = "Fx";
            fxDataGridViewTextBoxColumn.HeaderText = "f(x)";
            fxDataGridViewTextBoxColumn.Name = "fxDataGridViewTextBoxColumn";
            fxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // XBin
            // 
            XBin.DataPropertyName = "XBin";
            XBin.HeaderText = "XBin";
            XBin.Name = "XBin";
            XBin.ReadOnly = true;
            // 
            // Gx
            // 
            Gx.DataPropertyName = "Gx";
            Gx.HeaderText = "Gx";
            Gx.Name = "Gx";
            Gx.ReadOnly = true;
            // 
            // osobnikBindingSource
            // 
            osobnikBindingSource.DataSource = typeof(kod.Osobnik);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 37);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 10;
            label5.Text = "Pk = ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(426, 41);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 11;
            label6.Text = "Pm =";
            // 
            // texBoxPk
            // 
            texBoxPk.Location = new Point(383, 34);
            texBoxPk.Name = "texBoxPk";
            texBoxPk.Size = new Size(37, 23);
            texBoxPk.TabIndex = 12;
            texBoxPk.Text = "0.5";
            // 
            // textBoxPm
            // 
            textBoxPm.Location = new Point(468, 38);
            textBoxPm.Name = "textBoxPm";
            textBoxPm.Size = new Size(47, 23);
            textBoxPm.TabIndex = 13;
            textBoxPm.Text = "0.0001";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(539, 42);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 14;
            label7.Text = "T =";
            // 
            // textBoxT
            // 
            textBoxT.Location = new Point(569, 39);
            textBoxT.Name = "textBoxT";
            textBoxT.Size = new Size(36, 23);
            textBoxT.TabIndex = 15;
            textBoxT.Text = "80";
            // 
            // formsPlotWyniki
            // 
            formsPlotWyniki.DisplayScale = 1F;
            formsPlotWyniki.Location = new Point(608, 119);
            formsPlotWyniki.Name = "formsPlotWyniki";
            formsPlotWyniki.Size = new Size(836, 519);
            formsPlotWyniki.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 690);
            Controls.Add(formsPlotWyniki);
            Controls.Add(textBoxT);
            Controls.Add(label7);
            Controls.Add(textBoxPm);
            Controls.Add(texBoxPk);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)osobnikBindingSource).EndInit();
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
        private DataGridView dataGridView1;
        private BindingSource osobnikBindingSource;
        private Label label5;
        private Label label6;
        private TextBox texBoxPk;
        private TextBox textBoxPm;
        private Label label7;
        private TextBox textBoxT;
        private DataGridViewTextBoxColumn xRealDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn XBin;
        private DataGridViewTextBoxColumn Gx;
        private ScottPlot.WinForms.FormsPlot formsPlotWyniki;
    }
}
