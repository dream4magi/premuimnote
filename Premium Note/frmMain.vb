Option Strict On
Option Explicit On
Public Class frmMain
    Dim exit_flag As Boolean = False

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.Visible Then
            Me.Hide()
        Else
            Me.Show()
        End If

    End Sub





#Region "form event"
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '  Me.WindowState = FormWindowState.Minimized
        If Not exit_flag Then
            Me.Hide()
            e.Cancel = True
        End If


    End Sub
#End Region


    Sub showForm()
        Me.WindowState = FormWindowState.Normal
        Me.Show()
    End Sub
    Sub hideForm()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim frmAdd As Form = New frmAddNote
        'frmAdd.Show()
        frmAddNote.Show()
    End Sub



#Region "menu"
    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        showForm()
    End Sub

    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
        hideForm()
    End Sub
    Private Sub ExitPremiumNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitPremiumNoteToolStripMenuItem.Click
        exit_flag = True
        Application.Exit()
    End Sub
#End Region

    Private Sub StartWithSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartWithSystemToolStripMenuItem.Click
        My.Settings.START_WITH_SYSTEM = StartWithSystemToolStripMenuItem.Checked
        My.Settings.Save()
        registyStartWithSystem()
    End Sub


    Private Sub registyStartWithSystem()

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mdlVariable.initialNoteColor()

        Dim ALL_NOTES As clsAllNotes = readDataFile()
        For i As Integer = 0 To ALL_NOTES.Notes.Length - 1
            aryALL_NOTES.Add(ALL_NOTES.Notes(i))
        Next
        ALL_NOTES = Nothing


        saveDataFile()
    End Sub


    Function readDataFile() As clsAllNotes
        Dim ALL_NOTES As clsAllNotes
        Try


            Dim fileContents As String
            fileContents = My.Computer.FileSystem.ReadAllText("data.xml")

            Dim Xmsg As New Xstream.Core.XStream
            Xmsg.Alias("AllNotes", GetType(clsAllNotes))
            Xmsg.Alias("Note", GetType(clsAllNotes.clsNoteData))
            ALL_NOTES = CType(Xmsg.FromXml(fileContents), clsAllNotes)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
        If ALL_NOTES Is Nothing Then
            ALL_NOTES = New clsAllNotes
        End If
        Return ALL_NOTES
    End Function

    Sub saveDataFile()

        Dim ALL_NOTES = New clsAllNotes
        ReDim ALL_NOTES.Notes(aryALL_NOTES.Count - 1)

        For i As Integer = 0 To aryALL_NOTES.Count - 1
            ALL_NOTES.Notes(i) = aryALL_NOTES.Item(i)
        Next

        Try
            Dim Xmsg As New Xstream.Core.XStream
            Xmsg.Alias("AllNotes", GetType(clsAllNotes))
            Xmsg.Alias("Note", GetType(clsAllNotes.clsNoteData))


            My.Computer.FileSystem.WriteAllText("data.xml", Xmsg.ToXml(ALL_NOTES), False)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Function getNewNoteNo() As Double
        Dim NextNoteNo As Double = -1
        For Each obj As clsAllNotes.clsNoteData In aryALL_NOTES
            If CType(obj.note_no, Double) > NextNoteNo Then
                NextNoteNo = CType(obj.note_no, Double)
            End If
        Next
        Return NextNoteNo + 1
    End Function


    Private Sub btnNoteList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoteList.Click
        frmNoteList.Show()
    End Sub
End Class
