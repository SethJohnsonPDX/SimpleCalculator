<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Simple Calculator</h1>
        <p>
            First Value:&nbsp;
            <asp:TextBox ID="firstValue" runat="server"></asp:TextBox>
        </p>
        <p>
            Second Value:
            <asp:TextBox ID="secondValue" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" Width="30px" />
&nbsp;
            <asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" Width="30px" />
&nbsp;
            <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" Width="30px" />
&nbsp;
            <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" Width="30px" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server" BackColor="#99CCFF" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
