<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfoForm.aspx.cs" Inherits="StudentPortalApp.StudentInfoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" lang="javascript">
        /*function callMe() {
            var id = document.getElementById("txtId").value;

            WebServiceApplication.WebServiceClass.GetStudentInfo(id, callbackFunctionOnSuccess);
        }*/

        
    </script>
    <style type="text/css">
        .auto-style4 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">        
        <table style="width: 325px; float:left">
            <tr>
                <td><asp:Label ID="Label2" runat="server"> Id </asp:Label> </td>
                <td><asp:TextBox runat="server" ID="txtId">Student Id</asp:TextBox> </td>
            </tr>
            <tr>
                <td class="auto-style4"><asp:Label ID="Label1" runat="server"> First Name </asp:Label></td>
                <td class="auto-style4"><asp:TextBox runat="server" ID="txtFirstName">First Name</asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server"> Last Name </asp:Label></td>                
                <td><asp:TextBox runat="server" ID="txtLastName">Last Name</asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label4" runat="server"> Address </asp:Label></td>                
                <td><asp:TextBox runat="server" ID="txtAddress">Address</asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style4"><asp:Label ID="Label5" runat="server"> Contact </asp:Label></td>                
                <td class="auto-style4"><asp:TextBox runat="server" ID="txtContact">Contact</asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label6" runat="server"> Email </asp:Label></td>                
                <td><asp:TextBox runat="server" ID="txtEmail">Email</asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label7" runat="server"> Gender </asp:Label></td>                
                <td><asp:TextBox runat="server" ID="txtGender">Gender</asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="callMe" Text="Get Details" style="margin-left: 0px" Width="99px"/>
                </td>
            </tr>
        </table>
        <table style="float:left; height: 99px; width: 99px;">
            <tr>
                <td>

                </td>
            </tr>
            <tr>
                <td><asp:Image ID="img" runat="server" Height="197px" Width="155px"> </asp:Image></td>                
                
            </tr>
        </table>
    </form>
</body>
</html>
