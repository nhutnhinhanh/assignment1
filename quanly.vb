Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class quanly
    Dim table As New DataTable
    Dim some As String = "workstation id=vyntps02268.mssql.somee.com;packet size=4096;user id=ps02268_SQLLogin_1;pwd=wdn1lom6l7;data source=vyntps02268.mssql.somee.com;persist security info=False;initial catalog=vyntps02268"
    Private Sub tai()
        Dim upload As New SqlConnection(some)
        Dim insert As New SqlDataAdapter(" select * from SanPham ", upload)
        Try
            upload.Open()
            insert.Fill(table)

        Catch ex As Exception
        End Try
        data1.DataSource = table
        upload.Close()
    End Sub
    Private Sub btnxem_Click(sender As Object, e As EventArgs) Handles btnxem.Click
        Dim upload As New SqlConnection(some)
        Dim insert As New SqlDataAdapter(" select * from SanPham ", upload)
        Try
            upload.Open()
            insert.Fill(table)

        Catch ex As Exception
        End Try
        data1.DataSource = table
        upload.Close()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim hienthi As New SqlConnection(some)
        Dim add As New SqlDataAdapter("insert into SanPham values ('" & txtma.Text & "','" & txtten.Text & "', '" & txtgia.Text & "', '" & txtso.Text & "', '" & txtct.Text & "', '" & txtloai.Text & "')", hienthi)
        Try
            hienthi.Open()
            add.Fill(table)

        Catch ex As Exception
            MessageBox.Show("thêm dữ liệu thành công!")
        End Try
        data1.DataSource = table
        hienthi.Close()
    End Sub
End Class