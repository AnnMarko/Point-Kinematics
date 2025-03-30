namespace lab9
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
            this.groupBoxOperatingMode = new System.Windows.Forms.GroupBox();
            this.radioButtonTestMode = new System.Windows.Forms.RadioButton();
            this.radioButtonCalcMode = new System.Windows.Forms.RadioButton();
            this.groupBoxOperatingMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOperatingMode
            // 
            this.groupBoxOperatingMode.Controls.Add(this.radioButtonTestMode);
            this.groupBoxOperatingMode.Controls.Add(this.radioButtonCalcMode);
            this.groupBoxOperatingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOperatingMode.Location = new System.Drawing.Point(85, 363);
            this.groupBoxOperatingMode.Name = "groupBoxOperatingMode";
            this.groupBoxOperatingMode.Size = new System.Drawing.Size(256, 124);
            this.groupBoxOperatingMode.TabIndex = 0;
            this.groupBoxOperatingMode.TabStop = false;
            this.groupBoxOperatingMode.Text = "Вибір режиму роботи";
            // 
            // radioButtonTestMode
            // 
            this.radioButtonTestMode.AutoSize = true;
            this.radioButtonTestMode.Location = new System.Drawing.Point(15, 76);
            this.radioButtonTestMode.Name = "radioButtonTestMode";
            this.radioButtonTestMode.Size = new System.Drawing.Size(173, 24);
            this.radioButtonTestMode.TabIndex = 1;
            this.radioButtonTestMode.Text = "Режим перевірки";
            this.radioButtonTestMode.UseVisualStyleBackColor = true;
            this.radioButtonTestMode.Click += new System.EventHandler(this.radioButtonTestMode_Click);
            // 
            // radioButtonCalcMode
            // 
            this.radioButtonCalcMode.AutoSize = true;
            this.radioButtonCalcMode.Checked = true;
            this.radioButtonCalcMode.Location = new System.Drawing.Point(15, 40);
            this.radioButtonCalcMode.Name = "radioButtonCalcMode";
            this.radioButtonCalcMode.Size = new System.Drawing.Size(182, 24);
            this.radioButtonCalcMode.TabIndex = 0;
            this.radioButtonCalcMode.TabStop = true;
            this.radioButtonCalcMode.Text = "Режим розрахунку";
            this.radioButtonCalcMode.UseVisualStyleBackColor = true;
            this.radioButtonCalcMode.Click += new System.EventHandler(this.radioButtonCalcMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 532);
            this.Controls.Add(this.groupBoxOperatingMode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxOperatingMode.ResumeLayout(false);
            this.groupBoxOperatingMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOperatingMode;
        private System.Windows.Forms.RadioButton radioButtonTestMode;
        private System.Windows.Forms.RadioButton radioButtonCalcMode;
    }
}

