using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_WeeklyPayroll
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string empName = "";            //Name of employee
            double hrWage;                  //Hourly wage
            double hrsWorked;               //Hours worked this week
            //int allowances = 0;                //Number of withholding allowances for employee
            int exemptions;                 //Number of exemptions for employee
            string mStatus = "";            //Marital status: S - Single; M - Married
            double prevPay;                 //Total pay for year excluding this week
            double pay;                     //This week's pay before taxes
            double totalPay;                //Total pay for year including this week
            double ficaTax;                 //FICA taxes for this week
            double fedTax;                  //Federal income tax withheld this week
            double check;                   //Paycheck this week (take-home pay)

            //-------------------------------------------------------
            //Task 1: Perform form validation
            //-------------------------------------------------------

            //WRITE CODE HERE

            try
            {
                empName = txtName.Text;
                if (string.IsNullOrWhiteSpace(empName)) // Check if empty
                {
                    MessageBox.Show("Employee name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter an employee name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                txtName.SelectAll();
                return;
            }

            try
            {
                hrWage = double.Parse(txtWage.Text);

                if (hrWage < 0)
                {
                    MessageBox.Show("Hourly wage cannot be negative. Please enter a valid amount.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWage.Focus();
                    txtWage.SelectAll();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter a valid hourly wage.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWage.Focus();
                txtWage.SelectAll();
                return;
            }

            try
            {
                hrsWorked = double.Parse(txtHours.Text);

                if (hrsWorked < 0)
                {
                    MessageBox.Show("Hours Worked cannot be negative. Please enter a valid amount.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHours.Focus();
                    txtHours.SelectAll();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter valid hours worked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHours.Focus();
                txtHours.SelectAll();
                return;
            }

            try
            {
                exemptions = int.Parse(txtExempts.Text);

                if (exemptions < 0)
                {
                    MessageBox.Show("Number of exemptions for employee cannot be negative. Please enter a valid number.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtExempts.Focus();
                    txtExempts.SelectAll();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter a valid number for exemptions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExempts.Focus();
                txtExempts.SelectAll();
                return;
            }

            try
            {
                mStatus = txtMarital.Text;
                if (string.IsNullOrWhiteSpace(mStatus))
                {
                    MessageBox.Show("Marital status cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMarital.Focus();
                    txtMarital.SelectAll();
                    return;
                }

                if (mStatus != "S"  && mStatus != "M")
                {
                    MessageBox.Show("Invalid marital status. Please enter 'S' for Single or 'M' for Married in UPPERCASE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMarital.Focus();
                    txtMarital.SelectAll();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter 'S' for Single or 'M' for Married UPPERCASE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarital.Focus();
                txtMarital.SelectAll();
                return;
            }

            try
            {
                prevPay = double.Parse(txtPriorPay.Text);

                if (prevPay < 0)
                {
                    MessageBox.Show("Total pay for year cannot be negative. Please enter a valid amount.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPriorPay.Focus();
                    txtPriorPay.SelectAll();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter a valid prior pay amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPriorPay.Focus();
                txtPriorPay.SelectAll();
                return;
            }
            //-------------------------------------------------------

            //-------------------------------------------------------
            //T Calculate Gross Pay
            if (hrsWorked <= 40)
            {
                pay = hrsWorked * hrWage;
            }
            else
            {
                pay = 40 * hrWage + (hrsWorked - 40) * 1.5 * hrWage;
            }
            //-------------------------------------------------------


            //-------------------------------------------------------
            //Total Pay
            totalPay = prevPay + pay;
            //-------------------------------------------------------


            //-------------------------------------------------------
            //Task 5: Compute social security and medicare tax
            double socialSecurity = 0; //Social Security tax for this week
            double medicare = 0; //Medicare tax for this week
            double sum = 0; //Sum of above two taxes
            const double WAGE_BASE = 90000;
            if (totalPay <= WAGE_BASE)
            {
                socialSecurity = System.Convert.ToDouble(0.062 * pay);
            }
            else if (prevPay < WAGE_BASE)
            {
                socialSecurity = System.Convert.ToDouble(0.062 * (WAGE_BASE - prevPay));
            }
            medicare = System.Convert.ToDouble(0.0145 * pay);
            sum = socialSecurity + medicare;
            ficaTax = Math.Round(sum, 2); //Round to nearest cent
            //-------------------------------------------------------


            //---------------------------------------------------------------------------
            //Compute federal income tax withheld rounded to 2 decimal places
            double adjPay;
            double tax = 0; //Unrounded federal tax withheld
            adjPay = Convert.ToDouble(pay - (61.54 * exemptions));
            if (adjPay < 0)
            {
                adjPay = 0;
            }
            if (mStatus == "S")
            {
                //-------------------------------------------------------
                //Find the taxes for "S" Single (See Table 3 from the document

                //WRITE CODE HERE..
                if (adjPay > 0 && adjPay <= 51)
                {
                    tax = 0;
                }
                else if (adjPay <= 188)
                {
                    tax = 0.10 * (adjPay - 51);
                }
                else if (adjPay <= 606)
                {
                    tax = 13.70 + (adjPay - 188) * 0.15;
                }
                else if (adjPay <= 1341)
                {
                    tax = 76.40 + (adjPay - 606) * 0.25;
                }
                else if (adjPay <= 2922)
                {
                    tax = 260.15 + (adjPay - 1341) * 0.28;
                }
                else if (adjPay <= 6313)
                {
                    tax = 702.83 + (adjPay - 2922) * 0.33;
                }
                else
                {
                    tax = 1821.86 + (adjPay - 6313) * 0.35;
                }



                //-------------------------------------------------------
            }
            else
            {
                //-------------------------------------------------------
                //Find the taxes for "M" Married (See Table 4 from the document

                //WRITE CODE HERE..
                if (adjPay > 0 && adjPay <= 154)
                {
                    tax = 0;
                }
                else if (adjPay <= 435)
                {
                    tax = (adjPay - 154) * 0.10;
                }
                else if (adjPay <= 1273)
                {
                    tax = 28.10 + (adjPay - 435) * 0.15;
                }
                else if (adjPay <= 2322)
                {
                    tax = 153.80 + (adjPay - 1273) * 0.25;
                }
                else if (adjPay <= 3646)
                {
                    tax = 416.05 + (adjPay - 2322) * 0.28;
                }
                else if (adjPay <= 6409)
                {
                    tax = 786.77 + (adjPay - 3646) * 0.33;
                }
                else
                {
                    tax = 1698.56 + (adjPay - 6409) * 0.35;
                }
                //-------------------------------------------------------
            }
            fedTax = Math.Round(tax, 2); //Round to nearest cent
            //-------------------------------------------------------------


            //Task 7: Compute Check amount
            check = pay - ficaTax - fedTax;


            //Task 8: Display results of payroll computations
            lstResults.Items.Clear();
            lstResults.Items.Add("Payroll results for " + empName);
            lstResults.Items.Add("");
            lstResults.Items.Add("Gross pay this period:" + "   " + string.Format("{0:C}", pay));
            lstResults.Items.Add("");

            lstResults.Items.Add("Yr. to Date Earning:" + "   " + string.Format("{0:C}", totalPay));
            lstResults.Items.Add("");
            lstResults.Items.Add("FICA Taxes:" + "   " + string.Format("{0:C}", ficaTax));
            lstResults.Items.Add("");
            lstResults.Items.Add("Income Tax Wh.:" + "   " + string.Format("{0:C}", fedTax));
            lstResults.Items.Add("");
            lstResults.Items.Add("Check Amount:" + "   " + string.Format("{0:C}", check));
            lstResults.Items.Add("");

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Clear all textbox and listbox contents
            txtName.Clear();
            txtWage.Clear();
            txtHours.Clear();
            txtExempts.Clear();
            txtMarital.Clear();
            txtPriorPay.Clear();
            lstResults.Items.Clear();
            txtName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
