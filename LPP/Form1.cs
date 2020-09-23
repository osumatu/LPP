using LPP.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPP
{
    public partial class Form1 : Form
    {
        BinaryTree tree;
        public Form1()
        {
            InitializeComponent();
        }

        private void input_process_btn_Click(object sender, EventArgs e)
        {
            this.exception_lbl.Text = "";
            try
            {
                string formula = this.formula_tbx.Text;
                this.formula_tbx.Enabled = !(this.formula_tbx.Enabled);
                if (this.formula_tbx.Enabled)
                {
                    this.CleanFormControllers();
                }
                else
                {
                    this.input_process_btn.Text = "Enter another formula";
                    tree = new BinaryTree(formula);
                    this.binary_tree_pbx.ImageLocation = tree.GetTreeImage();
                    this.parsed_formula_lbl.Text = tree.PrintParsedFormula();
                    this.truth_table_lbl.Text = tree.GetTruthTable();
                }
            }
            catch (InvalidFormula ex)
            {
                this.exception_lbl.Text = ex.Message;
                this.input_process_btn.Text = "Enter another formula";
                this.exception_lbl.ForeColor = Color.Red;
            }
        }

        private void CleanFormControllers()
        {
            this.input_process_btn.Text = "Process Input";
            this.formula_tbx.Text = "";
            this.parsed_formula_lbl.Text = "Parsed formula will be here";
            this.binary_tree_pbx.Image = Properties.Resources.tree_holder;
            this.truth_table_lbl.Text = "";
        }
    }
}
