namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MULT = new System.Windows.Forms.Button();
            this.DIV = new System.Windows.Forms.Button();
            this.SUM = new System.Windows.Forms.Button();
            this.SUBT = new System.Windows.Forms.Button();
            this.Conc = new System.Windows.Forms.Label();
            this.Firstel = new System.Windows.Forms.TextBox();
            this.Secondel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MULT
            // 
            this.MULT.Location = new System.Drawing.Point(124, 206);
            this.MULT.Name = "MULT";
            this.MULT.Size = new System.Drawing.Size(75, 23);
            this.MULT.TabIndex = 0;
            this.MULT.Text = "*";
            this.MULT.UseVisualStyleBackColor = true;
            // 
            // DIV
            // 
            this.DIV.Location = new System.Drawing.Point(248, 206);
            this.DIV.Name = "DIV";
            this.DIV.Size = new System.Drawing.Size(75, 23);
            this.DIV.TabIndex = 1;
            this.DIV.Text = "/";
            this.DIV.UseVisualStyleBackColor = true;
            this.DIV.Click += new System.EventHandler(this.button2_Click);
            // 
            // SUM
            // 
            this.SUM.Location = new System.Drawing.Point(124, 139);
            this.SUM.Name = "SUM";
            this.SUM.Size = new System.Drawing.Size(75, 23);
            this.SUM.TabIndex = 2;
            this.SUM.Text = "+";
            this.SUM.UseVisualStyleBackColor = true;
            // 
            // SUBT
            // 
            this.SUBT.Location = new System.Drawing.Point(248, 139);
            this.SUBT.Name = "SUBT";
            this.SUBT.Size = new System.Drawing.Size(75, 23);
            this.SUBT.TabIndex = 3;
            this.SUBT.Text = "-";
            this.SUBT.UseVisualStyleBackColor = true;
            // 
            // Conc
            // 
            this.Conc.AutoSize = true;
            this.Conc.Location = new System.Drawing.Point(400, 69);
            this.Conc.Name = "Conc";
            this.Conc.Size = new System.Drawing.Size(35, 13);
            this.Conc.TabIndex = 4;
            this.Conc.Text = "label1";
            // 
            // Firstel
            // 
            this.Firstel.Location = new System.Drawing.Point(114, 62);
            this.Firstel.Name = "Firstel";
            this.Firstel.Size = new System.Drawing.Size(100, 20);
            this.Firstel.TabIndex = 5;
            // 
            // Secondel
            // 
            this.Secondel.Location = new System.Drawing.Point(248, 62);
            this.Secondel.Name = "Secondel";
            this.Secondel.Size = new System.Drawing.Size(100, 20);
            this.Secondel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Secondel);
            this.Controls.Add(this.Firstel);
            this.Controls.Add(this.Conc);
            this.Controls.Add(this.SUBT);
            this.Controls.Add(this.SUM);
            this.Controls.Add(this.DIV);
            this.Controls.Add(this.MULT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MULT;
        private System.Windows.Forms.Button DIV;
        private System.Windows.Forms.Button SUM;
        private System.Windows.Forms.Button SUBT;
        private System.Windows.Forms.Label Conc;
        private System.Windows.Forms.TextBox Firstel;
        private System.Windows.Forms.TextBox Secondel;
    }
}

