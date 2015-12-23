Public Class Form1
    Public wholecode As String
    Public php_code As String
    Public table As DataTable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b As Array
        Dim html_lines() As String
        html_lines = Split(Me.html.Text, vbCrLf, -1, CompareMethod.Binary)
        Dim new_php_lines As String

        new_php_lines = ""

        Dim phpStartTag As String = "<?php " + vbCrLf + vbCrLf
        Dim obj_name As String = "$html_generate = array();" + vbCrLf + "$html_gen_name = 'html_display1';" + vbCrLf + "$html_generate[$html_gen_name] = """";" + vbCrLf + vbCrLf
        Dim php_findObjects_Create As String = ""
        If table IsNot Nothing Then
            If table.Rows.Count > 0 Then
                php_findObjects_Create = UCase("/** ---- php replace objects from html-to-php-converter 1.0  ---- **/") + vbCrLf
                For Each row As DataRow In table.Rows
                    php_findObjects_Create += "$" + CStr(row("replaced_php_obj_name")) + " = """ + Replace(CStr(row("php_object_Value")), """", Chr(39)) + """;" + vbCrLf


                Next
                php_findObjects_Create += UCase("//------ Complete php replace objects declearation -------// ") + vbCrLf + vbCrLf

            End If
        End If

        For Each line As String In html_lines
            Dim ReplacedLineInSignle As String = line.Replace("""", Chr(39))
            'MsgBox("""")

            ReplacedLineInSignle = ReplacedLineInSignle.Replace(vbTab, "")
            Dim Str As String = "$html_generate[$html_gen_name] .= """ + Trim(Trim(ReplacedLineInSignle)) + """;"



            If InStr(Str, "#", CompareMethod.Text) > 0 Then
                Dim Strbr
                Strbr = "$browse_url = '#';" + vbCrLf
                Str = vbCrLf + Strbr + Str.Replace("#", "{$browse_url}") + vbCrLf

            End If
            If InStr(Str, "<?php echo ", CompareMethod.Text) > 0 Then
                Str = Str.Replace("<?php echo ", "")
            End If
            If InStr(Str, "; ?>", CompareMethod.Text) > 0 Then
                Str = Str.Replace("; ?>", "")
            End If
            If InStr(Str, ";?>", CompareMethod.Text) > 0 Then
                Str = Str.Replace(";?>", "")
            End If
            Dim searchtxt As String
            searchtxt = " ?>"
            If InStr(Str, searchtxt, CompareMethod.Text) > 0 Then
                Str = Str.Replace(searchtxt, "")
            End If
            Dim replace_object As String = ""

            Dim Compare As Microsoft.VisualBasic.CompareMethod


            If table IsNot Nothing Then
                If table.Rows.Count > 0 Then
                    For Each row As DataRow In table.Rows
                        If CBool(row("CaseSensetive")) = True Then
                            Compare = CompareMethod.Binary
                        Else
                            Compare = CompareMethod.Text

                        End If
                        searchtxt = CStr(row("find_object"))
                        replace_object = "{$" + CStr(row("replaced_php_obj_name")) + "}"
                        If InStr(Str, searchtxt, Compare) > 0 Then
                            Str = Replace(Str, searchtxt, replace_object, 1, -1, Compare)
                        End If
                    Next


                End If
            End If

            new_php_lines += Str & vbCrLf
        Next
        Dim FinishedLine As String = ""



        FinishedLine = vbCrLf + "echo $html_generate[$html_gen_name];" + vbCrLf + vbCrLf + "?>"

        wholecode = phpStartTag + php_findObjects_Create + obj_name + new_php_lines + FinishedLine
        php_code = php_findObjects_Create + obj_name + new_php_lines


        Me.php.Text = wholecode

        My.Settings.Save()

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Dim sW As New IO.StringWriter


        'table.WriteXml(sW)
        'My.Settings.phpConditionDb = sW.ToString
        'My.Settings.Save()
        'Dim Tb
        'My.Settings.Reload()
        'Tb = My.Settings.phpConditionDb
        ' table.WriteXml(My.Application.Info.DirectoryPath + "\condition.xml")
        My.Settings.php_code_only = php_code
        My.Settings.wholephp_code = wholecode
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'On Error Resume Next
        'If My.Settings.phpConditionDb.ToString = "" Then Exit Sub

        'Dim sR As New IO.StringReader(My.Settings.phpConditionDb)
        'table = New DataTable("php_replace")
        'If My.Settings.phpConditionDb IsNot Nothing OrElse My.Settings.phpConditionDb.ToString = "" Then
        '    If sR.ToString <> "" Then
        '        table.TableName = "php_replace"

        '    End If

        'End If
        'If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\condition.xml") Then
        '    table.ReadXml(My.Application.Info.DirectoryPath + "\condition.xml")

        'End If

        php_code = My.Settings.php_code_only
        wholecode = My.Settings.wholephp_code
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(wholecode)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(php_code)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        condition.Show()
        If table IsNot Nothing Then
            condition.DataGridView1.DataSource = table
        End If

    End Sub
End Class
