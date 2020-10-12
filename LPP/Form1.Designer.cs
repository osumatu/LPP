using System.Drawing;
using System.Windows.Forms;

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
            this.truthTableGridView = new System.Windows.Forms.DataGridView();
            this.simplifiedTruthTableGridView = new System.Windows.Forms.DataGridView();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dnf_original_infix_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dnf_original_prefix_lbl = new System.Windows.Forms.Label();
            this.hash_code_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dnf_simplified_infix_lbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dnf_simplified_prefix_lbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.truthTableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplifiedTruthTableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binary_tree_pbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // truthTableGridView
            // 
            this.truthTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.truthTableGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.truthTableGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.truthTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.truthTableGridView.Location = new System.Drawing.Point(412, 115);
            this.truthTableGridView.Margin = new System.Windows.Forms.Padding(20);
            this.truthTableGridView.Name = "truthTableGridView";
            this.truthTableGridView.RowHeadersWidth = 62;
            this.truthTableGridView.Size = new System.Drawing.Size(300, 400);
            this.truthTableGridView.TabIndex = 0;
            // 
            // simplifiedTruthTableGridView
            // 
            this.simplifiedTruthTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.simplifiedTruthTableGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.simplifiedTruthTableGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.simplifiedTruthTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simplifiedTruthTableGridView.Location = new System.Drawing.Point(412, 567);
            this.simplifiedTruthTableGridView.Margin = new System.Windows.Forms.Padding(20);
            this.simplifiedTruthTableGridView.Name = "simplifiedTruthTableGridView";
            this.simplifiedTruthTableGridView.RowHeadersWidth = 62;
            this.simplifiedTruthTableGridView.Size = new System.Drawing.Size(300, 310);
            this.simplifiedTruthTableGridView.TabIndex = 0;
            // 
            // input_process_btn
            // 
            this.input_process_btn.Location = new System.Drawing.Point(57, 146);
            this.input_process_btn.Name = "input_process_btn";
            this.input_process_btn.Size = new System.Drawing.Size(314, 59);
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
            this.binary_tree_pbx.Location = new System.Drawing.Point(735, 344);
            this.binary_tree_pbx.Name = "binary_tree_pbx";
            this.binary_tree_pbx.Size = new System.Drawing.Size(489, 533);
            this.binary_tree_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.binary_tree_pbx.TabIndex = 2;
            this.binary_tree_pbx.TabStop = false;
            // 
            // parsed_formula_lbl
            // 
            this.parsed_formula_lbl.AutoSize = true;
            this.parsed_formula_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parsed_formula_lbl.Location = new System.Drawing.Point(3, 12);
            this.parsed_formula_lbl.MaximumSize = new System.Drawing.Size(0, 29);
            this.parsed_formula_lbl.Name = "parsed_formula_lbl";
            this.parsed_formula_lbl.Size = new System.Drawing.Size(0, 28);
            this.parsed_formula_lbl.TabIndex = 3;
            this.parsed_formula_lbl.UseMnemonic = false;
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.parsed_formula_lbl);
            this.panel1.Location = new System.Drawing.Point(57, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 74);
            this.panel1.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(412, 535);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 30);
            this.label14.TabIndex = 9;
            this.label14.Text = "Simplified truth table";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(412, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 30);
            this.label15.TabIndex = 9;
            this.label15.Text = "Truth table";
            // 
            // dnf_original_infix_lbl
            // 
            this.dnf_original_infix_lbl.AutoSize = true;
            this.dnf_original_infix_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dnf_original_infix_lbl.Location = new System.Drawing.Point(3, 57);
            this.dnf_original_infix_lbl.MaximumSize = new System.Drawing.Size(0, 29);
            this.dnf_original_infix_lbl.Name = "dnf_original_infix_lbl";
            this.dnf_original_infix_lbl.Size = new System.Drawing.Size(0, 28);
            this.dnf_original_infix_lbl.TabIndex = 3;
            this.dnf_original_infix_lbl.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dnf_original_prefix_lbl);
            this.panel2.Controls.Add(this.dnf_original_infix_lbl);
            this.panel2.Location = new System.Drawing.Point(57, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 127);
            this.panel2.TabIndex = 8;
            // 
            // dnf_original_prefix_lbl
            // 
            this.dnf_original_prefix_lbl.AutoSize = true;
            this.dnf_original_prefix_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dnf_original_prefix_lbl.Location = new System.Drawing.Point(3, 18);
            this.dnf_original_prefix_lbl.MaximumSize = new System.Drawing.Size(0, 29);
            this.dnf_original_prefix_lbl.Name = "dnf_original_prefix_lbl";
            this.dnf_original_prefix_lbl.Size = new System.Drawing.Size(0, 28);
            this.dnf_original_prefix_lbl.TabIndex = 3;
            this.dnf_original_prefix_lbl.UseMnemonic = false;
            // 
            // hash_code_lbl
            // 
            this.hash_code_lbl.AutoSize = true;
            this.hash_code_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hash_code_lbl.Location = new System.Drawing.Point(3, 12);
            this.hash_code_lbl.MaximumSize = new System.Drawing.Size(0, 29);
            this.hash_code_lbl.Name = "hash_code_lbl";
            this.hash_code_lbl.Size = new System.Drawing.Size(0, 28);
            this.hash_code_lbl.TabIndex = 3;
            this.hash_code_lbl.UseMnemonic = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.hash_code_lbl);
            this.panel3.Location = new System.Drawing.Point(57, 251);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 74);
            this.panel3.TabIndex = 8;
            // 
            // dnf_simplified_infix_lbl
            // 
            this.dnf_simplified_infix_lbl.AutoSize = true;
            this.dnf_simplified_infix_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dnf_simplified_infix_lbl.Location = new System.Drawing.Point(3, 57);
            this.dnf_simplified_infix_lbl.MaximumSize = new System.Drawing.Size(0, 29);
            this.dnf_simplified_infix_lbl.Name = "dnf_simplified_infix_lbl";
            this.dnf_simplified_infix_lbl.Size = new System.Drawing.Size(0, 28);
            this.dnf_simplified_infix_lbl.TabIndex = 3;
            this.dnf_simplified_infix_lbl.UseMnemonic = false;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.dnf_simplified_prefix_lbl);
            this.panel4.Controls.Add(this.dnf_simplified_infix_lbl);
            this.panel4.Location = new System.Drawing.Point(57, 598);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 127);
            this.panel4.TabIndex = 8;
            // 
            // dnf_simplified_prefix_lbl
            // 
            this.dnf_simplified_prefix_lbl.AutoSize = true;
            this.dnf_simplified_prefix_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dnf_simplified_prefix_lbl.Location = new System.Drawing.Point(3, 18);
            this.dnf_simplified_prefix_lbl.MaximumSize = new System.Drawing.Size(0, 29);
            this.dnf_simplified_prefix_lbl.Name = "dnf_simplified_prefix_lbl";
            this.dnf_simplified_prefix_lbl.Size = new System.Drawing.Size(0, 28);
            this.dnf_simplified_prefix_lbl.TabIndex = 3;
            this.dnf_simplified_prefix_lbl.UseMnemonic = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(57, 330);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 28);
            this.label16.TabIndex = 10;
            this.label16.Text = "Parsed formula";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(57, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 28);
            this.label17.TabIndex = 10;
            this.label17.Text = "Hash code";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(57, 438);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(188, 28);
            this.label18.TabIndex = 10;
            this.label18.Text = "DNF of original TT";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(57, 583);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(209, 28);
            this.label19.TabIndex = 10;
            this.label19.Text = "DNF of simplified TT";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(4, 471);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 28);
            this.label20.TabIndex = 11;
            this.label20.Text = "Prefix";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(4, 616);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 28);
            this.label21.TabIndex = 11;
            this.label21.Text = "Prefix";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(16, 512);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 28);
            this.label22.TabIndex = 11;
            this.label22.Text = "Infix";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(16, 655);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 28);
            this.label23.TabIndex = 11;
            this.label23.Text = "Infix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 898);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exception_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.binary_tree_pbx);
            this.Controls.Add(this.formula_tbx);
            this.Controls.Add(this.input_process_btn);
            this.Controls.Add(this.truthTableGridView);
            this.Controls.Add(this.simplifiedTruthTableGridView);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.truthTableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplifiedTruthTableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binary_tree_pbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button input_process_btn;
        private System.Windows.Forms.DataGridView truthTableGridView;
        private System.Windows.Forms.DataGridView simplifiedTruthTableGridView;
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
        private System.Windows.Forms.Panel panel1;
        private Label label14;
        private Label label15;
        private Label dnf_original_infix_lbl;
        private Panel panel2;
        private Label hash_code_lbl;
        private Panel panel3;
        private Label dnf_simplified_infix_lbl;
        private Panel panel4;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label dnf_original_prefix_lbl;
        private Label dnf_simplified_prefix_lbl;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
    }
}

