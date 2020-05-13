<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutEFRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.txt_Folder = New System.Windows.Forms.TextBox
        Me.cmd_ChooseFolder = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.check_Prefix = New System.Windows.Forms.CheckBox
        Me.check_Postfix = New System.Windows.Forms.CheckBox
        Me.check_Remove = New System.Windows.Forms.CheckBox
        Me.check_Replace = New System.Windows.Forms.CheckBox
        Me.txt_Prefix = New System.Windows.Forms.TextBox
        Me.txt_Postfix = New System.Windows.Forms.TextBox
        Me.txt_remove = New System.Windows.Forms.TextBox
        Me.txt_Replace = New System.Windows.Forms.TextBox
        Me.cmd_Start = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_ReplaceWith = New System.Windows.Forms.TextBox
        Me.cmd_Stop = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.AboutEFRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(294, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'AboutEFRToolStripMenuItem
        '
        Me.AboutEFRToolStripMenuItem.Name = "AboutEFRToolStripMenuItem"
        Me.AboutEFRToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.AboutEFRToolStripMenuItem.Text = "About EFR"
        '
        'txt_Folder
        '
        Me.txt_Folder.Location = New System.Drawing.Point(12, 47)
        Me.txt_Folder.Name = "txt_Folder"
        Me.txt_Folder.Size = New System.Drawing.Size(240, 20)
        Me.txt_Folder.TabIndex = 1
        '
        'cmd_ChooseFolder
        '
        Me.cmd_ChooseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ChooseFolder.Location = New System.Drawing.Point(253, 46)
        Me.cmd_ChooseFolder.Name = "cmd_ChooseFolder"
        Me.cmd_ChooseFolder.Size = New System.Drawing.Size(26, 21)
        Me.cmd_ChooseFolder.TabIndex = 2
        Me.cmd_ChooseFolder.Text = "..."
        Me.cmd_ChooseFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_ChooseFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmd_ChooseFolder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bitte Ordner auswählen"
        '
        'check_Prefix
        '
        Me.check_Prefix.AutoSize = True
        Me.check_Prefix.Location = New System.Drawing.Point(12, 86)
        Me.check_Prefix.Name = "check_Prefix"
        Me.check_Prefix.Size = New System.Drawing.Size(52, 17)
        Me.check_Prefix.TabIndex = 3
        Me.check_Prefix.Text = "Prefix"
        Me.check_Prefix.UseVisualStyleBackColor = True
        '
        'check_Postfix
        '
        Me.check_Postfix.AutoSize = True
        Me.check_Postfix.Location = New System.Drawing.Point(12, 112)
        Me.check_Postfix.Name = "check_Postfix"
        Me.check_Postfix.Size = New System.Drawing.Size(57, 17)
        Me.check_Postfix.TabIndex = 5
        Me.check_Postfix.Text = "Postfix"
        Me.check_Postfix.UseVisualStyleBackColor = True
        '
        'check_Remove
        '
        Me.check_Remove.AutoSize = True
        Me.check_Remove.Location = New System.Drawing.Point(12, 138)
        Me.check_Remove.Name = "check_Remove"
        Me.check_Remove.Size = New System.Drawing.Size(66, 17)
        Me.check_Remove.TabIndex = 7
        Me.check_Remove.Text = "Entferne"
        Me.check_Remove.UseVisualStyleBackColor = True
        '
        'check_Replace
        '
        Me.check_Replace.AutoSize = True
        Me.check_Replace.Location = New System.Drawing.Point(12, 164)
        Me.check_Replace.Name = "check_Replace"
        Me.check_Replace.Size = New System.Drawing.Size(61, 17)
        Me.check_Replace.TabIndex = 9
        Me.check_Replace.Text = "Ersetze"
        Me.check_Replace.UseVisualStyleBackColor = True
        '
        'txt_Prefix
        '
        Me.txt_Prefix.Location = New System.Drawing.Point(99, 84)
        Me.txt_Prefix.Name = "txt_Prefix"
        Me.txt_Prefix.Size = New System.Drawing.Size(74, 20)
        Me.txt_Prefix.TabIndex = 4
        '
        'txt_Postfix
        '
        Me.txt_Postfix.Location = New System.Drawing.Point(99, 110)
        Me.txt_Postfix.Name = "txt_Postfix"
        Me.txt_Postfix.Size = New System.Drawing.Size(74, 20)
        Me.txt_Postfix.TabIndex = 6
        '
        'txt_remove
        '
        Me.txt_remove.Location = New System.Drawing.Point(99, 136)
        Me.txt_remove.Name = "txt_remove"
        Me.txt_remove.Size = New System.Drawing.Size(74, 20)
        Me.txt_remove.TabIndex = 8
        '
        'txt_Replace
        '
        Me.txt_Replace.Location = New System.Drawing.Point(99, 162)
        Me.txt_Replace.Name = "txt_Replace"
        Me.txt_Replace.Size = New System.Drawing.Size(74, 20)
        Me.txt_Replace.TabIndex = 10
        '
        'cmd_Start
        '
        Me.cmd_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Start.Location = New System.Drawing.Point(12, 199)
        Me.cmd_Start.Name = "cmd_Start"
        Me.cmd_Start.Size = New System.Drawing.Size(267, 23)
        Me.cmd_Start.TabIndex = 12
        Me.cmd_Start.Text = "Start"
        Me.cmd_Start.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_Start.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmd_Start.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "mit"
        '
        'txt_ReplaceWith
        '
        Me.txt_ReplaceWith.Location = New System.Drawing.Point(205, 162)
        Me.txt_ReplaceWith.Name = "txt_ReplaceWith"
        Me.txt_ReplaceWith.Size = New System.Drawing.Size(74, 20)
        Me.txt_ReplaceWith.TabIndex = 11
        '
        'cmd_Stop
        '
        Me.cmd_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Stop.Location = New System.Drawing.Point(12, 199)
        Me.cmd_Stop.Name = "cmd_Stop"
        Me.cmd_Stop.Size = New System.Drawing.Size(267, 23)
        Me.cmd_Stop.TabIndex = 12
        Me.cmd_Stop.Text = "Stop"
        Me.cmd_Stop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 228)
        Me.Controls.Add(Me.cmd_Stop)
        Me.Controls.Add(Me.txt_ReplaceWith)
        Me.Controls.Add(Me.txt_Replace)
        Me.Controls.Add(Me.txt_remove)
        Me.Controls.Add(Me.txt_Postfix)
        Me.Controls.Add(Me.txt_Prefix)
        Me.Controls.Add(Me.check_Replace)
        Me.Controls.Add(Me.check_Remove)
        Me.Controls.Add(Me.check_Postfix)
        Me.Controls.Add(Me.check_Prefix)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_Start)
        Me.Controls.Add(Me.cmd_ChooseFolder)
        Me.Controls.Add(Me.txt_Folder)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Easy Folder Renamer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutEFRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txt_Folder As System.Windows.Forms.TextBox
    Friend WithEvents cmd_ChooseFolder As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents check_Prefix As System.Windows.Forms.CheckBox
    Friend WithEvents check_Postfix As System.Windows.Forms.CheckBox
    Friend WithEvents check_Remove As System.Windows.Forms.CheckBox
    Friend WithEvents check_Replace As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Prefix As System.Windows.Forms.TextBox
    Friend WithEvents txt_Postfix As System.Windows.Forms.TextBox
    Friend WithEvents txt_remove As System.Windows.Forms.TextBox
    Friend WithEvents txt_Replace As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Start As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ReplaceWith As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Stop As System.Windows.Forms.Button

End Class
