namespace SimpleTestcasesGenerator
{
    partial class Main
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pseudoCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_convertedCode = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_outputErrors = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxVariables = new System.Windows.Forms.GroupBox();
            this.dataGridViewVariables = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_generateCode = new System.Windows.Forms.Button();
            this.btn_codeAnalysis = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonAuto = new System.Windows.Forms.RadioButton();
            this.consoleControl = new ConsoleControl.ConsoleControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariables)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 448);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pseudoCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pseudo Code";
            // 
            // txt_pseudoCode
            // 
            this.txt_pseudoCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pseudoCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pseudoCode.Location = new System.Drawing.Point(3, 16);
            this.txt_pseudoCode.Multiline = true;
            this.txt_pseudoCode.Name = "txt_pseudoCode";
            this.txt_pseudoCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_pseudoCode.Size = new System.Drawing.Size(386, 199);
            this.txt_pseudoCode.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_convertedCode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "C# Code";
            // 
            // txt_convertedCode
            // 
            this.txt_convertedCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_convertedCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_convertedCode.Location = new System.Drawing.Point(3, 16);
            this.txt_convertedCode.Multiline = true;
            this.txt_convertedCode.Name = "txt_convertedCode";
            this.txt_convertedCode.ReadOnly = true;
            this.txt_convertedCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_convertedCode.Size = new System.Drawing.Size(386, 109);
            this.txt_convertedCode.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_outputErrors);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 84);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Messages";
            // 
            // txt_outputErrors
            // 
            this.txt_outputErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_outputErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_outputErrors.Location = new System.Drawing.Point(3, 16);
            this.txt_outputErrors.Multiline = true;
            this.txt_outputErrors.Name = "txt_outputErrors";
            this.txt_outputErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_outputErrors.Size = new System.Drawing.Size(386, 65);
            this.txt_outputErrors.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBoxVariables, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(407, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(399, 448);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBoxVariables
            // 
            this.groupBoxVariables.Controls.Add(this.dataGridViewVariables);
            this.groupBoxVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVariables.Location = new System.Drawing.Point(3, 114);
            this.groupBoxVariables.Name = "groupBoxVariables";
            this.groupBoxVariables.Size = new System.Drawing.Size(393, 128);
            this.groupBoxVariables.TabIndex = 0;
            this.groupBoxVariables.TabStop = false;
            this.groupBoxVariables.Text = "Variables";
            // 
            // dataGridViewVariables
            // 
            this.dataGridViewVariables.AllowUserToAddRows = false;
            this.dataGridViewVariables.AllowUserToDeleteRows = false;
            this.dataGridViewVariables.AllowUserToResizeColumns = false;
            this.dataGridViewVariables.AllowUserToResizeRows = false;
            this.dataGridViewVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVariables.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewVariables.Name = "dataGridViewVariables";
            this.dataGridViewVariables.RowHeadersVisible = false;
            this.dataGridViewVariables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVariables.Size = new System.Drawing.Size(387, 109);
            this.dataGridViewVariables.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Initial Value";
            this.Column2.Name = "Column2";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btn_run, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_generateCode, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_codeAnalysis, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(393, 61);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btn_run
            // 
            this.btn_run.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_run.Location = new System.Drawing.Point(265, 3);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(125, 55);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "3. RUN";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_generateCode
            // 
            this.btn_generateCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_generateCode.Location = new System.Drawing.Point(134, 3);
            this.btn_generateCode.Name = "btn_generateCode";
            this.btn_generateCode.Size = new System.Drawing.Size(125, 55);
            this.btn_generateCode.TabIndex = 1;
            this.btn_generateCode.Text = "2. Generate C# Code";
            this.btn_generateCode.UseVisualStyleBackColor = true;
            this.btn_generateCode.Click += new System.EventHandler(this.btn_generateCode_Click);
            // 
            // btn_codeAnalysis
            // 
            this.btn_codeAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_codeAnalysis.Location = new System.Drawing.Point(3, 3);
            this.btn_codeAnalysis.Name = "btn_codeAnalysis";
            this.btn_codeAnalysis.Size = new System.Drawing.Size(125, 55);
            this.btn_codeAnalysis.TabIndex = 0;
            this.btn_codeAnalysis.Text = "1. Code Analysis";
            this.btn_codeAnalysis.UseVisualStyleBackColor = true;
            this.btn_codeAnalysis.Click += new System.EventHandler(this.btn_codeAnalysis_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.radioButtonUser, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.radioButtonAuto, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(393, 38);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonUser.Location = new System.Drawing.Point(199, 3);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(191, 32);
            this.radioButtonUser.TabIndex = 1;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "User Input Test Case";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonAuto
            // 
            this.radioButtonAuto.AutoSize = true;
            this.radioButtonAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonAuto.Location = new System.Drawing.Point(3, 3);
            this.radioButtonAuto.Name = "radioButtonAuto";
            this.radioButtonAuto.Size = new System.Drawing.Size(190, 32);
            this.radioButtonAuto.TabIndex = 0;
            this.radioButtonAuto.TabStop = true;
            this.radioButtonAuto.Text = "Auto Generated Test Cases";
            this.radioButtonAuto.UseVisualStyleBackColor = true;
            // 
            // consoleControl
            // 
            this.consoleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleControl.IsInputEnabled = false;
            this.consoleControl.Location = new System.Drawing.Point(3, 16);
            this.consoleControl.Name = "consoleControl";
            this.consoleControl.SendKeyboardCommandsToProcess = false;
            this.consoleControl.ShowDiagnostics = false;
            this.consoleControl.Size = new System.Drawing.Size(387, 178);
            this.consoleControl.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.consoleControl);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 197);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Console";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxVariables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariables)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_convertedCode;
        private System.Windows.Forms.TextBox txt_pseudoCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxVariables;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_codeAnalysis;
        private System.Windows.Forms.DataGridView dataGridViewVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_generateCode;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox txt_outputErrors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.RadioButton radioButtonAuto;
        private ConsoleControl.ConsoleControl consoleControl;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}