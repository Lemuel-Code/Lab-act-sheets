namespace Lab01_WeeklyPayroll
{
    partial class frmPayroll
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
            this.txtExempts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPriorPay = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMarital = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblPriorPay = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExempts
            // 
            this.txtExempts.Location = new System.Drawing.Point(179, 105);
            this.txtExempts.Name = "txtExempts";
            this.txtExempts.Size = new System.Drawing.Size(61, 20);
            this.txtExempts.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Number of Exemptions:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPriorPay
            // 
            this.txtPriorPay.Location = new System.Drawing.Point(179, 163);
            this.txtPriorPay.Name = "txtPriorPay";
            this.txtPriorPay.Size = new System.Drawing.Size(91, 20);
            this.txtPriorPay.TabIndex = 40;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(179, 76);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(61, 20);
            this.txtHours.TabIndex = 36;
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(179, 44);
            this.txtWage.Name = "txtWage";
            this.txtWage.Size = new System.Drawing.Size(61, 20);
            this.txtWage.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 34;
            // 
            // txtMarital
            // 
            this.txtMarital.Location = new System.Drawing.Point(179, 134);
            this.txtMarital.Name = "txtMarital";
            this.txtMarital.Size = new System.Drawing.Size(61, 20);
            this.txtMarital.TabIndex = 38;
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 14;
            this.lstResults.Location = new System.Drawing.Point(310, 12);
            this.lstResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(405, 172);
            this.lstResults.TabIndex = 46;
            // 
            // lblPriorPay
            // 
            this.lblPriorPay.AutoSize = true;
            this.lblPriorPay.Location = new System.Drawing.Point(32, 166);
            this.lblPriorPay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPriorPay.Name = "lblPriorPay";
            this.lblPriorPay.Size = new System.Drawing.Size(137, 13);
            this.lblPriorPay.TabIndex = 42;
            this.lblPriorPay.Text = "Total pay prior to this week:";
            this.lblPriorPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.Location = new System.Drawing.Point(-2, 117);
            this.lblMaritalStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(171, 53);
            this.lblMaritalStatus.TabIndex = 41;
            this.lblMaritalStatus.Text = "Marital Status (M or S):";
            this.lblMaritalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(43, 76);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(126, 13);
            this.lblHours.TabIndex = 39;
            this.lblHours.Text = "Number of hours worked:";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(100, 44);
            this.lblWage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(69, 13);
            this.lblWage.TabIndex = 37;
            this.lblWage.Text = "Hourly wage:";
            this.lblWage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(87, 12);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 13);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Employee name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(583, 219);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(132, 32);
            this.btnQuit.TabIndex = 45;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(424, 219);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 32);
            this.btnNext.TabIndex = 44;
            this.btnNext.Text = "Next Employee";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(157, 219);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(132, 32);
            this.btnDisplay.TabIndex = 43;
            this.btnDisplay.Text = "Display Payroll";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 265);
            this.Controls.Add(this.txtExempts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPriorPay);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtWage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMarital);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.lblPriorPay);
            this.Controls.Add(this.lblMaritalStatus);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Form1";
            this.Text = "Weekly Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtExempts;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtPriorPay;
        internal System.Windows.Forms.TextBox txtHours;
        internal System.Windows.Forms.TextBox txtWage;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtMarital;
        internal System.Windows.Forms.ListBox lstResults;
        internal System.Windows.Forms.Label lblPriorPay;
        internal System.Windows.Forms.Label lblMaritalStatus;
        internal System.Windows.Forms.Label lblHours;
        internal System.Windows.Forms.Label lblWage;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Button btnQuit;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Button btnDisplay;
    }
}

