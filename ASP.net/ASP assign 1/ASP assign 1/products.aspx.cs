using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_assign_1
{
    public partial class products : System.Web.UI.Page
    {
        private static readonly string[] ProductImages = {
            "", 
            "~/images/product1.jpg",
            "~/images/product2.jpg",
            "~/images/product3.jpg"
        };

        private static readonly decimal[] ProductPrices = {
           0, 
           1000,
           2000,
           3000
            // Add more prices as needed
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize dropdown and other controls if needed
            }
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update product display when dropdown selection changes
            UpdateProductDisplay();
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            // Update product display when Get Price button is clicked
            UpdateProductDisplay();
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            // Validate form fields when Check button is clicked
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

        private void UpdateProductDisplay()
        {
            int selectedIndex = int.Parse(ddlProducts.SelectedValue);

            if (selectedIndex > 0) // Assuming 0 is for "Select a product"
            {
                // Set the image URL and price based on the selected product
                imgProduct.ImageUrl = ResolveUrl(ProductImages[selectedIndex]);
                lblPrice.Text = $"Price: ${ProductPrices[selectedIndex]:0.00}";
            }
            else
            {
                imgProduct.ImageUrl = string.Empty;
                lblPrice.Text = "Please select a product.";
            }
        }
    }
}