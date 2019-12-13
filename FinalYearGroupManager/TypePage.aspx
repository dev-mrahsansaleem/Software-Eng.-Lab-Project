<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TypePage.aspx.cs" Inherits="FinalYearGroupManager.AddUserForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            type name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbType" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Type" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
    </form>
</body>
</html>
