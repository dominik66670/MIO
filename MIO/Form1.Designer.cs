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
            osobnikBindingSource = new BindingSource(components);
            label5 = new Label();
            label6 = new Label();
            texBoxPk = new TextBox();
            textBoxPm = new TextBox();
            label7 = new Label();
            textBoxT = new TextBox();
            formsPlotWyniki = new ScottPlot.WinForms.FormsPlot();
            Algorytm = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label8 = new Label();
            progressBar1 = new ProgressBar();
            dataGridView2 = new DataGridView();
            nDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fxAvgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wielkiWynikBindingSource = new BindingSource(components);
            buttonWielkieTesty = new Button();
            tabPage3 = new TabPage();
            richTextWynikGEO = new RichTextBox();
            labelBestTGEO = new Label();
            labelGEOTetInfo = new Label();
            progressBarGEOT = new ProgressBar();
            progressBarSzukanieTetGEO = new ProgressBar();
            buttonStartTestGEO = new Button();
            labelBestGEO = new Label();
            formsPlotGEO = new ScottPlot.WinForms.FormsPlot();
            buttonStartGEO = new Button();
            textBoxTetGEO = new TextBox();
            textBoxTGEO = new TextBox();
            textBoxDGEO = new TextBox();
            textBoxBGEO = new TextBox();
            textBoxAGEO = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)osobnikBindingSource).BeginInit();
            Algorytm.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wielkiWynikBindingSource).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(6, 15);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(31, 23);
            textBoxA.TabIndex = 0;
            textBoxA.Text = "-4";
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(84, 15);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(30, 23);
            textBoxB.TabIndex = 1;
            textBoxB.Text = "12";
            // 
            // textBoxPrecyzja
            // 
            textBoxPrecyzja.Location = new Point(167, 15);
            textBoxPrecyzja.Name = "textBoxPrecyzja";
            textBoxPrecyzja.Size = new Size(49, 23);
            textBoxPrecyzja.TabIndex = 2;
            textBoxPrecyzja.Text = "0,001";
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(258, 15);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(41, 23);
            textBoxN.TabIndex = 3;
            textBoxN.Text = "10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-24, 18);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 4;
            label1.Text = "a =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 18);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 5;
            label2.Text = "b =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 18);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 6;
            label3.Text = "D = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 18);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "N = ";
            // 
            // buttonGeneruj
            // 
            buttonGeneruj.Location = new Point(591, 23);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { xRealDataGridViewTextBoxColumn, fxDataGridViewTextBoxColumn, XBin });
            dataGridView1.DataSource = osobnikBindingSource;
            dataGridView1.Location = new Point(6, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(549, 562);
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
            // osobnikBindingSource
            // 
            osobnikBindingSource.DataSource = typeof(kod.Osobnik);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 18);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 10;
            label5.Text = "Pk = ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 22);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 11;
            label6.Text = "Pm =";
            // 
            // texBoxPk
            // 
            texBoxPk.Location = new Point(345, 15);
            texBoxPk.Name = "texBoxPk";
            texBoxPk.Size = new Size(37, 23);
            texBoxPk.TabIndex = 12;
            texBoxPk.Text = "0.5";
            // 
            // textBoxPm
            // 
            textBoxPm.Location = new Point(430, 19);
            textBoxPm.Name = "textBoxPm";
            textBoxPm.Size = new Size(47, 23);
            textBoxPm.TabIndex = 13;
            textBoxPm.Text = "0.0001";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(501, 23);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 14;
            label7.Text = "T =";
            // 
            // textBoxT
            // 
            textBoxT.Location = new Point(531, 20);
            textBoxT.Name = "textBoxT";
            textBoxT.Size = new Size(36, 23);
            textBoxT.TabIndex = 15;
            textBoxT.Text = "80";
            // 
            // formsPlotWyniki
            // 
            formsPlotWyniki.DisplayScale = 1F;
            formsPlotWyniki.Location = new Point(672, 49);
            formsPlotWyniki.Name = "formsPlotWyniki";
            formsPlotWyniki.Size = new Size(836, 519);
            formsPlotWyniki.TabIndex = 16;
            // 
            // Algorytm
            // 
            Algorytm.Controls.Add(tabPage1);
            Algorytm.Controls.Add(tabPage2);
            Algorytm.Controls.Add(tabPage3);
            Algorytm.Location = new Point(12, 13);
            Algorytm.Name = "Algorytm";
            Algorytm.SelectedIndex = 0;
            Algorytm.Size = new Size(1512, 654);
            Algorytm.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(formsPlotWyniki);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(textBoxT);
            tabPage1.Controls.Add(buttonGeneruj);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBoxA);
            tabPage1.Controls.Add(textBoxPm);
            tabPage1.Controls.Add(textBoxB);
            tabPage1.Controls.Add(texBoxPk);
            tabPage1.Controls.Add(textBoxPrecyzja);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBoxN);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1504, 626);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Algorytm Ewolucyjny";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(progressBar1);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(buttonWielkieTesty);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1504, 626);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Wielke Testy Ewolucyjne";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("ROG Fonts", 13F);
            label8.Location = new Point(683, 116);
            label8.Name = "label8";
            label8.Size = new Size(120, 22);
            label8.TabIndex = 3;
            label8.Text = "Progres";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(591, 141);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(308, 49);
            progressBar1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nDataGridViewTextBoxColumn, pkDataGridViewTextBoxColumn, pmDataGridViewTextBoxColumn, tDataGridViewTextBoxColumn, fxAvgDataGridViewTextBoxColumn });
            dataGridView2.DataSource = wielkiWynikBindingSource;
            dataGridView2.Location = new Point(919, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(546, 520);
            dataGridView2.TabIndex = 1;
            // 
            // nDataGridViewTextBoxColumn
            // 
            nDataGridViewTextBoxColumn.DataPropertyName = "N";
            nDataGridViewTextBoxColumn.HeaderText = "N";
            nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            // 
            // pkDataGridViewTextBoxColumn
            // 
            pkDataGridViewTextBoxColumn.DataPropertyName = "Pk";
            pkDataGridViewTextBoxColumn.HeaderText = "Pk";
            pkDataGridViewTextBoxColumn.Name = "pkDataGridViewTextBoxColumn";
            // 
            // pmDataGridViewTextBoxColumn
            // 
            pmDataGridViewTextBoxColumn.DataPropertyName = "Pm";
            pmDataGridViewTextBoxColumn.HeaderText = "Pm";
            pmDataGridViewTextBoxColumn.Name = "pmDataGridViewTextBoxColumn";
            // 
            // tDataGridViewTextBoxColumn
            // 
            tDataGridViewTextBoxColumn.DataPropertyName = "T";
            tDataGridViewTextBoxColumn.HeaderText = "T";
            tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            // 
            // fxAvgDataGridViewTextBoxColumn
            // 
            fxAvgDataGridViewTextBoxColumn.DataPropertyName = "FxAvg";
            fxAvgDataGridViewTextBoxColumn.HeaderText = "FxAvg";
            fxAvgDataGridViewTextBoxColumn.Name = "fxAvgDataGridViewTextBoxColumn";
            // 
            // wielkiWynikBindingSource
            // 
            wielkiWynikBindingSource.DataSource = typeof(kod.WielkiWynik);
            // 
            // buttonWielkieTesty
            // 
            buttonWielkieTesty.Font = new Font("ROG Fonts", 30F);
            buttonWielkieTesty.Location = new Point(591, 6);
            buttonWielkieTesty.Name = "buttonWielkieTesty";
            buttonWielkieTesty.Size = new Size(308, 92);
            buttonWielkieTesty.TabIndex = 0;
            buttonWielkieTesty.Text = "Start";
            buttonWielkieTesty.UseVisualStyleBackColor = true;
            buttonWielkieTesty.Click += buttonWielkieTesty_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(richTextWynikGEO);
            tabPage3.Controls.Add(labelBestTGEO);
            tabPage3.Controls.Add(labelGEOTetInfo);
            tabPage3.Controls.Add(progressBarGEOT);
            tabPage3.Controls.Add(progressBarSzukanieTetGEO);
            tabPage3.Controls.Add(buttonStartTestGEO);
            tabPage3.Controls.Add(labelBestGEO);
            tabPage3.Controls.Add(formsPlotGEO);
            tabPage3.Controls.Add(buttonStartGEO);
            tabPage3.Controls.Add(textBoxTetGEO);
            tabPage3.Controls.Add(textBoxTGEO);
            tabPage3.Controls.Add(textBoxDGEO);
            tabPage3.Controls.Add(textBoxBGEO);
            tabPage3.Controls.Add(textBoxAGEO);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1504, 626);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "GEO";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextWynikGEO
            // 
            richTextWynikGEO.Location = new Point(6, 61);
            richTextWynikGEO.Name = "richTextWynikGEO";
            richTextWynikGEO.ReadOnly = true;
            richTextWynikGEO.Size = new Size(422, 54);
            richTextWynikGEO.TabIndex = 18;
            richTextWynikGEO.Text = "";
            // 
            // labelBestTGEO
            // 
            labelBestTGEO.AutoSize = true;
            labelBestTGEO.Location = new Point(17, 385);
            labelBestTGEO.Name = "labelBestTGEO";
            labelBestTGEO.Size = new Size(12, 15);
            labelBestTGEO.TabIndex = 17;
            labelBestTGEO.Text = "-";
            // 
            // labelGEOTetInfo
            // 
            labelGEOTetInfo.AutoSize = true;
            labelGEOTetInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelGEOTetInfo.Location = new Point(17, 286);
            labelGEOTetInfo.Name = "labelGEOTetInfo";
            labelGEOTetInfo.Size = new Size(13, 17);
            labelGEOTetInfo.TabIndex = 16;
            labelGEOTetInfo.Text = "-";
            // 
            // progressBarGEOT
            // 
            progressBarGEOT.Location = new Point(68, 324);
            progressBarGEOT.Name = "progressBarGEOT";
            progressBarGEOT.Size = new Size(291, 23);
            progressBarGEOT.TabIndex = 15;
            // 
            // progressBarSzukanieTetGEO
            // 
            progressBarSzukanieTetGEO.Location = new Point(68, 233);
            progressBarSzukanieTetGEO.Name = "progressBarSzukanieTetGEO";
            progressBarSzukanieTetGEO.Size = new Size(291, 23);
            progressBarSzukanieTetGEO.TabIndex = 14;
            // 
            // buttonStartTestGEO
            // 
            buttonStartTestGEO.Font = new Font("ROG Fonts", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStartTestGEO.Location = new Point(68, 121);
            buttonStartTestGEO.Name = "buttonStartTestGEO";
            buttonStartTestGEO.Size = new Size(291, 81);
            buttonStartTestGEO.TabIndex = 13;
            buttonStartTestGEO.Text = "Start Test";
            buttonStartTestGEO.UseVisualStyleBackColor = true;
            buttonStartTestGEO.Click += buttonStartTestGEO_Click;
            // 
            // labelBestGEO
            // 
            labelBestGEO.AutoSize = true;
            labelBestGEO.Location = new Point(6, 52);
            labelBestGEO.Name = "labelBestGEO";
            labelBestGEO.Size = new Size(0, 15);
            labelBestGEO.TabIndex = 12;
            // 
            // formsPlotGEO
            // 
            formsPlotGEO.DisplayScale = 1F;
            formsPlotGEO.Location = new Point(494, 6);
            formsPlotGEO.Name = "formsPlotGEO";
            formsPlotGEO.Size = new Size(1010, 471);
            formsPlotGEO.TabIndex = 11;
            // 
            // buttonStartGEO
            // 
            buttonStartGEO.Location = new Point(353, 10);
            buttonStartGEO.Name = "buttonStartGEO";
            buttonStartGEO.Size = new Size(75, 23);
            buttonStartGEO.TabIndex = 10;
            buttonStartGEO.Text = "Start";
            buttonStartGEO.UseVisualStyleBackColor = true;
            buttonStartGEO.Click += buttonStartGEO_Click;
            // 
            // textBoxTetGEO
            // 
            textBoxTetGEO.Location = new Point(320, 10);
            textBoxTetGEO.Name = "textBoxTetGEO";
            textBoxTetGEO.Size = new Size(27, 23);
            textBoxTetGEO.TabIndex = 9;
            textBoxTetGEO.Text = "0,5";
            // 
            // textBoxTGEO
            // 
            textBoxTGEO.Location = new Point(241, 10);
            textBoxTGEO.Name = "textBoxTGEO";
            textBoxTGEO.Size = new Size(34, 23);
            textBoxTGEO.TabIndex = 8;
            textBoxTGEO.Text = "2000";
            // 
            // textBoxDGEO
            // 
            textBoxDGEO.Location = new Point(170, 10);
            textBoxDGEO.Name = "textBoxDGEO";
            textBoxDGEO.Size = new Size(35, 23);
            textBoxDGEO.TabIndex = 7;
            textBoxDGEO.Text = "0,001";
            // 
            // textBoxBGEO
            // 
            textBoxBGEO.Location = new Point(102, 10);
            textBoxBGEO.Name = "textBoxBGEO";
            textBoxBGEO.Size = new Size(33, 23);
            textBoxBGEO.TabIndex = 6;
            textBoxBGEO.Text = "12";
            // 
            // textBoxAGEO
            // 
            textBoxAGEO.Location = new Point(36, 10);
            textBoxAGEO.Name = "textBoxAGEO";
            textBoxAGEO.Size = new Size(26, 23);
            textBoxAGEO.TabIndex = 5;
            textBoxAGEO.Text = "-4";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(211, 13);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 4;
            label13.Text = "T =";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(281, 13);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 3;
            label12.Text = "Tet =";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(141, 13);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 2;
            label11.Text = "D =";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(68, 13);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 1;
            label10.Text = "b = ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 13);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 0;
            label9.Text = "a =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 660);
            Controls.Add(Algorytm);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)osobnikBindingSource).EndInit();
            Algorytm.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wielkiWynikBindingSource).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
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
        private ScottPlot.WinForms.FormsPlot formsPlotWyniki;
        private TabControl Algorytm;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button buttonWielkieTesty;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pmDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fxAvgDataGridViewTextBoxColumn;
        private BindingSource wielkiWynikBindingSource;
        private ProgressBar progressBar1;
        private Label label8;
        private DataGridViewTextBoxColumn xRealDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn XBin;
        private TabPage tabPage3;
        private TextBox textBoxAGEO;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBoxTetGEO;
        private TextBox textBoxTGEO;
        private TextBox textBoxDGEO;
        private TextBox textBoxBGEO;
        private Button buttonStartGEO;
        private ScottPlot.WinForms.FormsPlot formsPlotGEO;
        private Label labelBestGEO;
        private Button buttonStartTestGEO;
        private ProgressBar progressBarSzukanieTetGEO;
        private ProgressBar progressBarGEOT;
        private Label labelGEOTetInfo;
        private Label labelBestTGEO;
        private RichTextBox richTextWynikGEO;
    }
}
