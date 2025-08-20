
namespace Prac3._2_creative_55898939
{
    partial class frmRegression
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.gbFormula = new System.Windows.Forms.GroupBox();
            this.lblFormulaInstructions = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.pbLineShape = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.gbAxisData = new System.Windows.Forms.GroupBox();
            this.lblXAxis = new System.Windows.Forms.Label();
            this.lblYAxis = new System.Windows.Forms.Label();
            this.txtXTitle = new System.Windows.Forms.TextBox();
            this.txtYTitle = new System.Windows.Forms.TextBox();
            this.lblYAx = new System.Windows.Forms.Label();
            this.lblXax = new System.Windows.Forms.Label();
            this.rtbDataInsights = new System.Windows.Forms.RichTextBox();
            this.lblYValue = new System.Windows.Forms.Label();
            this.lblYValOut = new System.Windows.Forms.Label();
            this.gbFormula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineShape)).BeginInit();
            this.pnlOutput.SuspendLayout();
            this.gbAxisData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(173, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(449, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Regression analizer";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(342, 88);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(93, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "y = a +bx";
            // 
            // gbFormula
            // 
            this.gbFormula.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbFormula.Controls.Add(this.txtX);
            this.gbFormula.Controls.Add(this.txtB);
            this.gbFormula.Controls.Add(this.txtA);
            this.gbFormula.Controls.Add(this.label3);
            this.gbFormula.Controls.Add(this.label2);
            this.gbFormula.Controls.Add(this.lblA);
            this.gbFormula.Controls.Add(this.lblFormulaInstructions);
            this.gbFormula.Location = new System.Drawing.Point(12, 160);
            this.gbFormula.Name = "gbFormula";
            this.gbFormula.Size = new System.Drawing.Size(334, 198);
            this.gbFormula.TabIndex = 2;
            this.gbFormula.TabStop = false;
            this.gbFormula.Text = "Formula";
            // 
            // lblFormulaInstructions
            // 
            this.lblFormulaInstructions.AutoSize = true;
            this.lblFormulaInstructions.Location = new System.Drawing.Point(6, 28);
            this.lblFormulaInstructions.Name = "lblFormulaInstructions";
            this.lblFormulaInstructions.Size = new System.Drawing.Size(299, 51);
            this.lblFormulaInstructions.TabIndex = 3;
            this.lblFormulaInstructions.Text = "Please insert the below values for the formula \r\ny = a + bx:\r\n\r\n";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(6, 79);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(23, 20);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "x:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(50, 79);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(156, 22);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(50, 112);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(156, 22);
            this.txtB.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(50, 144);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(156, 22);
            this.txtX.TabIndex = 2;
            // 
            // pbLineShape
            // 
            this.pbLineShape.Image = global::Prac3._2_creative_55898939.Properties.Resources.bval_is_zero;
            this.pbLineShape.Location = new System.Drawing.Point(414, 381);
            this.pbLineShape.Name = "pbLineShape";
            this.pbLineShape.Size = new System.Drawing.Size(310, 116);
            this.pbLineShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLineShape.TabIndex = 3;
            this.pbLineShape.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(414, 272);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(310, 39);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(414, 317);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(310, 41);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlOutput
            // 
            this.pnlOutput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlOutput.Controls.Add(this.lblYValOut);
            this.pnlOutput.Controls.Add(this.lblYValue);
            this.pnlOutput.Controls.Add(this.rtbDataInsights);
            this.pnlOutput.Location = new System.Drawing.Point(7, 397);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(310, 100);
            this.pnlOutput.TabIndex = 6;
            // 
            // gbAxisData
            // 
            this.gbAxisData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbAxisData.Controls.Add(this.txtYTitle);
            this.gbAxisData.Controls.Add(this.txtXTitle);
            this.gbAxisData.Controls.Add(this.lblYAxis);
            this.gbAxisData.Controls.Add(this.lblXAxis);
            this.gbAxisData.Location = new System.Drawing.Point(414, 161);
            this.gbAxisData.Name = "gbAxisData";
            this.gbAxisData.Size = new System.Drawing.Size(310, 98);
            this.gbAxisData.TabIndex = 7;
            this.gbAxisData.TabStop = false;
            this.gbAxisData.Text = "X/Y axis titles";
            // 
            // lblXAxis
            // 
            this.lblXAxis.AutoSize = true;
            this.lblXAxis.Location = new System.Drawing.Point(13, 27);
            this.lblXAxis.Name = "lblXAxis";
            this.lblXAxis.Size = new System.Drawing.Size(75, 17);
            this.lblXAxis.TabIndex = 0;
            this.lblXAxis.Text = "X axis title:";
            // 
            // lblYAxis
            // 
            this.lblYAxis.AutoSize = true;
            this.lblYAxis.Location = new System.Drawing.Point(13, 60);
            this.lblYAxis.Name = "lblYAxis";
            this.lblYAxis.Size = new System.Drawing.Size(71, 17);
            this.lblYAxis.TabIndex = 1;
            this.lblYAxis.Text = "Y axis title";
            // 
            // txtXTitle
            // 
            this.txtXTitle.Location = new System.Drawing.Point(108, 24);
            this.txtXTitle.Name = "txtXTitle";
            this.txtXTitle.Size = new System.Drawing.Size(178, 22);
            this.txtXTitle.TabIndex = 0;
            // 
            // txtYTitle
            // 
            this.txtYTitle.Location = new System.Drawing.Point(108, 57);
            this.txtYTitle.Name = "txtYTitle";
            this.txtYTitle.Size = new System.Drawing.Size(178, 22);
            this.txtYTitle.TabIndex = 1;
            // 
            // lblYAx
            // 
            this.lblYAx.AutoSize = true;
            this.lblYAx.Location = new System.Drawing.Point(344, 426);
            this.lblYAx.Name = "lblYAx";
            this.lblYAx.Size = new System.Drawing.Size(46, 17);
            this.lblYAx.TabIndex = 8;
            this.lblYAx.Text = "label1";
            // 
            // lblXax
            // 
            this.lblXax.AutoSize = true;
            this.lblXax.Location = new System.Drawing.Point(540, 500);
            this.lblXax.Name = "lblXax";
            this.lblXax.Size = new System.Drawing.Size(46, 17);
            this.lblXax.TabIndex = 9;
            this.lblXax.Text = "label4";
            // 
            // rtbDataInsights
            // 
            this.rtbDataInsights.Location = new System.Drawing.Point(15, 13);
            this.rtbDataInsights.Name = "rtbDataInsights";
            this.rtbDataInsights.Size = new System.Drawing.Size(276, 46);
            this.rtbDataInsights.TabIndex = 0;
            this.rtbDataInsights.Text = "";
            // 
            // lblYValue
            // 
            this.lblYValue.AutoSize = true;
            this.lblYValue.Location = new System.Drawing.Point(12, 73);
            this.lblYValue.Name = "lblYValue";
            this.lblYValue.Size = new System.Drawing.Size(106, 17);
            this.lblYValue.TabIndex = 1;
            this.lblYValue.Text = "Your y-value is:";
            // 
            // lblYValOut
            // 
            this.lblYValOut.AutoSize = true;
            this.lblYValOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYValOut.Location = new System.Drawing.Point(138, 73);
            this.lblYValOut.Name = "lblYValOut";
            this.lblYValOut.Size = new System.Drawing.Size(0, 20);
            this.lblYValOut.TabIndex = 2;
            // 
            // frmRegression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(793, 536);
            this.Controls.Add(this.lblXax);
            this.Controls.Add(this.lblYAx);
            this.Controls.Add(this.gbAxisData);
            this.Controls.Add(this.pnlOutput);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pbLineShape);
            this.Controls.Add(this.gbFormula);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmRegression";
            this.Text = "Regression";
            this.Load += new System.EventHandler(this.frmRegression_Load);
            this.gbFormula.ResumeLayout(false);
            this.gbFormula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineShape)).EndInit();
            this.pnlOutput.ResumeLayout(false);
            this.pnlOutput.PerformLayout();
            this.gbAxisData.ResumeLayout(false);
            this.gbAxisData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox gbFormula;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblFormulaInstructions;
        private System.Windows.Forms.PictureBox pbLineShape;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlOutput;
        private System.Windows.Forms.GroupBox gbAxisData;
        private System.Windows.Forms.TextBox txtYTitle;
        private System.Windows.Forms.TextBox txtXTitle;
        private System.Windows.Forms.Label lblYAxis;
        private System.Windows.Forms.Label lblXAxis;
        private System.Windows.Forms.Label lblYAx;
        private System.Windows.Forms.Label lblXax;
        private System.Windows.Forms.RichTextBox rtbDataInsights;
        private System.Windows.Forms.Label lblYValOut;
        private System.Windows.Forms.Label lblYValue;
    }
}

