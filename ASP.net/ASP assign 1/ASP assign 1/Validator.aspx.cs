using System;
using System.Web.UI;

namespace YourNamespace
{
    public partial class Validator : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                
                Session["Name"] = txtName.Text;
                Session["FamilyName"] = txtFamilyName.Text;
                Session["Address"] = txtAddress.Text;
                Session["City"] = txtCity.Text;
                Session["ZipCode"] = txtZipCode.Text;
                Session["Phone"] = txtPhone.Text;
                Session["Email"] = txtEmail.Text;

                
                Response.Redirect("Result.aspx");
            }
            else
            {
                
                pnlError.Visible = true;
                litErrorMessage.Text = "Please fill in all mandatory fields.";
            }
        }
    }
}
