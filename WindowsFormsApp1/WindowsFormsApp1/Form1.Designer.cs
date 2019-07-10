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
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Conclusion = new System.Windows.Forms.Label();
            this.FirstElement = new System.Windows.Forms.TextBox();
            this.SecondElement = new System.Windows.Forms.TextBox();
            this.squaring = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(124, 206);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(75, 23);
            this.Multiplication.TabIndex = 0;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Calculator);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(248, 206);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 1;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Calculator);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(124, 139);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(75, 23);
            this.Addition.TabIndex = 2;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Calculator);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(248, 139);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(75, 23);
            this.Subtraction.TabIndex = 3;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Calculator);
            // 
            // Conclusion
            // 
            this.Conclusion.AutoSize = true;
            this.Conclusion.Location = new System.Drawing.Point(400, 69);
            this.Conclusion.Name = "Conclusion";
            this.Conclusion.Size = new System.Drawing.Size(13, 13);
            this.Conclusion.TabIndex = 4;
            this.Conclusion.Text = "0";
            this.Conclusion.Click += new System.EventHandler(this.Conclusion_Click);
            // 
            // FirstElement
            // 
            this.FirstElement.Location = new System.Drawing.Point(114, 62);
            this.FirstElement.Name = "FirstElement";
            this.FirstElement.Size = new System.Drawing.Size(100, 20);
            this.FirstElement.TabIndex = 5;
            // 
            // SecondElement
            // 
            this.SecondElement.Location = new System.Drawing.Point(248, 62);
            this.SecondElement.Name = "SecondElement";
            this.SecondElement.Size = new System.Drawing.Size(100, 20);
            this.SecondElement.TabIndex = 6;
            // 
            // squaring
            // 
            this.squaring.Location = new System.Drawing.Point(360, 139);
            this.squaring.Name = "squaring";
            this.squaring.Size = new System.Drawing.Size(75, 23);
            this.squaring.TabIndex = 7;
            this.squaring.Text = "^2";
            this.squaring.UseVisualStyleBackColor = true;
            this.squaring.Click += new System.EventHandler(this.OneCalculator);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(360, 206);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(75, 23);
            this.root.TabIndex = 8;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.OneCalculator);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.root);
            this.Controls.Add(this.squaring);
            this.Controls.Add(this.SecondElement);
            this.Controls.Add(this.FirstElement);
            this.Controls.Add(this.Conclusion);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Label Conclusion;
        private System.Windows.Forms.TextBox FirstElement;
        private System.Windows.Forms.TextBox SecondElement;
        private System.Windows.Forms.Button squaring;
        private System.Windows.Forms.Button root;
    }
}

