<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="De-Serialization.aspx.cs" Inherits="SerializationDeserializaton.De_Serialization" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        span {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Deserializing JSON into Object</h2>

            <table>
                <tr>
                    <td>FirstName:</td>
                    <td>
                        <asp:Label ID="lblFirstName" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>LastName:</td>
                    <td>
                        <asp:Label ID="lblLastName" runat="server" /></td>
                </tr>
                <tr>
                    <td>Designation:</td>
                    <td>
                        <asp:Label ID="lblDesignation" runat="server" /></td>
                </tr>
                <tr>
                    <td>Department:</td>
                    <td>
                        <asp:Label ID="lblDepartment" runat="server" /></td>
                </tr>
                <tr>
                    <td>DateOfBirth:</td>
                    <td>
                        <asp:Label ID="lblDateOfBirth" runat="server" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
