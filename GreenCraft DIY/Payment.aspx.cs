using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenCraft_DIY
{
    public partial class Checkout : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSumbit_Click(object sender, EventArgs e)
        {
            int result = 0;

            Payment p = new Payment(decimal.Parse(lblamount.Text),,ddlCardType.SelectedValue, txtName.Text, txtcardnumber.Text, txtExpiry.Text, txtCVV.Text);
        }
    }
}