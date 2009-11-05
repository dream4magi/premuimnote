﻿Public Class frmMain
    Dim exit_flag As Boolean = False

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
            Me.Hide()
        Else
            Me.WindowState = FormWindowState.Normal
            Me.Show()
        End If

    End Sub





#Region "form event"
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Minimized
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
        Me.Hide()
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
End Class
