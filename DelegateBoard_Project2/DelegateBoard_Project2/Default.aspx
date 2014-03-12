<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" ViewStateMode="Disabled" Inherits="DelegateBoard_Project2.Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>제목 없음</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<asp:LinkButton ID="lnkTitles" runat="server" OnClick="LinkButton_Click">Titles</asp:LinkButton>
		<asp:LinkButton ID="lnkStores" runat="server" OnClick="LinkButton_Click">Stores</asp:LinkButton></div>
    </form>
</body>
</html>

