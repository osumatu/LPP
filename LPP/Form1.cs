using LPP.Data_structures;
using LPP.Exceptions;
using LPP.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
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
            exception_lbl.Text = "";
            try
            {
                string formula = formula_tbx.Text;
                formula_tbx.Enabled = !(formula_tbx.Enabled);
                if (formula_tbx.Enabled)
                {
                    CleanFormControllers();
                }
                else
                {
                    input_process_btn.Text = "Enter another formula";
                    tree = new BinaryTree(formula);
                    binary_tree_pbx.ImageLocation = tree.GetTreeImage();
                    parsed_formula_lbl.Text = tree.PrintParsedFormula();
                    GenerateGridView(ref truthTableGridView, tree.GetOriginalTable(), tree.GetTableHeaders());
                    GenerateGridView(ref simplifiedTruthTableGridView, tree.GetSimplifiedTable(), tree.GetTableHeaders());
                    hash_code_lbl.Text = tree.GetTruthTableHashCode();
                    DNFModel dnfOfOriginalTable = tree.GetOriginalTableDNF();
                    dnf_original_infix_lbl.Text = dnfOfOriginalTable.InfixFormat;
                    dnf_original_prefix_lbl.Text = dnfOfOriginalTable.PrefixFormat;
                    DNFModel dnfOfSimplifiedTable = tree.GetSimplifiedTableDNF();
                    dnf_simplified_infix_lbl.Text = dnfOfSimplifiedTable.InfixFormat;
                    dnf_simplified_prefix_lbl.Text = dnfOfSimplifiedTable.PrefixFormat;
                    nandify_lbl.Text = tree.NandifyFormula();
                }
            }
            catch (InvalidFormula ex)
            {
                exception_lbl.Text = ex.Message;
                input_process_btn.Text = "Enter another formula";
                exception_lbl.ForeColor = Color.Red;
            }
        }

        private void CleanFormControllers()
        {
            input_process_btn.Text = "Process Input";
            truthTableGridView.Rows.Clear();
            truthTableGridView.Columns.Clear();
            truthTableGridView.Refresh();
            simplifiedTruthTableGridView.Rows.Clear();
            simplifiedTruthTableGridView.Columns.Clear();
            simplifiedTruthTableGridView.Refresh();
            formula_tbx.Text = "";
            parsed_formula_lbl.Text = "";
            hash_code_lbl.Text = "";
            dnf_original_infix_lbl.Text = "";
            dnf_simplified_infix_lbl.Text = "";
            dnf_original_prefix_lbl.Text = "";
            dnf_simplified_prefix_lbl.Text = "";
            binary_tree_pbx.Image = Image.FromFile(@"..\..\..\images\tree_holder.png");
            nandify_lbl.Text = "";
        }

        private void GenerateGridView(ref DataGridView view, char[][] data, string[] headers)
        {
            view.ColumnCount = headers.Count();
            view.ColumnHeadersVisible = true;
            view.ReadOnly = true;
            view.AllowUserToAddRows = false;
            view.AllowUserToDeleteRows = false;
            view.AllowUserToResizeRows = false;
            view.AllowUserToResizeColumns = false;
            view.RowHeadersVisible = false;
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
