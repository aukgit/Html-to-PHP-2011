Public Class condition

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

      


        If TypeOf Me.DataGridView1.DataSource Is BindingSource Then
            Form1.table = Me.Ds.php_replace
        Else
            Form1.table = Me.DataGridView1.DataSource

        End If

        Dim Tab As DataTable = Form1.table
        For I As Integer = 0 To Form1.table.Rows.Count - 1
            If InStr(Tab.Rows(I).Item("replaced_php_obj_name").ToString, "$") Then
                Tab.Rows(I).Item("replaced_php_obj_name") = Replace(Tab.Rows(I).Item("replaced_php_obj_name").ToString, "$", "", 1, -1, CompareMethod.Text)

            End If
        Next

        Me.Close()

    End Sub
End Class