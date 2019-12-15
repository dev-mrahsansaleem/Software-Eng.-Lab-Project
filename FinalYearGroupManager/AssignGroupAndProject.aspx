<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssignGroupAndProject.aspx.cs" Inherits="FinalYearGroupManager.AssignGroupAndProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
        <br />
    
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Larger" Text="Assign Group"></asp:Label>
        <br />
        <br />
        Student List:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
&nbsp;<br />
        <br />
        Group list:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="43px" OnClick="Button1_Click" Text="Assign" Width="137px" />
    
    </div>
        <p>
    
        <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Larger" Text="Assign Project To A Group"></asp:Label>
        </p>
        <p>
            Group List:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            Project List:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Height="43px" OnClick="Button2_Click" Text="Assign" Width="137px" />
        </p>
    </form>
</body>
</html>
