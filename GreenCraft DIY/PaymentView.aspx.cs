using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenCraft_DIY
{
    public partial class PaymentView : System.Web.UI.Page
    {
        Payment aPayment = new Payment();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }
        protected void bind()
        {
            List<Payment> paymentList = new List<Payment>();
            paymentList = aPayment.GetPaymentAll();
            gvPayment.DataSource = paymentList;
            gvPayment.DataBind();
        }

        protected void gvPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvPayment.SelectedRow;
            string paymentID = row.Cells[0].Text;
            Response.Redirect("Payment.aspx?Payment_Id=" + paymentID);
        }
    }
}