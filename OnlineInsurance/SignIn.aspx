<%@ Page Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="OnlineInsurance.SignIn" %>
 <asp:Content ID="SignIn" runat="server"    ContentPlaceHolderID="head"></asp:Content>
<asp:Content ID="ContentHead" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
           <link  rel="stylesheet" href="CSStyleSheet1.css" />
    <div >
        <table >
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
            </table>
    </div>
</asp:Content>
