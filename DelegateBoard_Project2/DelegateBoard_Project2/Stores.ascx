<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Stores.ascx.cs" Inherits="DelegateBoard_Project2.Stores" %>
Stores List<br />
<table border="1">
    <tr>

        <td>
            Store Title
        </td>
        <td> Store Content</td>
    </tr>
        <asp:Repeater ID="repeater1" runat="server">
            <ItemTemplate>
            <tr>

                <td> <%#Eval("Title1") %></td>
                <td> <%# Eval("Content1") %></td>
            </tr>
                </ItemTemplate>
        </asp:Repeater>
    

</table>
