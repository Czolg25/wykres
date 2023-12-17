namespace Wykres
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.PatternLabel = new System.Windows.Forms.Label();
            this.patternTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xMinBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.xMaxBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tittleTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.xMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(490, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(80, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Wykres Funkcji";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PatternLabel
            // 
            this.PatternLabel.AutoSize = true;
            this.PatternLabel.Location = new System.Drawing.Point(23, 13);
            this.PatternLabel.Name = "PatternLabel";
            this.PatternLabel.Size = new System.Drawing.Size(69, 13);
            this.PatternLabel.TabIndex = 1;
            this.PatternLabel.Text = "Wzór Funkcji";
            // 
            // patternTextBox
            // 
            this.patternTextBox.Location = new System.Drawing.Point(26, 30);
            this.patternTextBox.Name = "patternTextBox";
            this.patternTextBox.Size = new System.Drawing.Size(192, 20);
            this.patternTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X min:";
            // 
            // xMinBox
            // 
            this.xMinBox.Location = new System.Drawing.Point(61, 70);
            this.xMinBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xMinBox.Name = "xMinBox";
            this.xMinBox.Size = new System.Drawing.Size(157, 20);
            this.xMinBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X max:";
            // 
            // xMaxBox
            // 
            this.xMaxBox.Location = new System.Drawing.Point(61, 104);
            this.xMaxBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xMaxBox.Name = "xMaxBox";
            this.xMaxBox.Size = new System.Drawing.Size(157, 20);
            this.xMaxBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opis osi X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis osi Y:";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(26, 216);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(192, 20);
            this.yTextBox.TabIndex = 9;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(26, 154);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(192, 20);
            this.xTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tytuł Wykresu";
            // 
            // tittleTextBox
            // 
            this.tittleTextBox.Location = new System.Drawing.Point(26, 279);
            this.tittleTextBox.Name = "tittleTextBox";
            this.tittleTextBox.Size = new System.Drawing.Size(192, 20);
            this.tittleTextBox.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 325);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Linie siatki poziomej";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(26, 349);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Linie siatki pionowej";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(290, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 390);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(516, 428);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(30, 13);
            this.xLabel.TabIndex = 16;
            this.xLabel.Text = "Oś X";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(26, 387);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 18;
            this.drawButton.Text = "Rysuj";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(248, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 142);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tittleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xMaxBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xMinBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patternTextBox);
            this.Controls.Add(this.PatternLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xMinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label PatternLabel;
        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown xMinBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown xMaxBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tittleTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel panel2;
    }
}

