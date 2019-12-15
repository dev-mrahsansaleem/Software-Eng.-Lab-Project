<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Evaluation page.aspx.cs" Inherits="FinalYearGroupManager.Evaluation_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    
    </div>
        <p>
            Student Name:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="161px">
                <asp:ListItem>none</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            //all data show</p>
        <p>
            &nbsp;</p>
        <p>
            Total marks:</p>
        <p>
            obtain marks:</p>
        <p>
            weightage:</p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="40px" Text="Add Evaluation of student" Width="163px" />
        </p>
    </form>
</body>
</html>
