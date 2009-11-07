Public Class frmSetting

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkStartWSys.Checked = My.Settings.START_WITH_SYSTEM
        updateLabelFont()
        TrackBarOpacity.Value = CType(My.Settings.NOTE_OPACITY * 100, Int32)
        Me.lblOpacity.Text = TrackBarOpacity.Value.ToString


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
        My.Settings.Animation = chkStartWSys.Checked

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmNoteDetailTemplate.Show()
        noteSettingRefresh()
    End Sub

    Sub noteSettingRefresh()
        For Each noteForm In My.Application.OpenForms
            If noteForm.GetType.Equals(GetType(frmNoteDetailTemplate)) Then
                CType(noteForm, frmNoteDetailTemplate).Opacity = My.Settings.NOTE_OPACITY
            End If
        Next
    End Sub
End Class