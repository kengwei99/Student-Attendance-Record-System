<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AssignStudent.aspx.cs" Inherits="SARS.AssignStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Assign Student to Class</h2>
    <p>
        &nbsp;</p>
    <div>
        <table class="style1">
            <tr>
                <td style="width: 119px">Student Name:</td>
                <td style="width: 120px">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="SName" DataValueField="SID">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 119px">&nbsp;</td>
                <td style="width: 120px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 119px">Timetable Number:</td>
                <td style="width: 120px">
                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="TID" DataValueField="TID">
                    </asp:DropDownList>
                </td>
            </tr>
            </table>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    <asp:Button ID="btnAddStudent" runat="server" Text="Assign" OnClick="btnAssign_Click"/>
    <br />
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Timetable]"></asp:SqlDataSource>
    <br />
</asp:Content>
