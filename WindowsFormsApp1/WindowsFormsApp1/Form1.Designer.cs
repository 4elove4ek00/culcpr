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
            this.sin = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.divisionByElement = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.Remainder = new System.Windows.Forms.Button();
            this.fractionation = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.tenInDegree = new System.Windows.Forms.Button();
            this.module = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arctg = new System.Windows.Forms.Button();
            this.negatively = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.geometricMean = new System.Windows.Forms.Button();
            this.exponentiation = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.IntegerDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(124, 185);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(75, 23);
            this.Multiplication.TabIndex = 0;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Calculator);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(205, 185);
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
            this.Subtraction.Location = new System.Drawing.Point(205, 139);
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
            this.SecondElement.Location = new System.Drawing.Point(220, 62);
            this.SecondElement.Name = "SecondElement";
            this.SecondElement.Size = new System.Drawing.Size(100, 20);
            this.SecondElement.TabIndex = 6;
            // 
            // squaring
            // 
            this.squaring.Location = new System.Drawing.Point(286, 139);
            this.squaring.Name = "squaring";
            this.squaring.Size = new System.Drawing.Size(75, 23);
            this.squaring.TabIndex = 7;
            this.squaring.Text = "^2";
            this.squaring.UseVisualStyleBackColor = true;
            this.squaring.Click += new System.EventHandler(this.OneCalculator);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(286, 185);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(75, 23);
            this.root.TabIndex = 8;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.OneCalculator);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(529, 69);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 9;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneCalculator);
            // 
            // tan
            // 
            this.tan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tan.Location = new System.Drawing.Point(529, 98);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 10;
            this.tan.Text = "Tan";
            this.tan.UseCompatibleTextRendering = true;
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneCalculator);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(610, 98);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(75, 23);
            this.ln.TabIndex = 11;
            this.ln.Text = "Ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.OneCalculator);
            // 
            // divisionByElement
            // 
            this.divisionByElement.Location = new System.Drawing.Point(529, 127);
            this.divisionByElement.Name = "divisionByElement";
            this.divisionByElement.Size = new System.Drawing.Size(75, 23);
            this.divisionByElement.TabIndex = 12;
            this.divisionByElement.Text = "1/x";
            this.divisionByElement.UseVisualStyleBackColor = true;
            this.divisionByElement.Click += new System.EventHandler(this.OneCalculator);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(610, 69);
            this.cos.Name = "cos";
            this.cos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 13;
            this.cos.Text = "Cos";
            this.cos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneCalculator);
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(610, 127);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(75, 23);
            this.Average.TabIndex = 14;
            this.Average.Text = "(x+y)/2";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.Calculator);
            // 
            // Remainder
            // 
            this.Remainder.Location = new System.Drawing.Point(529, 156);
            this.Remainder.Name = "Remainder";
            this.Remainder.Size = new System.Drawing.Size(75, 23);
            this.Remainder.TabIndex = 15;
            this.Remainder.Text = "remainder";
            this.Remainder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Remainder.UseVisualStyleBackColor = true;
            this.Remainder.Click += new System.EventHandler(this.Calculator);
            // 
            // fractionation
            // 
            this.fractionation.Location = new System.Drawing.Point(610, 156);
            this.fractionation.Name = "fractionation";
            this.fractionation.Size = new System.Drawing.Size(75, 23);
            this.fractionation.TabIndex = 16;
            this.fractionation.Text = "x^(1/y)";
            this.fractionation.UseVisualStyleBackColor = true;
            this.fractionation.Click += new System.EventHandler(this.Calculator);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(529, 185);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 17;
            this.max.Text = "Max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.Calculator);
            // 
            // tenInDegree
            // 
            this.tenInDegree.Location = new System.Drawing.Point(610, 185);
            this.tenInDegree.Name = "tenInDegree";
            this.tenInDegree.Size = new System.Drawing.Size(75, 23);
            this.tenInDegree.TabIndex = 18;
            this.tenInDegree.Text = "10^x";
            this.tenInDegree.UseVisualStyleBackColor = true;
            this.tenInDegree.Click += new System.EventHandler(this.OneCalculator);
            // 
            // module
            // 
            this.module.Location = new System.Drawing.Point(43, 304);
            this.module.Name = "module";
            this.module.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.module.Size = new System.Drawing.Size(75, 23);
            this.module.TabIndex = 19;
            this.module.Text = "|x|";
            this.module.UseVisualStyleBackColor = true;
            this.module.Click += new System.EventHandler(this.OneCalculator);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(124, 304);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 20;
            this.arcsin.Text = "Arcsin(x)";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.OneCalculator);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(233, 304);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 21;
            this.arccos.Text = "Arccos(x)";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.OneCalculator);
            // 
            // arctg
            // 
            this.arctg.Location = new System.Drawing.Point(314, 304);
            this.arctg.Name = "arctg";
            this.arctg.Size = new System.Drawing.Size(75, 23);
            this.arctg.TabIndex = 22;
            this.arctg.Text = "Arctg(x)";
            this.arctg.UseVisualStyleBackColor = true;
            this.arctg.Click += new System.EventHandler(this.OneCalculator);
            // 
            // negatively
            // 
            this.negatively.Location = new System.Drawing.Point(395, 304);
            this.negatively.Name = "negatively";
            this.negatively.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.negatively.Size = new System.Drawing.Size(75, 23);
            this.negatively.TabIndex = 23;
            this.negatively.Text = "-x";
            this.negatively.UseVisualStyleBackColor = true;
            this.negatively.Click += new System.EventHandler(this.OneCalculator);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(43, 345);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 24;
            this.min.Text = "Min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.Calculator);
            // 
            // geometricMean
            // 
            this.geometricMean.Location = new System.Drawing.Point(124, 345);
            this.geometricMean.Name = "geometricMean";
            this.geometricMean.Size = new System.Drawing.Size(103, 23);
            this.geometricMean.TabIndex = 25;
            this.geometricMean.Text = "Geometric mean";
            this.geometricMean.UseVisualStyleBackColor = true;
            this.geometricMean.Click += new System.EventHandler(this.Calculator);
            // 
            // exponentiation
            // 
            this.exponentiation.Location = new System.Drawing.Point(233, 345);
            this.exponentiation.Name = "exponentiation";
            this.exponentiation.Size = new System.Drawing.Size(75, 23);
            this.exponentiation.TabIndex = 26;
            this.exponentiation.Text = "x^y";
            this.exponentiation.UseVisualStyleBackColor = true;
            this.exponentiation.Click += new System.EventHandler(this.Calculator);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(314, 345);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 27;
            this.log.Text = "Logx(y)";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.Calculator);
            // 
            // IntegerDivision
            // 
            this.IntegerDivision.Location = new System.Drawing.Point(395, 345);
            this.IntegerDivision.Name = "IntegerDivision";
            this.IntegerDivision.Size = new System.Drawing.Size(104, 23);
            this.IntegerDivision.TabIndex = 28;
            this.IntegerDivision.Text = "Integer division";
            this.IntegerDivision.UseVisualStyleBackColor = true;
            this.IntegerDivision.Click += new System.EventHandler(this.Calculator);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IntegerDivision);
            this.Controls.Add(this.log);
            this.Controls.Add(this.exponentiation);
            this.Controls.Add(this.geometricMean);
            this.Controls.Add(this.min);
            this.Controls.Add(this.negatively);
            this.Controls.Add(this.arctg);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.module);
            this.Controls.Add(this.tenInDegree);
            this.Controls.Add(this.max);
            this.Controls.Add(this.fractionation);
            this.Controls.Add(this.Remainder);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.divisionByElement);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.sin);
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
            this.Click += new System.EventHandler(this.OneCalculator);
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
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button divisionByElement;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Remainder;
        private System.Windows.Forms.Button fractionation;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button tenInDegree;
        private System.Windows.Forms.Button module;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arctg;
        private System.Windows.Forms.Button negatively;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button geometricMean;
        private System.Windows.Forms.Button exponentiation;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button IntegerDivision;
    }
}

