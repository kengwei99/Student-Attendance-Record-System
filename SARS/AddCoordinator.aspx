<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCoordinator.aspx.cs" Inherits="SARS.AddCoordinator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Course Coordinator</h2>
    <p>&nbsp;</p>
    <div>
        <table class="style1">
            <tr>
                <td>Username:</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Coordinator Name: </td>
                <td>
                    <asp:TextBox ID="txtCoordinatorName" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    <asp:Button ID="btnAddCoordinator" runat="server" Text="Add Coordinator" OnClick="btnAddCoordinator_Click" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Course]"></asp:SqlDataSource>
    </asp:Content>
