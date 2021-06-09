
namespace lab02_WinForms
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
            this.grpMax = new System.Windows.Forms.GroupBox();
            this.cbMax = new System.Windows.Forms.CheckBox();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.gpbAvg = new System.Windows.Forms.GroupBox();
            this.cbAvg = new System.Windows.Forms.CheckBox();
            this.pBar2 = new System.Windows.Forms.ProgressBar();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.gpbMin = new System.Windows.Forms.GroupBox();
            this.cbMin = new System.Windows.Forms.CheckBox();
            this.pBar3 = new System.Windows.Forms.ProgressBar();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArr = new System.Windows.Forms.TextBox();
            this.grpMax.SuspendLayout();
            this.gpbAvg.SuspendLayout();
            this.gpbMin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMax
            // 
            this.grpMax.Controls.Add(this.cbMax);
            this.grpMax.Controls.Add(this.pBar1);
            this.grpMax.Controls.Add(this.txtMax);
            this.grpMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpMax.Location = new System.Drawing.Point(40, 84);
            this.grpMax.Name = "grpMax";
            this.grpMax.Size = new System.Drawing.Size(568, 83);
            this.grpMax.TabIndex = 0;
            this.grpMax.TabStop = false;
            this.grpMax.Text = "Max";
            // 
            // cbMax
            // 
            this.cbMax.AutoSize = true;
            this.cbMax.Location = new System.Drawing.Point(524, 46);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(15, 14);
            this.cbMax.TabIndex = 2;
            this.cbMax.UseVisualStyleBackColor = true;
            // 
            // pBar1
            // 
            this.pBar1.ForeColor = System.Drawing.Color.Lime;
            this.pBar1.Location = new System.Drawing.Point(245, 36);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(247, 35);
            this.pBar1.TabIndex = 1;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(23, 36);
            this.txtMax.Multiline = true;
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(140, 35);
            this.txtMax.TabIndex = 0;
            // 
            // gpbAvg
            // 
            this.gpbAvg.Controls.Add(this.cbAvg);
            this.gpbAvg.Controls.Add(this.pBar2);
            this.gpbAvg.Controls.Add(this.txtAvg);
            this.gpbAvg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpbAvg.Location = new System.Drawing.Point(40, 193);
            this.gpbAvg.Name = "gpbAvg";
            this.gpbAvg.Size = new System.Drawing.Size(568, 82);
            this.gpbAvg.TabIndex = 1;
            this.gpbAvg.TabStop = false;
            this.gpbAvg.Text = "Avg";
            // 
            // cbAvg
            // 
            this.cbAvg.AutoSize = true;
            this.cbAvg.Location = new System.Drawing.Point(524, 50);
            this.cbAvg.Name = "cbAvg";
            this.cbAvg.Size = new System.Drawing.Size(15, 14);
            this.cbAvg.TabIndex = 3;
            this.cbAvg.UseVisualStyleBackColor = true;
            // 
            // pBar2
            // 
            this.pBar2.ForeColor = System.Drawing.Color.Lime;
            this.pBar2.Location = new System.Drawing.Point(245, 39);
            this.pBar2.Name = "pBar2";
            this.pBar2.Size = new System.Drawing.Size(247, 35);
            this.pBar2.TabIndex = 2;
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(23, 39);
            this.txtAvg.Multiline = true;
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(140, 35);
            this.txtAvg.TabIndex = 1;
            // 
            // gpbMin
            // 
            this.gpbMin.Controls.Add(this.cbMin);
            this.gpbMin.Controls.Add(this.pBar3);
            this.gpbMin.Controls.Add(this.txtMin);
            this.gpbMin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpbMin.Location = new System.Drawing.Point(40, 301);
            this.gpbMin.Name = "gpbMin";
            this.gpbMin.Size = new System.Drawing.Size(568, 83);
            this.gpbMin.TabIndex = 1;
            this.gpbMin.TabStop = false;
            this.gpbMin.Text = "Min";
            // 
            // cbMin
            // 
            this.cbMin.AutoSize = true;
            this.cbMin.Location = new System.Drawing.Point(524, 50);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(15, 14);
            this.cbMin.TabIndex = 4;
            this.cbMin.UseVisualStyleBackColor = true;
            // 
            // pBar3
            // 
            this.pBar3.BackColor = System.Drawing.SystemColors.Control;
            this.pBar3.ForeColor = System.Drawing.Color.Lime;
            this.pBar3.Location = new System.Drawing.Point(245, 38);
            this.pBar3.Name = "pBar3";
            this.pBar3.Size = new System.Drawing.Size(247, 35);
            this.pBar3.TabIndex = 3;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(23, 38);
            this.txtMin.Multiline = true;
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(140, 35);
            this.txtMin.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.Location = new System.Drawing.Point(242, 409);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(129, 29);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Array:";
            // 
            // txtArr
            // 
            this.txtArr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtArr.Location = new System.Drawing.Point(121, 39);
            this.txtArr.Multiline = true;
            this.txtArr.Name = "txtArr";
            this.txtArr.ReadOnly = true;
            this.txtArr.Size = new System.Drawing.Size(474, 33);
            this.txtArr.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 447);
            this.Controls.Add(this.txtArr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gpbMin);
            this.Controls.Add(this.gpbAvg);
            this.Controls.Add(this.grpMax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMax.ResumeLayout(false);
            this.grpMax.PerformLayout();
            this.gpbAvg.ResumeLayout(false);
            this.gpbAvg.PerformLayout();
            this.gpbMin.ResumeLayout(false);
            this.gpbMin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMax;
        private System.Windows.Forms.GroupBox gpbAvg;
        private System.Windows.Forms.GroupBox gpbMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.ProgressBar pBar2;
        private System.Windows.Forms.ProgressBar pBar3;
        private System.Windows.Forms.CheckBox cbMax;
        private System.Windows.Forms.CheckBox cbAvg;
        private System.Windows.Forms.CheckBox cbMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArr;
    }
}

