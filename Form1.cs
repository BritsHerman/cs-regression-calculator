using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac3._2_creative_55898939
{
    public partial class frmRegression : Form
    {
        public frmRegression()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*
             VARIABLES REQUIREMENT BELOW, 5 VARIABLES AND DIFFERENT TYPES
             */

            // Initializing variables
            double aVal;
            double bVal;
            double xVal;

            // Axis titles
            string yAxisTitle = txtYTitle.Text;
            string xAxisTitle = txtXTitle.Text;

            // Converting text to decimal values, handling exceptions via else
            if (double.TryParse(txtA.Text, out aVal)
                && double.TryParse(txtB.Text, out bVal)
                && double.TryParse(txtX.Text, out xVal)
                && xAxisTitle != ""
                && yAxisTitle != "")
            {
                // Resetting panel colors
                gbAxisData.BackColor = SystemColors.ScrollBar;
                gbFormula.BackColor = SystemColors.ScrollBar;

                /*
                 PROCESSING REQUIREMENTS BELOW
                 */
                // y = a + bx
                double yVal = aVal + (bVal * xVal);

                /*
                 OUTPUT FORMATTED IN LABEL
                 */
                // Outputting y value
                lblYValOut.Text = yVal.ToString("N2");

                /*
                 OUTPUT PART TWO, CONCATENATING STRINGS
                 */
                // Message to display sumarizing the insights.
                string insights = "As " + xAxisTitle + " increases, the " + yAxisTitle;

                // loading image based on if bval is negative, positive or 0
                if (bVal < 0)
                {
                    pbLineShape.Image = Properties.Resources.bval_is_negative;
                    insights += " decreases, leading to a negative linear relationship";
                }
                else if (bVal > 0)
                {
                    pbLineShape.Image = Properties.Resources.bval_is_positive;
                    insights += " increases, leading to a positive linear relationship";
                }
                else
                {
                    //bval is 0
                    pbLineShape.Image = Properties.Resources.bval_is_zero;
                    insights += " remains constant - indicating no linear relationship";
                }

                rtbDataInsights.Text = insights;

                // Setting the axis titles
                lblYAx.Text = yAxisTitle;
                lblXax.Text = xAxisTitle;

                // Displaying outputs
                // Hiding unneeded outputs
                pnlOutput.Visible = true;
                pbLineShape.Visible = true;
                lblYAx.Visible = true;
                lblXax.Visible = true;
            }
            else
            {
                // Coloring the problem panel in red
                // Checking title panel values
                bool titleValues;
                bool formulaValues;

                if (xAxisTitle == ""
                    && yAxisTitle == "")
                {
                    titleValues = false;
                }
                else
                {
                    titleValues = true;
                }
                
                // Checking formula panel values
                if (double.TryParse(txtA.Text, out aVal)
                    && double.TryParse(txtB.Text, out bVal)
                    && double.TryParse(txtX.Text, out xVal))
                {
                    formulaValues = true;
                }
                else
                {
                    formulaValues = false;
                }

                // Setting colors to red based on what was missing, also resetting if nothin was missing
                // for multiple runs.
                if (!formulaValues)
                {
                    gbFormula.BackColor = Color.Red;
                }
                else
                {
                    gbFormula.BackColor = SystemColors.ScrollBar;
                }

                if (!titleValues)
                {
                    gbAxisData.BackColor = Color.Red;
                }
                else
                {
                    gbAxisData.BackColor = SystemColors.ScrollBar;
                }

                // Giving user an error message
                MessageBox.Show("Couldn't convert values, please ensure the a, b and x values are integers/decimals and that your axis titles are filled in.");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Hiding unneeded outputs
            pnlOutput.Visible = false;
            pbLineShape.Visible = false;
            lblYAx.Visible = false;
            lblXax.Visible = false;

            // Clearing all inputs
            txtA.Clear();
            txtB.Clear();
            txtX.Clear();
            txtXTitle.Clear();
            txtYTitle.Clear();

            // Resetting focus to first text input
            txtA.Focus();

            // Resetting panel colors
            gbAxisData.BackColor = SystemColors.ScrollBar;
            gbFormula.BackColor = SystemColors.ScrollBar;
        }

        private void frmRegression_Load(object sender, EventArgs e)
        {
            // Hiding unneeded outputs
            pnlOutput.Visible = false;
            pbLineShape.Visible = false;
            lblYAx.Visible = false;
            lblXax.Visible = false;
        }
    }
}
