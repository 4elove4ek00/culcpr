namespace Calcpr
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Multiplication
            // 
            this.Multiplication.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiplication.Location = new System.Drawing.Point(15, 127);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(75, 23);
            this.Multiplication.TabIndex = 0;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Calculator);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Division.Location = new System.Drawing.Point(96, 127);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 1;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Calculator);
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Addition.Location = new System.Drawing.Point(15, 81);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(75, 23);
            this.Addition.TabIndex = 2;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Calculator);
            // 
            // Subtraction
            // 
            this.Subtraction.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subtraction.Location = new System.Drawing.Point(96, 81);
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
            this.Conclusion.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Conclusion.Location = new System.Drawing.Point(379, 31);
            this.Conclusion.Name = "Conclusion";
            this.Conclusion.Size = new System.Drawing.Size(20, 23);
            this.Conclusion.TabIndex = 4;
            this.Conclusion.Text = "0";
            this.Conclusion.Click += new System.EventHandler(this.Conclusion_Click);
            // 
            // FirstElement
            // 
            this.FirstElement.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstElement.Location = new System.Drawing.Point(18, 24);
            this.FirstElement.Name = "FirstElement";
            this.FirstElement.Size = new System.Drawing.Size(100, 30);
            this.FirstElement.TabIndex = 5;
            // 
            // SecondElement
            // 
            this.SecondElement.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondElement.Location = new System.Drawing.Point(139, 24);
            this.SecondElement.Name = "SecondElement";
            this.SecondElement.Size = new System.Drawing.Size(100, 30);
            this.SecondElement.TabIndex = 6;
            // 
            // squaring
            // 
            this.squaring.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squaring.Location = new System.Drawing.Point(177, 81);
            this.squaring.Name = "squaring";
            this.squaring.Size = new System.Drawing.Size(75, 23);
            this.squaring.TabIndex = 7;
            this.squaring.Text = "^2";
            this.squaring.UseVisualStyleBackColor = true;
            this.squaring.Click += new System.EventHandler(this.OneCalculator);
            // 
            // root
            // 
            this.root.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.root.Location = new System.Drawing.Point(177, 127);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(75, 23);
            this.root.TabIndex = 8;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.OneCalculator);
            // 
            // sin
            // 
            this.sin.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sin.Location = new System.Drawing.Point(289, 77);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 9;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneCalculator);
            // 
            // tan
            // 
            this.tan.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tan.Location = new System.Drawing.Point(289, 106);
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
            this.ln.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ln.Location = new System.Drawing.Point(370, 106);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(75, 23);
            this.ln.TabIndex = 11;
            this.ln.Text = "Ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.OneCalculator);
            // 
            // divisionByElement
            // 
            this.divisionByElement.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionByElement.Location = new System.Drawing.Point(289, 135);
            this.divisionByElement.Name = "divisionByElement";
            this.divisionByElement.Size = new System.Drawing.Size(75, 23);
            this.divisionByElement.TabIndex = 12;
            this.divisionByElement.Text = "1/x";
            this.divisionByElement.UseVisualStyleBackColor = true;
            this.divisionByElement.Click += new System.EventHandler(this.OneCalculator);
            // 
            // cos
            // 
            this.cos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cos.Location = new System.Drawing.Point(370, 77);
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
            this.Average.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Average.Location = new System.Drawing.Point(370, 135);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(75, 23);
            this.Average.TabIndex = 14;
            this.Average.Text = "(x+y)/2";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.Calculator);
            // 
            // Remainder
            // 
            this.Remainder.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remainder.Location = new System.Drawing.Point(289, 164);
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
            this.fractionation.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fractionation.Location = new System.Drawing.Point(370, 164);
            this.fractionation.Name = "fractionation";
            this.fractionation.Size = new System.Drawing.Size(75, 23);
            this.fractionation.TabIndex = 16;
            this.fractionation.Text = "x^(1/y)";
            this.fractionation.UseVisualStyleBackColor = true;
            this.fractionation.Click += new System.EventHandler(this.Calculator);
            // 
            // max
            // 
            this.max.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max.Location = new System.Drawing.Point(289, 193);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 17;
            this.max.Text = "Max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.Calculator);
            // 
            // tenInDegree
            // 
            this.tenInDegree.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenInDegree.Location = new System.Drawing.Point(370, 193);
            this.tenInDegree.Name = "tenInDegree";
            this.tenInDegree.Size = new System.Drawing.Size(75, 23);
            this.tenInDegree.TabIndex = 18;
            this.tenInDegree.Text = "10^x";
            this.tenInDegree.UseVisualStyleBackColor = true;
            this.tenInDegree.Click += new System.EventHandler(this.OneCalculator);
            // 
            // module
            // 
            this.module.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.module.Location = new System.Drawing.Point(18, 248);
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
            this.arcsin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arcsin.Location = new System.Drawing.Point(370, 289);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 20;
            this.arcsin.Text = "Arcsin(x)";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.OneCalculator);
            // 
            // arccos
            // 
            this.arccos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arccos.Location = new System.Drawing.Point(208, 248);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 21;
            this.arccos.Text = "Arccos(x)";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.OneCalculator);
            // 
            // arctg
            // 
            this.arctg.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arctg.Location = new System.Drawing.Point(289, 248);
            this.arctg.Name = "arctg";
            this.arctg.Size = new System.Drawing.Size(75, 23);
            this.arctg.TabIndex = 22;
            this.arctg.Text = "Arctg(x)";
            this.arctg.UseVisualStyleBackColor = true;
            this.arctg.Click += new System.EventHandler(this.OneCalculator);
            // 
            // negatively
            // 
            this.negatively.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.negatively.Location = new System.Drawing.Point(370, 248);
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
            this.min.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min.Location = new System.Drawing.Point(18, 289);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 24;
            this.min.Text = "Min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.Calculator);
            // 
            // geometricMean
            // 
            this.geometricMean.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.geometricMean.Location = new System.Drawing.Point(99, 289);
            this.geometricMean.Name = "geometricMean";
            this.geometricMean.Size = new System.Drawing.Size(103, 23);
            this.geometricMean.TabIndex = 25;
            this.geometricMean.Text = "Geometric mean";
            this.geometricMean.UseVisualStyleBackColor = true;
            this.geometricMean.Click += new System.EventHandler(this.Calculator);
            // 
            // exponentiation
            // 
            this.exponentiation.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exponentiation.Location = new System.Drawing.Point(208, 289);
            this.exponentiation.Name = "exponentiation";
            this.exponentiation.Size = new System.Drawing.Size(75, 23);
            this.exponentiation.TabIndex = 26;
            this.exponentiation.Text = "x^y";
            this.exponentiation.UseVisualStyleBackColor = true;
            this.exponentiation.Click += new System.EventHandler(this.Calculator);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(289, 289);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 27;
            this.log.Text = "Logx(y)";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.Calculator);
            // 
            // IntegerDivision
            // 
            this.IntegerDivision.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntegerDivision.Location = new System.Drawing.Point(99, 248);
            this.IntegerDivision.Name = "IntegerDivision";
            this.IntegerDivision.Size = new System.Drawing.Size(104, 23);
            this.IntegerDivision.TabIndex = 28;
            this.IntegerDivision.Text = "Integer division";
            this.IntegerDivision.UseVisualStyleBackColor = true;
            this.IntegerDivision.Click += new System.EventHandler(this.Calculator);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Результат:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 329);
            this.Controls.Add(this.label1);
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
            this.Text = "Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label1;
    }
}

