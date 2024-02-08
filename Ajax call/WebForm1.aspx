<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practiceconnections.Ajax_call.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.8.2.js"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/jquery-ui.min.js"></script>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        First Name&nbsp;
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <p>
            Password&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnSave" runat="server" Text="Save" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="username" HeaderText="Username" />
                <asp:BoundField DataField="Email"   HeaderText="Email" />
            </Columns>

        </asp:GridView>
    </form>
</body>
 
</html>
  <%-- <script type="text/javascript">


       $(function () {
           debugger
           $("[id*=btnSave]").bind("click", function () {
               var user = {};
               user.Username = $("[id*=txtUserName]").val();
               user.email = $("[id*=txtEmail]").val();
               $.ajax({
                   type: "POST",
                   url: "WebForm1.aspx/user",
                   data: '{user:' + JSON.stringify(user) + '}',
                   contentType: "application/json; charset=utf-8",
                   dataType: "Json",
                   success: function () {
                       alert("data save successfully");
                       window.location.reload();
                   }
               });
               return false;

           });
       });
   </script>--%>
