<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSubject.aspx.cs" Inherits="SARS.AddSubject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Subject</h2>
    <p>&nbsp;</p>
    <div>
        <table class="style1">
            <tr>
                <td>Subject Name:</td>
                <td>
                    <asp:TextBox ID="txtSubjectName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Course:</td>
                <td>
                <asp:DropDownList ID="DDL_Course" runat="server" DataSourceID="SqlDataSource1" DataTextField="CourseName" DataValueField="CourseName"></asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </div>
    <asp:Button ID="btnAddSubject" runat="server" Text="Add Subject" OnClick="btnAddSubject_Click" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Course]"></asp:SqlDataSource>
    </asp:Content>
