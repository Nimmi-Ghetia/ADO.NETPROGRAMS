﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Program_3b.aspx.cs" Inherits="PAPERSOLUTION.Program_3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Username:<asp:TextBox ID="uname" runat="server"></asp:TextBox>
        Password:<asp:TextBox ID="pwd" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

    </div>
    </form>
</body>
</html>
