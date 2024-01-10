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

        protected void gvPayment_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvPayment.EditIndex = e.NewEditIndex;
            bind();
        }

        protected void gvPayment_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int result = 0;
            Payment p = new Payment();
            GridViewRow row = (GridViewRow)gvPayment.Rows[e.RowIndex];
            string id = gvPayment.DataKeys[e.RowIndex].Value.ToString();
            string pid = ((TextBox)row.Cells[0].Controls[0]).Text;
            string card_number = ((TextBox)row.Cells[2].Controls[0]).Text;
            //DropDownList ddlCardType = (DropDownList)gvPayment.Rows[e.RowIndex].FindControl("ddlCardType");

            DropDownList ddlcard_type = (DropDownList)gvPayment.Rows[e.RowIndex].FindControl("ddlCardType");
            if (ddlcard_type != null)
            {
                string card_type = ddlcard_type.SelectedValue;
                string expiry_date = ((TextBox)row.Cells[4].Controls[0]).Text;
                string name = ((TextBox)row.Cells[5].Controls[0]).Text;
                string cvv = ((TextBox)row.Cells[8].Controls[0]).Text;
                result = p.PaymentUpdate(pid, card_number, card_type, expiry_date, name, cvv);

            }


            if (result > 0)
            {
                Response.Write("<script>alert('Payment updated successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Payment NOT updated');</script>");
            }
            gvPayment.EditIndex = -1;
            bind();
        }
    }
}