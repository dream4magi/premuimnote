Option Strict On
Option Explicit On
Public Class frmPreference

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkStartWSys.Checked = My.Settings.START_WITH_SYSTEM
        updateLabelFont()
        TrackBarOpacity.Value = CType(My.Settings.NOTE_OPACITY * 100, Int32)
        TrackBarTabOpacity.Value = CType(My.Settings.NOTE_TAB_OPACITY * 100, Int32)
        Me.lblOpacity.Text = TrackBarOpacity.Value.ToString
        Me.lblTabOpacity.Text = TrackBarTabOpacity.Value.ToString
        chkTabOnTop.Checked = My.Settings.NOTE_TAB_ON_TOP
        chkAnimation.Checked = My.Settings.ANIMATION

        cboSort.SelectedIndex = My.Settings.SORT_METHOD
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FontDialog1.FontMustExist = True
        FontDialog1.ShowApply = False
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.NOTE_FONT = FontDialog1.Font

            updateLabelFont()
        End If
    End Sub

    Private Sub chkStartWSys_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartWSys.CheckedChanged
        My.Settings.START_WITH_SYSTEM = chkStartWSys.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        My.Settings.Save()
        noteSettingRefresh()
        Me.Close()
    End Sub

    Private Sub chkAnimation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnimation.CheckedChanged
        My.Settings.ANIMATION = chkAnimation.Checked

    End Sub


    Sub updateLabelFont()
        lblFont.Text = My.Settings.NOTE_FONT.Name.ToString & ", " & _
               My.Settings.NOTE_FONT.Size.ToString & "pt, " & _
               My.Settings.NOTE_FONT.Style.ToString
    End Sub

    Private Sub TrackBarOpacity_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarOpacity.Scroll
        My.Settings.NOTE_OPACITY = TrackBarOpacity.Value / 100
        Me.lblOpacity.Text = TrackBarOpacity.Value.ToString
    End Sub

    Private Sub TrackBarTabOpacity_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarTabOpacity.Scroll
        My.Settings.NOTE_TAB_OPACITY = TrackBarTabOpacity.Value / 100
        Me.lblTabOpacity.Text = TrackBarTabOpacity.Value.ToString
    End Sub

    Sub noteSettingRefresh()
        For Each obj As INotePaper In aryALL_NOTES_paper
            If obj.GetType.Equals(GetType(frmNoteDetailTemplate)) Then
                CType(obj, frmNoteDetailTemplate).Opacity = My.Settings.NOTE_OPACITY
                CType(obj, frmNoteDetailTemplate).Font = My.Settings.NOTE_FONT
            ElseIf obj.GetType.Equals(GetType(frmNoteTemplate)) Then
                CType(obj, frmNoteTemplate).Opacity = My.Settings.NOTE_TAB_OPACITY
                CType(obj, frmNoteTemplate).TopMost = My.Settings.NOTE_TAB_ON_TOP
            End If

        Next
    End Sub

    Private Sub chkTabOnTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTabOnTop.CheckedChanged
        My.Settings.NOTE_TAB_ON_TOP = chkTabOnTop.Checked
    End Sub


    Private Sub cboSort_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSort.SelectedIndexChanged
        My.Settings.SORT_METHOD = cboSort.SelectedIndex
    End Sub
End Class