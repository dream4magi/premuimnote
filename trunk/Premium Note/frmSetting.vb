Public Class frmSetting

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkStartWSys.Checked = My.Settings.START_WITH_SYSTEM
        updateLabelFont()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FontDialog1.FontMustExist = True
        FontDialog1.ShowApply = False
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.NOTE_FONT = FontDialog1.Font
            My.Settings.Save()
            updateLabelFont()
        End If
    End Sub

    Private Sub chkStartWSys_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartWSys.CheckedChanged
        My.Settings.START_WITH_SYSTEM = chkStartWSys.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkAnimation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnimation.CheckedChanged
        My.Settings.Animation = chkStartWSys.Checked
        My.Settings.Save()
    End Sub


    Sub updateLabelFont()
        lblFont.Text = My.Settings.NOTE_FONT.Name.ToString & ", " & _
               My.Settings.NOTE_FONT.Size.ToString & "pt, " & _
               My.Settings.NOTE_FONT.Style.ToString
    End Sub
End Class