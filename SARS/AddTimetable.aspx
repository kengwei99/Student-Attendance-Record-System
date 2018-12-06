<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddTimetable.aspx.cs" Inherits="SARS.AddTimetable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Timetable</h2>
    <p>&nbsp;</p>
    <div>
        <table class="style1">
            <tr>
                <td>Subject Name:</td>
                <td style="width: 103px">
                    <asp:DropDownList ID="DDL_SJName" runat="server"></asp:DropDownList>
                    <%--<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="SJName" DataValueField="CourseName"></asp:DropDownList>--%>
                </td>
            </tr>
            <tr>
                <td>Day:</td>
                <td style="width: 103px">
                <asp:DropDownList ID="DDL_Day" runat="server"
                                  AppendDataBoundItems="true">
                <asp:ListItem>Monday</asp:ListItem>
                <asp:ListItem>Tuesday</asp:ListItem>
                <asp:ListItem>Wednesday</asp:ListItem>
                <asp:ListItem>Thursday</asp:ListItem>
                <asp:ListItem>Friday</asp:ListItem>
                </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="height: 24px">Period:</td>
                <td style="height: 24px; width: 103px">
                <asp:DropDownList ID="DDL_Period" runat="server"
                                  AppendDataBoundItems="true">
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                </asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </div>
    <asp:Button ID="btnAddTimetable" runat="server" Text="Add Timetable" OnClick="btnAddTimetable_Click" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Subject] ORDER BY [SJID]"></asp:SqlDataSource>
    </asp:Content>
