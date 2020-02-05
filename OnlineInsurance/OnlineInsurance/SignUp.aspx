<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="OnlineInsurance.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="SignUp" runat="server">
    <div>

        <h1 style="text-align: center"><b>WELCOME </b></h1>
            <h3 style="text-align: center">TO</h3>
            <h1 style="text-align: center">SBI LIFE INSURANCE</h1>
            <table align="Center">
                <tr>
                    <td>CustomerName</td>
                    <td>
                        <asp:TextBox runat="server" ID="textCustomerName"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="validateCustomerName" runat="server" ControlToValidate="textCustomerName" ErrorMessage="Customer name required" Style="color: red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="validateName" runat="server" ControlToValidate="textCustomerName" ErrorMessage="Enter valid name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>CustomerId</td>
                    <td>
                        <asp:TextBox runat="server" ID="textCustomerId"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="validateCustomerId" runat="server" ControlToValidate="textCustomerId" ErrorMessage="CustomerId required" Style="color: red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rgvName" runat="server" ControlToValidate="textCustomerId" ErrorMessage="Enter Valid Id" ValidationExpression="^[6789]\d{2}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Policy Number</td>
                    <td>
                        <asp:TextBox runat="server" ID="TextPolicyNumber"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="validatePolicyNumber" runat="server" ControlToValidate="textpolicyNumber" ErrorMessage="Policy number required" Style="color: red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rgvPolicyNumber" runat="server" ControlToValidate="textPolicyNumber" ErrorMessage="Enter valid Policy number" ValidationExpression="^[6789]\d{4}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>
                    <td>phone Number</td>
                    <td>
                        <asp:TextBox runat="server" ID="textphoneNumber"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="validatePhoneNumber" runat="server" ControlToValidate="textPhoneNumber" ErrorMessage="Phone number required" Style="color: red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rgvphoneNumber" runat="server" ControlToValidate="textPhoneNumber" ErrorMessage="Enter valid Phone number" ValidationExpression="^[6789]\d{9}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>DOB</td>
                    <td>
                        <asp:TextBox ID="textDOB" runat="server" TextMode="Date"></asp:TextBox></td>
                </tr>
                <td>
                    <asp:RequiredFieldValidator ID="validateDOB" runat="server" ControlToValidate="textDOB" ErrorMessage="DOB required" Style="color: red"></asp:RequiredFieldValidator>
                </td>
               
               <td>Mail Id</td>
                <td>
                    <asp:TextBox runat="server" ID="textMailId" TextMode="Email"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="validateMailId" runat="server" ControlToValidate="textMailId" ErrorMessage="Mail id required" Style="color: red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rgvMailId" runat="server" ControlToValidate="textMailId" ErrorMessage="Enter valid mail id" ValidationExpression="^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$"></asp:RegularExpressionValidator>
                </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox runat="server" ID="textPassword" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="textPassword" ErrorMessage="Password required" style="color:red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr>
                    <td>Confirm Password</td>
                    <td>
                        <asp:TextBox runat="server" ID="textConfirmPassword" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator runat="server" ID="rfvConfirmPassword" ControlToValidate="textConfirmPassword" ErrorMessage="Confirm password required" style="color:red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator runat="server" ID="validatePassword" ControlToValidate="textConfirmPassword" ControlToCompare="textPassword" ErrorMessage="Password and Confirm password must be same"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button runat="server" ID="buttonSignUp" Text="Sign up" OnClick="Signup_Click" />
                    </td>
                </tr>
                <tr>
                    
                </tr>
            </table>
            <asp:ValidationSummary ID="validationSummary" runat="server" />
    </div>
    </form>
</body>
</html>
