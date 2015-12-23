<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.html = New System.Windows.Forms.TextBox
        Me.php = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(681, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Convert to php"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(714, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Copy Code"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PHP OUTPUT CODES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "HTML INPUT CODES"
        '
        'html
        '
        Me.html.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Html_to_Php_Converter.My.MySettings.Default, "html", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.html.Location = New System.Drawing.Point(15, 41)
        Me.html.Multiline = True
        Me.html.Name = "html"
        Me.html.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.html.Size = New System.Drawing.Size(773, 180)
        Me.html.TabIndex = 6
        Me.html.Text = Global.Html_to_Php_Converter.My.MySettings.Default.html
        '
        'php
        '
        Me.php.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Html_to_Php_Converter.My.MySettings.Default, "php", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.php.Location = New System.Drawing.Point(15, 256)
        Me.php.Multiline = True
        Me.php.Name = "php"
        Me.php.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.php.Size = New System.Drawing.Size(773, 240)
        Me.php.TabIndex = 7
        Me.php.Text = Global.Html_to_Php_Converter.My.MySettings.Default.php
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(524, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "user search and replace condition"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(566, 227)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Copy without php tag"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 508)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.php)
        Me.Controls.Add(Me.html)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HTML PREVIEW GENENRATE TO PHP ECHO BY AUK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents html As System.Windows.Forms.TextBox
    Friend WithEvents php As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
