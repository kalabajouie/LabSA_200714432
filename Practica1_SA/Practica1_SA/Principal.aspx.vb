Imports Practica1_SA.api_sa_admin_contactos

Public Class Principal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim api As New administratorcontact100Client

            'Se crean 10 contactos
            'For i As Integer = 0 To 10 - 1
            '    api.create("200714432 - Contacto " & i, 0, "", 1)
            'Next


            Dim filtro As New readList_filters
            filtro.published = 1

            Dim obj = api.readList(0, 10, "200714432", filtro, "", "", "")

            Dim dt As New DataTable
            dt.Columns.Add("id")
            dt.Columns.Add("access")
            dt.Columns.Add("featured")
            dt.Columns.Add("language")
            dt.Columns.Add("name")
            dt.Columns.Add("ordering")


            For i As Integer = 0 To obj.Count - 1
                dt.Rows.Add(obj(i).id, obj(i).access, obj(i).featured, obj(i).language, obj(i).name, obj(i).ordering)
            Next

            GridView1.DataSource = dt
            GridView1.DataBind()

        Catch ex As Exception

        End Try
        

    End Sub

End Class