<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Principal.aspx.vb" Inherits="Practica1_SA.Principal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="css/datatables.css" rel="stylesheet" type="text/css" />
    
    <script src="js/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="js/datatables.js" type="text/javascript"></script>
    <script src="js/dataTables.responsive.js" type="text/javascript"></script>
    
    <script type="text/javascript">
        $(function () {
            $("[id*=GridView1]").prepend($("<thead></thead>").append($('#GridView1').find("tr:first"))).DataTable();

        });
</script>

    <title></title>
</head>
<body style="background-color:Gray;">
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
