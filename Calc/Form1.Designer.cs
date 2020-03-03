namespace Calc
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlusBTN = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.MinusBTN = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.MultBTN = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.DivBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            this.ClearEntryBTN = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.PosNegBTN = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.DecimalBTN = new System.Windows.Forms.Button();
            this.EqualBTN = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.PlusBTN, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Num3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Num2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Num1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.MinusBTN, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Num6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Num5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Num4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MultBTN, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Num9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Num8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Num7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DivBTN, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BackBTN, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClearEntryBTN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClearBTN, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PosNegBTN, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Num0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.DecimalBTN, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.EqualBTN, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.Display, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // PlusBTN
            // 
            this.PlusBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusBTN.Location = new System.Drawing.Point(606, 351);
            this.PlusBTN.Name = "PlusBTN";
            this.PlusBTN.Size = new System.Drawing.Size(195, 81);
            this.PlusBTN.TabIndex = 19;
            this.PlusBTN.Text = "+";
            this.PlusBTN.UseVisualStyleBackColor = true;
            this.PlusBTN.Click += new System.EventHandler(this.operator_Click);
            // 
            // Num3
            // 
            this.Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(405, 351);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(195, 81);
            this.Num3.TabIndex = 18;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(204, 351);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(195, 81);
            this.Num2.TabIndex = 17;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(3, 351);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(195, 81);
            this.Num1.TabIndex = 16;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // MinusBTN
            // 
            this.MinusBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusBTN.Location = new System.Drawing.Point(606, 264);
            this.MinusBTN.Name = "MinusBTN";
            this.MinusBTN.Size = new System.Drawing.Size(195, 81);
            this.MinusBTN.TabIndex = 15;
            this.MinusBTN.Text = "-";
            this.MinusBTN.UseVisualStyleBackColor = true;
            this.MinusBTN.Click += new System.EventHandler(this.operator_Click);
            // 
            // Num6
            // 
            this.Num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6.Location = new System.Drawing.Point(405, 264);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(195, 81);
            this.Num6.TabIndex = 14;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num5
            // 
            this.Num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5.Location = new System.Drawing.Point(204, 264);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(195, 81);
            this.Num5.TabIndex = 13;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num4
            // 
            this.Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.Location = new System.Drawing.Point(3, 264);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(195, 81);
            this.Num4.TabIndex = 12;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // MultBTN
            // 
            this.MultBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultBTN.Location = new System.Drawing.Point(606, 177);
            this.MultBTN.Name = "MultBTN";
            this.MultBTN.Size = new System.Drawing.Size(195, 81);
            this.MultBTN.TabIndex = 11;
            this.MultBTN.Text = "*";
            this.MultBTN.UseVisualStyleBackColor = true;
            this.MultBTN.Click += new System.EventHandler(this.operator_Click);
            // 
            // Num9
            // 
            this.Num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num9.Location = new System.Drawing.Point(405, 177);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(195, 81);
            this.Num9.TabIndex = 10;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num8
            // 
            this.Num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num8.Location = new System.Drawing.Point(204, 177);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(195, 81);
            this.Num8.TabIndex = 9;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num7
            // 
            this.Num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7.Location = new System.Drawing.Point(3, 177);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(195, 81);
            this.Num7.TabIndex = 8;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // DivBTN
            // 
            this.DivBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivBTN.Location = new System.Drawing.Point(606, 90);
            this.DivBTN.Name = "DivBTN";
            this.DivBTN.Size = new System.Drawing.Size(195, 81);
            this.DivBTN.TabIndex = 7;
            this.DivBTN.Text = "/";
            this.DivBTN.UseVisualStyleBackColor = true;
            this.DivBTN.Click += new System.EventHandler(this.operator_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBTN.Location = new System.Drawing.Point(405, 90);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(195, 81);
            this.BackBTN.TabIndex = 6;
            this.BackBTN.Text = "<<";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // ClearEntryBTN
            // 
            this.ClearEntryBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntryBTN.Location = new System.Drawing.Point(3, 90);
            this.ClearEntryBTN.Name = "ClearEntryBTN";
            this.ClearEntryBTN.Size = new System.Drawing.Size(195, 81);
            this.ClearEntryBTN.TabIndex = 0;
            this.ClearEntryBTN.Text = "CE";
            this.ClearEntryBTN.UseVisualStyleBackColor = true;
            this.ClearEntryBTN.Click += new System.EventHandler(this.ClearEntryBTN_Click);
            // 
            // ClearBTN
            // 
            this.ClearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBTN.Location = new System.Drawing.Point(204, 90);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(195, 81);
            this.ClearBTN.TabIndex = 1;
            this.ClearBTN.Text = "C";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // PosNegBTN
            // 
            this.PosNegBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosNegBTN.Location = new System.Drawing.Point(3, 438);
            this.PosNegBTN.Name = "PosNegBTN";
            this.PosNegBTN.Size = new System.Drawing.Size(195, 81);
            this.PosNegBTN.TabIndex = 2;
            this.PosNegBTN.Text = "+/-";
            this.PosNegBTN.UseVisualStyleBackColor = true;
            this.PosNegBTN.Click += new System.EventHandler(this.PosNegBTN_Click);
            // 
            // Num0
            // 
            this.Num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num0.Location = new System.Drawing.Point(204, 438);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(195, 81);
            this.Num0.TabIndex = 3;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // DecimalBTN
            // 
            this.DecimalBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalBTN.Location = new System.Drawing.Point(405, 438);
            this.DecimalBTN.Name = "DecimalBTN";
            this.DecimalBTN.Size = new System.Drawing.Size(195, 81);
            this.DecimalBTN.TabIndex = 4;
            this.DecimalBTN.Text = ".";
            this.DecimalBTN.UseVisualStyleBackColor = true;
            this.DecimalBTN.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // EqualBTN
            // 
            this.EqualBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualBTN.Location = new System.Drawing.Point(606, 438);
            this.EqualBTN.Name = "EqualBTN";
            this.EqualBTN.Size = new System.Drawing.Size(195, 81);
            this.EqualBTN.TabIndex = 5;
            this.EqualBTN.Text = "=";
            this.EqualBTN.UseVisualStyleBackColor = true;
            this.EqualBTN.Click += new System.EventHandler(this.EqualBTN_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.Display, 4);
            this.Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(3, 3);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(799, 81);
            this.Display.TabIndex = 20;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PlusBTN;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button MinusBTN;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button MultBTN;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button DivBTN;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Button ClearEntryBTN;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.Button PosNegBTN;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button DecimalBTN;
        private System.Windows.Forms.Button EqualBTN;
        private System.Windows.Forms.TextBox Display;
    }
}

