namespace CalculatorForm
{
    partial class MainForm
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bMultiplication = new System.Windows.Forms.Button();
            this.bDivision = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bBackspace = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.tbNumberStatus = new System.Windows.Forms.TextBox();
            this.bEqually = new System.Windows.Forms.Button();
            this.bSqrt = new System.Windows.Forms.Button();
            this.bPow = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Label();
            this.ActiveOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 158);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(32, 32);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(50, 158);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(32, 32);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(88, 158);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(32, 32);
            this.b3.TabIndex = 2;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 120);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(32, 32);
            this.b4.TabIndex = 3;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(50, 120);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(32, 32);
            this.b5.TabIndex = 4;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(88, 120);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(32, 32);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 82);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(32, 32);
            this.b7.TabIndex = 6;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(50, 82);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(32, 32);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(88, 82);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(32, 32);
            this.b9.TabIndex = 8;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 196);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(70, 32);
            this.b0.TabIndex = 9;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(126, 196);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(32, 32);
            this.bAdd.TabIndex = 10;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSub
            // 
            this.bSub.Location = new System.Drawing.Point(126, 158);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(32, 32);
            this.bSub.TabIndex = 11;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.bSub_Click);
            // 
            // bMultiplication
            // 
            this.bMultiplication.Location = new System.Drawing.Point(126, 120);
            this.bMultiplication.Name = "bMultiplication";
            this.bMultiplication.Size = new System.Drawing.Size(32, 32);
            this.bMultiplication.TabIndex = 12;
            this.bMultiplication.Text = "x";
            this.bMultiplication.UseVisualStyleBackColor = true;
            this.bMultiplication.Click += new System.EventHandler(this.bMultiplication_Click);
            // 
            // bDivision
            // 
            this.bDivision.Location = new System.Drawing.Point(126, 82);
            this.bDivision.Name = "bDivision";
            this.bDivision.Size = new System.Drawing.Size(32, 32);
            this.bDivision.TabIndex = 13;
            this.bDivision.Text = "/";
            this.bDivision.UseVisualStyleBackColor = true;
            this.bDivision.Click += new System.EventHandler(this.bDivision_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(164, 44);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(32, 32);
            this.bClear.TabIndex = 14;
            this.bClear.Text = "С";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bBackspace
            // 
            this.bBackspace.Location = new System.Drawing.Point(12, 44);
            this.bBackspace.Name = "bBackspace";
            this.bBackspace.Size = new System.Drawing.Size(32, 32);
            this.bBackspace.TabIndex = 15;
            this.bBackspace.Text = "←";
            this.bBackspace.UseVisualStyleBackColor = true;
            this.bBackspace.Click += new System.EventHandler(this.bBackspace_Click);
            // 
            // bDot
            // 
            this.bDot.Location = new System.Drawing.Point(88, 196);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(32, 32);
            this.bDot.TabIndex = 16;
            this.bDot.Text = ",";
            this.bDot.UseVisualStyleBackColor = true;
            // 
            // tbNumberStatus
            // 
            this.tbNumberStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumberStatus.Location = new System.Drawing.Point(12, 12);
            this.tbNumberStatus.Name = "tbNumberStatus";
            this.tbNumberStatus.Size = new System.Drawing.Size(184, 26);
            this.tbNumberStatus.TabIndex = 17;
            this.tbNumberStatus.Text = "0";
            this.tbNumberStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bEqually
            // 
            this.bEqually.Location = new System.Drawing.Point(164, 158);
            this.bEqually.Name = "bEqually";
            this.bEqually.Size = new System.Drawing.Size(32, 70);
            this.bEqually.TabIndex = 18;
            this.bEqually.Text = "=";
            this.bEqually.UseVisualStyleBackColor = true;
            this.bEqually.Click += new System.EventHandler(this.bEqually_Click);
            // 
            // bSqrt
            // 
            this.bSqrt.Location = new System.Drawing.Point(164, 82);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(32, 32);
            this.bSqrt.TabIndex = 19;
            this.bSqrt.Text = "√";
            this.bSqrt.UseVisualStyleBackColor = true;
            this.bSqrt.Click += new System.EventHandler(this.bSqrt_Click);
            // 
            // bPow
            // 
            this.bPow.Location = new System.Drawing.Point(164, 120);
            this.bPow.Name = "bPow";
            this.bPow.Size = new System.Drawing.Size(32, 32);
            this.bPow.TabIndex = 20;
            this.bPow.Text = "xⁿ";
            this.bPow.UseVisualStyleBackColor = true;
            this.bPow.Click += new System.EventHandler(this.bPow_Click);
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.Location = new System.Drawing.Point(51, 45);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(39, 13);
            this.History.TabIndex = 21;
            this.History.Text = "History";
            // 
            // ActiveOperation
            // 
            this.ActiveOperation.AutoSize = true;
            this.ActiveOperation.Location = new System.Drawing.Point(51, 63);
            this.ActiveOperation.Name = "ActiveOperation";
            this.ActiveOperation.Size = new System.Drawing.Size(13, 13);
            this.ActiveOperation.TabIndex = 22;
            this.ActiveOperation.Text = "+";
            this.ActiveOperation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 240);
            this.Controls.Add(this.ActiveOperation);
            this.Controls.Add(this.History);
            this.Controls.Add(this.bPow);
            this.Controls.Add(this.bSqrt);
            this.Controls.Add(this.bEqually);
            this.Controls.Add(this.tbNumberStatus);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.bBackspace);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bDivision);
            this.Controls.Add(this.bMultiplication);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bMultiplication;
        private System.Windows.Forms.Button bDivision;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bBackspace;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.TextBox tbNumberStatus;
        private System.Windows.Forms.Button bEqually;
        private System.Windows.Forms.Button bSqrt;
        private System.Windows.Forms.Button bPow;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Label ActiveOperation;
    }
}

