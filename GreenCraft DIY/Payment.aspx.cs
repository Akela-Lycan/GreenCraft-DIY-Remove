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

            
            Payment p = new Payment(lblamount.Text,txtcardnumber.Text,ddlCardType.SelectedItem.Text,
           txtExpiry.Text, txtName.Text, lblpayment_date.Text, lblStatus.Text, txtCVV.Text);
            result = p.PaymentInsert();


            if (result > 0)
            {
                
                Response.Write("<script>alert('Insert successful');</script>");
            }
            else { Response.Write("<script>alert('Insert NOT successful');</script>"); }
        }
    }
}