using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTestcasesGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            radioButtonAuto.Checked = true;
        }

        List<Variable> variables;
        List<Condition> conditions;
        private void btn_codeAnalysis_Click(object sender, EventArgs e)
        {
            dataGridViewVariables.Rows.Clear();

            variables = PseudoCodeAnalysis.GetVariables(txt_pseudoCode.Text);
            foreach (var item in variables)
                dataGridViewVariables.Rows.Add(item.Name, item.AssignmentVariable);
        }

        private void btn_generateCode_Click(object sender, EventArgs e)
        {
            txt_convertedCode.Text = "";

            for (int i = 0; i < dataGridViewVariables.Rows.Count; i++)
            {
                var item = dataGridViewVariables.Rows[i];
                if (item.Cells[1].Value != null)
                {
                    if (item.Cells[1].Value.ToString() != "")
                        variables.Find(x => x.Name == item.Cells[0].Value.ToString()).AssignmentVariable =
                                item.Cells[1].Value.ToString();
                }
                else
                    variables.Find(x => x.Name == item.Cells[0].Value.ToString()).AssignmentVariable = null;
            }

            conditions = PseudoCodeAnalysis.GetConditions(txt_pseudoCode.Text);
            if (radioButtonAuto.Checked)
                txt_convertedCode.Text = PseudoCodeAnalysis.GenerateCSharpCode(variables, conditions, true);
            else
                txt_convertedCode.Text = PseudoCodeAnalysis.GenerateCSharpCode(variables, conditions, false);
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            consoleControl.ClearOutput();
            string result = PseudoCodeAnalysis.CompileCode(txt_convertedCode.Text);

            txt_outputErrors.Text = result;
            if (result == "Code Compiled Successfully.")
            {
                txt_outputErrors.ForeColor = Color.LimeGreen;
                //Process.Start("CompiledApp.exe");
                consoleControl.StartProcess("CompiledApp.exe", "");
            }
            else
            {
                txt_outputErrors.ForeColor = Color.Red;
                //MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
