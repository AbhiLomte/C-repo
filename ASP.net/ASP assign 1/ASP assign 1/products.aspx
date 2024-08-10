<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="ASP_assign_1.products" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Catalog</title>
     <style>
        .form-container {
            max-width: 600px; 
            margin: 0 auto;
            padding: 20px;
        }
        .form-group {
            display: flex;
            align-items: center;
            margin-bottom: 15px;
        }
        .form-group label {
            flex: 0 0 150px; 
            margin-right: 10px;
            text-align: right;
        }
        .form-group .required-field {
            color: red;
            margin-left: 5px;
        }
        .form-group input {
            flex: 1;
            max-width: 300px; 
        }
        .form-group input.error {
            background-color: yellow;
        }
        .error {
            color: red;
            background-color: yellow;
            padding: 5px;
            border: 1px solid red;
            margin-top: 10px;
        }
        .product-container {
            margin-top: 30px;
            text-align: center;
        }
        .product-image {
            max-width: 300px;
            max-height: 300px;
            margin-top: 20px;
        }
    </style>
    <script>
        function validateForm() {
            var inputs = document.querySelectorAll('.form-group input');
            var emptyFields = [];
            var hasError = false;

            inputs.forEach(function (input) {
                if (input.value.trim() === '') {
                    input.classList.add('error');
                    emptyFields.push(input.previousElementSibling.textContent.trim());
                    hasError = true;
                } else {
                    input.classList.remove('error');
                }
            });

            if (hasError) {
                var message = 'The following fields are required:\n' + emptyFields.join('\n');
                alert(message); 
                document.getElementById('pnlError').style.display = 'block';
                return false; 
            } else {
                document.getElementById('pnlError').style.display = 'none';
                return true; 
            }
        }

        document.addEventListener('DOMContentLoaded', function () {
            document.getElementById('btnCheck').addEventListener('click', function (event) {
                if (!validateForm()) {
                    event.preventDefault(); 
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <div class="form-group">
                <label for="txtName">Name:</label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <span class="required-field">*</span>
                <asp:RequiredFieldValidator ID="rfvName" ControlToValidate="txtName" 
                    InitialValue="" ErrorMessage="Name is required." 
                    ForeColor="Red" Display="Dynamic" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtFamilyName">Family Name:</label>
                <asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox>
                <span class="required-field">*</span>
                <asp:RequiredFieldValidator ID="rfvFamilyName" ControlToValidate="txtFamilyName" 
                    InitialValue="" ErrorMessage="Differs from name" 
                    ForeColor="Red" Display="Dynamic" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtAddress">Address:</label>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                <span class="required-field">*</span>
                <asp:RequiredFieldValidator ID="rfvAddress" ControlToValidate="txtAddress" 
                    InitialValue="" ErrorMessage="Atleast 2 char" 
                    ForeColor="Red" Display="Dynamic" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtCity">City:</label>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                <span class="required-field">*</span>
                <asp:RequiredFieldValidator ID="rfvCity" ControlToValidate="txtCity" 
                    InitialValue="" ErrorMessage="Atleast 2 char" 
                    ForeColor="Red" Display="Dynamic" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtZipCode">Zip Code:</label>
                <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
                <span class="required-field">*</span>
                <asp:RequiredFieldValidator ID="rfvZipCode" ControlToValidate="txtZipCode" 
                    InitialValue="" ErrorMessage="(xxxxx)" 
                    ForeColor="Red" Display="Dynamic" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtPhone">Phone:</label>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                <span class="required-field">*</span>
                <asp:RequiredFieldValidator ID="rfvPhone" ControlToValidate="txtPhone" 
                    InitialValue="" ErrorMessage="(xx-xxxxxxx/xxx-xxxxxxx)" 
                    ForeColor="Red" Display="Dynamic" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtEmail">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <span class="required-field">*</span>
                <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="txtEmail" 
                    InitialValue="" ErrorMessage="example@example.com" 
                    ForeColor="Red" Display="Dynamic" runat="server" />
            </div>

             <div class="product-container">
                <div class="form-group">
                    <label for="ddlProducts">Select Product:</label>
                    <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
                       <asp:ListItem Text="Select a product" Value="0" />
                        <asp:ListItem Text="Product 1" Value="1" />
                        <asp:ListItem Text="Product 2" Value="2" />
                        <asp:ListItem Text="Product 3" Value="3" />
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <asp:Image ID="imgProduct" runat="server" CssClass="product-image" />
                </div>

                <div class="form-group">
                    <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click"  CausesValidation="false" />
                </div>

                <div class="form-group">
                    <asp:Label ID="lblPrice" runat="server" Text="Price will be displayed here" />
                </div>
            </div>

            <div class="form-group">
                <asp:Button ID="btnCheck" Text="Check" runat="server" OnClick="btnCheck_Click" />
            </div>

            <asp:Panel ID="pnlError" CssClass="error" runat="server" Visible="false">
                <asp:Literal ID="litErrorMessage" runat="server"></asp:Literal>
            </asp:Panel>
        </div>
    </form>
</body>
</html>