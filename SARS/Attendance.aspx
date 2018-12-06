<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Attendance.aspx.cs" Inherits="SARS.Attendance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Attendance</h2>
    <p></p>
    <asp:Panel ID="Panel1" runat="server" GroupingText="Attendance Header" Width="100%">
        Subject Name :
        <asp:Label ID="lblSubject" runat="server" CssClass="borderlabel"></asp:Label>
        &nbsp; &nbsp; Today :
        <asp:Label ID="lblToday" runat="server" CssClass="borderlabel"></asp:Label>
        &nbsp; &nbsp; Day :
        <asp:Label ID="lblWeekno" runat="server" CssClass="borderlabel"></asp:Label>
        &nbsp; &nbsp; Period :
        <asp:Label ID="lblPeriod" runat="server" CssClass="borderlabel"></asp:Label>
    </asp:Panel>
    <br />
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="SID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="SID" HeaderText="SID" InsertVisible="False" ReadOnly="True" SortExpression="SID" />
                <asp:BoundField DataField="SName" HeaderText="SName" SortExpression="SName" />
               <asp:TemplateField HeaderText="Attendance">
                   <ItemTemplate>
                       <asp:RadioButton ID="rbPresent" runat="server" Checked="True" GroupName="g1" Text="Present" />
                       <asp:RadioButton ID="rbAbsent" runat="server" GroupName="g1" Text="Absent" />
                   </ItemTemplate>
                   <ItemStyle HorizontalAlign="Center" />
               </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="Btn_Record" runat="server" Text="Record" OnClick="Btn_Record_Click" />
    </p>
    <p>
        <asp:Label ID="lbl_attendance" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT Class.SID, SName FROM ((Class INNER JOIN Student ON Class.SID = Student.SID) INNER JOIN Timetable ON Class.TID = Timetable.TID) WHERE Timetable.TID = @tid ORDER BY Class.SID">
            <SelectParameters>
                <asp:QueryStringParameter Name="tid" QueryStringField="tid" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
