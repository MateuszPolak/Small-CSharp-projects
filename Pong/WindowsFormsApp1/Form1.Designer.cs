namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startBOX = new System.Windows.Forms.PictureBox();
            this.Paddle = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_ss = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.startBOX);
            this.panel1.Controls.Add(this.Paddle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 453);
            this.panel1.TabIndex = 2;
            // 
            // startBOX
            // 
            this.startBOX.Location = new System.Drawing.Point(50, 50);
            this.startBOX.Name = "startBOX";
            this.startBOX.Size = new System.Drawing.Size(30, 30);
            this.startBOX.TabIndex = 1;
            this.startBOX.TabStop = false;
            this.startBOX.Visible = false;
            // 
            // Paddle
            // 
            this.Paddle.BackColor = System.Drawing.Color.Purple;
            this.Paddle.Location = new System.Drawing.Point(400, 422);
            this.Paddle.Name = "Paddle";
            this.Paddle.Size = new System.Drawing.Size(160, 25);
            this.Paddle.TabIndex = 0;
            this.Paddle.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_ss
            // 
            this.button_ss.Location = new System.Drawing.Point(665, 100);
            this.button_ss.Name = "button_ss";
            this.button_ss.Size = new System.Drawing.Size(134, 60);
            this.button_ss.TabIndex = 3;
            this.button_ss.Text = "Start";
            this.button_ss.UseVisualStyleBackColor = true;
            this.button_ss.Click += new System.EventHandler(this.button_ss_Click);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(665, 182);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(134, 60);
            this.button_generate.TabIndex = 4;
            this.button_generate.Text = "Generate new ball";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 568);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.button_ss);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Pong";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_ss;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.PictureBox Paddle;
        private System.Windows.Forms.PictureBox startBOX;
    }
}

