<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Titles.ascx.cs" Inherits="DelegateBoard_Project2.Titles" %>
Titles List<br />
<asp:DataGrid ID="dgList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
	<FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
	<EditItemStyle BackColor="#2461BF" />
	<SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
	<PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
	<AlternatingItemStyle BackColor="White" />
	<ItemStyle BackColor="#EFF3FB" />
	<HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
</asp:DataGrid>