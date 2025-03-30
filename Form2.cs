using System;
using System.Windows.Forms;

namespace lab9
{
    // Form for time interval input
    public partial class Form2 : Form
    {
        public double IntervalValue => (double)numericUpDown.Value;

        private NumericUpDown numericUpDown;
        private Button buttonOk;
        private Button buttonCancel;
        private Label labelPrompt;
        public Form2(double currentTimeStep)
        {
            this.Text = "Enter the time interval";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 350;
            this.Height = 160;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            labelPrompt = new Label()
            {
                Text = "The amount of time increase",
                AutoSize = true,
                Top = 20,
                Left = 90
            };

            numericUpDown = new NumericUpDown()
            {
                Minimum = 1,
                Maximum = 1000,
                Value = (int)currentTimeStep,
                Width = 100,
                Top = 45,
                Left = 120
            };

            buttonOk = new Button()
            {
                Text = "Ok",
                DialogResult = DialogResult.OK,
                Top = 80,
                Left = 180,
                Width = 80
            };

            buttonCancel = new Button()
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Top = 80,
                Left = 60,
                Width = 80
            };

            this.Controls.Add(labelPrompt);
            this.Controls.Add(numericUpDown);
            this.Controls.Add(buttonOk);
            this.Controls.Add(buttonCancel);

            this.AcceptButton = buttonOk;
            this.CancelButton = buttonCancel;
        }
    }
}