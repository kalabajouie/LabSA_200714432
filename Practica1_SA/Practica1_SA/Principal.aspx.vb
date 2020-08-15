Imports Practica1_SA.api_sa_admin_contactos

Public Class Principal
    Inherits System.Web.UI.Page
    Dim api As New administratorcontact100Client

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'api.ClientCredentials.UserName.UserName = "sa"
        'api.ClientCredentials.UserName.Password = "usac"
    End Sub

    Private Sub crear_contactos()

        'MsgBox(api.ClientCredentials)
        api.ClientCredentials.UserName.UserName = "sa"
        api.ClientCredentials.UserName.Password = "usac"

        'Ciclo que se repite 10 veces, en cada pasada inserta un contacto
        For i As Integer = 0 To 10 - 1
            api.create("200714432 - Contacto " & i, 0, "", 1)
        Next

        listar_contactos()

    End Sub

    Private Sub listar_contactos()
        'Se utiliza la operacion readList del Servicio proporcionado, se aplica como filtro el numero de registro academico
        Try
            Dim filtro As New readList_filters
            filtro.published = 1

            Dim obj = api.readList(0, 10, "200714432", filtro, "", "", "")

            'Se crea un datatable donde se almacenará la informacion devuelta
            Dim dt As New DataTable
            dt.Columns.Add("id")
            dt.Columns.Add("access")
            dt.Columns.Add("featured")
            dt.Columns.Add("language")
            dt.Columns.Add("name")
            dt.Columns.Add("ordering")

            'Un ciclo almacena los datos de cada contacto en el Datatable
            For i As Integer = 0 To obj.Count - 1
                dt.Rows.Add(obj(i).id, obj(i).access, obj(i).featured, obj(i).language, obj(i).name, obj(i).ordering)
            Next

            'Los datos resultantes se muestran en un Grid
            GridView1.DataSource = dt
            GridView1.DataBind()
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub btn_crear_contactos_Click(sender As Object, e As EventArgs) Handles btn_crear_contactos.Click
        crear_contactos()
    End Sub

    Protected Sub btn_listar_contactos_Click(sender As Object, e As EventArgs) Handles btn_listar_contactos.Click
        listar_contactos()
    End Sub
End Class