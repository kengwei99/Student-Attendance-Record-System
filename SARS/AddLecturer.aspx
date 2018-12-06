<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddLecturer.aspx.cs" Inherits="SARS.AddLecturer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Lecturer</h2>
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
                <td>Lecturer Name: </td>
                <td>
                    <asp:TextBox ID="txtLecturerName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Course:</td>
                <td>
                <asp:DropDownList ID="DDL_Course" runat="server" DataSourceID="SqlDataSource1" DataTextField="CourseName" DataValueField="CourseName">
                </asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    <asp:Button ID="btnAddLecturer" runat="server" Text="Add Lecturer" OnClick="btnAddLecturer_Click" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Course]"></asp:SqlDataSource>
    </asp:Content>
