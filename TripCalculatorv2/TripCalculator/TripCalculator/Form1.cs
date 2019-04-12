using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripCalculator
{
    public partial class Form1 : Form
    {
        // Declaring global variables like totals for each person and the sum 
        decimal sum = 0;
        decimal louisTotal = 0;
        decimal carterTotal = 0;
        decimal davidTotal = 0;
        decimal evenSplit = 0;
        string maxPaid = "";
        Dictionary<string, decimal> totals = new Dictionary<string, decimal>();
        decimal owedByLouis = 0;
        decimal owedByCarter = 0;
        decimal owedByDavid = 0;

        public Form1()
        {
            InitializeComponent();
            // first textbox is focused on, label is populated /w instructions, and buttons are colored
            txtLouis.Select();
            label1.Text =  "1) Type in the necessary expenses \n2) Add and Remove freely (item must be selected before removal) \n3) Select Calculate once ready";
            btnAddCarter.BackColor = Color.LightGreen;
            btnRemoveCarter.BackColor = Color.LightPink;
            btnAddLouis.BackColor = Color.LightGreen;
            btnRemoveLouis.BackColor = Color.LightPink;
            btnAddDavid.BackColor = Color.LightGreen;
            btnRemoveDavid.BackColor = Color.LightPink;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit button to close out window
            this.Close();
        }

        private void btnAddLouis_Click(object sender, EventArgs e)
        {
            // Create variable for amount, then clear textbox, and add amount to the listbox
            string louisAmount = txtLouis.Text;
            txtLouis.Clear();
            if (louisAmount == "")
            {
                louisAmount = "0";
                lstLouis.Items.Add(Convert.ToDecimal(louisAmount));
            }
            else
            {
                lstLouis.Items.Add(Convert.ToDecimal(louisAmount));
            }
            
        }

        private void btnRemoveLouis_Click(object sender, EventArgs e)
        {
            // Remove selected item in listbox for Louis
            lstLouis.Items.Remove(lstLouis.SelectedItem);
        }

        private void btnAddCarter_Click(object sender, EventArgs e)
        {
            // Create variable for amount, then clear textbox, and add amount to the listbox
            string carterAmount = txtCarter.Text;
            txtCarter.Clear();
            if (carterAmount == "")
            {
                carterAmount = "0";
                lstCarter.Items.Add(Convert.ToDecimal(carterAmount));
            }
            else
            {
                lstCarter.Items.Add(Convert.ToDecimal(carterAmount));
            }
            
        }

        private void btnRemoveCarter_Click(object sender, EventArgs e)
        {

            // Remove selected item in listbox for Carter
            lstCarter.Items.Remove(lstCarter.SelectedItem);
        }

        private void btnAddDavid_Click(object sender, EventArgs e)
        {
            // Create variable for amount, then clear textbox, and add amount to the listbox
            string davidAmount = txtDavid.Text;
            txtDavid.Clear();

            if (davidAmount == "")
            {
                davidAmount = "0";
                lstDavid.Items.Add(Convert.ToDecimal(davidAmount));
            }
            else
            {
                lstDavid.Items.Add(Convert.ToDecimal(davidAmount));
            }
        }

        private void btnRemoveDavid_Click(object sender, EventArgs e)
        {
            lstDavid.Items.Remove(lstDavid.SelectedItem);
        }

        private void txtLouis_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Allowing only decimals and whole numbers and limiting to one decimal point
            char ch = e.KeyChar;

            if (ch == 46 && txtLouis.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCarter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only decimals and whole numbers and limiting to one decimal point
            char ch = e.KeyChar;

            if (ch == 46 && txtCarter.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtDavid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only decimals and whole numbers and limiting to one decimal point
            char ch = e.KeyChar;

            if (ch == 46 && txtDavid.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            

            // Iterate through the payments Louis made and add it to the global variable louisTotal
            for (int i = 0; i < lstLouis.Items.Count; i++)
            {
                louisTotal += Convert.ToDecimal(lstLouis.Items[i]);
                
            }

            // if the totals dictionary object doesn't already contain the total, then add it.
            if (!totals.ContainsKey("Louis"))
            {
                totals.Add("Louis", louisTotal);
            }
            else
            {
                totals["Louis"] = louisTotal;
            }

           

            // Make label visible and print out the total payments made by Louis
            lblLouisTotal.Visible = true;
            lblLouisTotal.Text = "Total for Louis: $" + louisTotal.ToString();

            for (int i = 0; i < lstCarter.Items.Count; i++)
            {
                carterTotal += Convert.ToDecimal(lstCarter.Items[i]);
                
            }

            
            if (!totals.ContainsKey("Carter"))
            {
                totals.Add("Carter", carterTotal);
            }
            else
            {
                totals["Carter"] = carterTotal;
            }

            

            lblCarterTotal.Visible = true;
            lblCarterTotal.Text = "Total for Carter: $" + carterTotal.ToString();


            for (int i = 0; i < lstDavid.Items.Count; i++)
            {
                davidTotal += Convert.ToDecimal(lstDavid.Items[i]);
            }

            if (!totals.ContainsKey("David"))
            {
                totals.Add("David", davidTotal);
            }
            else
            {
                totals["David"] = davidTotal;
            }

            

            lblDavidTotal.Visible = true;
            lblDavidTotal.Text = "Total for David: $" + davidTotal.ToString();


            if (louisTotal == carterTotal && carterTotal == louisTotal)
            {
                MessageBox.Show("Everyone paid the same amount.");
            }
            else
            {

                sum = SumOfAll(louisTotal, carterTotal, davidTotal);

                // Rounded the split to the nearest cent
                evenSplit = Math.Round(sum / 3, 2, MidpointRounding.AwayFromZero);

                if (louisTotal > carterTotal && louisTotal > davidTotal)
                {
                    maxPaid = "Louis";
                }
                else if (carterTotal > louisTotal && carterTotal > davidTotal)
                {
                    maxPaid = "Carter";
                }else
                {
                    maxPaid = "David";
                }


                if (maxPaid == "Louis")
                {
                    owedByCarter = evenSplit - carterTotal;
                    owedByDavid = evenSplit - davidTotal;
                }
                else if (maxPaid == "Carter")
                {
                    owedByLouis = evenSplit - louisTotal;
                    owedByDavid = evenSplit - davidTotal;

                }
                else if (maxPaid == "David")
                {
                    owedByLouis = evenSplit - louisTotal;
                    owedByCarter = evenSplit - carterTotal;
                }

                Console.WriteLine("Carter owes: " + owedByCarter + "\n" + "David owes: " + owedByDavid);
                lblLouisOwe.Visible = true;
                lblCarterOwe.Visible = true;
                lblDavidOwe.Visible = true;

                if (maxPaid == "Louis")
                {
                    lblLouisOwe.Text = maxPaid + " owes nothing.";
                    lblCarterOwe.Text = "Carter owes $" + owedByCarter + " to " + maxPaid + ".";
                    lblDavidOwe.Text = "David owes $" + owedByDavid + " to " + maxPaid + ".";
                }
                else if (maxPaid == "Carter")
                {
                    lblCarterOwe.Text = maxPaid + " owes nothing.";
                    lblLouisOwe.Text = "Louis owes $" + owedByLouis + " to " + maxPaid + ".";
                    lblDavidOwe.Text = "David owes $" + owedByDavid + " to " + maxPaid + ".";

                }
                else if (maxPaid == "David")
                {
                    lblDavidOwe.Text = maxPaid + " owes nothing.";
                    lblLouisOwe.Text = "Louis owes $" + owedByLouis + " to " + maxPaid + ".";
                    lblCarterOwe.Text = "Carter owes $" + owedByCarter + " to " + maxPaid + ".";
                }
                maxPaid = "";
                totals.Clear();
            }

        }

        public static decimal SumOfAll(decimal x, decimal y, decimal z)
        {
            return x + y + z;
        }

       public void btnClear_Click(object sender, EventArgs e)
       {

           ResetApplication();

        }

        public void ResetApplication()
       {
           // Remove all items on listboxes
           lstLouis.Items.Clear();
           lstCarter.Items.Clear();
           lstDavid.Items.Clear();

           // Reset global variables
           sum = 0;
           louisTotal = 0;
           carterTotal = 0;
           davidTotal = 0;
           evenSplit = 0;
           maxPaid = "";
           //Dictionary<string, decimal> totals = new Dictionary<string, decimal>();
           totals.Clear();
           owedByLouis = 0;
           owedByCarter = 0;
           owedByDavid = 0;

           // Hide the labels again
           lblLouisTotal.Visible = false;
           lblCarterTotal.Visible = false;
           lblDavidTotal.Visible = false;

           lblLouisOwe.Visible = false;
           lblCarterOwe.Visible = false;
           lblDavidOwe.Visible = false;
       }
    }
}
