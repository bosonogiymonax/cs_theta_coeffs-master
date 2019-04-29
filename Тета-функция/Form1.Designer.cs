namespace Theta
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.xMaxBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nxCntBox = new System.Windows.Forms.TextBox();
            this.MCntLabel = new System.Windows.Forms.Label();
            this.mCntBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kCntBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fromValueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toValueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lValueBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(15, 29);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart1.Size = new System.Drawing.Size(937, 603);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(892, 698);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.xMaxBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nxCntBox);
            this.groupBox1.Controls.Add(this.MCntLabel);
            this.groupBox1.Controls.Add(this.mCntBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kCntBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fromValueBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.toValueBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lValueBox);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 735);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dual";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(877, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 20;
            this.button2.Text = "Run tests";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 686);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "x_max";
            this.label7.UseMnemonic = false;
            // 
            // xMaxBox
            // 
            this.xMaxBox.ForeColor = System.Drawing.Color.Black;
            this.xMaxBox.Location = new System.Drawing.Point(14, 701);
            this.xMaxBox.Name = "xMaxBox";
            this.xMaxBox.Size = new System.Drawing.Size(100, 20);
            this.xMaxBox.TabIndex = 18;
            this.xMaxBox.Text = "15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 646);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "nx_cnt";
            this.label6.UseMnemonic = false;
            // 
            // nxCntBox
            // 
            this.nxCntBox.ForeColor = System.Drawing.Color.Black;
            this.nxCntBox.Location = new System.Drawing.Point(226, 661);
            this.nxCntBox.Name = "nxCntBox";
            this.nxCntBox.Size = new System.Drawing.Size(100, 20);
            this.nxCntBox.TabIndex = 16;
            this.nxCntBox.Text = "40";
            // 
            // MCntLabel
            // 
            this.MCntLabel.AutoSize = true;
            this.MCntLabel.Location = new System.Drawing.Point(118, 646);
            this.MCntLabel.Name = "MCntLabel";
            this.MCntLabel.Size = new System.Drawing.Size(36, 13);
            this.MCntLabel.TabIndex = 15;
            this.MCntLabel.Text = "m_cnt";
            this.MCntLabel.UseMnemonic = false;
            // 
            // mCntBox
            // 
            this.mCntBox.ForeColor = System.Drawing.Color.Black;
            this.mCntBox.Location = new System.Drawing.Point(120, 661);
            this.mCntBox.Name = "mCntBox";
            this.mCntBox.Size = new System.Drawing.Size(100, 20);
            this.mCntBox.TabIndex = 14;
            this.mCntBox.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "K_cnt";
            // 
            // kCntBox
            // 
            this.kCntBox.ForeColor = System.Drawing.Color.Black;
            this.kCntBox.Location = new System.Drawing.Point(14, 661);
            this.kCntBox.Name = "kCntBox";
            this.kCntBox.Size = new System.Drawing.Size(100, 20);
            this.kCntBox.TabIndex = 12;
            this.kCntBox.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 685);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "From";
            // 
            // fromValueBox
            // 
            this.fromValueBox.Location = new System.Drawing.Point(680, 700);
            this.fromValueBox.Name = "fromValueBox";
            this.fromValueBox.Size = new System.Drawing.Size(100, 20);
            this.fromValueBox.TabIndex = 10;
            this.fromValueBox.Text = "-5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(783, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "To";
            // 
            // toValueBox
            // 
            this.toValueBox.Location = new System.Drawing.Point(786, 700);
            this.toValueBox.Name = "toValueBox";
            this.toValueBox.Size = new System.Drawing.Size(100, 20);
            this.toValueBox.TabIndex = 8;
            this.toValueBox.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "L=w2/w1 ";
            // 
            // lValueBox
            // 
            this.lValueBox.Location = new System.Drawing.Point(120, 701);
            this.lValueBox.Name = "lValueBox";
            this.lValueBox.Size = new System.Drawing.Size(100, 20);
            this.lValueBox.TabIndex = 4;
            this.lValueBox.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(998, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 735);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Values";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 698);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lValueBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fromValueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox toValueBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nxCntBox;
        private System.Windows.Forms.Label MCntLabel;
        private System.Windows.Forms.TextBox mCntBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kCntBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox xMaxBox;
        private System.Windows.Forms.Button button2;
    }
}

