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
            this.formula_variables_lbl = new System.Windows.Forms.Label();
            this.exception_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.binary_tree_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // input_process_btn
            // 
            this.input_process_btn.Location = new System.Drawing.Point(490, 247);
            this.input_process_btn.Name = "input_process_btn";
            this.input_process_btn.Size = new System.Drawing.Size(194, 110);
            this.input_process_btn.TabIndex = 0;
            this.input_process_btn.Text = "Process Input";
            this.input_process_btn.UseVisualStyleBackColor = true;
            this.input_process_btn.Click += new System.EventHandler(this.input_process_btn_Click);
            // 
            // formula_tbx
            // 
            this.formula_tbx.Location = new System.Drawing.Point(21, 96);
            this.formula_tbx.Name = "formula_tbx";
            this.formula_tbx.Size = new System.Drawing.Size(314, 31);
            this.formula_tbx.TabIndex = 1;
            // 
            // binary_tree_pbx
            // 
            this.binary_tree_pbx.Image = ((System.Drawing.Image)(resources.GetObject("binary_tree_pbx.Image")));
            this.binary_tree_pbx.Location = new System.Drawing.Point(21, 185);
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
            this.parsed_formula_lbl.Location = new System.Drawing.Point(452, 97);
            this.parsed_formula_lbl.Name = "parsed_formula_lbl";
            this.parsed_formula_lbl.Size = new System.Drawing.Size(276, 30);
            this.parsed_formula_lbl.TabIndex = 3;
            this.parsed_formula_lbl.Text = "Parsed formula will be here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type in formula in ASCII format";
            // 
            // formula_variables_lbl
            // 
            this.formula_variables_lbl.AutoSize = true;
            this.formula_variables_lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formula_variables_lbl.Location = new System.Drawing.Point(21, 152);
            this.formula_variables_lbl.Name = "formula_variables_lbl";
            this.formula_variables_lbl.Size = new System.Drawing.Size(301, 30);
            this.formula_variables_lbl.TabIndex = 3;
            this.formula_variables_lbl.Text = "Formula variables will be here";
            // 
            // exception_lbl
            // 
            this.exception_lbl.AutoSize = true;
            this.exception_lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exception_lbl.Location = new System.Drawing.Point(203, 9);
            this.exception_lbl.Name = "exception_lbl";
            this.exception_lbl.Size = new System.Drawing.Size(0, 30);
            this.exception_lbl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.exception_lbl);
            this.Controls.Add(this.formula_variables_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parsed_formula_lbl);
            this.Controls.Add(this.binary_tree_pbx);
            this.Controls.Add(this.formula_tbx);
            this.Controls.Add(this.input_process_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.binary_tree_pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button input_process_btn;
        private System.Windows.Forms.TextBox formula_tbx;
        private System.Windows.Forms.PictureBox binary_tree_pbx;
        private System.Windows.Forms.Label parsed_formula_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label formula_variables_lbl;
        private System.Windows.Forms.Label exception_lbl;
    }
}

