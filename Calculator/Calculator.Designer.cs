using System;

namespace Polak9
{
    partial class Calculator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.radioButton1arg = new System.Windows.Forms.RadioButton();
            this.radioButton2arg = new System.Windows.Forms.RadioButton();
            this.textBox1starg = new System.Windows.Forms.TextBox();
            this.textBox2ndarg = new System.Windows.Forms.TextBox();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Location = new System.Drawing.Point(28, 139);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(86, 17);
            this.checkBoxShow.TabIndex = 0;
            this.checkBoxShow.Text = "Show Dialog";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.Location = new System.Drawing.Point(28, 203);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(86, 17);
            this.checkBoxSave.TabIndex = 1;
            this.checkBoxSave.Text = "Save To File";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            this.checkBoxSave.CheckedChanged += new System.EventHandler(this.checkBoxSave_CheckedChanged);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(195, 139);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(261, 81);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click_1);
            // 
            // radioButton1arg
            // 
            this.radioButton1arg.AutoSize = true;
            this.radioButton1arg.Location = new System.Drawing.Point(28, 38);
            this.radioButton1arg.Name = "radioButton1arg";
            this.radioButton1arg.Size = new System.Drawing.Size(92, 17);
            this.radioButton1arg.TabIndex = 3;
            this.radioButton1arg.TabStop = true;
            this.radioButton1arg.Text = "One argument";
            this.radioButton1arg.UseVisualStyleBackColor = true;
            this.radioButton1arg.CheckedChanged += new System.EventHandler(this.radioButton1arg_CheckedChanged);
            // 
            // radioButton2arg
            // 
            this.radioButton2arg.AutoSize = true;
            this.radioButton2arg.Location = new System.Drawing.Point(195, 38);
            this.radioButton2arg.Name = "radioButton2arg";
            this.radioButton2arg.Size = new System.Drawing.Size(98, 17);
            this.radioButton2arg.TabIndex = 4;
            this.radioButton2arg.TabStop = true;
            this.radioButton2arg.Text = "Two arguments";
            this.radioButton2arg.UseVisualStyleBackColor = true;
            this.radioButton2arg.CheckedChanged += new System.EventHandler(this.radioButton2arg_CheckedChanged);
            // 
            // textBox1starg
            // 
            this.textBox1starg.Location = new System.Drawing.Point(28, 89);
            this.textBox1starg.Name = "textBox1starg";
            this.textBox1starg.Size = new System.Drawing.Size(100, 20);
            this.textBox1starg.TabIndex = 5;
            this.textBox1starg.TextChanged += new System.EventHandler(this.textBox1starg_TextChanged);
            // 
            // textBox2ndarg
            // 
            this.textBox2ndarg.Location = new System.Drawing.Point(356, 89);
            this.textBox2ndarg.Name = "textBox2ndarg";
            this.textBox2ndarg.Size = new System.Drawing.Size(100, 20);
            this.textBox2ndarg.TabIndex = 6;
            this.textBox2ndarg.Visible = false;
            this.textBox2ndarg.TextChanged += new System.EventHandler(this.textBox2ndarg_TextChanged);
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Location = new System.Drawing.Point(195, 89);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelect.TabIndex = 7;
            this.comboBoxSelect.Text = "select";
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelect_SelectedIndexChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 258);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.textBox2ndarg);
            this.Controls.Add(this.textBox1starg);
            this.Controls.Add(this.radioButton2arg);
            this.Controls.Add(this.radioButton1arg);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.checkBoxSave);
            this.Controls.Add(this.checkBoxShow);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.RadioButton radioButton1arg;
        private System.Windows.Forms.RadioButton radioButton2arg;
        private System.Windows.Forms.TextBox textBox1starg;
        private System.Windows.Forms.TextBox textBox2ndarg;
        private System.Windows.Forms.ComboBox comboBoxSelect;
    }
}

