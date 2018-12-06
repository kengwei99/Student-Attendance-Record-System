<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="SARS.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <h2>
        Welcome to UOG(Student Attendance System) - Admin Page</h2>
    <p>
        <table align="center" style="width: 62%;">
            <tr>
                <td class="style1" style="width: 564px">
                    <asp:Button ID="Button1" runat="server" BackColor="#FFCC66" ForeColor="Maroon" 
                        onclick="Button1_Click" Text="Add Coordinator" Width="181px" Height="43px" />
                </td>
                <td class="style3" rowspan="4">
                    <img class="style2" src="uog.jpg" /></td>
            </tr>
            <tr>
                <td class="style1" style="width: 564px">
                    <asp:Button ID="Button4" runat="server" BackColor="#FFCC66" ForeColor="Maroon" 
                        Text="Add Lecturer" Width="185px" Height="42px" 
                        onclick="Button4_Click" />
                </td>
            </tr>
            <tr>
                <td class="style1" style="width: 564px">
                    <asp:Button ID="Button2" runat="server" BackColor="#FFCC66" ForeColor="Maroon" 
                        Text="Add Student" Width="182px" Height="49px" onclick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td  class="style1" style="width: 564px">
                    <asp:Button ID="Button3" runat="server" BackColor="#FFCC66" ForeColor="Maroon" 
                        Text="Add Subject" Width="185px" Height="45px" 
                        onclick="Button3_Click" />
                </td>
            </tr>
                        <tr>
                <td  class="style1" style="width: 564px">
                    <asp:Button ID="Button5" runat="server" BackColor="#FFCC66" ForeColor="Maroon" 
                        Text="Add Timetable" Width="185px" Height="45px" 
                        onclick="Button5_Click" />
                </td>
            </tr>
        </table>
</asp:Content>
