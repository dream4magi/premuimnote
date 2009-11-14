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
        frmAddNote.Owner = Me

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
        If ALL_NOTES.Notes IsNot Nothing Then
            For i As Integer = 0 To ALL_NOTES.Notes.Length - 1
                aryALL_NOTES.Add(ALL_NOTES.Notes(i))
            Next
        End If

        ALL_NOTES = Nothing


        'Dim a As New clsAllNotes.clsNoteData(T.getNewNoteNo.ToString)

        'aryALL_NOTES.Add(a)
        'a = New clsAllNotes.clsNoteData(T.getNewNoteNo.ToString)
        'aryALL_NOTES.Add(a)

        refreshNote_no()
        loadAllNotePaper()
    End Sub







    Sub refreshNote_no()
        tlblNoteNo.Text = String.Format("Total Notes Count: {0}", getTotalNoteCount())
    End Sub

    Private Sub btnNoteList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoteList.Click
        frmNoteList.Show()
    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        frmSetting.Show()
    End Sub

    Private Sub AddNewNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewNoteToolStripMenuItem.Click
        frmAddNote.Show()
        frmAddNote.Owner = Me
    End Sub
End Class
