<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="SARS.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Student</h2>
    <p>&nbsp;</p>
    <div>
        <table class="style1">
            <tr>
                <td>Username:</td>
                <td style="width: 130px">
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td style="width: 130px">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Student Name: </td>
                <td style="width: 130px">
                    <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Course:</td>
                <td style="width: 130px">
                <asp:DropDownList ID="DDL_Course" runat="server" DataSourceID="SqlDataSource1" DataTextField="CourseName" DataValueField="CourseName">
                </asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    <asp:Button ID="btnAddStudent" runat="server" Text="Add Student" OnClick="btnAddStudent_Click" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Course]"></asp:SqlDataSource>
    </asp:Content>
