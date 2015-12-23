Public Class condition_replace

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




        If TypeOf Me.DataGridView1.DataSource Is BindingSource Then
            phpconverter.table = Me.Ds.php_replace
        Else
            phpconverter.table = Me.DataGridView1.DataSource

        End If

        Dim Tab As DataTable = phpconverter.table
        For I As Integer = 0 To phpconverter.table.Rows.Count - 1
            If InStr(Tab.Rows(I).Item("replaced_php_obj_name").ToString, "$") Then
                Tab.Rows(I).Item("replaced_php_obj_name") = Replace(Tab.Rows(I).Item("replaced_php_obj_name").ToString, "$", "", 1, -1, CompareMethod.Text)

            End If
        Next

        Me.Close()

    End Sub
End Class