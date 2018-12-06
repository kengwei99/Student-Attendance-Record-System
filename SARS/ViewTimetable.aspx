<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewTimetable.aspx.cs" Inherits="SARS.ViewTimetable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Timetable</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="TID" HeaderText="TID" InsertVisible="False" ReadOnly="True" SortExpression="TID" />
            <asp:BoundField DataField="SJName" HeaderText="Subject Name" SortExpression="SJName" />
            <asp:BoundField DataField="Day" HeaderText="Day" SortExpression="Day" />
            <asp:BoundField DataField="Period" HeaderText="Period" SortExpression="Period" />
            <asp:BoundField DataField="CourseName" HeaderText="Course Name" SortExpression="CourseName" />
            <asp:HyperLinkField DataNavigateUrlFields="sjname,day,period,coursename,tid" DataNavigateUrlFormatString="attendance.aspx?sjname={0}&amp;day={1}&amp;period={2}&amp;coursename={3}&amp;tid={4}"
            Text="Attendance" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Timetable]"></asp:SqlDataSource>

</asp:Content>
