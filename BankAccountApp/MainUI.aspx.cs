using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankAccountApp
{
    public partial class MainUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Account anAccount = new Account();

            anAccount.AccountNumber = accNumberTextBox.Text;
            anAccount.CustomerName = clientNameTextBox.Text;


            saveButton.Enabled = false;

            ViewState.Add("Account", anAccount);
        }

        protected void depositButton_Click(object sender, EventArgs e)
        {
            Account anAccount = (Account)ViewState["Account"];

            double amount =Convert.ToDouble(ammountTextBox.Text);
            anAccount.Deposit(amount);
        }

        protected void withdrawButton_Click(object sender, EventArgs e)
        {
            Account anAccount = (Account)ViewState["Account"];
            double amount = Convert.ToDouble(ammountTextBox.Text);

            anAccount.Withdraw(amount);
        }

        protected void reportButton_Click(object sender, EventArgs e)
        {
            Account anAccount = (Account)ViewState["Account"];

            reportLabel.Text = Convert.ToString(anAccount.Report());
        }
    }
}