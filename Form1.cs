using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        // Panel for selecting the operating mode
        //private GroupBox groupBoxOperatingMode;    // Operating mode selection

        //private RadioButton radioButtonCalcMode;   // Calculation mode
        //private RadioButton radioButtonTestMode;   // Testing mode

        // Motion law label
        private Label labelMotionLawTitle;     // Motion law
        private Label labelMotionLawFormula;   // x = sin(πt / 4)

        // Table
        // Row labels
        private Label labelCoordinates;
        private Label labelSpeed;
        private Label labelAcceleration;
        // Column labels
        private Label labelTime0;
        private Label labelTime1;
        private Label labelTime2;
        // Cells
        private TextBox textBoxCT0;
        private TextBox textBoxCT1;
        private TextBox textBoxCT2;
        private TextBox textBoxST0;
        private TextBox textBoxST1;
        private TextBox textBoxST2;
        private TextBox textBoxAT0;
        private TextBox textBoxAT1;
        private TextBox textBoxAT2;
        private List<TextBox> textBoxes = new List<TextBox>();

        // Buttons
        private Button buttonOperate;
        private Button buttonExit;

        // Tooltips
        private ToolTip toolTip;

        // Variables
        private double timeStart = 0;
        private double timeStep = 1;
        private enum OperatingMode
        {
            Calculation = 0,
            Testing = 1,
        }
        private OperatingMode currentOperatingMode = OperatingMode.Calculation;

        public Form1()
        {
            InitializeComponent();
            Initialization();
        }

        private void Initialization()
        {
            // Form properties
            this.Text = "Point Kinematics";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Width = 700;
            this.Height = 480;
            this.Font = new Font(this.Font.FontFamily, 10);

            // Motion law label properties
            labelMotionLawTitle = new Label()
            {
                Text = "Motion Law",
                Left = 400,
                Top = 20,
                AutoSize = true,
                Font = new Font(this.Font.FontFamily, 12)
            };
            labelMotionLawFormula = new Label()
            {
                Text = "x = sin(πt / 4)",
                Left = 400,
                Top = 50,
                AutoSize = true,
                Font = new Font(this.Font.FontFamily, 12, FontStyle.Italic)
            };

            this.Controls.Add(labelMotionLawTitle);
            this.Controls.Add(labelMotionLawFormula);

            // Table properties
            // Row labels
            labelCoordinates = new Label()
            {
                Text = "Coordinates:",
                Left = 120,
                Top = 190,
                AutoSize = true,
                Font = this.Font
            };

            labelSpeed = new Label()
            {
                Text = "Speed:",
                Left = 120,
                Top = 230,
                AutoSize = true,
                Font = this.Font
            };

            labelAcceleration = new Label()
            {
                Text = "Acceleration:",
                Left = 120,
                Top = 270,
                AutoSize = true,
                Font = this.Font
            };

            this.Controls.Add(labelCoordinates);
            this.Controls.Add(labelSpeed);
            this.Controls.Add(labelAcceleration);

            // Column labels
            labelTime0 = new Label()
            {
                Text = $"t = {timeStart}",
                Left = 320,
                Top = 160,
                AutoSize = true,
                Font = this.Font
            };
            labelTime0.Click += labelTime_Click;
            labelTime1 = new Label()
            {
                Text = $"t = {timeStart + timeStep}",
                Left = 500,
                Top = 160,
                AutoSize = true,
                Font = this.Font
            };
            labelTime1.Click += labelTime_Click;
            labelTime2 = new Label()
            {
                Text = $"t = {timeStart + 2 * timeStep}",
                Left = 680,
                Top = 160,
                AutoSize = true,
                Font = this.Font
            };
            labelTime2.Click += labelTime_Click;

            this.Controls.Add(labelTime0);
            this.Controls.Add(labelTime1);
            this.Controls.Add(labelTime2);

            // Cells
            textBoxCT0 = new TextBox()
            {
                Left = 250,
                Top = 190,
                Width = 180,
                Font = this.Font,
                ReadOnly = true,
                Tag = "coord"
            };
            textBoxCT1 = new TextBox()
            {
                Left = 430,
                Top = 190,
                Width = 180,
                Font = this.Font,
                ReadOnly = true,
                Tag = "coord"
            };
            textBoxCT2 = new TextBox()
            {
                Left = 610,
                Top = 190,
                Width = 180,
                Font = this.Font,
                ReadOnly = true,
                Tag = "coord"
            };

            textBoxST0 = new TextBox()
            {
                Left = 250,
                Top = 230,
                Width = 180,
                Font = this.Font,
                ReadOnly = true,
                Tag = "speed"
            };
            textBoxST1 = new TextBox()
            {
                Left = 430,
                Top = 230,
                Width = 180,
                Font = this.Font,
                ReadOnly = true,
                Tag = "speed"
            };
            textBoxST2 = new TextBox()
            {
                Left = 610,
                Top = 230,
                Width = 180,
                Font = this.Font,
                ReadOnly = true,
                Tag = "speed"
            };

            textBoxAT0 = new TextBox()
            {
                Left = 250,
                Top = 270,
                Width = 180,
                Font = this.Font,
                ReadOnly = true,
                Tag = "accel"
            };
            textBoxAT1 = new TextBox()
            {
                Left = 430,
                Top = 270,
                Width = 180,
                Font = this.Font,
                ReadOnly = true,
                Tag = "accel"
            };
            textBoxAT2 = new TextBox()
            {
                Left = 610,
                Top = 270,
                Width = 180,
                Font = this.Font,
                ReadOnly = true,
                Tag = "accel"
            };
            textBoxes.Add(textBoxCT0);
            textBoxes.Add(textBoxCT1);
            textBoxes.Add(textBoxCT2);
            textBoxes.Add(textBoxST0);
            textBoxes.Add(textBoxST1);
            textBoxes.Add(textBoxST2);
            textBoxes.Add(textBoxAT0);
            textBoxes.Add(textBoxAT1);
            textBoxes.Add(textBoxAT2);

            foreach (var textBox in textBoxes)
            {
                this.Controls.Add(textBox);
            }

            // Button properties
            buttonOperate = new Button()
            {
                Text = "Calculate",
                Left = 610,
                Top = 370,
                Width = 180,
                Height = 40,
                Font = this.Font
            };
            buttonOperate.Click += buttonOperate_Click;
            buttonExit = new Button()
            {
                Text = "Exit",
                Left = 610,
                Top = 440,
                Width = 180,
                Height = 40,
                Font = this.Font
            };
            buttonExit.Click += buttonExit_Click;

            // Tooltips
            toolTip = new ToolTip();

            toolTip.SetToolTip(textBoxCT0, "x(t) = sin(πt / 4)");
            toolTip.SetToolTip(textBoxCT1, "x(t) = sin(πt / 4)");
            toolTip.SetToolTip(textBoxCT2, "x(t) = sin(πt / 4)");

            toolTip.SetToolTip(textBoxST0, "v(t) = (π / 4) · cos(πt / 4)");
            toolTip.SetToolTip(textBoxST1, "v(t) = (π / 4) · cos(πt / 4)");
            toolTip.SetToolTip(textBoxST2, "v(t) = (π / 4) · cos(πt / 4)");

            toolTip.SetToolTip(textBoxAT0, "a(t) = - (π / 4)² · sin(πt / 4)");
            toolTip.SetToolTip(textBoxAT1, "a(t) = - (π / 4)² · sin(πt / 4)");
            toolTip.SetToolTip(textBoxAT2, "a(t) = - (π / 4)² · sin(πt / 4)");

            toolTip.Active = false;

            this.Controls.Add(buttonOperate);
            this.Controls.Add(buttonExit);
        }

        // Clicking the button for calculation or testing
        private void buttonOperate_Click(object sender, EventArgs e)
        {
            if (currentOperatingMode == OperatingMode.Calculation)
            {
                DoCalculation();
            }
            else if (currentOperatingMode == OperatingMode.Testing)
            {
                DoTesting();
            }
        }

        // Calculation
        private void DoCalculation()
        {
            foreach (var textBox in textBoxes)
            {
                textBox.BackColor = this.BackColor;
            }

            textBoxCT0.Text = $"{GetCoordinates(timeStart)}";
            textBoxCT1.Text = $"{GetCoordinates(timeStart + timeStep)}";
            textBoxCT2.Text = $"{GetCoordinates(timeStart + 2 * timeStep)}";

            textBoxST0.Text = $"{GetSpeed(timeStart)}";
            textBoxST1.Text = $"{GetSpeed(timeStart + timeStep)}";
            textBoxST2.Text = $"{GetSpeed(timeStart + 2 * timeStep)}";

            textBoxAT0.Text = $"{GetAcceleration(timeStart)}";
            textBoxAT1.Text = $"{GetAcceleration(timeStart + timeStep)}";
            textBoxAT2.Text = $"{GetAcceleration(timeStart + 2 * timeStep)}";
        }

        // Testing
        private void DoTesting()
        {
            double currentResult;
            int index = 0;
            foreach (var textBox in textBoxes)
            {
                Func<double, double> GetValue;
                switch (textBox.Tag)
                {
                    case "coord":
                        GetValue = GetCoordinates;
                        break;
                    case "speed":
                        GetValue = GetSpeed;
                        break;
                    case "accel":
                        GetValue = GetAcceleration;
                        break;
                    default:
                        GetValue = GetCoordinates;
                        break;
                }
                if (IsDouble(textBox.Text, out currentResult) && IsApproximatelyEqual(currentResult, GetValue(timeStart + timeStep * (index++ % 3))))
                {
                    textBox.BackColor = Color.LightGreen;
                }
                else
                {
                    textBox.BackColor = Color.Red;
                }
            }
        }

        // Finding the coordinate
        private static double GetCoordinates(double t)
        {
            return Math.Sin(Math.PI * t / 4);
        }

        // Finding the speed (the first derivative of the coordinate)
        private static double GetSpeed(double t)
        {
            return (Math.PI / 4) * Math.Cos(Math.PI * t / 4);
        }

        // Finding the acceleration (the second derivative of the coordinate)
        private static double GetAcceleration(double t)
        {
            double factor = Math.PI / 4;
            return -factor * factor * Math.Sin(Math.PI * t / 4);
        }

        // Checking for double
        private static bool IsDouble(string text, out double result)
        {
            return Double.TryParse(text, out result);
        }

        // Comparing two doubles
        private static bool IsApproximatelyEqual(double value1, double value2, double epsilon = 1e-6)
        {
            return Math.Abs(value1 - value2) <= epsilon;
        }

        // Close the application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Selecting Test Mode
        private void radioButtonTestMode_Click(object sender, EventArgs e)
        {
            currentOperatingMode = OperatingMode.Testing;
            buttonOperate.Text = "Check";
            foreach (var textBox in textBoxes)
            {
                textBox.Text = String.Empty;
                textBox.ReadOnly = false;
            }
            textBoxes[0].Focus();
            TurnToolTipsOn();
        }

        // Selecting Calculation Mode
        private void radioButtonCalcMode_Click(object sender, EventArgs e)
        {
            currentOperatingMode = OperatingMode.Calculation;
            buttonOperate.Text = "Calculate";
            foreach (var textBox in textBoxes)
            {
                textBox.ReadOnly = true;
            }
            TurnToolTipsOff();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            using (Form2 dialog = new Form2(timeStep))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    timeStep = dialog.IntervalValue;
                    labelTime0.Text = $"t = {timeStart}";
                    labelTime1.Text = $"t = {timeStart + timeStep}";
                    labelTime2.Text = $"t = {timeStart + 2 * timeStep}";
                }
            }
        }

        private void TurnToolTipsOn()
        {
            toolTip.Active = true;
        }

        private void TurnToolTipsOff()
        {
            toolTip.Active = false;
        }
    }
}