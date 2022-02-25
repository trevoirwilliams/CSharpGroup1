namespace SampleWinformsCalculator
{
    partial class Calculator
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
            this.tbFirstNumber = new System.Windows.Forms.TextBox();
            this.tbSecondNumber = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirstNumber
            // 
            this.tbFirstNumber.Location = new System.Drawing.Point(73, 94);
            this.tbFirstNumber.Name = "tbFirstNumber";
            this.tbFirstNumber.Size = new System.Drawing.Size(114, 22);
            this.tbFirstNumber.TabIndex = 0;
            // 
            // tbSecondNumber
            // 
            this.tbSecondNumber.Location = new System.Drawing.Point(73, 223);
            this.tbSecondNumber.Name = "tbSecondNumber";
            this.tbSecondNumber.Size = new System.Drawing.Size(114, 22);
            this.tbSecondNumber.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(485, 168);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(120, 16);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer Goes Here";
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(295, 59);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(68, 45);
            this.btnAddition.TabIndex = 3;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(295, 115);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(68, 45);
            this.btnSubtraction.TabIndex = 4;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(295, 176);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(68, 45);
            this.btnMultiplication.TabIndex = 5;
            this.btnMultiplication.Text = "X";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(295, 237);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(68, 45);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(70, 73);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(117, 16);
            this.lblFirstNumber.TabIndex = 7;
            this.lblFirstNumber.Text = "Enter First Number";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(70, 204);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(139, 16);
            this.lblSecondNumber.TabIndex = 8;
            this.lblSecondNumber.Text = "Enter Second Number";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 97);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.tbSecondNumber);
            this.Controls.Add(this.tbFirstNumber);
            this.Name = "Calculator";
            this.Text = "Group 1 Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstNumber;
        private System.Windows.Forms.TextBox tbSecondNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Button button5;
    }
}

