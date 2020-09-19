namespace LPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input_process_btn = new System.Windows.Forms.Button();
            this.formula_tbx = new System.Windows.Forms.TextBox();
            this.binary_tree_pbx = new System.Windows.Forms.PictureBox();
            this.parsed_formula_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exception_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.truth_table_gbx = new System.Windows.Forms.GroupBox();
            this.truth_table_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.binary_tree_pbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.truth_table_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_process_btn
            // 
            this.input_process_btn.Location = new System.Drawing.Point(809, 369);
            this.input_process_btn.Name = "input_process_btn";
            this.input_process_btn.Size = new System.Drawing.Size(194, 110);
            this.input_process_btn.TabIndex = 0;
            this.input_process_btn.Text = "Process Input";
            this.input_process_btn.UseVisualStyleBackColor = true;
            this.input_process_btn.Click += new System.EventHandler(this.input_process_btn_Click);
            // 
            // formula_tbx
            // 
            this.formula_tbx.Location = new System.Drawing.Point(57, 96);
            this.formula_tbx.Name = "formula_tbx";
            this.formula_tbx.Size = new System.Drawing.Size(314, 31);
            this.formula_tbx.TabIndex = 1;
            // 
            // binary_tree_pbx
            // 
            this.binary_tree_pbx.Image = ((System.Drawing.Image)(resources.GetObject("binary_tree_pbx.Image")));
            this.binary_tree_pbx.Location = new System.Drawing.Point(57, 185);
            this.binary_tree_pbx.Name = "binary_tree_pbx";
            this.binary_tree_pbx.Size = new System.Drawing.Size(314, 304);
            this.binary_tree_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.binary_tree_pbx.TabIndex = 2;
            this.binary_tree_pbx.TabStop = false;
            // 
            // parsed_formula_lbl
            // 
            this.parsed_formula_lbl.AutoSize = true;
            this.parsed_formula_lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parsed_formula_lbl.Location = new System.Drawing.Point(57, 148);
            this.parsed_formula_lbl.Name = "parsed_formula_lbl";
            this.parsed_formula_lbl.Size = new System.Drawing.Size(276, 30);
            this.parsed_formula_lbl.TabIndex = 3;
            this.parsed_formula_lbl.Text = "Parsed formula will be here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type in formula in ASCII format";
            // 
            // exception_lbl
            // 
            this.exception_lbl.AutoSize = true;
            this.exception_lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exception_lbl.Location = new System.Drawing.Point(156, 18);
            this.exception_lbl.Name = "exception_lbl";
            this.exception_lbl.Size = new System.Drawing.Size(0, 30);
            this.exception_lbl.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(748, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 247);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symbol notations";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(51, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 30);
            this.label13.TabIndex = 0;
            this.label13.Text = "A ⋁ B";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(191, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "|(A,B)";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(51, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "A ⋀ B";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(191, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "&(A,B)";
            this.label10.UseMnemonic = false;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(51, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "A ⇔ B";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(191, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "=(A,B)";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(51, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "A ⇒ B";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(191, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = ">(A,B)";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(191, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "~(A)";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(51, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "¬A";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(191, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "ASCII";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Logic notation";
            // 
            // truth_table_gbx
            // 
            this.truth_table_gbx.Controls.Add(this.truth_table_lbl);
            this.truth_table_gbx.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.truth_table_gbx.ForeColor = System.Drawing.Color.Green;
            this.truth_table_gbx.Location = new System.Drawing.Point(407, 80);
            this.truth_table_gbx.Name = "truth_table_gbx";
            this.truth_table_gbx.Size = new System.Drawing.Size(320, 409);
            this.truth_table_gbx.TabIndex = 7;
            this.truth_table_gbx.TabStop = false;
            this.truth_table_gbx.Text = "Truth table";
            // 
            // truth_table_lbl
            // 
            this.truth_table_lbl.AutoSize = true;
            this.truth_table_lbl.ForeColor = System.Drawing.Color.Black;
            this.truth_table_lbl.Location = new System.Drawing.Point(22, 68);
            this.truth_table_lbl.Name = "truth_table_lbl";
            this.truth_table_lbl.Size = new System.Drawing.Size(0, 30);
            this.truth_table_lbl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 546);
            this.Controls.Add(this.truth_table_gbx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exception_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parsed_formula_lbl);
            this.Controls.Add(this.binary_tree_pbx);
            this.Controls.Add(this.formula_tbx);
            this.Controls.Add(this.input_process_btn);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.binary_tree_pbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.truth_table_gbx.ResumeLayout(false);
            this.truth_table_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button input_process_btn;
        private System.Windows.Forms.TextBox formula_tbx;
        private System.Windows.Forms.PictureBox binary_tree_pbx;
        private System.Windows.Forms.Label parsed_formula_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exception_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox truth_table_gbx;
        private System.Windows.Forms.Label truth_table_lbl;
    }
}

