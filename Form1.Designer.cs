namespace Simulation_Lab17
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxInten1 = new System.Windows.Forms.TextBox();
            this.textBoxInten2 = new System.Windows.Forms.TextBox();
            this.textBoxL1Mean = new System.Windows.Forms.TextBox();
            this.textBoxL1Variance = new System.Windows.Forms.TextBox();
            this.textBoxL2Variance = new System.Windows.Forms.TextBox();
            this.textBoxL2Mean = new System.Windows.Forms.TextBox();
            this.textBoxL3Variance = new System.Windows.Forms.TextBox();
            this.textBoxL3Mean = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInten3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumSim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "l1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "l2:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxInten1
            // 
            this.textBoxInten1.Location = new System.Drawing.Point(42, 44);
            this.textBoxInten1.Name = "textBoxInten1";
            this.textBoxInten1.Size = new System.Drawing.Size(44, 20);
            this.textBoxInten1.TabIndex = 4;
            this.textBoxInten1.Text = "8";
            // 
            // textBoxInten2
            // 
            this.textBoxInten2.Location = new System.Drawing.Point(42, 128);
            this.textBoxInten2.Name = "textBoxInten2";
            this.textBoxInten2.Size = new System.Drawing.Size(44, 20);
            this.textBoxInten2.TabIndex = 5;
            this.textBoxInten2.Text = "4";
            // 
            // textBoxL1Mean
            // 
            this.textBoxL1Mean.Location = new System.Drawing.Point(42, 70);
            this.textBoxL1Mean.Name = "textBoxL1Mean";
            this.textBoxL1Mean.ReadOnly = true;
            this.textBoxL1Mean.Size = new System.Drawing.Size(167, 20);
            this.textBoxL1Mean.TabIndex = 6;
            this.textBoxL1Mean.Text = "average:";
            // 
            // textBoxL1Variance
            // 
            this.textBoxL1Variance.Location = new System.Drawing.Point(42, 96);
            this.textBoxL1Variance.Name = "textBoxL1Variance";
            this.textBoxL1Variance.ReadOnly = true;
            this.textBoxL1Variance.Size = new System.Drawing.Size(167, 20);
            this.textBoxL1Variance.TabIndex = 7;
            this.textBoxL1Variance.Text = "variance:";
            // 
            // textBoxL2Variance
            // 
            this.textBoxL2Variance.Location = new System.Drawing.Point(42, 180);
            this.textBoxL2Variance.Name = "textBoxL2Variance";
            this.textBoxL2Variance.ReadOnly = true;
            this.textBoxL2Variance.Size = new System.Drawing.Size(167, 20);
            this.textBoxL2Variance.TabIndex = 9;
            this.textBoxL2Variance.Text = "variance:";
            // 
            // textBoxL2Mean
            // 
            this.textBoxL2Mean.Location = new System.Drawing.Point(42, 154);
            this.textBoxL2Mean.Name = "textBoxL2Mean";
            this.textBoxL2Mean.ReadOnly = true;
            this.textBoxL2Mean.Size = new System.Drawing.Size(167, 20);
            this.textBoxL2Mean.TabIndex = 8;
            this.textBoxL2Mean.Text = "average:";
            // 
            // textBoxL3Variance
            // 
            this.textBoxL3Variance.Location = new System.Drawing.Point(42, 261);
            this.textBoxL3Variance.Name = "textBoxL3Variance";
            this.textBoxL3Variance.ReadOnly = true;
            this.textBoxL3Variance.Size = new System.Drawing.Size(167, 20);
            this.textBoxL3Variance.TabIndex = 11;
            this.textBoxL3Variance.Text = "variance:";
            // 
            // textBoxL3Mean
            // 
            this.textBoxL3Mean.Location = new System.Drawing.Point(42, 235);
            this.textBoxL3Mean.Name = "textBoxL3Mean";
            this.textBoxL3Mean.ReadOnly = true;
            this.textBoxL3Mean.Size = new System.Drawing.Size(167, 20);
            this.textBoxL3Mean.TabIndex = 10;
            this.textBoxL3Mean.Text = "average:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(108, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "l3 =  l1 +  l2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInten3
            // 
            this.textBoxInten3.Location = new System.Drawing.Point(42, 209);
            this.textBoxInten3.Name = "textBoxInten3";
            this.textBoxInten3.ReadOnly = true;
            this.textBoxInten3.Size = new System.Drawing.Size(44, 20);
            this.textBoxInten3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "l3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "N:";
            // 
            // textBoxNumSim
            // 
            this.textBoxNumSim.Location = new System.Drawing.Point(42, 15);
            this.textBoxNumSim.Name = "textBoxNumSim";
            this.textBoxNumSim.Size = new System.Drawing.Size(44, 20);
            this.textBoxNumSim.TabIndex = 16;
            this.textBoxNumSim.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 316);
            this.Controls.Add(this.textBoxNumSim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxInten3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxL3Variance);
            this.Controls.Add(this.textBoxL3Mean);
            this.Controls.Add(this.textBoxL2Variance);
            this.Controls.Add(this.textBoxL2Mean);
            this.Controls.Add(this.textBoxL1Variance);
            this.Controls.Add(this.textBoxL1Mean);
            this.Controls.Add(this.textBoxInten2);
            this.Controls.Add(this.textBoxInten1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxInten1;
        private System.Windows.Forms.TextBox textBoxInten2;
        private System.Windows.Forms.TextBox textBoxL1Mean;
        private System.Windows.Forms.TextBox textBoxL1Variance;
        private System.Windows.Forms.TextBox textBoxL2Variance;
        private System.Windows.Forms.TextBox textBoxL2Mean;
        private System.Windows.Forms.TextBox textBoxL3Variance;
        private System.Windows.Forms.TextBox textBoxL3Mean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInten3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumSim;
    }
}

