<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="designation.aspx.cs" Inherits="Assignment6.designation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div>
            <h2>DESIGNATION</h2>
            <table align="center">

                <tr>
                    <td>Department
                    </td>
                    <td>
                        <asp:DropDownList ID="ddldpt" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Enter the designation
                    </td>
                    <td>
                        <asp:TextBox ID="txtdesig" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnsub" runat="server" Text="Register" OnClick="btnsub_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="DesignationId" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" >
                <Columns>
                    <asp:BoundField DataField="DepartmentName" HeaderText="Department" />
                    <asp:BoundField DataField="DesignationName" HeaderText="Designation" />
                    <asp:CommandField HeaderText="Update" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                    <asp:HyperLinkField DataNavigateUrlFields="DesignationId" HeaderText="Go to next page" Text="Go" DataNavigateUrlFormatString="navigation.aspx" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
    </center>
</body>
</html>
