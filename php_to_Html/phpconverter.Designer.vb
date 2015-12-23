<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class phpconverter
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
        Me.components = New System.ComponentModel.Container
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.html = New System.Windows.Forms.TextBox
        Me.php = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button8 = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HTMLAndPHPAutoIndentBeautiferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WorkWithMagentoFileStructerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConvertToPhpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReplaceInPhpCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CopyWholeCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyWithoutPhpTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BeautifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MagentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JoomlaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(671, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Convert to php"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(698, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Whole Code"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PHP OUTPUT CODES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "HTML INPUT CODES"
        '
        'html
        '
        Me.html.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Html_to_Php_Converter.My.MySettings.Default, "html", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.html.Location = New System.Drawing.Point(15, 78)
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
        Me.php.Location = New System.Drawing.Point(15, 293)
        Me.php.Multiline = True
        Me.php.Name = "php"
        Me.php.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.php.Size = New System.Drawing.Size(773, 214)
        Me.php.TabIndex = 7
        Me.php.Text = Global.Html_to_Php_Converter.My.MySettings.Default.php
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(609, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Replace"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(593, 264)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Without PHP Tag"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(69, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "More"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(87, 27)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(69, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "About Us"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(712, 513)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(66, 23)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Settings"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(554, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Copy"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(162, 27)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 23)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "Feedback"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HTMLAndPHPAutoIndentBeautiferToolStripMenuItem, Me.WorkWithMagentoFileStructerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 48)
        '
        'HTMLAndPHPAutoIndentBeautiferToolStripMenuItem
        '
        Me.HTMLAndPHPAutoIndentBeautiferToolStripMenuItem.Name = "HTMLAndPHPAutoIndentBeautiferToolStripMenuItem"
        Me.HTMLAndPHPAutoIndentBeautiferToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.HTMLAndPHPAutoIndentBeautiferToolStripMenuItem.Text = "Beautifier"
        '
        'WorkWithMagentoFileStructerToolStripMenuItem
        '
        Me.WorkWithMagentoFileStructerToolStripMenuItem.Name = "WorkWithMagentoFileStructerToolStripMenuItem"
        Me.WorkWithMagentoFileStructerToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.WorkWithMagentoFileStructerToolStripMenuItem.Text = "Magento"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(790, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MoreToolStripMenuItem
        '
        Me.MoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConvertToPhpToolStripMenuItem, Me.ReplaceInPhpCodeToolStripMenuItem, Me.ToolStripSeparator1, Me.CopyWholeCodeToolStripMenuItem, Me.CopyWithoutPhpTagToolStripMenuItem, Me.ToolStripSeparator3, Me.BeautifierToolStripMenuItem, Me.MagentoToolStripMenuItem, Me.JoomlaToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.MoreToolStripMenuItem.Name = "MoreToolStripMenuItem"
        Me.MoreToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.MoreToolStripMenuItem.Text = "More"
        '
        'ConvertToPhpToolStripMenuItem
        '
        Me.ConvertToPhpToolStripMenuItem.Name = "ConvertToPhpToolStripMenuItem"
        Me.ConvertToPhpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ConvertToPhpToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ConvertToPhpToolStripMenuItem.Text = "Convert to php"
        '
        'ReplaceInPhpCodeToolStripMenuItem
        '
        Me.ReplaceInPhpCodeToolStripMenuItem.Name = "ReplaceInPhpCodeToolStripMenuItem"
        Me.ReplaceInPhpCodeToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReplaceInPhpCodeToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ReplaceInPhpCodeToolStripMenuItem.Text = "Replace In php Code"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(244, 6)
        '
        'CopyWholeCodeToolStripMenuItem
        '
        Me.CopyWholeCodeToolStripMenuItem.Name = "CopyWholeCodeToolStripMenuItem"
        Me.CopyWholeCodeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.CopyWholeCodeToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.CopyWholeCodeToolStripMenuItem.Text = "Copy Whole Code"
        '
        'CopyWithoutPhpTagToolStripMenuItem
        '
        Me.CopyWithoutPhpTagToolStripMenuItem.Name = "CopyWithoutPhpTagToolStripMenuItem"
        Me.CopyWithoutPhpTagToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.CopyWithoutPhpTagToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.CopyWithoutPhpTagToolStripMenuItem.Text = "Copy without php Tag"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(244, 6)
        '
        'BeautifierToolStripMenuItem
        '
        Me.BeautifierToolStripMenuItem.Name = "BeautifierToolStripMenuItem"
        Me.BeautifierToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BeautifierToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.BeautifierToolStripMenuItem.Text = "Beautifier"
        '
        'MagentoToolStripMenuItem
        '
        Me.MagentoToolStripMenuItem.Name = "MagentoToolStripMenuItem"
        Me.MagentoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MagentoToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.MagentoToolStripMenuItem.Text = "Magento"
        '
        'JoomlaToolStripMenuItem
        '
        Me.JoomlaToolStripMenuItem.Name = "JoomlaToolStripMenuItem"
        Me.JoomlaToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.JoomlaToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.JoomlaToolStripMenuItem.Text = "Joomla"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(244, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'phpconverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 555)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.php)
        Me.Controls.Add(Me.html)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "phpconverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HTML Preview Generate in PHP"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HTMLAndPHPAutoIndentBeautiferToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkWithMagentoFileStructerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertToPhpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplaceInPhpCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeautifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JoomlaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyWholeCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyWithoutPhpTagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
