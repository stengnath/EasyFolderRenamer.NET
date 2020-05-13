Imports System.IO

Public Class Form1

    Private curDirName As String = ""
    Private dirInfo As DirectoryInfo
    Private path As String = ""
    Private blnRunning As Boolean = False
    Private blnstop As Boolean = False

    Private Sub AboutEFRToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutEFRToolStripMenuItem.Click
        Dim objAbout As New frmAbout
        objAbout.ShowDialog()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub cmd_ChooseFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ChooseFolder.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt_Folder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Function creatValidDir(ByVal path As String) As String
        Dim result As String = ""
        If path = "" Then
            Return ""
        End If
        If Mid(path, path.Length - 1, 1) <> "\" Then
            result = path & "\"
        End If

        If Directory.Exists(result) = False Then
            MsgBox("Pfad wurde nicht gefunden")
            Return "-1"
        End If

        Return result
    End Function

    Private Sub cmd_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Start.Click
        blnRunning = True
        cmd_Start.Visible = False
        cmd_Stop.Visible = True

        Me.Update()
        path = creatValidDir(txt_Folder.Text)

        If path = "" Then
            MsgBox("Kein Pfad angegeben. Aktion wird abgebrochen")
        ElseIf path = "-1" Then

        Else
            dirInfo = New DirectoryInfo(path)

            If check_Remove.Checked = True And txt_remove.Text <> "" Then
                goRemove()
            End If

            If check_Replace.Checked = True And txt_Replace.Text <> "" And txt_ReplaceWith.Text <> "" Then
                goReplace()
            End If

            If check_Postfix.Checked = True And txt_Postfix.Text <> "" Then
                goPostfix()
            End If

            If check_Prefix.Checked = True And txt_Prefix.Text <> "" Then
                goPrefix()
            End If

        End If

        cmd_Start.Visible = True
        cmd_Stop.Visible = False
        blnstop = False
        blnRunning = False
    End Sub

    Private Sub goRemove()
        For Each dir As DirectoryInfo In dirInfo.GetDirectories
            If blnstop = True Then
                Exit For
            End If
            curDirName = path & dir.Name
            Try
                If check_Remove.Checked = True And txt_remove.Text <> "" Then
                    If dir.Name.Contains(txt_remove.Text) Then
                        curDirName = path & dir.Name.Replace(txt_remove.Text, "")
                        Directory.Move(path & dir.Name, curDirName)
                    End If
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub goReplace()
        For Each dir As DirectoryInfo In dirInfo.GetDirectories
            If blnstop = True Then
                Exit For
            End If
            curDirName = path & dir.Name
            Try
                If check_Replace.Checked = True And txt_Replace.Text <> "" And txt_ReplaceWith.Text <> "" Then

                    If dir.Name.Contains(txt_Replace.Text) Then
                        curDirName = path & dir.Name.Replace(txt_Replace.Text, txt_ReplaceWith.Text)
                        Directory.Move(path & dir.Name, curDirName)
                    End If
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub goPostfix()
        For Each dir As DirectoryInfo In dirInfo.GetDirectories
            If blnstop = True Then
                Exit For
            End If
            curDirName = path & dir.Name
            Try
                If check_Postfix.Checked = True And txt_Postfix.Text <> "" Then
                    curDirName = path & dir.Name & txt_Postfix.Text
                    Directory.Move(path & dir.Name, curDirName)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub goPrefix()
        For Each dir As DirectoryInfo In dirInfo.GetDirectories
            If blnstop = True Then
                Exit For
            End If
            curDirName = path & dir.Name
            Try
                If check_Prefix.Checked = True And txt_Prefix.Text <> "" Then
                    curDirName = path & txt_Prefix.Text & dir.Name
                    Directory.Move(path & dir.Name, curDirName)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If blnRunning = True Then
            MsgBox("Bitte erst das Umbennenen stoppen, bevor das Programm beendet wird.")
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd_Stop.Visible = False
    End Sub

    Private Sub cmd_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Stop.Click
        blnstop = True
    End Sub
End Class
