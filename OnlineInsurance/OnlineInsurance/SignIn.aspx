<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="OnlineInsurance.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:coral">
    <form id="form1" runat="server">
    <div>
           <h2 style="text-align: center"><b>WELCOME </b></h2>
            <h3 style="text-align: center">TO</h3>
            <h2 style="text-align: center">SBI LIFE INSURANCE</h2>
            <table align="Center">
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox runat="server" ID="textUserId" placeholder="Enter your mail id"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox runat="server" ID="textPassword" TextMode="Password" placeholder="Enter your password"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>
                        <asp:Button runat="server" Text="Sign In" OnClick="SignIn_Click" />
                    </td>
                     <td>
                        <asp:Button runat="server" Text="Sign Up" OnClick="SignUp_Click" />
                    </td>
                     </tr>

    </div>
    </form>
</body>
</html>
