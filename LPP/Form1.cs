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
                    this.GenerateGridView(ref truthTableGridView, this.tree.GetTruthTable(), this.tree.GetTableHeaders());
                    this.simplifiedTruthTableGridView.Visible = true;
                    this.GenerateGridView(ref simplifiedTruthTableGridView, this.tree.GetSimplifiedTruthTable(), this.tree.GetTableHeaders());
                    tree.GetTruthTable();
                    tree.GetSimplifiedTruthTable();
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
            this.truthTableGridView.Rows.Clear();
            this.truthTableGridView.Columns.Clear();
            this.truthTableGridView.Refresh();
            this.simplifiedTruthTableGridView.Rows.Clear();
            this.simplifiedTruthTableGridView.Columns.Clear();
            this.simplifiedTruthTableGridView.Refresh();
            this.formula_tbx.Text = "";
            this.parsed_formula_lbl.Text = "Future parsed formula";
            this.hash_code_lbl.Text = "Future hash code";
            this.dnf_original_lbl.Text = "Future DNF of original TT";
            this.dnf_simplified_lbl.Text = "Future DNF of simplified TT";
            this.binary_tree_pbx.Image = Properties.Resources.tree_holder;
        }

        private void GenerateGridView(ref DataGridView view, char[][] data, string[] headers)
        {
            view.ColumnCount = headers.Count();
            view.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            view.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            for (int i = 0; i < headers.Count(); i++)
            {
                view.Columns[i].Name = headers[i];
                view.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < data.GetLength(0); i++)
            {
                var dataString = data[i].Select(c => c.ToString()).ToArray();
                view.Rows.Add(dataString);
            }
        }
    }
}
