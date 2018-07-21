<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StudentApplication.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" lang="javascript">
        function getStudentByCode() {
            var code = document.getElementById("txtCode").value;
            debugger
            StudentApplication.StudentService.GetStudentByCode(code, GetStudentByCodeCallBackSuccess, GetStudentByCodeCallBackFailure)

        }
        debugger
       
        function GetStudentByCodeCallBackSuccess(results) {
            debugger
            document.getElementById("txtName").value = results["name"]; 
            document.getElementById("txtGender").value = results["gender"]; 
            document.getElementById("txtDateOfBirth").value = results["dateOfBirth"]; 

        }

        function GetStudentByCodeCallBackFailure(errors) {
            alert(errors.get_message());
        }
    </script>
</head>
<body>
    <form id="form2" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/StudentService.asmx" />
            </Services>
        </asp:ScriptManager>
        <div>
            <table style="font-family:Arial">
                <tr>
                    <td>
                        <b>Code</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
              
                        <input type="button" id="btnStd"  value="Get Student" onclick="getStudentByCode()" />
               
                        </td>
                </tr>
                <tr>
                    <td>
                        <b>Name</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Gender</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Date of Birth</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
               
               
            </table>
        </div>
    </form>
</body>
</html>

