<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LecturerPage.aspx.cs" Inherits="SARS.LecturerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <h2>
        Welcome to UOG(Student Attendance System) - Lecturer Page</h2>
    <p>
        <table align="center" style="width: 62%;">
            <tr>
                <td class="style1" style="width: 564px">
                    <asp:Button ID="Button1" runat="server" BackColor="#FFCC66" ForeColor="Maroon" 
                        onclick="Button1_Click" Text="View Timetable" Width="181px" Height="43px" />
                </td>
                <td class="style3" rowspan="4">
                    <img class="style2" src="uog.jpg" /></td>
            </tr>
            <tr>
                <td class="style1" style="width: 564px">
                    <asp:Button ID="Button4" runat="server" BackColor="#FFCC66" ForeColor="Maroon" 
                        Text="View Attendance Record" Width="185px" Height="42px" 
                        onclick="Button4_Click" />
                </td>
            </tr>
            <tr>
                <td class="style1" style="width: 564px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td  class="style1" style="width: 564px">
                    &nbsp;</td>
            </tr>
                        <tr>
                <td  class="style1" style="width: 564px">
                    &nbsp;</td>
            </tr>
        </table>
</asp:Content>
