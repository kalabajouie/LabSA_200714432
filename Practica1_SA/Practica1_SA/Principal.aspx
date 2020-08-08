<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Principal.aspx.vb" Inherits="Practica1_SA.Principal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="css/EstiloJSP.css" rel="stylesheet" type="text/css" />
    <link href="css/datatables.css" rel="stylesheet" type="text/css" />
    
    <script src="js/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="js/datatables.js" type="text/javascript"></script>
    <script src="js/dataTables.responsive.js" type="text/javascript"></script>
    
    <script type="text/javascript">
        $(function () {
            $("[id*=GridView1]").prepend($("<thead></thead>").append($('#GridView1').find("tr:first"))).DataTable();

        });
    </script>

    <title>Contactos2</title>
</head>
<body class="body">
    <form id="form1" runat="server">
    <div>
        <div class="form-group col-12 col-sm-12 col-md-12 col-lg-10 col-xl-8 offset-lg-1 offset-xl-2">
            <div class="card">
                <div class="card-header text-white bg-dark">Contactos</div>
                <div class="card-body">
                    <div class="row">
                        <asp:Button ID="btn_crear_contactos" runat="server" Text="Insertar Contactos" /> &nbsp
                        <asp:Button ID="btn_listar_contactos" runat="server" Text="Listar Contactos" />
                    </div>
                    <br/>
                    <asp:GridView ID="GridView1" runat="server" class="table table-dark table-stripped table-hover">
                    </asp:GridView>
                </div>
            </div>
        </div>
        
    </div>
    </form>
</body>
</html>
